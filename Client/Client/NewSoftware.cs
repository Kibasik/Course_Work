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
    public partial class NewSoftware : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = root; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();

        public NewSoftware()
        {
            InitializeComponent();
        }

        private void NewGoods_Load(object sender, EventArgs e)
        {
            connection.Open();
            command = new MySqlCommand("SELECT softwaretype.SoftwareTypeName FROM softwaretype", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    softwareTypeCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void softwareCostTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (softwareTypeCB.SelectedItem == null || softwareNameTB.Text == "" || softwareCostTB.Text == "")
            {
                MessageBox.Show("Введите все данные!");
            }
            else
            {
                connection.Open();
                int softwareTypeID = 0;
                command = new MySqlCommand("SELECT softwaretype.SoftwareTypeID FROM softwaretype WHERE softwaretype.SoftwareTypeName = '" + softwareTypeCB.SelectedItem.ToString() + "'", connection);
                using (MySqlDataReader MyReader = command.ExecuteReader())
                {
                    while (MyReader.Read())
                    {
                        softwareTypeID = MyReader.GetInt32(0);
                    }
                    MyReader.Close();
                }
                command = new MySqlCommand("INSERT INTO software (software.SoftwareName, software.SoftwareTypeID, software.SoftwareCost) VALUES " +
                                           "('" + softwareNameTB.Text + "', '" + softwareTypeID + "', '" + softwareCostTB.Text + "')", connection);
                command.ExecuteNonQuery();
                softwareNameTB.Clear();
                softwareCostTB.Clear();
                softwareTypeCB.ResetText();
                connection.Close();
            } 
        }
    }
}
