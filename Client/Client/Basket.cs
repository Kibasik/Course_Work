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
    public partial class Basket : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = client; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public int basketID { get; set; }
        public double totalCost = 0;

        public Basket()
        {
            InitializeComponent();
        }

        private void Basket_Load(object sender, EventArgs e)
        {
            connection.Open();
            goodsDGV.Rows.Clear();
            softwareDGV.Rows.Clear();
            additionalServicesDGV.Rows.Clear();
            serviceMaintenanceDGV.Rows.Clear();
            command = new MySqlCommand("SELECT typecategory.TypeCategoryName, categorygoods.CategoryGoodsName, goodscatalog.GoodsName, " +
                                       "goodsmanufacturer.GoodsManufacturerName, goodscatalog.GoodsCost, componentslist.GoodsQuantity, " +
                                       "goodscatalog.GoodsID, componentslist.BasketID FROM categorygoods INNER JOIN typecategory " +
                                       "ON categorygoods.TypeCategoryID = typecategory.TypeCategoryID " +
                                       "INNER JOIN goodscatalog ON goodscatalog.CategoryGoodsID = categorygoods.CategoryGoodsID INNER JOIN componentslist " +
                                       "ON componentslist.GoodsID = goodscatalog.GoodsID INNER JOIN goodsmanufacturer " +
                                       "ON goodscatalog.GoodsManufacturerID = goodsmanufacturer.GoodsManufacturerID " +
                                       "WHERE componentslist.BasketID = '" + basketID + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                int j = 0;
                while (MyReader.Read())
                {
                    goodsDGV.Rows.Add();
                    goodsDGV[0, j].Value = MyReader.GetString(0);
                    goodsDGV[1, j].Value = MyReader.GetString(1);
                    goodsDGV[2, j].Value = MyReader.GetString(2);
                    goodsDGV[3, j].Value = MyReader.GetString(3);
                    goodsDGV[4, j].Value = MyReader.GetDouble(4);
                    goodsDGV[5, j].Value = MyReader.GetInt32(5);
                    goodsDGV[6, j].Value = MyReader.GetInt32(6);
                    j++;
                    totalCost += (MyReader.GetDouble(4) * MyReader.GetInt32(5));
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT softwaretype.SoftwareTypeName, software.SoftwareName, software.SoftwareCost, chosensoftware.SoftwareQuantity, " +
                                       "software.SoftwareID FROM software INNER JOIN softwaretype ON software.SoftwareTypeID = softwaretype.SoftwareTypeID " +
                                       "INNER JOIN chosensoftware ON chosensoftware.SoftwareID = software.SoftwareID " +
                                       "WHERE chosensoftware.BasketID = '" + basketID + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                int j = 0;
                while (MyReader.Read())
                {
                    softwareDGV.Rows.Add();
                    softwareDGV[0, j].Value = MyReader.GetString(0);
                    softwareDGV[1, j].Value = MyReader.GetString(1);
                    softwareDGV[2, j].Value = MyReader.GetDouble(2);
                    softwareDGV[3, j].Value = MyReader.GetInt32(3);
                    softwareDGV[4, j].Value = MyReader.GetInt32(4);
                    j++;
                    totalCost += (MyReader.GetDouble(2) * MyReader.GetInt32(3));
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT additionalservices.AdditionalServiceName, additionalservices.AdditionalServiceCost, " +
                                       "chosenadditionalservices.AdditionalServiceID FROM chosenadditionalservices INNER JOIN additionalservices " +
                                       "ON chosenadditionalservices.AdditionalServiceID = additionalservices.AdditionalServiceID " +
                                       "WHERE chosenadditionalservices.BasketID = '" + basketID + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                int j = 0;
                while (MyReader.Read())
                {
                    additionalServicesDGV.Rows.Add();
                    additionalServicesDGV[0, j].Value = MyReader.GetString(0);
                    additionalServicesDGV[1, j].Value = MyReader.GetDouble(1);
                    additionalServicesDGV[2, j].Value = MyReader.GetInt32(2);
                    j++;
                    totalCost += MyReader.GetDouble(1);
                }
                MyReader.Close();
            }
            totalCostLabel.Text = totalCost.ToString();

            command = new MySqlCommand("SELECT servicemaintenance.ServiceMaintenanceName, servicemaintenance.ServiceMaintenanceCost, " +
                                       "servicemaintenance.ServiceMaintenancePeriod, chosenservicemaintenance.ServiceMaintenanceID FROM " +
                                       "chosenservicemaintenance INNER JOIN servicemaintenance ON " +
                                       "chosenservicemaintenance.ServiceMaintenanceID = servicemaintenance.ServiceMaintenanceID " +
                                       "WHERE chosenservicemaintenance.BasketID = '" + basketID + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                int j = 0;
                while (MyReader.Read())
                {
                    serviceMaintenanceDGV.Rows.Add();
                    serviceMaintenanceDGV[0, j].Value = MyReader.GetString(0);
                    serviceMaintenanceDGV[1, j].Value = MyReader.GetDouble(1);
                    serviceMaintenanceDGV[2, j].Value = MyReader.GetInt32(2);
                    serviceMaintenanceDGV[3, j].Value = MyReader.GetInt32(3);
                    j++;
                    totalCost += MyReader.GetDouble(1);
                }
                MyReader.Close();
            }
            totalCostLabel.Text = totalCost.ToString();
            goodsDGV.ClearSelection();
            softwareDGV.ClearSelection();
            additionalServicesDGV.ClearSelection();
            serviceMaintenanceDGV.ClearSelection();
            connection.Close();
        }

        private void deleteSoftwareButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (softwareDGV.SelectedRows.Count == 1 || softwareDGV.GetCellCount(DataGridViewElementStates.Selected) == 1)
            {
                totalCost -= (Convert.ToDouble(softwareDGV.CurrentRow.Cells[2].Value) * Convert.ToDouble(softwareDGV.CurrentRow.Cells[3].Value));
                command = new MySqlCommand("DELETE FROM chosensoftware WHERE chosensoftware.BasketID = '" + basketID + "' " +
                                           "AND chosensoftware.SoftwareID = '" + Convert.ToInt32(softwareDGV.CurrentRow.Cells[4].Value) + "'", connection);
                command.ExecuteNonQuery();
                softwareDGV.Rows.RemoveAt(softwareDGV.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Выберите программное обеспечение!");
            }
            totalCostLabel.Text = totalCost.ToString();
            softwareDGV.ClearSelection();
            connection.Close();
        }

        private void deleteGoodsButton_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            if (goodsDGV.SelectedRows.Count == 1 || goodsDGV.GetCellCount(DataGridViewElementStates.Selected) == 1)
            {
                totalCost -= (Convert.ToDouble(goodsDGV.CurrentRow.Cells[4].Value) * Convert.ToInt32(goodsDGV.CurrentRow.Cells[5].Value));
                command = new MySqlCommand("DELETE FROM componentslist WHERE componentslist.BasketID = '" + basketID + "' " +
                                           "AND componentslist.GoodsID = '" + Convert.ToInt32(goodsDGV.CurrentRow.Cells[6].Value) + "'", connection);
                command.ExecuteNonQuery();
                goodsDGV.Rows.RemoveAt(goodsDGV.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Выберите комплектующее!");
            }
            totalCostLabel.Text = totalCost.ToString();
            goodsDGV.ClearSelection();
            connection.Close();
        }

        private void deleteAdditionalServiceButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (additionalServicesDGV.SelectedRows.Count == 1 || additionalServicesDGV.GetCellCount(DataGridViewElementStates.Selected) == 1)
            {
                totalCost -= Convert.ToDouble(additionalServicesDGV.CurrentRow.Cells[1].Value);
                command = new MySqlCommand("DELETE FROM chosenadditionalservices WHERE chosenadditionalservices.BasketID = '" + basketID + "' " +
                                           "AND chosenadditionalservices.AdditionalServiceID = '" + Convert.ToInt32(additionalServicesDGV.CurrentRow.Cells[2].Value) + "'", connection);
                command.ExecuteNonQuery();
                additionalServicesDGV.Rows.RemoveAt(additionalServicesDGV.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Выберите доп. услугу!");
            }
            totalCostLabel.Text = totalCost.ToString();
            additionalServicesDGV.ClearSelection();
            connection.Close();
        }

        private void deleteServiceMaintenanceButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (serviceMaintenanceDGV.SelectedRows.Count == 1 || serviceMaintenanceDGV.GetCellCount(DataGridViewElementStates.Selected) == 1)
            {
                totalCost -= Convert.ToDouble(serviceMaintenanceDGV.CurrentRow.Cells[1].Value);
                command = new MySqlCommand("DELETE FROM chosenservicemaintenance WHERE chosenservicemaintenance.BasketID = '" + basketID + "' " +
                                           "AND chosenservicemaintenance.ServiceMaintenanceID = '" + Convert.ToInt32(serviceMaintenanceDGV.CurrentRow.Cells[3].Value) + "'", connection);
                command.ExecuteNonQuery();
                serviceMaintenanceDGV.Rows.RemoveAt(serviceMaintenanceDGV.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Выберите сервисное обслуживание!");
            }
            totalCostLabel.Text = totalCost.ToString();
            serviceMaintenanceDGV.ClearSelection();
            connection.Close();
        }
    }
}
