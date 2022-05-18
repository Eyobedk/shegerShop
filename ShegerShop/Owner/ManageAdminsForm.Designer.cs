
namespace ShegerShop.Owner
{
    partial class ManageAdminsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Loginbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.Uname = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.Pass = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.removeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTobeRemoved = new System.Windows.Forms.TextBox();
            this.viewAdminsGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAdminsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(35, 68);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(322, 281);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Loginbtn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.passwordField);
            this.tabPage1.Controls.Add(this.Uname);
            this.tabPage1.Controls.Add(this.usernameField);
            this.tabPage1.Controls.Add(this.Pass);
            this.tabPage1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(314, 253);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add Admins";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BackColor = System.Drawing.Color.Orange;
            this.Loginbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Loginbtn.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Location = new System.Drawing.Point(121, 197);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(75, 23);
            this.Loginbtn.TabIndex = 17;
            this.Loginbtn.Text = "Add";
            this.Loginbtn.UseVisualStyleBackColor = false;
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Add New Admin name and Password ";
            // 
            // passwordField
            // 
            this.passwordField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordField.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordField.Location = new System.Drawing.Point(138, 138);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(135, 26);
            this.passwordField.TabIndex = 15;
            // 
            // Uname
            // 
            this.Uname.AutoSize = true;
            this.Uname.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Uname.Location = new System.Drawing.Point(40, 96);
            this.Uname.Name = "Uname";
            this.Uname.Size = new System.Drawing.Size(86, 15);
            this.Uname.TabIndex = 12;
            this.Uname.Text = "Admin name";
            // 
            // usernameField
            // 
            this.usernameField.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameField.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameField.Location = new System.Drawing.Point(138, 92);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(135, 26);
            this.usernameField.TabIndex = 14;
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Pass.Location = new System.Drawing.Point(42, 143);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(68, 15);
            this.Pass.TabIndex = 13;
            this.Pass.Text = "Password";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.removeButton);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.nameTobeRemoved);
            this.tabPage2.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(314, 262);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Remove Admins";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Orange;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeButton.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.removeButton.ForeColor = System.Drawing.Color.White;
            this.removeButton.Location = new System.Drawing.Point(125, 175);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 21;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(68, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 15);
            this.label2.TabIndex = 20;
            this.label2.Text = "Add The Admin  Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(27, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 18;
            this.label3.Text = "Admin name";
            // 
            // nameTobeRemoved
            // 
            this.nameTobeRemoved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTobeRemoved.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameTobeRemoved.Location = new System.Drawing.Point(125, 115);
            this.nameTobeRemoved.Name = "nameTobeRemoved";
            this.nameTobeRemoved.Size = new System.Drawing.Size(136, 26);
            this.nameTobeRemoved.TabIndex = 19;
            // 
            // viewAdminsGrid
            // 
            this.viewAdminsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAdminsGrid.Location = new System.Drawing.Point(446, 106);
            this.viewAdminsGrid.Name = "viewAdminsGrid";
            this.viewAdminsGrid.RowTemplate.Height = 25;
            this.viewAdminsGrid.Size = new System.Drawing.Size(342, 221);
            this.viewAdminsGrid.TabIndex = 1;
            // 
            // ManageAdminsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 468);
            this.Controls.Add(this.viewAdminsGrid);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageAdminsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageAdminsForm";
            this.Load += new System.EventHandler(this.ManageAdminsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewAdminsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label Uname;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.Button Loginbtn;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTobeRemoved;
        private System.Windows.Forms.DataGridView viewAdminsGrid;
    }
}