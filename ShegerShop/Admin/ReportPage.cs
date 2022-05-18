using ShegerShop.Items;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShegerShop.Admin
{
    public partial class ReportPage : Form
    {
        DataTable dt;
        Report rp = new Report();
        Connections info = new Connections();
        static DateTime dateTime = DateTime.UtcNow.Date;
        string ava = @"D:\CSV\avaliable.csv";
        string exp = @"D:\CSV\expired.csv";
        string toexp = @"D:\CSV\ToBexpired.csv";
        string queryAll = "select * from ItemTable";
        string queryExpired = "Select * from ItemTable where EXPDate <'" + dateTime.ToString("MM/dd/yyyy") + "'";
        string queryToExpire = "select * from ItemTable where Amount BETWEEN 0 AND 15";



        public ReportPage()
        {
            InitializeComponent();
        }


        private void ReportPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dt = rp.BindDataGridView(dataGridView1, queryAll);
            rp.All(dataGridView1,ava);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           dt =  rp.BindDataGridView(dataGridView1, queryExpired);
            rp.All(dataGridView1,exp);   
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
            File.Delete(ava);
            File.Delete(exp);
            File.Delete(toexp);
            dt.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dt = rp.BindDataGridView(dataGridView1, queryToExpire);
            rp.All(dataGridView1, toexp);
        }
    }
}
