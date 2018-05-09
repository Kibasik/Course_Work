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
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = client; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            goodsCategoryCB.Items.Clear();
            connection.Open();
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
                                       "ON categorygoods.TypeCategoryID = typecategory.TypeCategoryID WHERE typecategory.TypeCategoryName = \"" + stationaryRB.Text + "\"", connection);
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
                                       "ON categorygoods.TypeCategoryID = typecategory.TypeCategoryID WHERE typecategory.TypeCategoryName = \"" + mobileRB.Text + "\"", connection);
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
    }
}