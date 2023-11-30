namespace DiarioDeClasse.Views
{
    partial class HUDlogin
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
            labelUserName = new Label();
            txtUserName = new TextBox();
            txtUserPassword = new TextBox();
            labelUserPassword = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserName.Location = new Point(43, 27);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(34, 16);
            labelUserName.TabIndex = 0;
            labelUserName.Text = "login";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(43, 48);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(194, 23);
            txtUserName.TabIndex = 1;
            // 
            // txtUserPassword
            // 
            txtUserPassword.Location = new Point(43, 107);
            txtUserPassword.Name = "txtUserPassword";
            txtUserPassword.Size = new Size(194, 23);
            txtUserPassword.TabIndex = 3;
            txtUserPassword.UseSystemPasswordChar = true;
            // 
            // labelUserPassword
            // 
            labelUserPassword.AutoSize = true;
            labelUserPassword.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserPassword.Location = new Point(43, 86);
            labelUserPassword.Name = "labelUserPassword";
            labelUserPassword.Size = new Size(42, 16);
            labelUserPassword.TabIndex = 2;
            labelUserPassword.Text = "senha";
            // 
            // btnLogin
            // 
            btnLogin.FlatStyle = FlatStyle.Popup;
            btnLogin.Location = new Point(162, 154);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // HUDlogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 189);
            Controls.Add(btnLogin);
            Controls.Add(txtUserPassword);
            Controls.Add(labelUserPassword);
            Controls.Add(txtUserName);
            Controls.Add(labelUserName);
            Name = "HUDlogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelUserName;
        private TextBox txtUserName;
        private TextBox txtUserPassword;
        private Label labelUserPassword;
        private Button btnLogin;
    }
}