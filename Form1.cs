namespace MyFirstWindow_1_
{
    public partial class Form1 : Form
    {
        private readonly User _user;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(User user)
        {
            _user = user;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblHello.Text = "Hello Angelenean!";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;

            if (username.Equals("admin") && password.Equals("admin") ||
                _user.Username.Equals(username) && _user.Password.Equals(password))
            {
                Hide();
                var form = new Form2(_user);
                form.FormClosed += (s, args) => Close();
                form.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Log in failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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