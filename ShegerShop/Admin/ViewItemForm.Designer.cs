
namespace ShegerShop
{
    partial class ViewItemForm
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
            this.ViewItemsGrid = new System.Windows.Forms.DataGridView();
            this.ViewITEMScomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.filterbutton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.expINdate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewItemsGrid
            // 
            this.ViewItemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ViewItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewItemsGrid.Location = new System.Drawing.Point(20, 37);
            this.ViewItemsGrid.Name = "ViewItemsGrid";
            this.ViewItemsGrid.RowTemplate.Height = 25;
            this.ViewItemsGrid.Size = new System.Drawing.Size(803, 419);
            this.ViewItemsGrid.TabIndex = 0;
            this.ViewItemsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ViewITEMScomboBox
            // 
            this.ViewITEMScomboBox.FormattingEnabled = true;
            this.ViewITEMScomboBox.Items.AddRange(new object[] {
            "vegetables",
            "fruits",
            "gadgets",
            "snacks",
            "Beverages",
            "Health Care",
            "Baby Items",
            "Household"});
            this.ViewITEMScomboBox.Location = new System.Drawing.Point(702, 6);
            this.ViewITEMScomboBox.Name = "ViewITEMScomboBox";
            this.ViewITEMScomboBox.Size = new System.Drawing.Size(121, 23);
            this.ViewITEMScomboBox.TabIndex = 1;
            this.ViewITEMScomboBox.SelectedIndexChanged += new System.EventHandler(this.ViewITEMScomboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(185, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "To Expire In";
            // 
            // filterbutton
            // 
            this.filterbutton.BackColor = System.Drawing.Color.Yellow;
            this.filterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.filterbutton.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.filterbutton.ForeColor = System.Drawing.Color.Black;
            this.filterbutton.Location = new System.Drawing.Point(457, 7);
            this.filterbutton.Name = "filterbutton";
            this.filterbutton.Size = new System.Drawing.Size(61, 23);
            this.filterbutton.TabIndex = 6;
            this.filterbutton.Text = "get";
            this.filterbutton.UseVisualStyleBackColor = false;
            this.filterbutton.Click += new System.EventHandler(this.filterbutton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(29, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 8;
            this.button1.Text = "Expired";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // expINdate
            // 
            this.expINdate.Location = new System.Drawing.Point(287, 7);
            this.expINdate.Name = "expINdate";
            this.expINdate.Size = new System.Drawing.Size(153, 23);
            this.expINdate.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(637, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Filter by";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(702, 462);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "view all";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(857, 468);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.expINdate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filterbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewITEMScomboBox);
            this.Controls.Add(this.ViewItemsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewItemForm";
            this.Text = "ViewItemForm";
            this.Load += new System.EventHandler(this.ViewItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewItemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ViewItemsGrid;
        private System.Windows.Forms.ComboBox ViewITEMScomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button filterbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker expINdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}