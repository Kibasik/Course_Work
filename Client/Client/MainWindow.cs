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
        public List<string> stationaryGoodsCategory = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load_1(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stationaryGoods.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.stationaryGoods.DataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "stationaryGoodsQuantity.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter1.Fill(this.stationaryGoodsQuantity.DataTable);
            connection.Open();
            //id = 0;
            //command = new MySqlCommand("SELECT componentslist.BasketID FROM componentslist", connection);
            //using (MySqlDataReader MyReader = command.ExecuteReader())
            //{
            //    while (MyReader.Read())
            //    {
            //        id = MyReader.GetInt32(0);
            //    }
            //    MyReader.Close();
            //}
            //goodsCategoryCB.Items.Clear();
            command = new MySqlCommand("SELECT DISTINCT categorygoods.CategoryGoodsName, typecategory.TypeCategoryName FROM categorygoods INNER JOIN typecategory ON " +
                                       "categorygoods.TypeCategoryID = typecategory.TypeCategoryID WHERE typecategory.TypeCategoryName = 'Стационарное'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    stationaryGoodsCategoryCB.Items.Add(MyReader.GetString(0));
                    stationaryGoodsCategory.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void allGoodsListButton_Click(object sender, EventArgs e)
        {
            stationaryLowPriceTB.Clear();
            stationaryHighPriceTB.Clear();
            stationaryManufacturerTB.Clear();
            stationaryGoodsCategoryCB.ResetText();
            stationaryGoodsCategoryCB.Items.Clear();
            for (int i = 0; i < stationaryGoodsCategory.Count; i++)
            {
                stationaryGoodsCategoryCB.Items.Add(stationaryGoodsCategory[i]);
            }
            connection.Open();
            DataView dataView = stationaryGoods.Tables[0].DefaultView;
            dataView.RowFilter = "";
            stationaryGoodsDGV.DataSource = dataView;
            dataTableBindingSource1.Filter = "";
            categoryGoodsQuantityChart.DataBind();
            connection.Close();
        }

        private void goodsCategoryCB_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = stationaryGoods.Tables[0].DefaultView;
            dataView.RowFilter = "CategoryGoodsName = '" + stationaryGoodsCategoryCB.SelectedItem.ToString() + "'";
            if (stationaryLowPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost >= '" + Convert.ToInt32(stationaryLowPriceTB.Text) + "'";
            }
            if (stationaryHighPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost <= '" + Convert.ToInt32(stationaryHighPriceTB.Text) + "'";
            }
            if (stationaryManufacturerTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsManufacturerName = '" + stationaryManufacturerTB.Text + "'";
            }
            if(stationaryGoodsNameTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsName LIKE '" + stationaryGoodsNameTB.Text + "%'";
            }
            stationaryGoodsDGV.DataSource = dataView;
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
            dw.goodsName = stationaryGoodsDGV.CurrentRow.Cells[2].Value.ToString();
            dw.manufacturer = stationaryGoodsDGV.CurrentRow.Cells[3].Value.ToString();
            command = new MySqlCommand("SELECT goodsdescription.GoodsDescription, goodscatalog.GoodsName, goodscatalog.GoodsImage FROM goodscatalog INNER JOIN " +
                                       "goodsdescription ON goodscatalog.GoodsDescriptionID = goodsdescription.GoodsDescriptionID WHERE " +
                                       "goodscatalog.GoodsID = '" + stationaryGoodsDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    dw.image = (byte[])(MyReader[2]);
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
            DataView dataView = stationaryGoods.Tables[0].DefaultView;
            if (stationaryLowPriceTB.Text != "" && stationaryHighPriceTB.Text == "")
            {
                dataView.RowFilter = "GoodsCost >= '" + Convert.ToInt32(stationaryLowPriceTB.Text) + "'";
            }
            if (stationaryLowPriceTB.Text == "" && stationaryHighPriceTB.Text != "")
            {
                dataView.RowFilter = "GoodsCost <= '" + Convert.ToInt32(stationaryHighPriceTB.Text) + "'";
            }
            if (stationaryLowPriceTB.Text != "" && stationaryHighPriceTB.Text != "")
            {
                dataView.RowFilter = "GoodsCost >= '" + Convert.ToInt32(stationaryLowPriceTB.Text) + "' AND GoodsCost <= '" + Convert.ToInt32(stationaryHighPriceTB.Text) + "'";
            }
            if (stationaryManufacturerTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsManufacturerName = '" + stationaryManufacturerTB.Text + "'";
            }
            if (stationaryGoodsNameTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsName LIKE '" + stationaryGoodsNameTB.Text + "%'";
            }
            if (stationaryGoodsCategoryCB.SelectedItem != null)
            {
                dataView.RowFilter += "AND CategoryGoodsName = '" + stationaryGoodsCategoryCB.SelectedItem.ToString() + "'";
            }
            stationaryGoodsDGV.DataSource = dataView;
            connection.Close();
        }

        private void filterManufacturerButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = stationaryGoods.Tables[0].DefaultView;
            dataView.RowFilter = "GoodsManufacturerName = '" + stationaryManufacturerTB.Text + "'";
            if (stationaryLowPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost >= '" + Convert.ToInt32(stationaryLowPriceTB.Text) + "'";
            }
            if (stationaryHighPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost <= '" + Convert.ToInt32(stationaryHighPriceTB.Text) + "'";
            }
            if (stationaryGoodsCategoryCB.SelectedItem != null)
            {
                dataView.RowFilter += "AND CategoryGoodsName = '" + stationaryGoodsCategoryCB.SelectedItem.ToString() + "'";
            }
            if (stationaryGoodsNameTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsName LIKE '" + stationaryGoodsNameTB.Text + "%'";
            }
            stationaryGoodsDGV.DataSource = dataView;
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
            DataView dataView = stationaryGoods.Tables[0].DefaultView;
            dataView.RowFilter = "GoodsName LIKE '" + stationaryGoodsNameTB.Text + "%'";
            if (stationaryLowPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost >= '" + Convert.ToInt32(stationaryLowPriceTB.Text) + "'";
            }
            if (stationaryHighPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost <= '" + Convert.ToInt32(stationaryHighPriceTB.Text) + "'";
            }
            if (stationaryGoodsCategoryCB.SelectedItem != null)
            {
                dataView.RowFilter += "AND CategoryGoodsName = '" + stationaryGoodsCategoryCB.SelectedItem.ToString() + "'";
            }
            if (stationaryManufacturerTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsManufacturerName = '" + stationaryManufacturerTB.Text + "'";
            }
            stationaryGoodsDGV.DataSource = dataView;
            connection.Close();
        }
    }
}