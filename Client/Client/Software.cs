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
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = client; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public List<string> softwareType = new List<string>();
        public int basketID { get; set; }
        public int count = 1;

        public Software()
        {
            InitializeComponent();
        }

        private void Software_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareList.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.softwareList.DataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareQuantity.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter1.Fill(this.softwareQuantity.DataTable);
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

        private void button1_Click(object sender, EventArgs e)
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

        private void softwareTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = softwareList.Tables[0].DefaultView;
            dataView.RowFilter = "SoftwareTypeName = '" + softwareTypeCB.SelectedItem.ToString() + "'";
            softwareDGV.DataSource = dataView;
            connection.Close();
        }

        private void basketButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            Basket basket = new Basket();
            basket.basketID = basketID;
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
            command = new MySqlCommand("INSERT INTO chosensoftware (chosensoftware.SoftwareID, chosensoftware.BasketID) VALUES " +
                                       "('" + softwareDGV.CurrentRow.Cells[3].Value.ToString() + "', '" + basketID + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
