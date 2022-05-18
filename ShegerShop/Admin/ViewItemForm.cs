using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShegerShop.Items;


namespace ShegerShop
{
    public partial class ViewItemForm : Form
    {
        AdminCl proClass = new AdminCl();
        Connections info = new Connections();
        // Admin_C ad = new Admin_C();
        Loader load = new Loader();

        public ViewItemForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ManageProducts_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ViewItemForm_Load(object sender, EventArgs e)
        {
            ViewItemsGrid.DataSource = load.LoadAllRecords(ViewITEMScomboBox.Text);
            info.getAdapter().Dispose();
            info.connect().Close();
        }
//

        private void ViewITEMScomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewItemsGrid.DataSource= load.LoadAllRecords(ViewITEMScomboBox.Text);
            info.getAdapter().Dispose();
            info.connect().Close();
        }

        private void filterbutton_Click(object sender, EventArgs e)
        {
            ViewItemsGrid.DataSource = load.FilterExpired(DateTime.Parse(expINdate.Text));

            info.getAdapter().Dispose();
            info.connect().Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewItemsGrid.DataSource = load.FilterExpired();

            info.getAdapter().Dispose();
            info.connect().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewItemsGrid.DataSource = load.LoadUsers("ItemTable");
            info.getAdapter().Dispose();
            info.connect().Close();
        }
    }
}
