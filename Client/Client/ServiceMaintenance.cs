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
    public partial class ServiceMaintenance : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = client; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public int basketID { get; set; }
        public int count = 1;

        public ServiceMaintenance()
        {
            InitializeComponent();
        }

        private void ServiceMaintenance_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "serviceMaintenanceList.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.serviceMaintenanceList.DataTable);

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
            command = new MySqlCommand("INSERT INTO chosenservicemaintenance (chosenservicemaintenance.BasketID, chosenservicemaintenance.ServiceMaintenanceID) VALUES " +
                                       "('" + basketID + "', '" + serviceMaintenanceDGV.CurrentRow.Cells[0].Value.ToString() + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
        }

        private void costButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = serviceMaintenanceList.Tables[0].DefaultView;
            if (lowPriceTB.Text != "" && highPriceTB.Text == "")
            {
                dataView.RowFilter = "ServiceMaintenanceCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "'";
            }
            if (lowPriceTB.Text == "" && highPriceTB.Text != "")
            {
                dataView.RowFilter = "ServiceMaintenanceCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            if (lowPriceTB.Text != "" && highPriceTB.Text != "")
            {
                dataView.RowFilter = "ServiceMaintenanceCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "' AND ServiceMaintenanceCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            if (serviceMaintenanceNameTB.Text != "")
            {
                dataView.RowFilter += "AND ServiceMaintenanceName LIKE '" + serviceMaintenanceNameTB.Text + "%'";
            }
            serviceMaintenanceDGV.DataSource = dataView;
            connection.Close();
        }

        private void serviceMaintenanceNameTB_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = serviceMaintenanceList.Tables[0].DefaultView;
            dataView.RowFilter = "ServiceMaintenanceName LIKE '" + serviceMaintenanceNameTB.Text + "%'";
            if (lowPriceTB.Text != "")
            {
                dataView.RowFilter += "AND ServiceMaintenanceCost >= '" + Convert.ToInt32(lowPriceTB.Text) + "'";
            }
            if (highPriceTB.Text != "")
            {
                dataView.RowFilter += "AND ServiceMaintenanceCost <= '" + Convert.ToInt32(highPriceTB.Text) + "'";
            }
            serviceMaintenanceDGV.DataSource = dataView;
            connection.Close();
        }

        private void showAllServiceMaintenanceButton_Click(object sender, EventArgs e)
        {
            lowPriceTB.Clear();
            highPriceTB.Clear();
            serviceMaintenanceNameTB.Clear();
            connection.Open();
            DataView dataView = serviceMaintenanceList.Tables[0].DefaultView;
            dataView.RowFilter = "";
            serviceMaintenanceDGV.DataSource = dataView;
            dataTableBindingSource.Filter = "";
            connection.Close();
        }

        private void serviceMaintenancePriceListButton_Click_1(object sender, EventArgs e)
        {
            serviceMaintenancePriceListReport.Show();
        }
    }
}
