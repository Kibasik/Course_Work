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
        MySqlDataAdapter adapter = new MySqlDataAdapter();
        public int basketID { get; set; }

        public Basket()
        {
            InitializeComponent();
        }

        private void Basket_Load(object sender, EventArgs e)
        {
            connection.Open();
            int totalCost = 0;
            command = new MySqlCommand("SELECT categorygoods.CategoryGoodsName, goodscatalog.GoodsName, goodsmanufacturer.GoodsManufacturerName, goodscatalog.GoodsCost, " +
                           "typecategory.TypeCategoryName, basket.BasketID FROM goodscatalog INNER JOIN categorygoods ON " +
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
                    j++;
                    totalCost += MyReader.GetInt32(3);
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT softwaretype.SoftwareTypeName, software.SoftwareName, software.SoftwareCost, " +
                                       "chosensoftware.BasketID FROM chosensoftware INNER JOIN software ON chosensoftware.SoftwareID = software.SoftwareID " +
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
                    j++;
                    totalCost += MyReader.GetInt32(2);
                }
                MyReader.Close();
            }
            totalCostLabel.Text = totalCost.ToString();
            connection.Close();
        }
    }
}
