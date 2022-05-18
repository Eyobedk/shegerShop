using ShegerShop.Items;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShegerShop
{
    class Report : Connections
    {
        SqlCommand command;
        SqlDataReader datareader;
        string csv = string.Empty;
        string csvText = "\r\n";

        public DataTable BindDataGridView(dynamic GD,string query)
        {
            connect().Open();
            command = new SqlCommand(query, connect());
            datareader = command.ExecuteReader();
            DataTable dt = new DataTable();

            dt.Columns.AddRange(new DataColumn[6] {
                new DataColumn("id", typeof(int)),
                new DataColumn("Name", typeof(string)),
                new DataColumn("Amount",typeof(int)),
                new DataColumn("Catagory", typeof(string)),
                new DataColumn("EXPDate", typeof(DateTime)),
                new DataColumn("Price", typeof(int))});

            while (datareader.Read())
            {
                dt.Rows.Add(datareader.GetValue(0), datareader.GetValue(1), datareader.GetValue(2), datareader.GetValue(3), datareader.GetValue(4), datareader.GetValue(5));
            }

            GD.DataSource = dt;
            connect().Close();
            command.Dispose();
            datareader.Close();
            return dt;
        }


        public void All(dynamic GD,string aval)
        {
            connect().Open();

            foreach (DataGridViewColumn column in GD.Columns)
            {
                csv += column.HeaderText + ',';
            }

            try
            {
                foreach (DataGridViewRow row in GD.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //Add the Data rows.
                        if (cell.Value == null)
                        {
                            continue;
                        }
                        csvText += cell.Value.ToString().Replace(",", ";") + ',';
                    }
                    csvText += "\r\n";

                    File.WriteAllText(aval, csv + csvText);
                    //Add new line.
                    // csv += "\r\n";
                }
                connect().Close();


            }
            catch (NullReferenceException ex) { MessageBox.Show(ex.ToString()); }
            finally
            {
                connect().Close();
                command.Dispose();
                datareader.Close();
            }
        }
        public DataTable disposer(dynamic DG, DataTable datatable) 
        {
            datatable.Clear();
            DG.DataSource = null;
            DG.Rows.Clear();
            DG.Refresh();
            return datatable;
        }
    }
}
