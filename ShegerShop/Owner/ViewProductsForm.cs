using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ShegerShop.Items;
namespace ShegerShop.Owner
{
    public partial class ViewProductsForm : Form
    {
        AdminCl proClass = new AdminCl();
        Connections info = new Connections();
        Loader load = new Loader();
        //Admin_C ad = new Admin_C();
        public ViewProductsForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            viewGridforOwner.DataSource = load.FilterExpired(DateTime.Parse(dateTimePicker1.Text));

            info.getAdapter().Dispose();
            info.connect().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewGridforOwner.DataSource = load.ViewMinRec();
            info.getAdapter().Dispose();
            info.connect().Close();
        }

        private void ViewProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void ViewAllbt_Click(object sender, EventArgs e)
        {
            viewGridforOwner.DataSource = load.LoadUsers("ItemTable");
            info.getAdapter().Dispose();
            info.connect().Close();
        }
    }
}
