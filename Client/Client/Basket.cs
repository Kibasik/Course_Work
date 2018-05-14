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
            command = new MySqlCommand("SELECT categorygoods.CategoryGoodsName, goodscatalog.GoodsName, goodsmanufacturer.GoodsManufacturerName, goodscatalog.GoodsCost, " +
                           "goodscatalog.GoodsID, typecategory.TypeCategoryName, basket.BasketID FROM goodscatalog INNER JOIN categorygoods ON " +
                           "goodscatalog.CategoryGoodsID = categorygoods.CategoryGoodsID INNER JOIN typecategory ON " +
                           "categorygoods.TypeCategoryID = typecategory.TypeCategoryID INNER JOIN componentslist ON " +
                           "componentslist.GoodsID = goodscatalog.GoodsID INNER JOIN basket ON componentslist.BasketID = basket.BasketID " +
                           "INNER JOIN goodsmanufacturer ON goodscatalog.GoodsManufacturerID = goodsmanufacturer.GoodsManufacturerID " +
                           "WHERE basket.BasketID = '" + basketID + "'", connection);
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
                    basketDGV[4, j].Value = MyReader.GetString(4);
                    j++;
                    totalCost += MyReader.GetInt32(3);
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT softwaretype.SoftwareTypeName, software.SoftwareName, software.SoftwareCost, " +
                                       "chosensoftware.SoftwareID, chosensoftware.BasketID FROM chosensoftware INNER JOIN software ON chosensoftware.SoftwareID = software.SoftwareID " +
                                       "INNER JOIN softwaretype ON software.SoftwareTypeID = softwaretype.SoftwareTypeID WHERE chosensoftware.BasketID = '" + basketID + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                int j = 0;
                while (MyReader.Read())
                {
                    softwareDGV.Rows.Add();
                    softwareDGV[0, j].Value = MyReader.GetString(0);
                    softwareDGV[1, j].Value = MyReader.GetString(1);
                    softwareDGV[2, j].Value = MyReader.GetString(2);
                    softwareDGV[3, j].Value = MyReader.GetString(3);
                    j++;
                    totalCost += MyReader.GetInt32(2);
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
                totalCost -= Convert.ToDouble(softwareDGV.CurrentRow.Cells[2].Value);
                command = new MySqlCommand("DELETE FROM chosensoftware WHERE chosensoftware.BasketID = '" + basketID + "' AND chosensoftware.SoftwareID = '" + Convert.ToInt32(softwareDGV.CurrentRow.Cells[3].Value) + "'", connection);
                command.ExecuteNonQuery();
                softwareDGV.Rows.RemoveAt(softwareDGV.CurrentRow.Index);
                MessageBox.Show("Удалено!");
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
                totalCost -= Convert.ToDouble(basketDGV.CurrentRow.Cells[3].Value);
                command = new MySqlCommand("DELETE FROM componentslist WHERE componentslist.BasketID = '" + basketID + "' AND componentslist.GoodsID = '" + Convert.ToInt32(basketDGV.CurrentRow.Cells[4].Value) + "'", connection);
                command.ExecuteNonQuery();
                basketDGV.Rows.RemoveAt(basketDGV.CurrentRow.Index);
                MessageBox.Show("Удалено!");
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
