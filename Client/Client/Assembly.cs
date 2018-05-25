using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Client
{
    public partial class Assembly : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = client; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public int basketID { get; set; }
        public int assemblyID { get; set; }
        public double totalCost = 0;
        public int count = 1;
        public int assemblyQuantity = 0;

        public Assembly()
        {
            InitializeComponent();
        }

        private void Assembly_Load(object sender, EventArgs e)
        {
            connection.Open();
            assemblyDGV.Rows.Clear();
            command = new MySqlCommand("SELECT assembly.AssemblyName FROM assembly", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    assemblyNameCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void assemblyNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            assemblyDGV.Rows.Clear();
            command = new MySqlCommand("SELECT assembly.AssemblyID FROM assembly " +
                                       "WHERE assembly.AssemblyName = '" + assemblyNameCB.SelectedItem.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    assemblyID = MyReader.GetInt32(0);
                }
                MyReader.Close();
            }
            totalCost = 0;
            command = new MySqlCommand("SELECT typecategory.TypeCategoryName, categorygoods.CategoryGoodsName, goodsmanufacturer.GoodsManufacturerName, " +
                                       "goodscatalog.GoodsName, goodscatalog.GoodsCost, goodslist.GoodsQuantity, goodslist.AssemblyID, goodslist.GoodsID FROM goodslist INNER JOIN goodscatalog " +
                                       "ON goodslist.GoodsID = goodscatalog.GoodsID INNER JOIN categorygoods ON goodscatalog.CategoryGoodsID = categorygoods.CategoryGoodsID " +
                                       "INNER JOIN typecategory ON categorygoods.TypeCategoryID = typecategory.TypeCategoryID INNER JOIN goodsmanufacturer " +
                                       "ON goodscatalog.GoodsManufacturerID = goodsmanufacturer.GoodsManufacturerID WHERE goodslist.AssemblyID = '" + assemblyID + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                int j = 0;
                while (MyReader.Read())
                {
                    assemblyDGV.Rows.Add();
                    assemblyDGV[0, j].Value = MyReader.GetString(0);
                    assemblyDGV[1, j].Value = MyReader.GetString(1);
                    assemblyDGV[2, j].Value = MyReader.GetString(2);
                    assemblyDGV[3, j].Value = MyReader.GetString(3);
                    assemblyDGV[4, j].Value = MyReader.GetDouble(4);
                    assemblyDGV[5, j].Value = MyReader.GetInt32(5);
                    assemblyDGV[6, j].Value = MyReader.GetInt32(6);
                    assemblyDGV[7, j].Value = MyReader.GetInt32(7);
                    j++;
                    totalCost += (MyReader.GetDouble(4) * MyReader.GetInt32(5));
                }
                MyReader.Close();
            }
            totalCostLabel.Text = totalCost.ToString();
            connection.Close();
        }

        private void basketButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            for (int i = 0; i < assemblyDGV.Rows.Count; i++)
            {
                int goodsQuantity = 0;
                try
                {
                    command = new MySqlCommand("SELECT componentslist.GoodsID, componentslist.BasketID, componentslist.GoodsQuantity FROM " +
                                               "componentslist WHERE componentslist.BasketID = '" + basketID + "' " +
                                               "AND componentslist.GoodsID = '" + assemblyDGV.Rows[i].Cells[7].Value.ToString() + "'", connection);
                    using (MySqlDataReader MyReader = command.ExecuteReader())
                    {
                        while (MyReader.Read())
                        {
                            goodsQuantity = MyReader.GetInt32(2);
                        }
                        MyReader.Close();
                    }
                }
                catch
                {
                }
                if (count == 1)
                {
                    try
                    {
                        command = new MySqlCommand("INSERT INTO basket (basket.BasketID) VALUES " +
                                                   "('" + basketID + "')", connection);
                        command.ExecuteNonQuery();
                        count++;
                    }
                    catch
                    {
                    }
                }
                if (goodsQuantity == 0)
                {
                    command = new MySqlCommand("INSERT INTO componentslist (componentslist.GoodsID, componentslist.BasketID, componentslist.GoodsQuantity) VALUES " +
                                               "('" + assemblyDGV.Rows[i].Cells[7].Value.ToString() + "', '" + basketID + "', " +
                                               "'" + Convert.ToInt32(assemblyDGV.Rows[i].Cells[5].Value) + "')", connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    command = new MySqlCommand("UPDATE componentslist SET componentslist.GoodsQuantity = '" + (goodsQuantity + Convert.ToInt32(assemblyDGV.Rows[i].Cells[5].Value)) + "' " +
                                               "WHERE componentslist.BasketID = '" + basketID + "' AND " +
                                               "componentslist.GoodsID = '" + assemblyDGV.Rows[i].Cells[7].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                }
            }
            connection.Close();
            CheckBasketQuantity();
        }

        private void CheckBasketQuantity()
        {
            connection.Open();
            assemblyQuantity = 0;
            command = new MySqlCommand("SELECT componentslist.BasketID, COUNT(componentslist.GoodsID) AS Quantity " +
                                       "FROM componentslist WHERE componentslist.BasketID = '" +  basketID + "' GROUP BY componentslist.BasketID", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    assemblyQuantity += MyReader.GetInt32(1);
                }
                MyReader.Close();
            }
            connection.Close();
        }
    }
}
