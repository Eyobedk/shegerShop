
namespace ShegerShop
{
    partial class ManageItemForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.price = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ManageProducts_dataGridView = new System.Windows.Forms.DataGridView();
            this.dateTime_Field = new System.Windows.Forms.DateTimePicker();
            this.CataGory_comboBox = new System.Windows.Forms.ComboBox();
            this.IdBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.soldbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManageProducts_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "PRICE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "NAME";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "AMOUNT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "CATAGORY";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(17, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Orange;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(109, 356);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "EDIT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(200, 356);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "DELETE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // price
            // 
            this.price.BackColor = System.Drawing.Color.White;
            this.price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.price.Location = new System.Drawing.Point(109, 99);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(132, 23);
            this.price.TabIndex = 7;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.White;
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Location = new System.Drawing.Point(109, 149);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(132, 23);
            this.name.TabIndex = 8;
            // 
            // amount
            // 
            this.amount.BackColor = System.Drawing.Color.White;
            this.amount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amount.Location = new System.Drawing.Point(109, 201);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(132, 23);
            this.amount.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "EXPIRE DATE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(336, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 27);
            this.label6.TabIndex = 13;
            this.label6.Text = "MANAGE PRODUCTS";
            // 
            // ManageProducts_dataGridView
            // 
            this.ManageProducts_dataGridView.BackgroundColor = System.Drawing.SystemColors.AppWorkspace;
            this.ManageProducts_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManageProducts_dataGridView.Location = new System.Drawing.Point(292, 69);
            this.ManageProducts_dataGridView.Name = "ManageProducts_dataGridView";
            this.ManageProducts_dataGridView.RowTemplate.Height = 25;
            this.ManageProducts_dataGridView.Size = new System.Drawing.Size(539, 395);
            this.ManageProducts_dataGridView.TabIndex = 14;
            // 
            // dateTime_Field
            // 
            this.dateTime_Field.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dateTime_Field.Location = new System.Drawing.Point(125, 308);
            this.dateTime_Field.Name = "dateTime_Field";
            this.dateTime_Field.Size = new System.Drawing.Size(116, 23);
            this.dateTime_Field.TabIndex = 23;
            this.dateTime_Field.ValueChanged += new System.EventHandler(this.dateTime_Field_ValueChanged);
            // 
            // CataGory_comboBox
            // 
            this.CataGory_comboBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CataGory_comboBox.FormattingEnabled = true;
            this.CataGory_comboBox.Items.AddRange(new object[] {
            "vegetables",
            "fruits",
            "gadgets",
            "snacks",
            "Beverages",
            "Health Care",
            "Baby Items",
            "Household"});
            this.CataGory_comboBox.Location = new System.Drawing.Point(109, 253);
            this.CataGory_comboBox.Name = "CataGory_comboBox";
            this.CataGory_comboBox.Size = new System.Drawing.Size(132, 25);
            this.CataGory_comboBox.TabIndex = 27;
            // 
            // IdBox
            // 
            this.IdBox.Location = new System.Drawing.Point(169, 404);
            this.IdBox.Name = "IdBox";
            this.IdBox.Size = new System.Drawing.Size(104, 23);
            this.IdBox.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(127, 407);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "ID";
            // 
            // soldbutton
            // 
            this.soldbutton.BackColor = System.Drawing.Color.Orange;
            this.soldbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soldbutton.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.soldbutton.ForeColor = System.Drawing.Color.White;
            this.soldbutton.Location = new System.Drawing.Point(17, 403);
            this.soldbutton.Name = "soldbutton";
            this.soldbutton.Size = new System.Drawing.Size(75, 23);
            this.soldbutton.TabIndex = 32;
            this.soldbutton.Text = "SOLD";
            this.soldbutton.UseVisualStyleBackColor = false;
            this.soldbutton.Click += new System.EventHandler(this.soldbutton_Click);
            // 
            // ManageItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(857, 468);
            this.Controls.Add(this.soldbutton);
            this.Controls.Add(this.IdBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CataGory_comboBox);
            this.Controls.Add(this.dateTime_Field);
            this.Controls.Add(this.ManageProducts_dataGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.name);
            this.Controls.Add(this.price);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ManageItemForm";
            this.Load += new System.EventHandler(this.ManageItemForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ManageProducts_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ManageProducts_dataGridView;
        private System.Windows.Forms.DateTimePicker dateTime_Field;
        private System.Windows.Forms.ComboBox CataGory_comboBox;
        private System.Windows.Forms.TextBox IdBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button soldbutton;
    }
}