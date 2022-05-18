using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using ShegerShop.Items;

namespace ShegerShop
{
    public partial class ManageItemForm : Form
    {
        Connections info = new Connections();

        public ManageItemForm()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool x = int.Parse(amount.Text)<0;
            bool y = int.Parse(amount.Text)==0;
            if (x || x) 
            {
                MessageBox.Show("a value can not be less than or equal ro zero");
            }
         //   MessageBox.Show(dateTime.ToString("MM/dd/yyyy"));
          //  if ( == x) { MessageBox.Show("eq"); }
            AdminCl adminster = new AdminCl(int.Parse(price.Text), name.Text, int.Parse(amount.Text), CataGory_comboBox.Text, DateTime.Parse(dateTime_Field.Text));
            adminster.Add();
            LoadAllRecords();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (IdBox.Text == "")
            {
                AdminCl admin = new AdminCl(int.Parse(price.Text), int.Parse(amount.Text), name.Text);
                admin.Update();
                
            }
            else
            {
                AdminCl adminster = new AdminCl(int.Parse(price.Text), int.Parse(amount.Text), int.Parse(IdBox.Text), name.Text);
                adminster.Update();
            }
            LoadAllRecords();
        }

        private void ManageItemForm_Load(object sender, EventArgs e)
        {
            LoadAllRecords();
         
        }
        public virtual DataTable LoadAllRecords()
        {

            DataTable dtEmp = new DataTable();
            SqlCommand command = new SqlCommand("select * from ItemTable", info.connect());
            SqlDataAdapter dA = new SqlDataAdapter(command);
            dA.Fill(dtEmp);
            ManageProducts_dataGridView.DataSource = dtEmp;
            info.connect().Close();//?
            dA.Dispose();
            command.Dispose();
            return dtEmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (IdBox.Text == "")
            {
                AdminCl ads = new AdminCl(CataGory_comboBox.Text);
                ads.Delete();
            }
            else
            {
                AdminCl adminster = new AdminCl(int.Parse(IdBox.Text));
                adminster.Delete();
            }
            LoadAllRecords();
        }

        private void dateTime_Field_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void soldbutton_Click(object sender, EventArgs e)
        {
            AdminCl adminster = new AdminCl();
            adminster.Sold(name.Text);
            LoadAllRecords();
        }
    }
}
