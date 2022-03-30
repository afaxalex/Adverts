using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Adverts
{
    public partial class frmCreateUser : Form
    {
        public frmCreateUser()
        {
            InitializeComponent();
        }
        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
        }
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            using (AdsEntity context = new AdsEntity())
            {
                User user = new User
                {
                    UserName = tbxUserName.Text,
                    Password = tbxPassword.Text
                };

                context.User.Add(user);
                context.SaveChanges();
            }
            this.Close();
        }
    }
}
