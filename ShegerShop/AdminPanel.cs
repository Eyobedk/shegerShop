using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using ShegerShop.Admin;

namespace ShegerShop
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        Thread th;
        public void openLoginPage(object obj)
        {
            Application.Run(new LoginPage());
        }

        public void loadform(object Form)
        {
            if (this.homepanel.Controls.Count > 0)
                this.homepanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.homepanel.Controls.Add(f);
            this.homepanel.Tag = f;
            f.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadform(new ManageItemForm());
        }

        private void ViewItembutton_Click(object sender, EventArgs e)
        {
            loadform(new ViewItemForm());
        }

        private void SearchItembutton_Click(object sender, EventArgs e)
        {
            loadform(new SearchtemForm());
        }

        private void GenerateRbutton_Click(object sender, EventArgs e)
        {
            loadform(new ReportPage());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();//  CLOSE THE CURRENT FORM
            th = new Thread(openLoginPage);  //  CREATE A NEW THREAD WHICH IS "ADMINPANNEL"
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void X_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void homepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
