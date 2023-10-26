namespace MyFirstWindow_1_
{
    public partial class LoginForm : Form
    {
        private readonly User _user;

        public LoginForm()
        {
            InitializeComponent();
        }

        public LoginForm(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            lblHello.Text = "Hello Angelenean!";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if (_user == null || _user.Username != username 
                || _user.Password != password)
            {
                MessageBox.Show("Invalid username or password", "Log in failed", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hide();
            var form = new MainForm(_user);
            form.FormClosed += (s, args) => Close();
            form.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            Hide();
            var form = new RegisterForm();
            form.FormClosed += (s, args) => Close();
            form.Show();
        }
    }
}