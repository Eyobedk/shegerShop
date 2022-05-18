using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using ShegerShop.Items;

namespace ShegerShop.Owner
{
    public class Owner_Class
    {
        public string uName;
        public string uPass;

        public Owner_Class(string newAdminName, string newAdminPass)
        {
            uName = newAdminName;
            uPass = newAdminPass;
         }
        public Owner_Class(string nameToberemoved) 
        {
            uName = nameToberemoved;
        }
        Connections info = new Connections();
       // Product product = new Product();
        public void addAdmin() 
        {
            try
            {
                info.connect().Open();
                string insertQ = "Insert into users(username, password,rolle) values('" + uName + "','" + uPass + "','admin')";

                SqlCommand command = new SqlCommand(insertQ, info.connect());
                info.InsertAdapter(command).InsertCommand.ExecuteNonQuery();

                info.getAdapter().Dispose();
                info.connect().Close();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
        public void removeAdmin() 
        {
            try
            {
                info.connect().Open();
                string insertQ = "Delete users where username='" + uName+"'";
                SqlCommand command = new SqlCommand(insertQ, info.connect());
                info.Deleteadapter(command).DeleteCommand.ExecuteNonQuery();

                info.getAdapter().Dispose();
                info.connect().Close();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }
    }
}
