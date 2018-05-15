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
    public partial class Delivery : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = client; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public double deliveryCost = 0;
        public string deliveryMethod { get; set; }

        public Delivery()
        {
            InitializeComponent();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            connection.Open();
            deliveryCityTB.Enabled = false;
            deliveryStreetTB.Enabled = false;
            deliveryHouseTB.Enabled = false;
            deliveryFlatTB.Enabled = false;
            deliveryDateDTP.Enabled = false;
            command = new MySqlCommand("SELECT deliverymethod.DeliveryMethodName FROM deliverymethod", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    deliveryMethodCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void deliveryMethodCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            deliveryCost = 0;
            deliveryMethod = deliveryMethodCB.SelectedItem.ToString();
            command = new MySqlCommand("SELECT deliverymethod.DeliveryMethodCost, deliverymethod.DeliveryMethodName FROM deliverymethod WHERE deliverymethod.DeliveryMethodName = '" + deliveryMethodCB.SelectedItem.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    deliveryCost += MyReader.GetDouble(0);
                }
                MyReader.Close();
            }
            if (deliveryCost == 0)
            {
                deliveryCostLabel.Text = "Бесплатно";
                deliveryCityTB.Enabled = false;
                deliveryStreetTB.Enabled = false;
                deliveryHouseTB.Enabled = false;
                deliveryFlatTB.Enabled = false;
                deliveryDateDTP.Enabled = false;
            }
            else
            {
                deliveryCostLabel.Text = deliveryCost.ToString();
                deliveryCityTB.Enabled = true;
                deliveryStreetTB.Enabled = true;
                deliveryHouseTB.Enabled = true;
                deliveryFlatTB.Enabled = true;
                deliveryDateDTP.Enabled = true;
            }
            connection.Close();
        }

        private void deliveryFlatTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void deliveryCityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void deliveryStreetTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void deliveryHouseTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void clientNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void clientSurnameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void clientPatronymicTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void deliveryAcceptButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            int deliveryMethodID = 0;
            //string clientName = clientSurnameTB.Text + " " + clientNameTB.Text + " " + clientPatronymicTB.Text;
            string deliveryAddress = "г. " + deliveryCityTB.Text + ", ул. " + deliveryStreetTB.Text + ", д. " + deliveryHouseTB.Text + ", кв. " + deliveryFlatTB.Text;
            //command = new MySqlCommand("INSERT INTO client (client.ClientName, client.ClientEmail, client.ClientPhone) VALUES " +
            //                           "('" + clientName + "', '" + clientEmailTB.Text + "', '" + clientPhoneMTB.Text + "')", connection);
            //command.ExecuteNonQuery();
            command = new MySqlCommand("SELECT deliverymethod.DeliveryMethodID, deliverymethod.DeliveryMethodName FROM deliverymethod " +
                                       "WHERE deliverymethod.DeliveryMethodName = '" + deliveryMethod + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    deliveryMethodID = MyReader.GetInt32(0);
                }
                MyReader.Close();
            }
            command = new MySqlCommand("INSERT INTO delivery (delivery.DeliveryAddress, delivery.DeliveryDate, delivery.DeliveryMethodID) VALUES " +
                                           "('" + deliveryAddress + "', '" + deliveryDateDTP.Value.Date.ToString("yyyy-MM-dd") + "', '" + deliveryMethodID + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Close();
        }
    }
}
