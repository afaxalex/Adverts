
namespace Adverts
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbxAds = new System.Windows.Forms.GroupBox();
            this.btnOrderByDate = new System.Windows.Forms.Button();
            this.btnOrderByPrice = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxSelectedAd = new System.Windows.Forms.ListBox();
            this.lbxSearchResults = new System.Windows.Forms.ListBox();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.cbxSearchCategory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.gbxUserAds = new System.Windows.Forms.GroupBox();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbxAdID = new System.Windows.Forms.TextBox();
            this.gbxLogIn = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbxCustomerID = new System.Windows.Forms.TextBox();
            this.tbxLoggedIn = new System.Windows.Forms.TextBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxInsertCategory = new System.Windows.Forms.ComboBox();
            this.btnCreateAd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxInsertDescription = new System.Windows.Forms.TextBox();
            this.tbxInsertPrice = new System.Windows.Forms.TextBox();
            this.tbxInsertTitle = new System.Windows.Forms.TextBox();
            this.lbxUserAds = new System.Windows.Forms.ListBox();
            this.gbxAds.SuspendLayout();
            this.gbxUserAds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.gbxLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAds
            // 
            this.gbxAds.Controls.Add(this.btnOrderByDate);
            this.gbxAds.Controls.Add(this.btnOrderByPrice);
            this.gbxAds.Controls.Add(this.btnSearch);
            this.gbxAds.Controls.Add(this.label4);
            this.gbxAds.Controls.Add(this.lbxSelectedAd);
            this.gbxAds.Controls.Add(this.lbxSearchResults);
            this.gbxAds.Controls.Add(this.tbxSearch);
            this.gbxAds.Controls.Add(this.cbxSearchCategory);
            this.gbxAds.Controls.Add(this.label3);
            this.gbxAds.Controls.Add(this.label2);
            this.gbxAds.Controls.Add(this.label1);
            this.gbxAds.Location = new System.Drawing.Point(10, 10);
            this.gbxAds.Name = "gbxAds";
            this.gbxAds.Size = new System.Drawing.Size(263, 491);
            this.gbxAds.TabIndex = 1;
            this.gbxAds.TabStop = false;
            this.gbxAds.Text = "Ad Search";
            // 
            // btnOrderByDate
            // 
            this.btnOrderByDate.Location = new System.Drawing.Point(164, 72);
            this.btnOrderByDate.Name = "btnOrderByDate";
            this.btnOrderByDate.Size = new System.Drawing.Size(95, 23);
            this.btnOrderByDate.TabIndex = 8;
            this.btnOrderByDate.Text = "Date";
            this.btnOrderByDate.UseVisualStyleBackColor = true;
            this.btnOrderByDate.Click += new System.EventHandler(this.btnOrderByDate_Click);
            // 
            // btnOrderByPrice
            // 
            this.btnOrderByPrice.Location = new System.Drawing.Point(63, 72);
            this.btnOrderByPrice.Name = "btnOrderByPrice";
            this.btnOrderByPrice.Size = new System.Drawing.Size(95, 23);
            this.btnOrderByPrice.TabIndex = 7;
            this.btnOrderByPrice.Text = "Price";
            this.btnOrderByPrice.UseVisualStyleBackColor = true;
            this.btnOrderByPrice.Click += new System.EventHandler(this.btnOrderByPrice_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(199, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 20);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Selected Ad";
            // 
            // lbxSelectedAd
            // 
            this.lbxSelectedAd.FormattingEnabled = true;
            this.lbxSelectedAd.Location = new System.Drawing.Point(5, 364);
            this.lbxSelectedAd.Name = "lbxSelectedAd";
            this.lbxSelectedAd.Size = new System.Drawing.Size(252, 121);
            this.lbxSelectedAd.TabIndex = 3;
            // 
            // lbxSearchResults
            // 
            this.lbxSearchResults.FormattingEnabled = true;
            this.lbxSearchResults.Location = new System.Drawing.Point(6, 101);
            this.lbxSearchResults.Name = "lbxSearchResults";
            this.lbxSearchResults.Size = new System.Drawing.Size(253, 238);
            this.lbxSearchResults.TabIndex = 3;
            this.lbxSearchResults.Click += new System.EventHandler(this.lbxSearchResults_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(63, 21);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(128, 20);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // cbxSearchCategory
            // 
            this.cbxSearchCategory.FormattingEnabled = true;
            this.cbxSearchCategory.Location = new System.Drawing.Point(63, 47);
            this.cbxSearchCategory.Name = "cbxSearchCategory";
            this.cbxSearchCategory.Size = new System.Drawing.Size(195, 21);
            this.cbxSearchCategory.TabIndex = 2;
            this.cbxSearchCategory.SelectedValueChanged += new System.EventHandler(this.cbxSearchCategory_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Order By :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search :";
            // 
            // btnLogIn
            // 
            this.btnLogIn.Location = new System.Drawing.Point(225, 19);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(73, 50);
            this.btnLogIn.TabIndex = 2;
            this.btnLogIn.Text = "Log In";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(5, 463);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(302, 22);
            this.btnCreateUser.TabIndex = 2;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // gbxUserAds
            // 
            this.gbxUserAds.Controls.Add(this.pbPicture);
            this.gbxUserAds.Controls.Add(this.btnRefresh);
            this.gbxUserAds.Controls.Add(this.tbxAdID);
            this.gbxUserAds.Controls.Add(this.gbxLogIn);
            this.gbxUserAds.Controls.Add(this.label12);
            this.gbxUserAds.Controls.Add(this.label11);
            this.gbxUserAds.Controls.Add(this.btnCreateUser);
            this.gbxUserAds.Controls.Add(this.label9);
            this.gbxUserAds.Controls.Add(this.tbxCustomerID);
            this.gbxUserAds.Controls.Add(this.tbxLoggedIn);
            this.gbxUserAds.Controls.Add(this.btnLogOut);
            this.gbxUserAds.Controls.Add(this.label5);
            this.gbxUserAds.Controls.Add(this.cbxInsertCategory);
            this.gbxUserAds.Controls.Add(this.btnCreateAd);
            this.gbxUserAds.Controls.Add(this.btnDelete);
            this.gbxUserAds.Controls.Add(this.btnUpdate);
            this.gbxUserAds.Controls.Add(this.label6);
            this.gbxUserAds.Controls.Add(this.label13);
            this.gbxUserAds.Controls.Add(this.label8);
            this.gbxUserAds.Controls.Add(this.tbxInsertDescription);
            this.gbxUserAds.Controls.Add(this.tbxInsertPrice);
            this.gbxUserAds.Controls.Add(this.tbxInsertTitle);
            this.gbxUserAds.Controls.Add(this.lbxUserAds);
            this.gbxUserAds.Location = new System.Drawing.Point(279, 10);
            this.gbxUserAds.Name = "gbxUserAds";
            this.gbxUserAds.Size = new System.Drawing.Size(313, 491);
            this.gbxUserAds.TabIndex = 6;
            this.gbxUserAds.TabStop = false;
            this.gbxUserAds.Text = "Your Ads";
            // 
            // pbPicture
            // 
            this.pbPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbPicture.Image = global::Adverts.Properties.Resources.Letter_A_svg;
            this.pbPicture.Location = new System.Drawing.Point(0, 0);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(313, 377);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPicture.TabIndex = 19;
            this.pbPicture.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(234, 24);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(69, 81);
            this.btnRefresh.TabIndex = 18;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tbxAdID
            // 
            this.tbxAdID.Location = new System.Drawing.Point(78, 111);
            this.tbxAdID.Name = "tbxAdID";
            this.tbxAdID.ReadOnly = true;
            this.tbxAdID.Size = new System.Drawing.Size(229, 20);
            this.tbxAdID.TabIndex = 17;
            // 
            // gbxLogIn
            // 
            this.gbxLogIn.Controls.Add(this.label10);
            this.gbxLogIn.Controls.Add(this.label7);
            this.gbxLogIn.Controls.Add(this.btnLogIn);
            this.gbxLogIn.Controls.Add(this.tbxUsername);
            this.gbxLogIn.Controls.Add(this.tbxPassword);
            this.gbxLogIn.Location = new System.Drawing.Point(5, 385);
            this.gbxLogIn.Name = "gbxLogIn";
            this.gbxLogIn.Size = new System.Drawing.Size(302, 76);
            this.gbxLogIn.TabIndex = 16;
            this.gbxLogIn.TabStop = false;
            this.gbxLogIn.Text = "Log In";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 50);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Password :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Username :";
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(77, 19);
            this.tbxUsername.Multiline = true;
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(142, 22);
            this.tbxUsername.TabIndex = 11;
            this.tbxUsername.TextChanged += new System.EventHandler(this.tbxUserName_TextChanged);
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(77, 47);
            this.tbxPassword.Multiline = true;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(142, 22);
            this.tbxPassword.TabIndex = 11;
            this.tbxPassword.TextChanged += new System.EventHandler(this.tbxUserName_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 358);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Customer ID :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 332);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Logged in as :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Description :";
            // 
            // tbxCustomerID
            // 
            this.tbxCustomerID.Location = new System.Drawing.Point(86, 355);
            this.tbxCustomerID.Multiline = true;
            this.tbxCustomerID.Name = "tbxCustomerID";
            this.tbxCustomerID.ReadOnly = true;
            this.tbxCustomerID.Size = new System.Drawing.Size(142, 22);
            this.tbxCustomerID.TabIndex = 11;
            this.tbxCustomerID.TextChanged += new System.EventHandler(this.tbxUserName_TextChanged);
            // 
            // tbxLoggedIn
            // 
            this.tbxLoggedIn.Location = new System.Drawing.Point(86, 327);
            this.tbxLoggedIn.Multiline = true;
            this.tbxLoggedIn.Name = "tbxLoggedIn";
            this.tbxLoggedIn.ReadOnly = true;
            this.tbxLoggedIn.Size = new System.Drawing.Size(142, 22);
            this.tbxLoggedIn.TabIndex = 11;
            this.tbxLoggedIn.TextChanged += new System.EventHandler(this.tbxUserName_TextChanged);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(234, 327);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(73, 50);
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Category :";
            // 
            // cbxInsertCategory
            // 
            this.cbxInsertCategory.FormattingEnabled = true;
            this.cbxInsertCategory.Location = new System.Drawing.Point(78, 192);
            this.cbxInsertCategory.Name = "cbxInsertCategory";
            this.cbxInsertCategory.Size = new System.Drawing.Size(229, 21);
            this.cbxInsertCategory.TabIndex = 1;
            // 
            // btnCreateAd
            // 
            this.btnCreateAd.Location = new System.Drawing.Point(5, 299);
            this.btnCreateAd.Name = "btnCreateAd";
            this.btnCreateAd.Size = new System.Drawing.Size(302, 22);
            this.btnCreateAd.TabIndex = 4;
            this.btnCreateAd.Text = "Create New Ad";
            this.btnCreateAd.UseVisualStyleBackColor = true;
            this.btnCreateAd.Click += new System.EventHandler(this.btnCreateAd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(5, 271);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(302, 22);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Remove Selected Ad";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(5, 245);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(302, 22);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Info";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Price :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 114);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Ad ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Title :";
            // 
            // tbxInsertDescription
            // 
            this.tbxInsertDescription.Location = new System.Drawing.Point(78, 219);
            this.tbxInsertDescription.Name = "tbxInsertDescription";
            this.tbxInsertDescription.Size = new System.Drawing.Size(229, 20);
            this.tbxInsertDescription.TabIndex = 11;
            // 
            // tbxInsertPrice
            // 
            this.tbxInsertPrice.Location = new System.Drawing.Point(78, 166);
            this.tbxInsertPrice.Name = "tbxInsertPrice";
            this.tbxInsertPrice.Size = new System.Drawing.Size(229, 20);
            this.tbxInsertPrice.TabIndex = 10;
            // 
            // tbxInsertTitle
            // 
            this.tbxInsertTitle.Location = new System.Drawing.Point(78, 140);
            this.tbxInsertTitle.Name = "tbxInsertTitle";
            this.tbxInsertTitle.Size = new System.Drawing.Size(229, 20);
            this.tbxInsertTitle.TabIndex = 9;
            // 
            // lbxUserAds
            // 
            this.lbxUserAds.FormattingEnabled = true;
            this.lbxUserAds.Location = new System.Drawing.Point(5, 23);
            this.lbxUserAds.Name = "lbxUserAds";
            this.lbxUserAds.Size = new System.Drawing.Size(223, 82);
            this.lbxUserAds.TabIndex = 3;
            this.lbxUserAds.Click += new System.EventHandler(this.lbxUserAds_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 504);
            this.Controls.Add(this.gbxUserAds);
            this.Controls.Add(this.gbxAds);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ads";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.gbxAds.ResumeLayout(false);
            this.gbxAds.PerformLayout();
            this.gbxUserAds.ResumeLayout(false);
            this.gbxUserAds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.gbxLogIn.ResumeLayout(false);
            this.gbxLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxAds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ComboBox cbxSearchCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbxSelectedAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxSearchResults;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.GroupBox gbxUserAds;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCreateAd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxInsertDescription;
        private System.Windows.Forms.TextBox tbxInsertPrice;
        private System.Windows.Forms.TextBox tbxInsertTitle;
        private System.Windows.Forms.ListBox lbxUserAds;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbxLoggedIn;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.ComboBox cbxInsertCategory;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.GroupBox gbxLogIn;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbxCustomerID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnOrderByPrice;
        private System.Windows.Forms.Button btnOrderByDate;
        private System.Windows.Forms.TextBox tbxAdID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox pbPicture;
    }
}