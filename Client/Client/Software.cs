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
    public partial class Software : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = root; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public List<string> softwareType = new List<string>();
        public int basketID { get; set; }
        public int count = 1;
        public int softwareQuantity = 0;

        public Software()
        {
            InitializeComponent();
        }

        private void Software_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareList.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.softwareList.DataTable);
            connection.Open();
            command = new MySqlCommand("SELECT softwaretype.SoftwareTypeName FROM softwaretype", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    softwareTypeCB.Items.Add(MyReader.GetString(0));
                    softwareType.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void softwareTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = softwareList.Tables[0].DefaultView;
            dataView.RowFilter = "SoftwareTypeName = '" + softwareTypeCB.SelectedItem.ToString() + "'";
            if (lowPriceTB.Text != "")
            {
                dataView.RowFilter += "AND SoftwareCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "'";
            }
            if (highPriceTB.Text != "")
            {
                dataView.RowFilter += "AND SoftwareCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            softwareDGV.DataSource = dataView;
            connection.Close();
        }

        private void basketButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            int softwareQuantity = 0;
            try
            {
                command = new MySqlCommand("SELECT chosensoftware.BasketID, chosensoftware.SoftwareID, chosensoftware.SoftwareQuantity FROM " +
                                           "chosensoftware WHERE chosensoftware.BasketID = '" + basketID + "' " +
                                           "AND chosensoftware.SoftwareID = '" + softwareDGV.CurrentRow.Cells[3].Value.ToString() + "'", connection);
                using (MySqlDataReader MyReader = command.ExecuteReader())
                {
                    while (MyReader.Read())
                    {
                        softwareQuantity = MyReader.GetInt32(2);
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
                                               "('" + basketID + "')", connection);
                    command.ExecuteNonQuery();
                    count++;
                }
                catch
                {
                }
            }
            if (softwareQuantityTB.Text == "" || Convert.ToInt32(softwareQuantityTB.Text) < 1)
            {
                MessageBox.Show("Введите количество товара для добавления!");
                softwareQuantityTB.Clear();
            }
            else
            {
                if (softwareQuantity == 0)
                {
                    command = new MySqlCommand("INSERT INTO chosensoftware (chosensoftware.SoftwareID, chosensoftware.BasketID, chosensoftware.SoftwareQuantity) VALUES " +
                                               "('" + softwareDGV.CurrentRow.Cells[3].Value.ToString() + "', '" + basketID + "', '" + Convert.ToInt32(softwareQuantityTB.Text) + "')", connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    command = new MySqlCommand("UPDATE chosensoftware SET chosensoftware.SoftwareQuantity = '" + (softwareQuantity + Convert.ToInt32(softwareQuantityTB.Text)) + "' " +
                                               "WHERE chosensoftware.BasketID = '" + basketID + "' AND chosensoftware.SoftwareID = '" + softwareDGV.CurrentRow.Cells[3].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                }
            }
            softwareQuantityTB.Clear();
            connection.Close();
            CheckBasketQuantity();
        }

        private void costButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = softwareList.Tables[0].DefaultView;
            if (lowPriceTB.Text != "" && highPriceTB.Text == "")
            {
                dataView.RowFilter = "SoftwareCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "'";
            }
            if (lowPriceTB.Text == "" && highPriceTB.Text != "")
            {
                dataView.RowFilter = "SoftwareCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            if (lowPriceTB.Text != "" && highPriceTB.Text != "")
            {
                dataView.RowFilter = "SoftwareCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "' AND SoftwareCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            if (softwareTypeCB.SelectedItem != null)
            {
                dataView.RowFilter += "AND SOftwareTypeName = '" + softwareTypeCB.SelectedItem.ToString() + "'";
            }
            if (softwareNameTB.Text != "")
            {
                dataView.RowFilter += "AND SoftwareName LIKE '" + softwareNameTB.Text + "%'";
            }
            softwareDGV.DataSource = dataView;
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

        private void softwareQuantityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void softwareNameTB_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = softwareList.Tables[0].DefaultView;
            dataView.RowFilter = "SoftwareName LIKE '" + softwareNameTB.Text + "%'";
            if (lowPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "'";
            }
            if (highPriceTB.Text != "")
            {
                dataView.RowFilter += "AND GoodsCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            if (softwareTypeCB.SelectedItem != null)
            {
                dataView.RowFilter += "AND SOftwareTypeName = '" + softwareTypeCB.SelectedItem.ToString() + "'";
            }
            softwareDGV.DataSource = dataView;
            connection.Close();
        }

        private void showAllSoftwareButton_Click(object sender, EventArgs e)
        {
            softwareTypeCB.ResetText();
            softwareTypeCB.Items.Clear();
            for (int i = 0; i < softwareType.Count; i++)
            {
                softwareTypeCB.Items.Add(softwareType[i]);
            }
            connection.Open();
            DataView dataView = softwareList.Tables[0].DefaultView;
            dataView.RowFilter = "";
            softwareDGV.DataSource = dataView;
            connection.Close();
        }

        private void CheckBasketQuantity()
        {
            connection.Open();
            softwareQuantity = 0;
            command = new MySqlCommand("SELECT chosensoftware.BasketID, COUNT(chosensoftware.SoftwareID) AS Quantity FROM chosensoftware " +
                                       "WHERE chosensoftware.BasketID = '" + basketID + "' GROUP BY chosensoftware.BasketID", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    softwareQuantity += MyReader.GetInt32(1);
                }
                MyReader.Close();
            }
            connection.Close();
        }
    }
}
