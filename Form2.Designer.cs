namespace MyFirstWindow_1_
{
    partial class Form2
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            label1 = new Label();
            btnLogout = new Guna.UI2.WinForms.Guna2Button();
            lblName = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            guna2Panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Anchor = AnchorStyles.None;
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 30;
            guna2Panel1.Controls.Add(label1);
            guna2Panel1.Controls.Add(btnLogout);
            guna2Panel1.Controls.Add(lblName);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.FillColor = Color.White;
            guna2Panel1.Location = new Point(202, 110);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.BorderRadius = 30;
            guna2Panel1.ShadowDecoration.Color = Color.Silver;
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.ShadowDecoration.Depth = 15;
            guna2Panel1.ShadowDecoration.Enabled = true;
            guna2Panel1.ShadowDecoration.Shadow = new Padding(2, 2, 8, 8);
            guna2Panel1.Size = new Size(396, 229);
            guna2Panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(5, 6, 15);
            label1.Location = new Point(3, 38);
            label1.Name = "label1";
            label1.Size = new Size(396, 30);
            label1.TabIndex = 7;
            label1.Text = "Hello!";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            btnLogout.BorderRadius = 10;
            btnLogout.CustomizableEdges = customizableEdges1;
            btnLogout.DisabledState.BorderColor = Color.DarkGray;
            btnLogout.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLogout.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLogout.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLogout.FillColor = Color.FromArgb(88, 36, 252);
            btnLogout.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(36, 142);
            btnLogout.Name = "btnLogout";
            btnLogout.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnLogout.Size = new Size(330, 45);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Log out";
            btnLogout.Click += btnLogout_Click;
            // 
            // lblName
            // 
            lblName.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.ForeColor = Color.FromArgb(88, 36, 252);
            lblName.Location = new Point(3, 70);
            lblName.Name = "lblName";
            lblName.Size = new Size(396, 30);
            lblName.TabIndex = 0;
            lblName.Text = "Hello";
            lblName.TextAlign = ContentAlignment.MiddleCenter;
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
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 8;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 243, 243);
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "Form2";
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            guna2Panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label lblName;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
    }
}