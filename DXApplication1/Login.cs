using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace DXApplication1
{
    public partial class Login : Form
    {
        public string hehe;
        Account account = new Account();
        AccountBLL accountbll = new AccountBLL();

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            account.sUserName = txtUserName.Text;
            account.sPassWord = txtPassWord.Text;
            string getuser = accountbll.CheckLogin(account);

            //Authentication response
            switch (getuser)
            {
                case "required_username":
                    MessageBox.Show("Tài khoản không được để trống");
                    return;

                case "required_password":
                    MessageBox.Show("Mật khẩu không được để trống");
                    return;

                case "Tài khoản hoặc mật khẩu không chính xác":
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác");
                    return;
            }
            hehe= txtUserName.Text;
            MessageBox.Show("Login Success");
            MainForm mainform = new MainForm();
            this.Hide();
            mainform.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
