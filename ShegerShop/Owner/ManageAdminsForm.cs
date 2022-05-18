using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using ShegerShop.Items;
using System.Windows.Forms;

namespace ShegerShop.Owner
{
    public partial class ManageAdminsForm : Form
    {
        AdminCl product = new AdminCl();
        public delegate void TheONe();
        public delegate void TheTwo();
        Loader load = new Loader();
        public ManageAdminsForm()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            Owner_Class owner_Class = new Owner_Class(usernameField.Text, passwordField.Text);
            TheTwo del2 = new TheTwo(owner_Class.addAdmin);
            del2();
            viewAdminsGrid.DataSource = load.LoadUsers("users");

        }

        private void ManageAdminsForm_Load(object sender, EventArgs e)
        {
            viewAdminsGrid.DataSource = load.LoadUsers("users");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Owner_Class owner_Class = new Owner_Class(nameTobeRemoved.Text);
            TheONe one = new TheONe(owner_Class.removeAdmin);
            one();
            viewAdminsGrid.DataSource = load.LoadUsers("users");
        }
    }
}
