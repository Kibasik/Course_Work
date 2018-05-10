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
    public partial class MainWindow : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = client; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public int id { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "categoryGoodsQuantity.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter1.Fill(this.categoryGoodsQuantity.DataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "categoryGoodsQuantity.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter1.Fill(this.categoryGoodsQuantity.DataTable);
            connection.Open();
            id = 0;
            command = new MySqlCommand("SELECT componentslist.BasketID FROM componentslist", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    id = MyReader.GetInt32(0);
                }
                MyReader.Close();
            }
            goodsCategoryCB.Items.Clear();
            //TODO: данная строка кода позволяет загрузить данные в таблицу "goodsCatalogForClient.DataTable".При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.goodsCatalogForClient.DataTable);
            command = new MySqlCommand("SELECT DISTINCT categorygoods.CategoryGoodsName FROM categorygoods", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    goodsCategoryCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void stationaryRB_CheckedChanged_1(object sender, EventArgs e)
        {
            goodsCategoryCB.Items.Clear();
            connection.Open();
            command = new MySqlCommand("SELECT categorygoods.CategoryGoodsName, typecategory.TypeCategoryName FROM categorygoods INNER JOIN typecategory " +
                                       "ON categorygoods.TypeCategoryID = typecategory.TypeCategoryID WHERE typecategory.TypeCategoryName = '" + stationaryRB.Text + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    goodsCategoryCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            DataView dataView = goodsCatalogForClient.Tables[0].DefaultView;
            dataView.RowFilter = "TypeCategoryName = '" + stationaryRB.Text + "'";
            goodsListDGV.DataSource = dataView;
            connection.Close();
        }

        private void mobileRB_CheckedChanged_1(object sender, EventArgs e)
        {
            goodsCategoryCB.Items.Clear();
            connection.Open();
            command = new MySqlCommand("SELECT categorygoods.CategoryGoodsName, typecategory.TypeCategoryName FROM categorygoods INNER JOIN typecategory " +
                                       "ON categorygoods.TypeCategoryID = typecategory.TypeCategoryID WHERE typecategory.TypeCategoryName = '" + mobileRB.Text + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    goodsCategoryCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            DataView dataView = goodsCatalogForClient.Tables[0].DefaultView;
            dataView.RowFilter = "TypeCategoryName = '" + mobileRB.Text + "'";
            goodsListDGV.DataSource = dataView;
            connection.Close();
        }

        private void allGoodsListButton_Click(object sender, EventArgs e)
        {
            stationaryRB.Checked = false;
            mobileRB.Checked = false;
            connection.Open();
            goodsCategoryCB.Items.Clear();
            command = new MySqlCommand("SELECT DISTINCT categorygoods.CategoryGoodsName FROM categorygoods", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    goodsCategoryCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            DataView dataView = goodsCatalogForClient.Tables[0].DefaultView;
            dataView.RowFilter = "";
            goodsListDGV.DataSource = dataView;
            connection.Close();
        }

        private void goodsCategoryCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = goodsCatalogForClient.Tables[0].DefaultView;
            if (stationaryRB.Checked == true)
            {
                dataView.RowFilter = "CategoryGoodsName = '" + goodsCategoryCB.SelectedItem.ToString() + "' AND TypeCategoryName = '" + stationaryRB.Text + "'";
                goodsListDGV.DataSource = dataView;
            }
            else if (mobileRB.Checked == true)
            {
                dataView.RowFilter = "CategoryGoodsName = '" + goodsCategoryCB.SelectedItem.ToString() + "' AND TypeCategoryName = '" + mobileRB.Text + "'";
                goodsListDGV.DataSource = dataView;
            }
            else
            {
                dataView.RowFilter = "CategoryGoodsName = '" + goodsCategoryCB.SelectedItem.ToString() + "'";
                goodsListDGV.DataSource = dataView;
            }
            connection.Close();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void descriptionButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            DescriptionWindow dw = new DescriptionWindow();
            dw.goodsName = goodsListDGV.CurrentRow.Cells[0].Value.ToString();
            dw.manufacturer = goodsListDGV.CurrentRow.Cells[3].Value.ToString();
            command = new MySqlCommand("SELECT goodsdescription.GoodsDescription, goodscatalog.GoodsName FROM goodscatalog INNER JOIN " +
                                       "goodsdescription ON goodscatalog.GoodsDescriptionID = goodsdescription.GoodsDescriptionID WHERE " +
                                       "goodscatalog.GoodsName = '" + goodsListDGV.CurrentRow.Cells[0].Value.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    dw.description = MyReader.GetString(0);
                }
                MyReader.Close();
            }
            dw.ShowDialog();
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

        private void costButton_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = goodsCatalogForClient.Tables[0].DefaultView;
            if (lowPriceTB.Text != "" && highPriceTB.Text == "")
            {
                dataView.RowFilter = "GoodsCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "'";
                goodsListDGV.DataSource = dataView;
            }
            else if (highPriceTB.Text != "" && lowPriceTB.Text == "")
            {
                dataView.RowFilter = "GoodsCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
                goodsListDGV.DataSource = dataView;
            }
            else if (highPriceTB.Text != "" && lowPriceTB.Text != "")
            {
                dataView.RowFilter = "GoodsCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "' AND GoodsCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
                goodsListDGV.DataSource = dataView;
            }
            connection.Close();
        }

        private void filterManufacturerButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = goodsCatalogForClient.Tables[0].DefaultView;
            if (manufacturerTB.Text != "")
            {
                dataView.RowFilter = "GoodsManufacturerName = '" + manufacturerTB.Text + "'";
                goodsListDGV.DataSource = dataView;
            }
            connection.Close();
        }

        private void корзинаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Basket basket = new Basket();
            basket.ShowDialog();
        }

        private void basketButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            //Basket basket = new Basket();
            //command = new MySqlCommand("INSERT INTO componentslist (componentslist.GoodsID, componentslist.BasketID) VALUES " +
            //                           "('"+ goodsListDGV.CurrentRow.Cells[5].Value + "', '"+ (id + 1) + "')", connection);
            //command.ExecuteNonQuery();
            connection.Close();
        }

        private void goodsNameTB_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = goodsCatalogForClient.Tables[0].DefaultView;
            if (goodsNameTB.Text != "")
            {
                dataView.RowFilter = "GoodsName LIKE '" + goodsNameTB.Text + "%'";
                goodsListDGV.DataSource = dataView;
            }
            connection.Close();
        }
    }
}