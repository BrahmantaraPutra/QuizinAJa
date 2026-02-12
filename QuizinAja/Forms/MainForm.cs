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
    public partial class MainForm : Form
    {
        private User _currentuser;
        public MainForm(User user)
        {
            InitializeComponent();
            _currentuser = user;

            txtusername.Text = _currentuser.Username;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {

        }

        private void txtusername_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }
    }
}
