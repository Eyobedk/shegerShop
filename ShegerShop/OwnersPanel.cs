using ShegerShop.Owner;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ShegerShop
{
    public partial class OwnersPanel : Form
    {
        public OwnersPanel()
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
            if (this.panelforOwner.Controls.Count > 0)
                this.panelforOwner.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panelforOwner.Controls.Add(f);
            this.panelforOwner.Tag = f;
            f.Show();
        }
        
        private void ManageAdmins_Click(object sender, EventArgs e)
        {
            loadform(new ManageAdminsForm());
        }

        private void ViewREPORTbutton_Click(object sender, EventArgs e)
        {
            //loadform(new ViewReportForm());
        }

        private void SearchItemforOWNERbutton_Click(object sender, EventArgs e)
        {
            loadform(new SearchtemForm());
        }

        private void ViewItems_Click(object sender, EventArgs e)
        {
            loadform(new ViewProductsForm());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();//  CLOSE THE CURRENT FORM
            th = new Thread(openLoginPage);  //  CREATE A NEW THREAD WHICH IS "ADMINPANNEL"
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void OWNERListpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelforOwner_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
