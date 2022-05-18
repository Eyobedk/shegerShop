using ShegerShop.Items;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShegerShop
{
    class Loader
    {
        ManageItemForm manage = new ManageItemForm();
        Connections info = new Connections();
        DateTime dateTime = DateTime.UtcNow.Date;
        public DataTable LoadUsers(string table)
        {
            info.getAdapter().Dispose();
            info.connect().Close();
            info.connect().Open();
            DataTable dtEmp = new DataTable();
            string query = "select * from " + table;
            SqlCommand command = new SqlCommand(query, info.connect());
            SqlDataAdapter dA = new SqlDataAdapter(command);
            dA.Fill(dtEmp);
            return dtEmp;
        }


        public DataTable LoadAllRecords(string selected)
        {
            info.getAdapter().Dispose();
            info.connect().Close();
            info.connect().Open();
            DataTable dtEmp = new DataTable();
            string query = "select * from ItemTable where Catagory='" + selected + "'";
            SqlCommand command = new SqlCommand(query, info.connect());
            SqlDataAdapter dA = new SqlDataAdapter(command);
            dA.Fill(dtEmp);
            return dtEmp;
        }
        public DataTable LoadAllRecords(string theName, string catagory, DateTime theDate)
        {
            info.getAdapter().Dispose();
            info.connect().Close();
            info.connect().Open();
            DataTable dtEmp = new DataTable();
            string query = "select * from ItemTable where Name= '" + theName + "' AND Catagory='" + catagory + "' AND EXPDate='" + theDate + "'";
            SqlCommand command = new SqlCommand(query, info.connect());
            SqlDataAdapter dA = new SqlDataAdapter(command);
            dA.Fill(dtEmp);
            return dtEmp;
        }
        public DataTable FilterExpired()
        {
            info.getAdapter().Dispose();
            info.connect().Close();
            info.connect().Open();
            DataTable dtEmp = new DataTable();
            string query = "Select * from ItemTable where EXPDate <'" + dateTime.ToString("MM/dd/yyyy") + "'";
            SqlCommand command = new SqlCommand(query, info.connect());
            SqlDataAdapter dA = new SqlDataAdapter(command);
            dA.Fill(dtEmp);
            return dtEmp;
        }
        public DataTable FilterExpired(DateTime Exp_date)
        {
            info.getAdapter().Dispose();
            info.connect().Close();
            info.connect().Open();
            DataTable dtEmp = new DataTable();
            string query = "Select * from ItemTable where EXPDate ='" + Exp_date + "'";
            SqlCommand command = new SqlCommand(query, info.connect());
            SqlDataAdapter dA = new SqlDataAdapter(command);
            dA.Fill(dtEmp);
            return dtEmp;
        }
        public DataTable ViewMinRec()
        {
            info.getAdapter().Dispose();
            info.connect().Close();
            info.connect().Open();
            DataTable dtEmp = new DataTable();
            string query = "select * from ItemTable where Amount BETWEEN 0 AND 15";
            SqlCommand command = new SqlCommand(query, info.connect());
            SqlDataAdapter dA = new SqlDataAdapter(command);
            dA.Fill(dtEmp);
            return dtEmp;
        }
    }
}
