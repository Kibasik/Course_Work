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
using FastReport;
using System.IO;

namespace Client
{
    public partial class MainWindow : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = client; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public int id { get; set; }
        public int count = 1;
        public List<string> goodsCategory = new List<string>();
        public List<string> goodsAllType = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "goods.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter1.Fill(this.goods.DataTable);
            //TODO: данная строка кода позволяет загрузить данные в таблицу "goodsQuantity.DataTable".При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.goodsQuantity.DataTable);
            connection.Open();
            id = 0;
            command = new MySqlCommand("SELECT basket.BasketID FROM basket", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    int tempID = MyReader.GetInt32(0);
                    if (tempID > id)
                    {
                        id = tempID;
                    }
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT DISTINCT categorygoods.CategoryGoodsName FROM categorygoods", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    goodsCategoryCB.Items.Add(MyReader.GetString(0));
                    goodsCategory.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT typecategory.TypeCategoryName FROM typecategory", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    goodsTypeCB.Items.Add(MyReader.GetString(0));
                    goodsAllType.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void descriptionButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            Description description = new Description();
            description.goodsName = goodsDGV.CurrentRow.Cells[3].Value.ToString();
            description.manufacturer = goodsDGV.CurrentRow.Cells[2].Value.ToString();
            command = new MySqlCommand("SELECT goodsdescription.GoodsDescription, goodscatalog.GoodsName, goodscatalog.GoodsImage FROM goodscatalog INNER JOIN " +
                                       "goodsdescription ON goodscatalog.GoodsDescriptionID = goodsdescription.GoodsDescriptionID WHERE " +
                                       "goodscatalog.GoodsID = '" + goodsDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    description.image = (byte[])(MyReader[2]);
                    description.description = MyReader.GetString(0);
                }
                MyReader.Close();
            }
            description.ShowDialog();
            connection.Close();
        }

        private void lowPriceTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void highPriceTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void корзинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket();
            basket.basketID = (id + 1);
            basket.ShowDialog();
        }

        private void basketButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            int goodsQuantity = 0;
            try
            {
                command = new MySqlCommand("SELECT componentslist.GoodsID, componentslist.BasketID, componentslist.GoodsQuantity FROM " +
                                            "componentslist WHERE componentslist.BasketID = '" + (id + 1) + "' " +
                                            "AND componentslist.GoodsID = '" + goodsDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
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
                                               "('" + (id + 1) + "')", connection);
                    command.ExecuteNonQuery();
                    count++;
                }
                catch
                {
                }
            }
            if (goodsQuantityTB.Text == "" || Convert.ToInt32(goodsQuantityTB.Text) <= 1)
            {
                if (goodsQuantity == 0)
                {
                    command = new MySqlCommand("INSERT INTO componentslist (componentslist.GoodsID, componentslist.BasketID, componentslist.GoodsQuantity) VALUES " +
                                               "('" + goodsDGV.CurrentRow.Cells[5].Value.ToString() + "', '" + (id + 1) + "', '" + 1 + "')", connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    command = new MySqlCommand("UPDATE componentslist SET componentslist.GoodsQuantity = '" + (goodsQuantity + 1) + "' " +
                                               "WHERE componentslist.BasketID = '" + (id + 1) + "' AND componentslist.GoodsID = '" + goodsDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                if (goodsQuantity == 0)
                {
                    command = new MySqlCommand("INSERT INTO componentslist (componentslist.GoodsID, componentslist.BasketID, componentslist.GoodsQuantity) VALUES " +
                                               "('" + goodsDGV.CurrentRow.Cells[5].Value.ToString() + "', '" + (id + 1) + "', '" + Convert.ToInt32(goodsQuantityTB.Text) + "')", connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    command = new MySqlCommand("UPDATE componentslist SET componentslist.GoodsQuantity = '" + (goodsQuantity + Convert.ToInt32(goodsQuantityTB.Text)) + "' " +
                                               "WHERE componentslist.BasketID = '" + (id + 1) + "' AND componentslist.GoodsID = '" + goodsDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                }
            }
            goodsQuantityTB.Clear();
            connection.Close();
        }

        private void goodsCategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = goods.Tables[0].DefaultView;
            dataView.RowFilter = "CategoryGoodsName = '" + goodsCategoryCB.SelectedItem.ToString() + "'";
            if (lowPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "'";
            }
            if (highPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            if (manufacturerTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsManufacturerName = '" + manufacturerTB.Text + "'";
            }
            if (goodsNameTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsName LIKE '" + goodsNameTB.Text + "%'";
            }
            if (goodsTypeCB.SelectedItem != null)
            {
                dataView.RowFilter += "AND TypeCategoryName = '" + goodsTypeCB.SelectedItem.ToString() + "'";
            }
            goodsDGV.DataSource = dataView;
            connection.Close();
        }

        private void showAllGoodsButton_Click(object sender, EventArgs e)
        {
            lowPriceTB.Clear();
            highPriceTB.Clear();
            manufacturerTB.Clear();
            goodsCategoryCB.ResetText();
            goodsCategoryCB.Items.Clear();
            goodsTypeCB.ResetText();
            goodsTypeCB.Items.Clear();
            for (int i = 0; i < goodsCategory.Count; i++)
            {
                goodsCategoryCB.Items.Add(goodsCategory[i]);
            }
            for (int i = 0; i < goodsAllType.Count; i++)
            {
                goodsTypeCB.Items.Add(goodsAllType[i]);
            }
            connection.Open();
            DataView dataView = goods.Tables[0].DefaultView;
            dataView.RowFilter = "";
            goodsDGV.DataSource = dataView;
            dataTableBindingSource1.Filter = "";
            goodsQuantityChart.DataBind();
            connection.Close();
        }

        private void costButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = goods.Tables[0].DefaultView;
            if (lowPriceTB.Text != "" && highPriceTB.Text == "")
            {
                dataView.RowFilter = "GoodsCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "'";
            }
            if (lowPriceTB.Text == "" && highPriceTB.Text != "")
            {
                dataView.RowFilter = "GoodsCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            if (lowPriceTB.Text != "" && highPriceTB.Text != "")
            {
                dataView.RowFilter = "GoodsCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "' AND GoodsCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            if (manufacturerTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsManufacturerName = '" + manufacturerTB.Text + "'";
            }
            if (goodsNameTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsName LIKE '" + goodsNameTB.Text + "%'";
            }
            if (goodsCategoryCB.SelectedItem != null)
            {
                dataView.RowFilter += "AND CategoryGoodsName = '" + goodsCategoryCB.SelectedItem.ToString() + "'";
            }
            if (goodsTypeCB.SelectedItem != null)
            {
                dataView.RowFilter += "AND TypeCategoryName = '" + goodsTypeCB.SelectedItem.ToString() + "'";
            }
            goodsDGV.DataSource = dataView;
            connection.Close();
        }

        private void manufacturerButton_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = goods.Tables[0].DefaultView;
            dataView.RowFilter = "GoodsManufacturerName = '" + manufacturerTB.Text + "'";
            if (lowPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "'";
            }
            if (highPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            if (goodsCategoryCB.SelectedItem != null)
            {
                dataView.RowFilter += "AND CategoryGoodsName = '" + goodsCategoryCB.SelectedItem.ToString() + "'";
            }
            if (goodsNameTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsName LIKE '" + goodsNameTB.Text + "%'";
            }
            if (goodsTypeCB.SelectedItem != null)
            {
                dataView.RowFilter += "AND TypeCategoryName = '" + goodsTypeCB.SelectedItem.ToString() + "'";
            }
            goodsDGV.DataSource = dataView;
            connection.Close();
        }

        private void goodsNameTB_TextChanged_1(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = goods.Tables[0].DefaultView;
            dataView.RowFilter = "GoodsName LIKE '" + goodsNameTB.Text + "%'";
            if (lowPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "'";
            }
            if (highPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            if (goodsCategoryCB.SelectedItem != null)
            {
                dataView.RowFilter += "AND CategoryGoodsName = '" + goodsCategoryCB.SelectedItem.ToString() + "'";
            }
            if (manufacturerTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsManufacturerName = '" + manufacturerTB.Text + "'";
            }
            if (goodsTypeCB.SelectedItem != null)
            {
                dataView.RowFilter += "AND TypeCategoryName = '" + goodsTypeCB.SelectedItem.ToString() + "'";
            }
            goodsDGV.DataSource = dataView;
            connection.Close();
        }

        private void goodsTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = goods.Tables[0].DefaultView;
            dataView.RowFilter = "TypeCategoryname = '" + goodsTypeCB.SelectedItem.ToString() + "'";
            goodsCategoryCB.ResetText();
            goodsCategoryCB.Items.Clear();
            command = new MySqlCommand("SELECT categorygoods.CategoryGoodsName, typecategory.TypeCategoryName FROM categorygoods INNER JOIN typecategory " +
                                       "ON categorygoods.TypeCategoryID = typecategory.TypeCategoryID WHERE typecategory.TypeCategoryName = '" + goodsTypeCB.SelectedItem.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    goodsCategoryCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            if (lowPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "'";
            }
            if (highPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            if (manufacturerTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsManufacturerName = '" + manufacturerTB.Text + "'";
            }
            if (goodsNameTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsName LIKE '" + goodsNameTB.Text + "%'";
            }
            if (goodsCategoryCB.SelectedItem != null)
            {
                dataView.RowFilter += "AND CategoryGoodsName = '" + goodsCategoryCB.SelectedItem.ToString() + "'";
            }
            goodsDGV.DataSource = dataView;
            connection.Close();
        }

        private void goodsQuantityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void программноеОбеспечениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Software software = new Software();
            software.basketID = (id + 1);
            software.ShowDialog();
        }

        private void дополнительныеУслугиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdditionalServices additionalServices = new AdditionalServices();
            additionalServices.basketID = (id + 1);
            additionalServices.ShowDialog();
        }

        private void сервисноеОбслуживаниеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ServiceMaintenance serviceMaintenance = new ServiceMaintenance();
            serviceMaintenance.basketID = (id + 1);
            serviceMaintenance.ShowDialog();
        }

        private void goodsPriceListButton_Click(object sender, EventArgs e)
        {
            goodsPriceListReport.Show();
        }

        private void сборкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly assembly = new Assembly();
            assembly.basketID = (id + 1);
            assembly.ShowDialog();
        }

        private void продажаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeliveryAndSale deliveryAndSale = new DeliveryAndSale();
            deliveryAndSale.basketID = (id + 1);
            deliveryAndSale.ShowDialog();
        }
    }
}