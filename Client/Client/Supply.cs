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
    public partial class Supply : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = root; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public List<string> suppliers = new List<string>();
        public List<string> workers = new List<string>();
        public int supplyID;
        public int count = 1;
        public int supplyCount = 1;
        public int suppliersID = 0;
        public int workerID = 0;

        public Supply()
        {
            InitializeComponent();
        }

        private void Supply_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "goods.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.goods.DataTable);
            connection.Open();
            command = new MySqlCommand("SELECT suppliers.SuppliersName FROM suppliers", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    suppliersCB.Items.Add(MyReader.GetString(0));
                    suppliers.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT worker.WorkerName FROM worker", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    workerNameCB.Items.Add(MyReader.GetString(0));
                    workers.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void supplyQuantityTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void supplyButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            int goodsQuantity = 0;
            try
            {
                command = new MySqlCommand("SELECT supplystructure.GoodsAmount FROM " +
                                           "supplystructure WHERE supplystructure.SupplyID = '" + supplyID + "' " +
                                           "AND supplystructure.GoodsID = '" + supplyDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
                using (MySqlDataReader MyReader = command.ExecuteReader())
                {
                    while (MyReader.Read())
                    {
                        goodsQuantity = MyReader.GetInt32(0);
                    }
                    MyReader.Close();
                }
            }
            catch
            {
            }
            try
            {
                command = new MySqlCommand("INSERT INTO supply (supply.SupplyID) VALUES " +
                                           "('" + supplyID + "')", connection);
                command.ExecuteNonQuery();
                count++;
            }
            catch
            {
            }
            connection.Close();
            if (supplyQuantityTB.Text == "" || Convert.ToInt32(supplyQuantityTB.Text) < 1)
            {
                MessageBox.Show("Введите количество товара поставки!");
                supplyQuantityTB.Clear();
            }
            else
            {
                connection.Open();
                if (goodsQuantity == 0)
                {
                    command = new MySqlCommand("INSERT INTO supplystructure (supplystructure.GoodsID, supplystructure.SupplyID, supplystructure.GoodsAmount) VALUES " +
                                               "('" + supplyDGV.CurrentRow.Cells[5].Value.ToString() + "', '" + supplyID + "', '" + Convert.ToInt32(supplyQuantityTB.Text) + "')", connection);
                    command.ExecuteNonQuery();
                }
                else
                {
                    command = new MySqlCommand("UPDATE supplystructure SET supplystructure.GoodsAmount = '" + (goodsQuantity + Convert.ToInt32(supplyQuantityTB.Text)) + "' " +
                                               "WHERE supplystructure.SupplyID = '" + supplyID + "' AND supplystructure.GoodsID = '" + supplyDGV.CurrentRow.Cells[5].Value.ToString() + "'", connection);
                    command.ExecuteNonQuery();
                }
                supplyQuantityTB.Clear();
                connection.Close();
            }
        }

        private void acceptSupplyButton_Click(object sender, EventArgs e)
        {
            List<string> goodsID = new List<string>();
            List<string> goodsAmount = new List<string>();
            if (suppliersCB.SelectedItem == null)
            {
                MessageBox.Show("Выберите поставщика!");
            }
            else if (workerNameCB.SelectedItem == null)
            {
                MessageBox.Show("Выберите сотрудника!");
            }
            else
            {
                connection.Open();
                command = new MySqlCommand("UPDATE supply SET supply.SuppliersID = '" + suppliersID + "', supply.WorkerID = '" + workerID + "', supply.SupplyDate = '" + supplyDateDTP.Value.Date.ToString("yyyy-MM-dd") + "' " +
                                           "WHERE supply.SupplyID = '" + supplyID + "'", connection);
                command.ExecuteNonQuery();
                command = new MySqlCommand("SELECT supplystructure.GoodsAmount, supplystructure.GoodsID FROM supplystructure " +
                                           "WHERE supplystructure.SupplyID = '" + supplyID + "'", connection);
                using (MySqlDataReader MyReader = command.ExecuteReader())
                {
                    while (MyReader.Read())
                    {
                        goodsAmount.Add(MyReader.GetInt32(0).ToString());
                        goodsID.Add(MyReader.GetInt32(1).ToString());
                    }
                    MyReader.Close();
                }
                for (int i = 0; i < goodsID.Count; i++)
                {
                    int goodsQuantity = 0;
                    try
                    {
                        command = new MySqlCommand("SELECT warehouse.WarehouseGoodsAmount FROM warehouse " +
                                                   "WHERE warehouse.GoodsID = '" + goodsID[i] + "'", connection);
                        using (MySqlDataReader MyReader = command.ExecuteReader())
                        {
                            while (MyReader.Read())
                            {
                                goodsQuantity = MyReader.GetInt32(0);
                            }
                            MyReader.Close();
                        }
                    }
                    catch
                    {
                    }
                    if (goodsQuantity == 0)
                    {
                        command = new MySqlCommand("INSERT INTO warehouse (warehouse.GoodsID, warehouse.WarehouseGoodsAmount) VALUES " +
                                                   "('" + goodsID[i] + "', '" + Convert.ToInt32(goodsAmount[i]) + "')", connection);
                        command.ExecuteNonQuery();
                    }
                    else
                    {
                        command = new MySqlCommand("UPDATE warehouse SET warehouse.WarehouseGoodsAmount = '" + (goodsQuantity + Convert.ToInt32(goodsAmount[i])) + "' " +
                                                   "WHERE warehouse.GoodsID = '" + goodsID[i] + "'", connection);
                        command.ExecuteNonQuery();
                    }
                }
                connection.Close();
                supplyCount++;
                supplyQuantityTB.Clear();
                suppliersCB.Items.Clear();
                workerNameCB.Items.Clear();
                for (int i = 0; i < suppliers.Count; i++)
                {
                    suppliersCB.Items.Add(suppliers[i]);
                }
                for (int i = 0; i < workers.Count; i++)
                {
                    workerNameCB.Items.Add(workers[i]);
                }
                supplyReport.SetParameterValue("SupplyID", supplyID);
                supplyReport.Show();
                Close();
            }
        }

        private void suppliersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            command = new MySqlCommand("SELECT suppliers.SuppliersID FROM suppliers " +
                                       "WHERE suppliers.SuppliersName = '" + suppliersCB.SelectedItem.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    suppliersID = MyReader.GetInt32(0);
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void workerNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            command = new MySqlCommand("SELECT worker.WorkerID FROM worker " +
                                       "WHERE worker.WorkerName = '" + workerNameCB.SelectedItem.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    workerID = MyReader.GetInt32(0);
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void supplyStructureButton_Click(object sender, EventArgs e)
        {
            SupplyStructure supplyStructure = new SupplyStructure();
            supplyStructure.supplyID = supplyID;
            supplyStructure.ShowDialog();
        }
    }
}
