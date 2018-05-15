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
    public partial class Basket : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = client; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public int basketID { get; set; }
        public double totalCost = 0;

        public Basket()
        {
            InitializeComponent();
        }

        private void Basket_Load(object sender, EventArgs e)
        {
            connection.Open();
            basketDGV.Rows.Clear();
            softwareDGV.Rows.Clear();
            command = new MySqlCommand("SELECT typecategory.TypeCategoryName, categorygoods.CategoryGoodsName, goodscatalog.GoodsName, " +
                                       "goodsmanufacturer.GoodsManufacturerName, goodscatalog.GoodsCost, componentslist.GoodsQuantity, " +
                                       "goodscatalog.GoodsID, componentslist.BasketID FROM categorygoods INNER JOIN typecategory " +
                                       "ON categorygoods.TypeCategoryID = typecategory.TypeCategoryID " +
                                       "INNER JOIN goodscatalog ON goodscatalog.CategoryGoodsID = categorygoods.CategoryGoodsID INNER JOIN componentslist " +
                                       "ON componentslist.GoodsID = goodscatalog.GoodsID INNER JOIN goodsmanufacturer " +
                                       "ON goodscatalog.GoodsManufacturerID = goodsmanufacturer.GoodsManufacturerID " +
                                       "WHERE componentslist.BasketID = '" + basketID + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                int j = 0;
                while (MyReader.Read())
                {
                    basketDGV.Rows.Add();
                    basketDGV[0, j].Value = MyReader.GetString(0);
                    basketDGV[1, j].Value = MyReader.GetString(1);
                    basketDGV[2, j].Value = MyReader.GetString(2);
                    basketDGV[3, j].Value = MyReader.GetString(3);
                    basketDGV[4, j].Value = MyReader.GetDouble(4);
                    basketDGV[5, j].Value = MyReader.GetInt32(5);
                    basketDGV[6, j].Value = MyReader.GetInt32(6);
                    j++;
                    totalCost += (MyReader.GetDouble(4) * MyReader.GetInt32(5));
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT softwaretype.SoftwareTypeName, software.SoftwareName, software.SoftwareCost, chosensoftware.SoftwareQuantity, " +
                                       "software.SoftwareID FROM software INNER JOIN softwaretype ON software.SoftwareTypeID = softwaretype.SoftwareTypeID " +
                                       "INNER JOIN chosensoftware ON chosensoftware.SoftwareID = software.SoftwareID " +
                                       "WHERE chosensoftware.BasketID = '" + basketID + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                int j = 0;
                while (MyReader.Read())
                {
                    softwareDGV.Rows.Add();
                    softwareDGV[0, j].Value = MyReader.GetString(0);
                    softwareDGV[1, j].Value = MyReader.GetString(1);
                    softwareDGV[2, j].Value = MyReader.GetDouble(2);
                    softwareDGV[3, j].Value = MyReader.GetInt32(3);
                    softwareDGV[4, j].Value = MyReader.GetInt32(4);
                    j++;
                    totalCost += (MyReader.GetDouble(2) * MyReader.GetInt32(3));
                }
                MyReader.Close();
            }
            totalCostLabel.Text = totalCost.ToString();
            connection.Close();
        }

        private void deleteSoftwareButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (softwareDGV.SelectedRows.Count == 1 || softwareDGV.GetCellCount(DataGridViewElementStates.Selected) == 1)
            {
                totalCost -= (Convert.ToDouble(softwareDGV.CurrentRow.Cells[2].Value) * Convert.ToDouble(softwareDGV.CurrentRow.Cells[3].Value));
                command = new MySqlCommand("DELETE FROM chosensoftware WHERE chosensoftware.BasketID = '" + basketID + "' " +
                                           "AND chosensoftware.SoftwareID = '" + Convert.ToInt32(softwareDGV.CurrentRow.Cells[4].Value) + "'", connection);
                command.ExecuteNonQuery();
                softwareDGV.Rows.RemoveAt(softwareDGV.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Выберите программное обеспечение!");
            }
            totalCostLabel.Text = totalCost.ToString();
            softwareDGV.ClearSelection();
            connection.Close();
        }

        private void deleteGoodsButton_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            if (basketDGV.SelectedRows.Count == 1 || basketDGV.GetCellCount(DataGridViewElementStates.Selected) == 1)
            {
                totalCost -= (Convert.ToDouble(basketDGV.CurrentRow.Cells[4].Value) * Convert.ToInt32(basketDGV.CurrentRow.Cells[5].Value));
                command = new MySqlCommand("DELETE FROM componentslist WHERE componentslist.BasketID = '" + basketID + "' " +
                                           "AND componentslist.GoodsID = '" + Convert.ToInt32(basketDGV.CurrentRow.Cells[6].Value) + "'", connection);
                command.ExecuteNonQuery();
                basketDGV.Rows.RemoveAt(basketDGV.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Выберите комплектующее!");
            }
            totalCostLabel.Text = totalCost.ToString();
            basketDGV.ClearSelection();
            connection.Close();
        }
    }
}
