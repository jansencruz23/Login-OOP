namespace MyFirstWindow_1_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblHello = new Label();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            btnLogin = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            lblRegister = new Label();
            btnClear = new Guna.UI2.WinForms.Guna2Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            guna2Panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHello
            // 
            lblHello.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblHello.ForeColor = Color.FromArgb(5, 6, 15);
            lblHello.Location = new Point(0, 35);
            lblHello.Name = "lblHello";
            lblHello.Size = new Size(396, 30);
            lblHello.TabIndex = 0;
            lblHello.Text = "Hello There!";
            lblHello.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            txtUsername.BorderRadius = 10;
            txtUsername.BorderThickness = 0;
            txtUsername.CustomizableEdges = customizableEdges1;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FillColor = Color.FromArgb(242, 242, 243);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Location = new Point(34, 129);
            txtUsername.Margin = new Padding(4, 3, 4, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderText = "Username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUsername.Size = new Size(330, 43);
            txtUsername.TabIndex = 3;
            txtUsername.TextOffset = new Point(0, 1);
            // 
            // txtPassword
            // 
            txtPassword.BorderRadius = 10;
            txtPassword.BorderThickness = 0;
            txtPassword.CustomizableEdges = customizableEdges3;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FillColor = Color.FromArgb(242, 242, 243);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(34, 183);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Password";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPassword.Size = new Size(330, 43);
            txtPassword.TabIndex = 4;
            txtPassword.TextOffset = new Point(0, 1);
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BorderRadius = 10;
            btnLogin.CustomizableEdges = customizableEdges5;
            btnLogin.DisabledState.BorderColor = Color.DarkGray;
            btnLogin.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogin.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogin.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogin.FillColor = Color.FromArgb(88, 36, 252);
            btnLogin.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(34, 244);
            btnLogin.Name = "btnLogin";
            btnLogin.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLogin.Size = new Size(330, 45);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Log in";
            btnLogin.Click += btnLogin_Click;
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.None;
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 30;
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(lblRegister);
            guna2Panel1.Controls.Add(btnClear);
            guna2Panel1.Controls.Add(txtUsername);
            guna2Panel1.Controls.Add(lblHello);
            guna2Panel1.Controls.Add(btnLogin);
            guna2Panel1.Controls.Add(txtPassword);
            guna2Panel1.CustomizableEdges = customizableEdges9;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(235, 56);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.BorderRadius = 30;
            guna2Panel1.ShadowDecoration.Color = Color.Silver;
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel1.ShadowDecoration.Depth = 15;
            guna2Panel1.ShadowDecoration.Enabled = true;
            guna2Panel1.ShadowDecoration.Shadow = new Padding(2, 2, 8, 8);
            guna2Panel1.Size = new Size(396, 390);
            guna2Panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 69);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 8;
            label1.Text = "No account?";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblRegister
            // 
            lblRegister.Cursor = Cursors.Hand;
            lblRegister.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblRegister.ForeColor = Color.FromArgb(88, 36, 252);
            lblRegister.Location = new Point(205, 69);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(188, 20);
            lblRegister.TabIndex = 7;
            lblRegister.Text = "Register";
            lblRegister.TextAlign = ContentAlignment.MiddleLeft;
            lblRegister.Click += lblRegister_Click;
            // 
            // btnClear
            // 
            btnClear.BorderColor = Color.FromArgb(224, 224, 224);
            btnClear.BorderRadius = 10;
            btnClear.BorderThickness = 1;
            btnClear.CustomizableEdges = customizableEdges7;
            btnClear.DisabledState.BorderColor = Color.DarkGray;
            btnClear.DisabledState.CustomBorderColor = Color.DarkGray;
            btnClear.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnClear.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnClear.FillColor = Color.White;
            btnClear.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnClear.ForeColor = Color.FromArgb(5, 6, 15);
            btnClear.Location = new Point(34, 297);
            btnClear.Name = "btnClear";
            btnClear.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnClear.Size = new Size(330, 45);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.Click += btnClear_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(guna2Panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(867, 503);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 243);
            ClientSize = new Size(867, 503);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "My First Window";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            guna2Panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblHello;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Label lblRegister;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
    }
}