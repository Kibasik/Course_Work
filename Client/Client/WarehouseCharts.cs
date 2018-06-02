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
    public partial class WarehouseCharts : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = root; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        List<string> suppliers = new List<string>();
        List<string> workers = new List<string>();
        List<string> componentsType = new List<string>();

        public WarehouseCharts()
        {
            InitializeComponent();
        }

        private void WarehouseCharts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouseComponentsAmount.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter3.Fill(this.warehouseComponentsAmount.DataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouseComponentsAmount.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter3.Fill(this.warehouseComponentsAmount.DataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dateSupplyChart1.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter2.Fill(this.dateSupplyChart1.DataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workersChart.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter1.Fill(this.workersChart.DataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suppliersChart.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.suppliersChart.DataTable);
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
            command = new MySqlCommand("SELECT typecategory.TypeCategoryName FROM typecategory", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    componentsTypeCB.Items.Add(MyReader.GetString(0));
                    componentsType.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void suppliersCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = suppliersChart.Tables[0].DefaultView;
            dataTableBindingSource.Filter = "SuppliersName = '" + suppliersCB.SelectedItem.ToString() + "'";
            suppliersSupplyChart.DataBind();
            connection.Close();
        }

        private void workerNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = workersChart.Tables[0].DefaultView;
            dataTableBindingSource1.Filter = "WorkerName = '" + workerNameCB.SelectedItem.ToString() + "'";
            workersSupplyChart.DataBind();
            connection.Close();
        }

        private void deleteSuppliersFilterButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = suppliersChart.Tables[0].DefaultView;
            dataTableBindingSource.Filter = "";
            suppliersSupplyChart.DataBind();
            connection.Close();
            suppliersCB.Items.Clear();
            for (int i = 0; i < suppliers.Count(); i++)
            {
                suppliersCB.Items.Add(suppliers[i]);
            }
        }

        private void deleteWorkerFilterButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = workersChart.Tables[0].DefaultView;
            dataTableBindingSource1.Filter = "";
            workersSupplyChart.DataBind();
            connection.Close();
            workerNameCB.Items.Clear();
            for (int i = 0; i < workers.Count(); i++)
            {
                workerNameCB.Items.Add(workers[i]);
            }
        }

        private void beginDTP_ValueChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = dateSupplyChart1.Tables[0].DefaultView;
            dataTableBindingSource2.Filter = "SupplyDate >= '" + beginDTP.Value.Date.ToString("yyyy-MM-dd") + "' AND SupplyDate <= '" + endDTP.Value.Date.ToString("yyyy-MM-dd") + "'";
            dateSupplyChart.DataBind();
            connection.Close();
        }

        private void endDTP_ValueChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = dateSupplyChart1.Tables[0].DefaultView;
            dataTableBindingSource2.Filter = "SupplyDate >= '" + beginDTP.Value.Date.ToString("yyyy-MM-dd") + "' AND SupplyDate <= '" + endDTP.Value.Date.ToString("yyyy-MM-dd") + "'";
            dateSupplyChart.DataBind();
            connection.Close();
        }

        private void deleteComponentsTypeFilterButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = warehouseComponentsAmount.Tables[0].DefaultView;
            dataTableBindingSource3.Filter = "";
            warehouseComponentsAmountChart.DataBind();
            connection.Close();
            componentsTypeCB.Items.Clear();
            for (int i = 0; i < componentsType.Count(); i++)
            {
                componentsTypeCB.Items.Add(workers[i]);
            }
        }

        private void componentsTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = warehouseComponentsAmount.Tables[0].DefaultView;
            dataTableBindingSource3.Filter = "TypeCategoryName = '" + componentsTypeCB.SelectedItem.ToString() + "'";
            warehouseComponentsAmountChart.DataBind();
            connection.Close();
        }
    }
}
