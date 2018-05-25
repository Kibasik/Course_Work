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
    public partial class AdditionalServices : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = client; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public int basketID { get; set; }
        public int count = 1;
        public int additionalServicesQuantity = 0;

        public AdditionalServices()
        {
            InitializeComponent();
        }

        private void AdditionalServices_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "additionalServicesList.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.additionalServicesList.DataTable);
        }

        private void basketButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (count == 1)
            {
                try
                {
                    command = new MySqlCommand("INSERT INTO basket (basket.BasketID) VALUES " +
                                               "('" + basketID + "')", connection);
                    command.ExecuteNonQuery();
                    count++;
                }
                catch
                {
                }
            }
            command = new MySqlCommand("INSERT INTO chosenadditionalservices (chosenadditionalservices.BasketID, chosenadditionalservices.AdditionalServiceID) VALUES " +
                                       "('" + basketID + "', '" + additionalServicesDGV.CurrentRow.Cells[0].Value.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            CheckBasketQuantity();
        }

        private void additionalServiceNameTB_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = additionalServicesList.Tables[0].DefaultView;
            dataView.RowFilter = "AdditionalServiceName LIKE '" + additionalServiceNameTB.Text + "%'";
            if (lowPriceTB.Text != "")
            {
                dataView.RowFilter += "AND AdditionalServiceCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "'";
            }
            if (highPriceTB.Text != "")
            {
                dataView.RowFilter += "AND AdditionalServiceCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            additionalServicesDGV.DataSource = dataView;
            connection.Close();
        }

        private void costButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = additionalServicesList.Tables[0].DefaultView;
            if (lowPriceTB.Text != "" && highPriceTB.Text == "")
            {
                dataView.RowFilter = "AdditionalServiceCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "'";
            }
            if (lowPriceTB.Text == "" && highPriceTB.Text != "")
            {
                dataView.RowFilter = "AdditionalServiceCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            if (lowPriceTB.Text != "" && highPriceTB.Text != "")
            {
                dataView.RowFilter = "AdditionalServiceCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "' AND AdditionalServiceCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            if (additionalServiceNameTB.Text != "")
            {
                dataView.RowFilter += "AND AdditionalServiceName LIKE '" + additionalServiceNameTB.Text + "%'";
            }
            additionalServicesDGV.DataSource = dataView;
            connection.Close();
        }

        private void showAllAdditionalServicesButton_Click(object sender, EventArgs e)
        {
            lowPriceTB.Clear();
            highPriceTB.Clear();
            additionalServiceNameTB.Clear();
            connection.Open();
            DataView dataView = additionalServicesList.Tables[0].DefaultView;
            dataView.RowFilter = "";
            additionalServicesDGV.DataSource = dataView;
            dataTableBindingSource.Filter = "";
            connection.Close();
        }

        private void CheckBasketQuantity()
        {
            connection.Open();
            additionalServicesQuantity = 0;
            command = new MySqlCommand("SELECT chosenadditionalservices.BasketID, COUNT(chosenadditionalservices.AdditionalServiceID) AS Quantity FROM chosenadditionalservices " +
                                       "WHERE chosenadditionalservices.BasketID = '" + basketID + "' GROUP BY chosenadditionalservices.BasketID", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    additionalServicesQuantity += MyReader.GetInt32(1);
                }
                MyReader.Close();
            }
            connection.Close();
        }
    }
}
