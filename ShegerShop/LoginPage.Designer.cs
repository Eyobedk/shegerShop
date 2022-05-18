
namespace ShegerShop
{
    partial class LoginPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.GroupBox();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.Uname = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.Label();
            this.Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(440, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(373, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Yours Username and Password";
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.Orange;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Loginbtn.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Location = new System.Drawing.Point(373, 313);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 23);
            this.Loginbtn.TabIndex = 6;
            this.Loginbtn.Text = "Login";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Login
            // 
            this.Login.Controls.Add(this.PasswordField);
            this.Login.Controls.Add(this.Uname);
            this.Login.Controls.Add(this.usernameField);
            this.Login.Controls.Add(this.Pass);
            this.Login.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Login.Location = new System.Drawing.Point(373, 164);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(262, 131);
            this.Login.TabIndex = 7;
            this.Login.TabStop = false;
            this.Login.Text = "LOGIN";
            // 
            // PasswordField
            // 
            this.PasswordField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PasswordField.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordField.Location = new System.Drawing.Point(105, 89);
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(135, 26);
            this.PasswordField.TabIndex = 11;
            // 
            // Uname
            // 
            this.Uname.AutoSize = true;
            this.Uname.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Uname.Location = new System.Drawing.Point(7, 47);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(70, 15);
            this.Uname.TabIndex = 8;
            this.Uname.Text = "Username";
            // 
            // usernameField
            // 
            this.usernameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameField.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameField.Location = new System.Drawing.Point(105, 43);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(135, 26);
            this.usernameField.TabIndex = 10;
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pass.Location = new System.Drawing.Point(7, 92);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(68, 15);
            this.Pass.TabIndex = 9;
            this.Pass.Text = "Password";
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 483);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "LoginPage";
            this.Text = "ShegerShop";
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.GroupBox Login;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.Label Uname;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label Pass;
    }
}