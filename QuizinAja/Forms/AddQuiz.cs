using QuizinAja.Models;

namespace QuizinAja.Forms
{
    public partial class AddQuiz : Form
    {
        private User _currentuser;
        public AddQuiz(User user)
        {
            InitializeComponent();
            _currentuser = user;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_description_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm(_currentuser);
            form.Show();
            this.Hide();
        }

        private void AddQuiz_Load(object sender, EventArgs e)
        {

        }
    }
}
