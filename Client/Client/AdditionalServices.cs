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

        public AdditionalServices()
        {
            InitializeComponent();
        }

        private void AdditionalServices_Load(object sender, EventArgs e)
        {
            connection.Open();
            int j = 0;
            command = new MySqlCommand("SELECT additionalservices.* FROM additionalservices", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    additionalServicesDGV.Rows.Add();
                    additionalServicesDGV[0, j].Value = MyReader.GetString(0);
                    additionalServicesDGV[1, j].Value = MyReader.GetString(1);
                    additionalServicesDGV[2, j].Value = MyReader.GetDouble(2);
                    j++;
                }
                MyReader.Close();
            }
            connection.Close();
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
        }
    }
}
