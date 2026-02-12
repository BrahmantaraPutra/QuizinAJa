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
    public partial class CreateAccount : Form
    {
        private DataConnection _Context;
        public CreateAccount()
        {
            InitializeComponent();
            _Context = new DataConnection();
        }

        private void link_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage form = new LoginPage();
            form.Show();
            this.Hide();
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtfullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtretypepassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void birth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtusername.Text) ||
                string.IsNullOrEmpty(txtfullname.Text) ||
                string.IsNullOrEmpty(txtpassword.Text) ||
                string.IsNullOrEmpty(txtretypepassword.Text))
            {
                MessageBox.Show("All field must be  filled");
                return;
            }

            if (txtpassword.Text.Length < 4)
            {
                MessageBox.Show("Password min 4 character");
                return;
            }

            if (txtpassword.Text != txtretypepassword.Text)
            {
                MessageBox.Show("Password does not match");
                return;
            }

            bool isExist = _Context.Users
                .Any(u => u.Username == txtusername.Text);
            
            if (isExist)
            {
                MessageBox.Show("Username already exists");
                return;
            }

            User newUser = new User
            {
                Username = txtusername.Text,
                FullName = txtfullname.Text,
                Password = txtpassword.Text,
                DateOfBirth = DateOnly.FromDateTime(birth.Value)
            };
                
            _Context.Users.Add(newUser);
            _Context.SaveChanges();

            MessageBox.Show("Account created successfully");
            MainForm form = new MainForm(newUser);
            form.Show();
            this.Hide();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
