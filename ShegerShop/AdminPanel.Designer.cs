
namespace ShegerShop
{
    partial class AdminPanel
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.GenerateRbutton = new System.Windows.Forms.Button();
            this.SearchItembutton = new System.Windows.Forms.Button();
            this.ViewItembutton = new System.Windows.Forms.Button();
            this.manageItembutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.homepanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.GenerateRbutton);
            this.panel1.Controls.Add(this.SearchItembutton);
            this.panel1.Controls.Add(this.ViewItembutton);
            this.panel1.Controls.Add(this.manageItembutton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 500);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Orange;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(12, 458);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(157, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "Logout";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // GenerateRbutton
            // 
            this.GenerateRbutton.BackColor = System.Drawing.Color.Orange;
            this.GenerateRbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateRbutton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GenerateRbutton.ForeColor = System.Drawing.Color.White;
            this.GenerateRbutton.Location = new System.Drawing.Point(12, 398);
            this.GenerateRbutton.Name = "GenerateRbutton";
            this.GenerateRbutton.Size = new System.Drawing.Size(157, 23);
            this.GenerateRbutton.TabIndex = 5;
            this.GenerateRbutton.Text = "GENERATE REPORT";
            this.GenerateRbutton.UseVisualStyleBackColor = false;
            this.GenerateRbutton.Click += new System.EventHandler(this.GenerateRbutton_Click);
            // 
            // SearchItembutton
            // 
            this.SearchItembutton.BackColor = System.Drawing.Color.Orange;
            this.SearchItembutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchItembutton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SearchItembutton.ForeColor = System.Drawing.Color.White;
            this.SearchItembutton.Location = new System.Drawing.Point(12, 334);
            this.SearchItembutton.Name = "SearchItembutton";
            this.SearchItembutton.Size = new System.Drawing.Size(157, 23);
            this.SearchItembutton.TabIndex = 4;
            this.SearchItembutton.Text = "SEARCH ITEM";
            this.SearchItembutton.UseVisualStyleBackColor = false;
            this.SearchItembutton.Click += new System.EventHandler(this.SearchItembutton_Click);
            // 
            // ViewItembutton
            // 
            this.ViewItembutton.BackColor = System.Drawing.Color.Orange;
            this.ViewItembutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ViewItembutton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ViewItembutton.ForeColor = System.Drawing.Color.White;
            this.ViewItembutton.Location = new System.Drawing.Point(12, 274);
            this.ViewItembutton.Name = "ViewItembutton";
            this.ViewItembutton.Size = new System.Drawing.Size(157, 23);
            this.ViewItembutton.TabIndex = 3;
            this.ViewItembutton.Text = "VIEW ITEM";
            this.ViewItembutton.UseVisualStyleBackColor = false;
            this.ViewItembutton.Click += new System.EventHandler(this.ViewItembutton_Click);
            // 
            // manageItembutton
            // 
            this.manageItembutton.BackColor = System.Drawing.Color.Orange;
            this.manageItembutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageItembutton.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manageItembutton.ForeColor = System.Drawing.Color.White;
            this.manageItembutton.Location = new System.Drawing.Point(12, 214);
            this.manageItembutton.Name = "manageItembutton";
            this.manageItembutton.Size = new System.Drawing.Size(157, 23);
            this.manageItembutton.TabIndex = 2;
            this.manageItembutton.Text = "MANAGE ITEM";
            this.manageItembutton.UseVisualStyleBackColor = false;
            this.manageItembutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ShegerShop.Properties.Resources.PinClipart_com_shopping_bag_clip_art_5484973;
            this.pictureBox1.Location = new System.Drawing.Point(38, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // homepanel
            // 
            this.homepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homepanel.Location = new System.Drawing.Point(179, 0);
            this.homepanel.Name = "homepanel";
            this.homepanel.Size = new System.Drawing.Size(843, 500);
            this.homepanel.TabIndex = 2;
            this.homepanel.Paint += new System.Windows.Forms.PaintEventHandler(this.homepanel_Paint);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1022, 500);
            this.Controls.Add(this.homepanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShegereShop";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button GenerateRbutton;
        private System.Windows.Forms.Button SearchItembutton;
        private System.Windows.Forms.Button ViewItembutton;
        private System.Windows.Forms.Button manageItembutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel homepanel;
    }
}

