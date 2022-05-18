using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace ShegerShop
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        public void openAdminPannel(object obj)
        {
            Application.Run(new AdminPanel());
        }

        public void openOwnerPannel( object obj) 
        {
            Application.Run(new OwnersPanel());
        }

        Thread th;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string output = "",rolle="";
            string query = "SELECT * FROM users WHERE username='" + usernameField.Text + "' AND password='" + PasswordField.Text + "'";
            string query2 = "SELECT rolle FROM users WHERE username='" + usernameField.Text + "'";
            string url = @"Data Source=DESKTOP-RBP4AAD\SQLEXPRESS;Initial Catalog=ShegerShop;Integrated Security=True";//;MultipleActiveResultSets=True

            SqlCommand command;
            SqlDataReader dr;
            SqlConnection conn = new SqlConnection(url);
            conn.Open();

            command = new SqlCommand(query, conn);
            dr = command.ExecuteReader();

            while (dr.Read())
            {
                output = output + dr.GetValue(0) + "--" + dr.GetValue(1) + "\n";
            }
            if (output == "")
            {
                MessageBox.Show("Please enter your login info properly");
            }
            else
               {
                  dr.Close();
                  command = new SqlCommand(query2, conn);
                  dr = command.ExecuteReader();
                  while (dr.Read())
                    {
                        rolle = (string)dr.GetValue(0);
                    }
                  if (rolle == "owner")
                  {
                    this.Close();//  CLOSE THE CURRENT FORM
                    th = new Thread(openOwnerPannel);  //  CREATE A NEW THREAD WHICH IS "OWNERPANNEL"
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                  }
                  else if(rolle =="admin")
                  {

                    this.Close();//  CLOSE THE CURRENT FORM
                    th = new Thread(openAdminPannel);  //  CREATE A NEW THREAD WHICH IS "ADMINPANNEL"
                    th.SetApartmentState(ApartmentState.STA);
                    th.Start();
                  }
               }
              command.Dispose();
              conn.Close();
        
    }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
    }
}
