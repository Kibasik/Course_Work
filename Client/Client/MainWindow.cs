﻿using System;
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
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = root; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public int id = 0;
        public int count = 1;
        public int basketCount = 1;
        public int basketQuantity = 0;
        public int componentsQuantity = 0;
        public int softwareQuantity = 0;
        public int additionalServicesQuantity = 0;
        public int serviceMaintenanceQuantity = 0;
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
            basketQuantityLabel.Text = "0";
            connection.Open();
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
            description.goodsManufacturer = goodsDGV.CurrentRow.Cells[2].Value.ToString();
            command = new MySqlCommand("SELECT characteristiclist.CharacteristicName, IFNULL(specificcharacteristics.SpecificCharacteristicValue, defaultcharacteristic.DefaultCharacteristicValue) AS Value " +
                                       "FROM specificcharacteristics LEFT OUTER JOIN goodscatalog ON specificcharacteristics.GoodsID = goodscatalog.GoodsID LEFT OUTER JOIN defaultcharacteristic " +
                                       "ON specificcharacteristics.DefaultCharacteristicID = defaultcharacteristic.DefaultCharacteristicID INNER JOIN characteristiclist " +
                                       "ON specificcharacteristics.CharacteristicID = characteristiclist.CharacteristicID WHERE goodscatalog.GoodsID = '" + goodsDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    description.description += MyReader.GetString(0) + ": " + MyReader.GetString(1) + "\n";
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT goodsdescription.GoodsDescription, goodscatalog.GoodsName, goodscatalog.GoodsImage FROM goodscatalog INNER JOIN " +
                                       "goodsdescription ON goodscatalog.GoodsDescriptionID = goodsdescription.GoodsDescriptionID WHERE " +
                                       "goodscatalog.GoodsID = '" + goodsDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    description.image = (byte[])(MyReader[2]);
                    description.description += MyReader.GetString(0);
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT warranty.WarrantyPeriod, goodscatalog.GoodsID FROM goodscatalog " +
                                       "INNER JOIN warranty ON goodscatalog.WarrantyID = warranty.WarrantyID WHERE " +
                                       "goodscatalog.GoodsID = '" + goodsDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    description.warrantyPeriod = MyReader.GetInt32(0);
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
            basket.basketID = (id + basketCount);
            basket.basketCount = basketCount;
            basket.basketQuantity = basketQuantity;
            basket.ShowDialog();
            basketCount = basket.basketCount;
            basketQuantityLabel.Text = basket.basketQuantity.ToString();
        }

        private void basketButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            int goodsQuantity = 0;
            try
            {
                command = new MySqlCommand("SELECT componentslist.GoodsID, componentslist.BasketID, componentslist.GoodsQuantity FROM " +
                                           "componentslist WHERE componentslist.BasketID = '" + (id + basketCount) + "' " +
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
                                               "('" + (id + basketCount) + "')", connection);
                    command.ExecuteNonQuery();
                    count++;
                }
                catch
                {
                }
            }
            connection.Close();
            if (goodsQuantityTB.Text == "" || Convert.ToInt32(goodsQuantityTB.Text) < 1)
            {
                MessageBox.Show("Введите количество товара для добавления!");
                goodsQuantityTB.Clear();
            }
            else if ((goodsQuantity + Convert.ToInt32(goodsQuantityTB.Text)) > Convert.ToInt32(goodsDGV.CurrentRow.Cells[6].Value.ToString()))
            {
                MessageBox.Show("Недостаточно товара для добавления!");
                goodsQuantityTB.Clear();
            }
            else
            {
                connection.Open();
                    if (goodsQuantity == 0)
                    {
                        command = new MySqlCommand("INSERT INTO componentslist (componentslist.GoodsID, componentslist.BasketID, componentslist.GoodsQuantity) VALUES " +
                                                   "('" + goodsDGV.CurrentRow.Cells[5].Value.ToString() + "', '" + (id + basketCount) + "', '" + Convert.ToInt32(goodsQuantityTB.Text) + "')", connection);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        command = new MySqlCommand("UPDATE componentslist SET componentslist.GoodsQuantity = '" + (goodsQuantity + Convert.ToInt32(goodsQuantityTB.Text)) + "' " +
                                                   "WHERE componentslist.BasketID = '" + (id + basketCount) + "' AND componentslist.GoodsID = '" + goodsDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
                        command.ExecuteNonQuery();
                    }
                goodsQuantityTB.Clear();
                connection.Close();
                CheckBasketQuantity();
                basketQuantityLabel.Text = componentsQuantity.ToString();
            }
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
            software.basketID = (id + basketCount);
            software.ShowDialog();
            softwareQuantity = software.softwareQuantity;
            basketQuantity = componentsQuantity + additionalServicesQuantity + softwareQuantity + serviceMaintenanceQuantity;
            basketQuantityLabel.Text = basketQuantity.ToString();
        }

        private void дополнительныеУслугиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdditionalServices additionalServices = new AdditionalServices();
            additionalServices.basketID = (id + basketCount);
            additionalServices.ShowDialog();
            additionalServicesQuantity = additionalServices.additionalServicesQuantity;
            basketQuantity = componentsQuantity + additionalServicesQuantity + softwareQuantity + serviceMaintenanceQuantity;
            basketQuantityLabel.Text = basketQuantity.ToString();
        }

        private void сервисноеОбслуживаниеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ServiceMaintenance serviceMaintenance = new ServiceMaintenance();
            serviceMaintenance.basketID = (id + basketCount);
            serviceMaintenance.ShowDialog();
            serviceMaintenanceQuantity = serviceMaintenance.serviceMaintenanceQuantity;
            basketQuantity = componentsQuantity + additionalServicesQuantity + softwareQuantity + serviceMaintenanceQuantity;
            basketQuantityLabel.Text = basketQuantity.ToString();
        }

        private void сборкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Assembly assembly = new Assembly();
            assembly.basketID = (id + basketCount);
            assembly.assemblyQuantity = componentsQuantity;
            assembly.ShowDialog();
            CheckBasketQuantity();
            basketQuantity = componentsQuantity + additionalServicesQuantity + softwareQuantity + serviceMaintenanceQuantity;
            basketQuantityLabel.Text = basketQuantity.ToString();
        }

        private void графикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Charts charts = new Charts();
            charts.ShowDialog();
        }

        private void складToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Warehouse warehouse = new Warehouse();
            warehouse.ShowDialog();
            MainWindow_Load_1(null, null);
        }

        private void поставкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void сотрудникиToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Workers workers = new Workers();
            workers.ShowDialog();
        }

        private void полныйПрайслистToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fullPriceListReport.Show();
        }

        private void прайслистКомплектующихToolStripMenuItem_Click(object sender, EventArgs e)
        {
            componentsPriceListReport.Show();
        }

        private void прайслистДопУслугToolStripMenuItem_Click(object sender, EventArgs e)
        {
            additionalServicesPriceListReport.Show();
        }

        private void прайслистСервисногоОбслуживанияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serviceMaintenancePriceListReport.Show();
        }

        private void прайслистПОToolStripMenuItem_Click(object sender, EventArgs e)
        {
            softwarePriceListReport.Show();
        }

        private void количествоТовараВМагазинеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goodsQuantityReport.Show();
        }

        private void CheckBasketQuantity()
        {
            connection.Open();
            componentsQuantity = 0;
            command = new MySqlCommand("SELECT componentslist.BasketID, COUNT(componentslist.GoodsID) AS Quantity " +
                                       "FROM componentslist WHERE componentslist.BasketID = '" + (id + basketCount) + "' GROUP BY componentslist.BasketID", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    componentsQuantity += MyReader.GetInt32(1);
                }
                MyReader.Close();
            }
            connection.Close();
        }
    }
}