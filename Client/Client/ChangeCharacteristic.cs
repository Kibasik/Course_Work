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
    public partial class ChangeCharacteristic : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = root; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public int componentID = 0;
        public int characteristicID = 0;
        public int defaulCharacteristicID = 0;
        public int warrantyID = 0;
        public string categoryGoodsName { get; set; }

        public ChangeCharacteristic()
        {
            InitializeComponent();
        }

        private void ChangeCharacteristic_Load(object sender, EventArgs e)
        {
            connection.Open();
            characteristicNameCB.Items.Clear();
            warrantyPeriodCB.Items.Clear();
            characteristicValuesRTB.Clear();
            characteristicValueCB.Items.Clear();
            warrantyPeriodCB.Items.Add("");
            characteristicNameCB.Items.Add("");
            command = new MySqlCommand("SELECT characteristiclist.CharacteristicName FROM characteristiclist WHERE characteristiclist.CategoryGoodsName = '" + categoryGoodsName + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    characteristicNameCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT warranty.WarrantyPeriod FROM warranty", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    warrantyPeriodCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT warranty.WarrantyPeriod, goodscatalog.GoodsID FROM goodscatalog " +
                                       "INNER JOIN warranty ON goodscatalog.WarrantyID = warranty.WarrantyID WHERE " +
                                       "goodscatalog.GoodsID = '" + componentID + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    characteristicValuesRTB.Text += "Срок гарантии: " + MyReader.GetInt32(0) + " мес.\n";
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT characteristiclist.CharacteristicName, IFNULL(specificcharacteristics.SpecificCharacteristicValue, defaultcharacteristic.DefaultCharacteristicValue) AS Value " +
                                       "FROM specificcharacteristics LEFT OUTER JOIN goodscatalog ON specificcharacteristics.GoodsID = goodscatalog.GoodsID LEFT OUTER JOIN defaultcharacteristic " +
                                       "ON specificcharacteristics.DefaultCharacteristicID = defaultcharacteristic.DefaultCharacteristicID INNER JOIN characteristiclist " +
                                       "ON specificcharacteristics.CharacteristicID = characteristiclist.CharacteristicID WHERE goodscatalog.GoodsID = '" + componentID + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    characteristicValuesRTB.Text += MyReader.GetString(0) + ": " + MyReader.GetString(1) + "\n";
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void characteristicNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            characteristicValueCB.Items.Clear();
            characteristicValueCB.Items.Add("");
            command = new MySqlCommand("SELECT characteristiclist.CharacteristicID FROM characteristiclist WHERE characteristiclist.CharacteristicName = '" + characteristicNameCB.SelectedItem.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    characteristicID = MyReader.GetInt32(0);
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT defaultcharacteristic.DefaultCharacteristicValue FROM defaultcharacteristic WHERE defaultcharacteristic.CharacteristicID = '" + characteristicID + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    characteristicValueCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            characteristicValueTB.Enabled = true;
            connection.Close();
            if (characteristicNameCB.SelectedItem.ToString() == "")
            {
                characteristicValueCB.Items.Clear();
            }
        }

        private void characteristicValueCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (characteristicValueCB.SelectedItem.ToString() == "")
            {
                characteristicValueTB.Enabled = true;
            }
            else
            {
                characteristicValueTB.Enabled = false;
                connection.Open();
                command = new MySqlCommand("SELECT defaultcharacteristic.DefaultCharacteristicID FROM defaultcharacteristic WHERE defaultcharacteristic.CharacteristicID = '" + characteristicID + "' " +
                                           "AND defaultcharacteristic.DefaultCharacteristicValue = '" + characteristicValueCB.SelectedItem + "'", connection);
                using (MySqlDataReader MyReader = command.ExecuteReader())
                {
                    while (MyReader.Read())
                    {
                        defaulCharacteristicID = MyReader.GetInt32(0);
                    }
                    MyReader.Close();
                }
                connection.Close();
            }
        }

        private void characteristicValueTB_TextChanged(object sender, EventArgs e)
        {
            characteristicValueCB.Enabled = false;
            if (characteristicValueTB.Text == "")
            {
                characteristicValueCB.Enabled = true;
            }
        }

        private void acceptButton_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            int tempCharacteristicID = 0;
            command = new MySqlCommand("SELECT specificcharacteristics.CharacteristicID FROM specificcharacteristics WHERE specificcharacteristics.GoodsID = '" + componentID + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    tempCharacteristicID = MyReader.GetInt32(0);
                }
                MyReader.Close();
            }
            if (defaulCharacteristicID != 0)
            {
                if (tempCharacteristicID != 0)
                {
                    command = new MySqlCommand("UPDATE specificcharacteristics SET specificcharacteristics.CharacteristicID = '" + characteristicID + "', specificcharacteristics.SpecificCharacteristicValue = @SpecValue, " +
                                               "specificcharacteristics.DefaultCharacteristicID = '" + defaulCharacteristicID + "' WHERE specificcharacteristics.GoodsID = '" + componentID + "'", connection);
                    command.Parameters.AddWithValue("@SpecValue", null);
                    command.ExecuteNonQuery();
                }
                else
                {
                    command = new MySqlCommand("INSERT INTO specificcharacteristics (specificcharacteristics.CharacteristicID, specificcharacteristics.DefaultCharacteristicID, specificcharacteristics.GoodsID) VALUES " +
                                               "('" + characteristicID + "', '" + defaulCharacteristicID + "', '" + componentID + "')", connection);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                if (tempCharacteristicID != 0)
                {
                    command = new MySqlCommand("UPDATE specificcharacteristics SET specificcharacteristics.CharacteristicID = '" + characteristicID + "', specificcharacteristics.SpecificCharacteristicValue = '" + characteristicValueTB.Text + "', " +
                                               "specificcharacteristics.DefaultCharacteristicID = @DefaultID WHERE specificcharacteristics.GoodsID = '" + componentID + "'", connection);
                    command.Parameters.AddWithValue("@DefaultID", null);
                    command.ExecuteNonQuery();
                }
                else if (characteristicID != 0)
                {
                    command = new MySqlCommand("INSERT INTO specificcharacteristics (specificcharacteristics.CharacteristicID, specificcharacteristics.SpecificCharacteristicValue, specificcharacteristics.GoodsID) VALUES " +
                                               "('" + characteristicID + "', '" + characteristicValueTB.Text + "', '" + componentID + "')", connection);
                    command.ExecuteNonQuery();
                } 
            }
            try
            {
                command = new MySqlCommand("INSERT INTO goodscatalog (goodscatalog.WarrantyID) VALUES " +
                                           "('" + warrantyID + "') WHERE goodscatalog.GoodsID = '" + componentID + "'", connection);
                command.ExecuteNonQuery();
            }
            catch
            {
            }
            try
            {
                command = new MySqlCommand("UPDATE goodscatalog SET goodscatalog.WarrantyID = '" + warrantyID + "' " +
                                           "WHERE goodscatalog.GoodsID = '" + componentID + "'", connection);
                command.ExecuteNonQuery();
            }
            catch
            {
            }
            connection.Close();
            ChangeCharacteristic_Load(null, null);
            characteristicValueTB.Clear();
        }

        private void warrantyPeriodCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            command = new MySqlCommand("SELECT warranty.WarrantyID FROM warranty " +
                                       "WHERE warranty.WarrantyPeriod = '" + warrantyPeriodCB.SelectedItem.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    warrantyID = MyReader.GetInt32(0);
                }
                MyReader.Close();
            }
            connection.Close();
        }
    }
}
