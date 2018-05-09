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
        public static string connectionString = "Data Source = localhost; User = client; Initial Catalog = course; SSL Mode = none";
        MySqlConnection connection = new MySqlConnection(connectionString);
        MySqlCommand command = new MySqlCommand();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection.Open();
            //TODO: данная строка кода позволяет загрузить данные в таблицу "goodsCatalogForClient.DataTable".При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.goodsCatalogForClient.DataTable);
            //string query = "SELECT `categorygoods`.`CategoryGoodsName`, `typecategory`.`TypeCategoryName` FROM `categorygoods` INNER JOIN `typecategory` " +
            //        "ON `categorygoods`.`TypeCategoryID` = `typecategory`.`TypeCategoryID`";
            //command = new MySqlCommand(query, connection);
            string str = "Стационарное";
            command = connection.CreateCommand();
            command.CommandText = ("SELECT `categorygoods`.`CategoryGoodsName`, `typecategory`.`TypeCategoryName` FROM `categorygoods` INNER JOIN `typecategory` ON `categorygoods`.`TypeCategoryID` = `typecategory`.`TypeCategoryID` WHERE `typecategory`.`TypeCategoryName` = @Type");
            command.Parameters.AddWithValue("@Type", str);
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
            string query = "SELECT `categorygoods`.`CategoryGoodsName`, `typecategory`.`TypeCategoryName` FROM `categorygoods` INNER JOIN `typecategory` " +
                    "ON `categorygoods`.`TypeCategoryID` = `typecategory`.`TypeCategoryID` WHERE `typecategory`.`TypeCategoryName` = 'Стационарное'";
            command = new MySqlCommand(query, connection);
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

        private void mobileRB_CheckedChanged_1(object sender, EventArgs e)
        {
            goodsCategoryCB.Items.Clear();
            connection.Open();
            string query = "SELECT `categorygoods`.`CategoryGoodsName`, `typecategory`.`TypeCategoryName` FROM `categorygoods` INNER JOIN `typecategory` " +
                    "ON `categorygoods`.`TypeCategoryID` = `typecategory`.`TypeCategoryID` WHERE `typecategory`.`TypeCategoryName` = 'Мобильное'";
            //string str = Encoding.UTF8.GetString(query);
            command = new MySqlCommand(query, connection);
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
    }
}