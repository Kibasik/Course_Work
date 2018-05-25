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
    public partial class DeliveryAndSale : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = client; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public double deliveryCost = 0;
        public string deliveryMethod { get; set; }
        public int basketID { get; set; }
        public string clientName { get; set; }
        public int basketCount { get; set; }
        public int basketQuantity { get; set; }

        public DeliveryAndSale()
        {
            InitializeComponent();
        }

        private void Delivery_Load(object sender, EventArgs e)
        {
            connection.Open();
            MainWindow mainWindow = new MainWindow();
            basketCount = mainWindow.basketCount;
            basketQuantity = mainWindow.basketQuantity;
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
            command = new MySqlCommand("SELECT worker.WorkerName FROM worker", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    workerNameCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT paymentmethod.PaymentMethodName FROM paymentmethod", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    paymentMethodCB.Items.Add(MyReader.GetString(0));
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
            command = new MySqlCommand("SELECT deliverymethod.DeliveryMethodCost, deliverymethod.DeliveryMethodName FROM deliverymethod " +
                                       "WHERE deliverymethod.DeliveryMethodName = '" + deliveryMethodCB.SelectedItem.ToString() + "'", connection);
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
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
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

        private void buyButton_Click(object sender, EventArgs e)
        {
            int deliveryMethodID = 0;
            int deliveryID = 0;
            int paymentMethodID = 0;
            int clientID = 0;
            int workerID = 0;
            double deliveryCost = 0;
            List<int> goodsID = new List<int>();
            List<int> componentsQuantity = new List<int>();
            List<int> goodsQuantity = new List<int>();
            if (deliveryMethodCB.SelectedItem == null)
            {
                MessageBox.Show("Выберите способ доставки!");
            }
            else if (deliveryMethodCB.SelectedItem.ToString() == "Доставка" && (deliveryCityTB.Text == "" || deliveryStreetTB.Text == "" || deliveryHouseTB.Text == "" || deliveryFlatTB.Text == ""))
            {
                MessageBox.Show("Введите данные для доставки!");
            }
            else if (clientSurnameTB.Text == "" || clientNameTB.Text == "" || clientPatronymicTB.Text == "" || clientPhoneMTB.Text == "(   )    -" || clientEmailTB.Text == "")
            {
                MessageBox.Show("Введите данные покупателя!");
            }
            else if (workerNameCB.SelectedItem == null)
            {
                MessageBox.Show("Выберите сотрудника!");
            }
            else if (paymentMethodCB.SelectedItem == null)
            {
                MessageBox.Show("Выберите способ оплаты!");
            }
            else
            {
                connection.Open();
                if (deliveryMethodCB.SelectedItem.ToString() == "Доставка")
                {
                    deliveryCost = 500;
                }
                clientName = clientSurnameTB.Text + " " + clientNameTB.Text + " " + clientPatronymicTB.Text;
                string deliveryAddress = "г. " + deliveryCityTB.Text + ", ул. " + deliveryStreetTB.Text + ", д. " + deliveryHouseTB.Text + ", кв. " + deliveryFlatTB.Text;
                command = new MySqlCommand("INSERT INTO client (client.ClientName, client.ClientEmail, client.ClientPhone) VALUES " +
                                           "('" + clientName + "', '" + clientEmailTB.Text + "', '" + clientPhoneMTB.Text + "')", connection);
                command.ExecuteNonQuery();
                command = new MySqlCommand("SELECT deliverymethod.DeliveryMethodID, deliverymethod.DeliveryMethodName FROM deliverymethod " +
                                           "WHERE deliverymethod.DeliveryMethodName = '" + deliveryMethodCB.SelectedItem.ToString() + "'", connection);
                using (MySqlDataReader MyReader = command.ExecuteReader())
                {
                    while (MyReader.Read())
                    {
                        deliveryMethodID = MyReader.GetInt32(0);
                    }
                    MyReader.Close();
                }
                if (deliveryMethodID == 1)
                {
                    command = new MySqlCommand("INSERT INTO delivery (delivery.DeliveryMethodID) VALUES " +
                                               "('" + deliveryMethodID + "')", connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    command = new MySqlCommand("INSERT INTO delivery (delivery.DeliveryAddress, delivery.DeliveryDate, delivery.DeliveryMethodID) VALUES " +
                                               "('" + deliveryAddress + "', '" + deliveryDateDTP.Value.Date.ToString("yyyy-MM-dd") + "', '" + deliveryMethodID + "')", connection);
                    command.ExecuteNonQuery();
                }
                command = new MySqlCommand("SELECT delivery.DeliveryID FROM delivery", connection);
                using (MySqlDataReader MyReader = command.ExecuteReader())
                {
                    while (MyReader.Read())
                    {
                        int tempID = MyReader.GetInt32(0);
                        if (tempID > deliveryID)
                        {
                            deliveryID = tempID;
                        }
                    }
                    MyReader.Close();
                }
                command = new MySqlCommand("SELECT paymentmethod.PaymentMethodID FROM paymentmethod " +
                                               "WHERE paymentmethod.PaymentMethodName = '" + paymentMethodCB.SelectedItem.ToString() + "'", connection);
                using (MySqlDataReader MyReader = command.ExecuteReader())
                {
                    while (MyReader.Read())
                    {
                        paymentMethodID = MyReader.GetInt32(0);
                    }
                    MyReader.Close();
                }
                command = new MySqlCommand("SELECT client.ClientID FROM client WHERE client.ClientName = '" + clientName + "'", connection);
                using (MySqlDataReader MyReader = command.ExecuteReader())
                {
                    while (MyReader.Read())
                    {
                        clientID = MyReader.GetInt32(0);
                    }
                    MyReader.Close();
                }
                command = new MySqlCommand("SELECT worker.WorkerID FROM worker WHERE worker.WorkerName = '" + workerNameCB.SelectedItem.ToString() + "'", connection);
                using (MySqlDataReader MyReader = command.ExecuteReader())
                {
                    while (MyReader.Read())
                    {
                        workerID = MyReader.GetInt32(0);
                    }
                    MyReader.Close();
                }
                command = new MySqlCommand("INSERT INTO sale (sale.BasketID, sale.DeliveryID, sale.PaymentMethodID, sale.ClientID, sale.WorkerID, sale.SaleDate) VALUES " +
                                           "('" + basketID + "', '" + deliveryID + "', '" + paymentMethodID + "', '" + clientID + "', '" + workerID + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "')", connection);
                command.ExecuteNonQuery();
                command = new MySqlCommand("SELECT componentslist.GoodsID, componentslist.GoodsQuantity, componentslist.BasketID FROM componentslist " +
                                           "WHERE componentslist.BasketID = '" + basketID + "'", connection);
                using (MySqlDataReader MyReader = command.ExecuteReader())
                {
                    while (MyReader.Read())
                    {
                        goodsID.Add(MyReader.GetInt32(0));
                        componentsQuantity.Add(MyReader.GetInt32(1));
                    }
                    MyReader.Close();
                }
                for (int i = 0; i < goodsID.Count; i++)
                {
                    command = new MySqlCommand("SELECT goodscatalog.GoodsID, goodscatalog.GoodsAmount, componentslist.BasketID FROM componentslist " +
                                               "INNER JOIN goodscatalog ON componentslist.GoodsID = goodscatalog.GoodsID INNER JOIN basket " +
                                               "ON componentslist.BasketID = basket.BasketID WHERE basket.BasketID = '" + basketID + "' AND " +
                                               "goodscatalog.GoodsID = '" + goodsID[i] + "'", connection);
                    using (MySqlDataReader MyReader = command.ExecuteReader())
                    {
                        while (MyReader.Read())
                        {
                            goodsQuantity.Add(MyReader.GetInt32(1));
                        }
                        MyReader.Close();
                    }
                }
                for (int i = 0; i < goodsID.Count; i++)
                {
                    command = new MySqlCommand("UPDATE goodscatalog SET goodscatalog.GoodsAmount = '" + (goodsQuantity[i] - componentsQuantity[i]) + "' " +
                                               "WHERE goodscatalog.GoodsID = '" + goodsID[i] + "'", connection);
                    command.ExecuteNonQuery();
                }
                saleReport.SetParameterValue("basketID", basketID);
                saleReport.SetParameterValue("clientName", clientName);
                saleReport.SetParameterValue("workerName", workerNameCB.SelectedItem.ToString());
                saleReport.SetParameterValue("paymentMethod", paymentMethodCB.SelectedItem.ToString());
                saleReport.SetParameterValue("deliveryCost", deliveryCost);
                saleReport.SetParameterValue("saleDate", DateTime.Now.ToString("yyyy-MM-dd"));
                saleReport.Show();
                connection.Close();
                basketCount++;
                basketQuantity = 0;
                Close();
            }
        }
    }
}
