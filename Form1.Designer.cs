namespace ECS_Equipment_Checkout_System
{
    partial class formLogin
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
            lblEmail = new Label();
            lblEmpID = new Label();
            txtEmail = new TextBox();
            txtEmpID = new TextBox();
            btnLogin = new Button();
            lblPassword = new Label();
            txtPassword = new TextBox();
            pnlLogin = new Panel();
            pnlLogin.SuspendLayout();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(116, 48);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "E-Mail:";
            // 
            // lblEmpID
            // 
            lblEmpID.AutoSize = true;
            lblEmpID.Location = new Point(116, 81);
            lblEmpID.Name = "lblEmpID";
            lblEmpID.Size = new Size(76, 15);
            lblEmpID.TabIndex = 1;
            lblEmpID.Text = "Employee ID:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(191, 45);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(115, 23);
            txtEmail.TabIndex = 2;
            // 
            // txtEmpID
            // 
            txtEmpID.Location = new Point(191, 78);
            txtEmpID.Name = "txtEmpID";
            txtEmpID.Size = new Size(115, 23);
            txtEmpID.TabIndex = 3;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(170, 181);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(84, 33);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(116, 116);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 5;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(191, 113);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(115, 23);
            txtPassword.TabIndex = 6;
            // 
            // pnlLogin
            // 
            pnlLogin.BackColor = SystemColors.ActiveCaption;
            pnlLogin.Controls.Add(txtEmail);
            pnlLogin.Controls.Add(txtPassword);
            pnlLogin.Controls.Add(lblEmail);
            pnlLogin.Controls.Add(lblPassword);
            pnlLogin.Controls.Add(lblEmpID);
            pnlLogin.Controls.Add(btnLogin);
            pnlLogin.Controls.Add(txtEmpID);
            pnlLogin.Location = new Point(193, 102);
            pnlLogin.Name = "pnlLogin";
            pnlLogin.Size = new Size(413, 248);
            pnlLogin.TabIndex = 7;
            // 
            // formLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlLogin);
            Name = "formLogin";
            Text = "Equipment Checkout System - Login Page";
            pnlLogin.ResumeLayout(false);
            pnlLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblEmail;
        private Label lblEmpID;
        private TextBox txtEmail;
        private TextBox txtEmpID;
        private Button btnLogin;
        private Label lblPassword;
        private TextBox txtPassword;
        private Panel pnlLogin;
    }
}
