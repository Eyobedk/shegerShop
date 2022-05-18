using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ShegerShop.Items
{
    public class Connections
    {
        static string url = @"Data Source=DESKTOP-RBP4AAD\SQLEXPRESS;Initial Catalog=ShegerShop;Integrated Security=True";
        SqlConnection conn = new SqlConnection(url);

        SqlDataAdapter adapt = new SqlDataAdapter();

        public SqlConnection connect()
        {                                                                                      //;MultipleActiveResultSets=True
            return conn;
        }
        
        public SqlDataAdapter adapter(SqlCommand com)
        {
            adapt.UpdateCommand = com;
            return adapt; 
        }
        public SqlDataAdapter Deleteadapter(SqlCommand com)
        {
            adapt.DeleteCommand = com;
            return adapt;
        }
        public SqlDataAdapter InsertAdapter(SqlCommand com)
        {
            adapt.InsertCommand = com;
            return adapt;
        }
        public SqlDataAdapter UpdateAdapter(SqlCommand com)
        {
            adapt.UpdateCommand = com;
            return adapt;
        }
        public SqlDataAdapter getAdapter()
        {
            return adapt;
        }


    }
}
