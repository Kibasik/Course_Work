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

namespace Client
{
    public partial class Warehouse : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = root; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public List<string> goodsCategory = new List<string>();
        public List<string> goodsAllType = new List<string>();
        public int id = 0;
        public int supplyCount = 1;

        public Warehouse()
        {
            InitializeComponent();
        }

        private void Warehouse_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouseGoods.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter1.Fill(this.warehouseGoods.DataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouseTable.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.warehouseTable.DataTable);
            connection.Open();
            command = new MySqlCommand("SELECT DISTINCT categorygoods.CategoryGoodsName FROM categorygoods", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    goodsCategoryCB.Items.Add(MyReader.GetString(0));
                    shopCategoryGoodsCB.Items.Add(MyReader.GetString(0));
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
            command = new MySqlCommand("SELECT supply.SupplyID FROM supply", connection);
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
            connection.Close();
        }

        private void addGoodsButton_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            int warehouseQuantity = 0;
            int currentGoodsQuantity = 0;
            command = new MySqlCommand("SELECT warehouse.WarehouseGoodsAmount FROM warehouse " +
                                       "WHERE warehouse.GoodsID = '" + warehouseDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    warehouseQuantity = MyReader.GetInt32(0);
                }
                MyReader.Close();
            }
            if (goodsQuantityTB.Text == "" || Convert.ToInt32(goodsQuantityTB.Text) < 10)
            {
                MessageBox.Show("Минимум 10 товаров для добавления!");
            }
            else if (warehouseQuantity < Convert.ToInt32(goodsQuantityTB.Text))
            {
                MessageBox.Show("На складе нет достаточного количества товаров!");
                goodsQuantityTB.Clear();
            }
            else
            {
                command = new MySqlCommand("SELECT goodscatalog.GoodsAmount FROM goodscatalog " +
                                           "WHERE goodscatalog.GoodsID = '" + warehouseDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
                using (MySqlDataReader MyReader = command.ExecuteReader())
                {
                    while (MyReader.Read())
                    {
                        currentGoodsQuantity = MyReader.GetInt32(0);
                    }
                    MyReader.Close();
                }
                if (currentGoodsQuantity == 0)
                {
                    command = new MySqlCommand("UPDATE goodscatalog SET goodscatalog.GoodsAmount = '" + Convert.ToInt32(goodsQuantityTB.Text) + "' " +
                                               "WHERE goodscatalog.GoodsID = '" + warehouseDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    command = new MySqlCommand("UPDATE goodscatalog SET goodscatalog.GoodsAmount = '" + (currentGoodsQuantity + Convert.ToInt32(goodsQuantityTB.Text)) + "' " +
                                               "WHERE goodscatalog.GoodsID = '" + warehouseDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                }
                command = new MySqlCommand("UPDATE warehouse SET warehouse.WarehouseGoodsAmount = '" + (Convert.ToInt32(warehouseDGV.CurrentRow.Cells[4].Value.ToString()) - Convert.ToInt32(goodsQuantityTB.Text)) + "' " +
                                           "WHERE warehouse.GoodsID = '" + warehouseDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
                command.ExecuteNonQuery();
                this.dataTableTableAdapter.Fill(this.warehouseTable.DataTable);
                goodsQuantityTB.Clear();
            }
            connection.Close();
            Warehouse_Load(null, null);
        }

        private void сформироватьПоставкуToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Supply supply = new Supply();
            supply.supplyID = (id + supplyCount);
            supply.ShowDialog();
            supplyCount = supply.supplyCount;
        }

        private void goodsQuantityTB_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.ShowDialog();
        }

        private void составПоставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplyStructureReport.SetParameterValue("SupplyID", (id + supplyCount));
            supplyStructureReport.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = warehouseGoods.Tables[0].DefaultView;
            dataView.RowFilter = "CategoryGoodsName = '" + shopCategoryGoodsCB.SelectedItem.ToString() + "'";
            if (goodsManufacturerTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsManufacturerName = '" + manufacturerTB.Text + "'";
            }
            goodsDGV.DataSource = dataView;
            connection.Close();
        }

        private void goodsCategoryCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = warehouseTable.Tables[0].DefaultView;
            dataView.RowFilter = "CategoryGoodsName = '" + goodsCategoryCB.SelectedItem.ToString() + "'";
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
            warehouseDGV.DataSource = dataView;
            connection.Close();
        }

        private void manufacturerButton_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = warehouseTable.Tables[0].DefaultView;
            dataView.RowFilter = "GoodsManufacturerName = '" + manufacturerTB.Text + "'";
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
            warehouseDGV.DataSource = dataView;
            connection.Close();
        }

        private void manufacturerFilterButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = warehouseGoods.Tables[0].DefaultView;
            dataView.RowFilter = "GoodsManufacturerName = '" + goodsManufacturerTB.Text + "'";
            if (shopCategoryGoodsCB.SelectedItem != null)
            {
                dataView.RowFilter += "AND CategoryGoodsName = '" + shopCategoryGoodsCB.SelectedItem.ToString() + "'";
            }
            goodsDGV.DataSource = dataView;
            connection.Close();
        }

        private void shopShowAllButton_Click(object sender, EventArgs e)
        {
            goodsManufacturerTB.Clear();
            shopCategoryGoodsCB.ResetText();
            shopCategoryGoodsCB.Items.Clear();
            for (int i = 0; i < goodsCategory.Count; i++)
            {
                shopCategoryGoodsCB.Items.Add(goodsCategory[i]);
            }
            connection.Open();
            DataView dataView = warehouseGoods.Tables[0].DefaultView;
            dataView.RowFilter = "";
            goodsDGV.DataSource = dataView;
            dataTableBindingSource1.Filter = "";
            connection.Close();
        }

        private void графикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarehouseCharts warehouseCharts = new WarehouseCharts();
            warehouseCharts.ShowDialog();
        }

        private void программноеОбеспечениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewSoftware newSoftware = new NewSoftware();
            newSoftware.ShowDialog();
        }

        private void комплектующееToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewComponent newComponent = new NewComponent();
            newComponent.ShowDialog();
        }

        private void товарыНаСкладеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            warehouseReport.Show();
        }

        private void changeDescriptionButton_Click(object sender, EventArgs e)
        {
            ChangeDescription changeDescription = new ChangeDescription();
            changeDescription.componentID = Convert.ToInt32(goodsDGV.CurrentRow.Cells[5].Value);
            changeDescription.componentName = goodsDGV.CurrentRow.Cells[3].Value.ToString();
            changeDescription.componentManufacturer = goodsDGV.CurrentRow.Cells[2].Value.ToString();
            connection.Open();
            command = new MySqlCommand("SELECT goodsdescription.GoodsDescriptionID, goodsdescription.GoodsDescription, goodscatalog.GoodsImage FROM goodscatalog INNER JOIN " +
                                       "goodsdescription ON goodscatalog.GoodsDescriptionID = goodsdescription.GoodsDescriptionID WHERE " +
                                       "goodscatalog.GoodsID = '" + goodsDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    changeDescription.image = (byte[])(MyReader[2]);
                    changeDescription.description = MyReader.GetString(1);
                    changeDescription.componentDescriptionID = MyReader.GetInt32(0);
                }
                MyReader.Close();
            }
            changeDescription.ShowDialog();
            connection.Close();
        }

        private void changeCharacteristicsButton_Click(object sender, EventArgs e)
        {
            ChangeCharacteristic changeCharacteristic = new ChangeCharacteristic();
            changeCharacteristic.componentID = Convert.ToInt32(goodsDGV.CurrentRow.Cells[5].Value);
            changeCharacteristic.categoryGoodsName = goodsDGV.CurrentRow.Cells[1].Value.ToString();
            changeCharacteristic.ShowDialog();
        }

        private void поставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Supply supply = new Supply();
            supply.supplyID = (id + supplyCount);
            supply.ShowDialog();
            supplyCount = supply.supplyCount;
        }

        private void goodsTypeCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = warehouseTable.Tables[0].DefaultView;
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
            warehouseDGV.DataSource = dataView;
            connection.Close();
        }

        private void showAllGoodsButton_Click_1(object sender, EventArgs e)
        {
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
            DataView dataView = warehouseTable.Tables[0].DefaultView;
            dataView.RowFilter = "";
            warehouseDGV.DataSource = dataView;
            dataTableBindingSource.Filter = "";
            connection.Close();
        }

        private void goodsNameTB_TextChanged_1(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = warehouseTable.Tables[0].DefaultView;
            dataView.RowFilter = "GoodsName LIKE '" + goodsNameTB.Text + "%'";
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
            warehouseDGV.DataSource = dataView;
            connection.Close();
        }
    }
}
