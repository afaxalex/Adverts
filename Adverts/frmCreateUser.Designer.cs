
namespace Adverts
{
    partial class frmCreateUser
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
            this.gbxCreateUser = new System.Windows.Forms.GroupBox();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbxCreateUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCreateUser
            // 
            this.gbxCreateUser.Controls.Add(this.btnCreateUser);
            this.gbxCreateUser.Controls.Add(this.label2);
            this.gbxCreateUser.Controls.Add(this.tbxPassword);
            this.gbxCreateUser.Controls.Add(this.tbxUserName);
            this.gbxCreateUser.Controls.Add(this.label3);
            this.gbxCreateUser.Location = new System.Drawing.Point(10, 10);
            this.gbxCreateUser.Name = "gbxCreateUser";
            this.gbxCreateUser.Size = new System.Drawing.Size(277, 102);
            this.gbxCreateUser.TabIndex = 4;
            this.gbxCreateUser.TabStop = false;
            this.gbxCreateUser.Text = "Create User";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(73, 73);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(195, 23);
            this.btnCreateUser.TabIndex = 3;
            this.btnCreateUser.Text = "Create User";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Name :";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(73, 48);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(195, 20);
            this.tbxPassword.TabIndex = 2;
            // 
            // tbxUserName
            // 
            this.tbxUserName.Location = new System.Drawing.Point(73, 23);
            this.tbxUserName.Name = "tbxUserName";
            this.tbxUserName.Size = new System.Drawing.Size(195, 20);
            this.tbxUserName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Password :";
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 124);
            this.Controls.Add(this.gbxCreateUser);
            this.Name = "frmCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create User";
            this.Load += new System.EventHandler(this.frmCreateUser_Load);
            this.gbxCreateUser.ResumeLayout(false);
            this.gbxCreateUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCreateUser;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxUserName;
        private System.Windows.Forms.Label label3;
    }
}