using System;
using System.Collections.Generic;
using System.Text;
using System;
using ShegerShop.Items;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ShegerShop
{
    public class AdminCl
    {
        public int price;
        public string name;
        public int amount;
        public string catagory;
        public DateTime date;
        public int id;

        ManageItemForm manage = new ManageItemForm();
        Connections info = new Connections();
        DateTime dateTime = DateTime.UtcNow.Date;

        public AdminCl(int item_price, string product_name, int product_amount, string product_catagory, DateTime Exp_date, int itemID)
        {
            this.price = item_price;
            this.name = product_name;
            this.amount = product_amount;
            this.catagory = product_catagory;
            this.date = Exp_date;
            this.id = itemID;
        }
        public AdminCl(int item_price, string product_name, int product_amount, string product_catagory, DateTime Exp_date)
        {
            this.price = item_price;
            this.name = product_name;
            this.amount = product_amount;
            this.catagory = product_catagory;
            this.date = Exp_date;

        }
        public AdminCl(int item_price, string product_name, int product_amount, string product_catagory)
        {
            this.price = item_price;
            this.name = product_name;
            this.amount = product_amount;
            this.catagory = product_catagory;
        }
        public AdminCl(int item_price, int prod_amount, int theid, string pro_name)
        {
            this.price = item_price;
            this.name = pro_name;
            this.amount = prod_amount;
            this.id = theid;
        }
        public AdminCl(int item_price, int prod_amount, string pro_name)
        {
            this.price = item_price;
            this.name = pro_name;
            this.amount = prod_amount;
        }
        public AdminCl(int itemID)
        {
            this.id = itemID;
        }
        public AdminCl(string cata)
        {
            this.catagory = cata;
        }

        public AdminCl() { }


        public void Add()
        {
            try
            {
                info.connect().Open();
                string insertQ = "Insert into ItemTable(Name, Amount,Catagory, EXPDate, Price) values('" + name + "'," + amount + ",'" + catagory + "','" + date + "'," + price + ")";
                DateTime x = DateTime.Parse(date.ToShortDateString());
                DateTime dateTime = DateTime.UtcNow.Date;
                dateTime.ToString("MM/dd/yyyy");
                DateTime y = dateTime;
                if (x == y)
                {
                    insertQ = "Insert into ItemTable(Name, Amount,Catagory, Price) values('" + name + "'," + amount + ",'" + catagory + "'," + price + ")";
                }
                SqlCommand command = new SqlCommand(insertQ, info.connect());
                info.InsertAdapter(command).InsertCommand.ExecuteNonQuery();

                info.getAdapter().Dispose();
                info.connect().Close();
                manage.LoadAllRecords();
            }
            catch (Exception ex) { Console.WriteLine(ex); }
        }

        public void Update()
        {
            try
            {
                info.connect().Open();
                string insertQ = "update ItemTable set Name='" + name + "'," + "Amount=" + amount + ",Price=" + price + " where id=" + id + " OR Name='" + name + "'";
                SqlCommand command = new SqlCommand(insertQ, info.connect());
                info.adapter(command).UpdateCommand.ExecuteNonQuery();

                info.getAdapter().Dispose();
                info.connect().Close();
                manage.LoadAllRecords();
            }
            catch (Exception ex) { Console.WriteLine(ex); }

        }
        public void Delete()
        {
            try
            {
                info.connect().Open();
                string insertQ = "Delete ItemTable where id=" + id + "OR " + "Name='" + name + "' OR Catagory='" + catagory + "'";
                SqlCommand command = new SqlCommand(insertQ, info.connect());
                info.Deleteadapter(command).DeleteCommand.ExecuteNonQuery();

                info.getAdapter().Dispose();
                info.connect().Close();
                manage.LoadAllRecords();
            }
            catch (Exception ex) { Console.WriteLine(ex); }

        }

        public void Sold(string itemName)
        {
            try
            {
                info.connect().Open();
                string soldQ = "Update ItemTable Set Amount = Amount - 1 where Name ='" + itemName + "'";
                SqlCommand command = new SqlCommand(soldQ, info.connect());
                info.UpdateAdapter(command).UpdateCommand.ExecuteNonQuery();
                info.getAdapter().Dispose();
                info.connect().Close();
            }
            catch (Exception ex) { Console.WriteLine(ex); }

        }

    }
}


