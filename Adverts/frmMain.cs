
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Adverts
{
    
    public partial class frmMain : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["dbms"].ConnectionString;
        private SqlConnection con;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private User activeUser;
        public frmMain()
        {
            con = new SqlConnection(connectionString);
            InitializeComponent();
            LoadAllAdsInListBox();
            PopulateCategoryComboBox();
            PopulateLoggedInCategoryComboBox();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        #region Not Logged In - Events
        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchByTitleInListBox();
        }
        private void cbxSearchCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            SearchByCategoryInListBox();
        }
        private void lbxSearchResults_Click(object sender, EventArgs e)
        {
            LoadSelectedAdInListBox();
        }
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            frmCreateUser newForm = new frmCreateUser();
            newForm.ShowDialog();
        }
        private void btnOrderByPrice_Click(object sender, EventArgs e)
        {
            OrderByPrice();
        }
        private void btnOrderByDate_Click(object sender, EventArgs e)
        {
            OrderByDate();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            LogIn();
        }
        #endregion

        #region Not Logged In - Methods

        private void OpenConnectionReaderRead()
        {
            con.Open();

            reader = cmd.ExecuteReader();

            lbxSearchResults.Items.Clear();

            while (reader.Read())
            {
                lbxSearchResults.Items.Add(reader.GetValue(0).ToString());
            }
            con.Close();
        }

        private void LoadAllAdsInListBox()
        {
            string query = "select title from Ad";

            using (cmd = new SqlCommand(query, con))
            {
                OpenConnectionReaderRead();
            }
        }
        
        private void SearchByTitleInListBox()
        {
            string query = "select Title from Ad where Title like @Title";

            using (cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Title", tbxSearch.Text + "%");
                OpenConnectionReaderRead();
            }
        }
        private void SearchByCategoryInListBox()
        {
            string query = "select Title from Ad join Categories c on Ad.CategoryID = c.CategoryID where Ad.CategoryID like @Category";

            using (cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Category", cbxSearchCategory.SelectedValue + "%");
                OpenConnectionReaderRead();
            }
        }
        private void PopulateCategoryComboBox()
        {
            cbxSearchCategory.DataSource = GetCategoriesForComboBox();
            cbxSearchCategory.DisplayMember = "Category";
            cbxSearchCategory.ValueMember = "CategoryID";
        }
        private object GetCategoriesForComboBox()
        {
            using (AdsEntity cbx = new AdsEntity())
            {
                return cbx.Categories.ToList();
            }
        }
        private void OrderByPrice()
        {
            string query = "select Title from Ad order by Price";

            using (cmd = new SqlCommand(query, con))
            {
                OpenConnectionReaderRead();
            }
        }
        private void OrderByDate()
        {
            string query = "select Title from Ad order by DateAdded desc";

            using (cmd = new SqlCommand(query, con))
            {
                OpenConnectionReaderRead();
            }
        }
        private void LoadSelectedAdInListBox()
        {
            lbxSelectedAd.Items.Clear();

            string query = "select c.Category, Title, DateAdded, Description, Price from Ad join Categories c on Ad.CategoryID = c.CategoryID  where Title like @Title";

            using (cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@Title", lbxSearchResults.Text + "%");

                con.Open();
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lbxSelectedAd.Items.Add("Category: " + reader.GetValue(0));
                    lbxSelectedAd.Items.Add("Title: " + reader.GetValue(1).ToString());
                    lbxSelectedAd.Items.Add("Date: " + reader.GetValue(2).ToString());
                    lbxSelectedAd.Items.Add("Info: " + reader.GetValue(3).ToString());
                    lbxSelectedAd.Items.Add("Price: " + reader.GetValue(4).ToString() + "kr");
                }
                con.Close();
            }
        }
        private void LogIn()
        {
            using (AdsEntity context = new AdsEntity())
            {
                string userName = tbxUsername.Text;
                string password = tbxPassword.Text;

                var user = context.User.Where(r => r.UserName == userName && r.Password == password).FirstOrDefault();

                try
                {
                    if (user != null)
                    {
                        MessageBox.Show("Valid User");

                        pbPicture.Visible = false;
                        pbPicture.Enabled = false;
                        activeUser = user;

                        tbxLoggedIn.Text = activeUser.UserName.ToString();
                        tbxCustomerID.Text = activeUser.CustomerID.ToString();
                        LoadUserAdsInListBox();

                        tbxUsername.Clear();
                        tbxPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Error");
                }
            }
        }
        #endregion

        #region Logged In - Events
        private void lbxUserAds_Click(object sender, EventArgs e)
        {
            UserSelectedAdToSeveralTextbox();
        }
        private void btnCreateAd_Click(object sender, EventArgs e)
        {
            CreateAd();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAd();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteAd();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadUserAdsInListBox();
        }
        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogOut();
        }
        #endregion

        #region Logged In - Methods

        private void UserAdsOpenConnectionReaderRead()
        {
            con.Open();

            reader = cmd.ExecuteReader();

            lbxUserAds.Items.Clear();

            while (reader.Read())
            {
                lbxUserAds.Items.Add(reader.GetValue(0).ToString());
            }
            con.Close();
        }
        private void PopulateLoggedInCategoryComboBox()
        {
            cbxInsertCategory.DataSource = GetCategoriesForComboBox();
            cbxInsertCategory.DisplayMember = "Category";
            cbxInsertCategory.ValueMember = "CategoryID";
        }
        private void LoadUserAdsInListBox()
        {
            string query = "select Title from Ad join[User] u on Ad.CustomerID = u.CustomerID where UserName like @UserName";

            using (cmd = new SqlCommand(query, con))
            {
                cmd.Parameters.AddWithValue("@UserName", tbxLoggedIn.Text + "%");
                UserAdsOpenConnectionReaderRead();
            }
        }
        private void UserSelectedAdToSeveralTextbox()
        {
            lbxSelectedAd.Items.Clear();

            string query = "select AdID, Title, Price, c.Category, Description from Ad join Categories c on Ad.CategoryID = c.CategoryID where Title = '" + lbxUserAds.Text + "'";

            using (cmd = new SqlCommand(query, con))
            {
            con.Open();

            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tbxAdID.Text = reader.GetValue(0).ToString();
                tbxInsertTitle.Text = reader.GetValue(1).ToString();
                tbxInsertPrice.Text = reader.GetValue(2).ToString();
                cbxInsertCategory.Text = reader.GetValue(3).ToString();
                tbxInsertDescription.Text = reader.GetValue(4).ToString();
            }
            con.Close();
            }
        }
        private void CreateAd()
        {
            using (cmd = new SqlCommand("spAddNewAd", con))
            {
                con.Open();

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Title", tbxInsertTitle.Text);
                cmd.Parameters.AddWithValue("@Price", tbxInsertPrice.Text);
                cmd.Parameters.AddWithValue("@Description", tbxInsertDescription.Text);
                cmd.Parameters.AddWithValue("@DateAdded", DateTime.Now);
                cmd.Parameters.AddWithValue("@CategoryID", cbxInsertCategory.SelectedValue);
                cmd.Parameters.AddWithValue("@CustomerID", activeUser.CustomerID);
                reader = cmd.ExecuteReader();

                con.Close();
            }
            ClearTextBoxes();
            LoadUserAdsInListBox();
            MessageBox.Show("You created a new ad");
        }
        private void UpdateAd()
        {
            using (cmd = new SqlCommand("spUpdateAd", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AdID", tbxAdID.Text);
                cmd.Parameters.AddWithValue("@Title", tbxInsertTitle.Text);
                cmd.Parameters.AddWithValue("@Price", tbxInsertPrice.Text);
                cmd.Parameters.AddWithValue("@Description", tbxInsertDescription.Text);
                cmd.Parameters.AddWithValue("@CategoryID", cbxInsertCategory.SelectedValue);
                reader = cmd.ExecuteReader();
                con.Close();
            }
            ClearTextBoxes();
            LoadUserAdsInListBox();
            MessageBox.Show("Successful Update");
        }
        private void DeleteAd()
        {
            using (cmd = new SqlCommand("spDeleteAd", con))
            {
                con.Open();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@AdID", tbxAdID.Text);
                cmd.ExecuteReader();
                con.Close();
            }
            ClearTextBoxes();
            LoadUserAdsInListBox();
            MessageBox.Show("Successful Delete");
        }
        private void ClearTextBoxes()
        {
            tbxAdID.Clear();
            tbxInsertTitle.Clear();
            tbxInsertPrice.Clear();
            tbxInsertDescription.Clear();
        }
        private void LogOut()
        {
            tbxCustomerID.Clear();
            tbxLoggedIn.Clear();
            activeUser = null;
            ClearTextBoxes();
            pbPicture.Visible = true;
        }
        #endregion

        #region Not Used
        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
        }
        private void tbxUserName_TextChanged(object sender, EventArgs e)
        {
        }
        private void cbxOrderBy_SelectedValueChanged(object sender, EventArgs e)
        {
        }
        private void cbxOrderBy_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        #endregion
    }
}
