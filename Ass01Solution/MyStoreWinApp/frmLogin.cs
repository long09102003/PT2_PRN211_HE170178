using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        private string username;
        private string password;

        public frmLogin()
        {
            InitializeComponent();
        }
        public frmLogin(string username, string password)
        {
            this.username = username;
            this.password = password;
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtEmail.Text = username;
            txtPass.Text = password;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if(username == txtEmail.Text && password == txtPass.Text)
            {
                MessageBox.Show("LoginSuccessfull");
                frmMemberManagement frmMemberManagement = new frmMemberManagement();
                this.Hide();
                frmMemberManagement.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Wrong email or password","Error Mess",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
        }
    }
}
