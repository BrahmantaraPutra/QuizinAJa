using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizinAja.Data;
using QuizinAja.Models;

namespace QuizinAja.Forms
{
    public partial class LoginPage : Form
    {
        private DataConnection _Context;
        public LoginPage()
        {
            InitializeComponent();
            _Context = new DataConnection();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Text;

            if(string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username or password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var User = _Context.Users
                .FirstOrDefault(u => u.Username == username && u.Password == password);

            if (User != null)
            {
                MessageBox.Show("Login Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm form = new MainForm(User);
                form.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Invalid Username or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void box_showpw_CheckedChanged(object sender, EventArgs e)
        {
            if(box_showpw.Checked)
            {
                txtpassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void link_create_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CreateAccount form = new CreateAccount();
            form.Show();
            this.Hide();
        }

        private void link_quest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
