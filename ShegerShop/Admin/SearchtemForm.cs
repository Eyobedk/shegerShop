using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShegerShop.Items;

namespace ShegerShop
{
    public partial class SearchtemForm : Form
    {
        AdminCl proClass = new AdminCl();
        Connections info = new Connections();
        Loader load = new Loader();
        public SearchtemForm()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            searchGrid.DataSource = load.LoadAllRecords(itemName.Text, catagoryCombo.Text,DateTime.Parse(expdate.Text));

            info.getAdapter().Dispose();
            info.connect().Close();
        }

        private void SearchtemForm_Load(object sender, EventArgs e)
        {

        }
    }
}
