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
    public partial class Suppliers : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = root; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public string suppliersName;

        public Suppliers()
        {
            InitializeComponent();
        }

        private void Suppliers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "suppliersList.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.suppliersList.DataTable);
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new MySqlCommand("SELECT suppliers.SuppliersName FROM suppliers WHERE suppliers.SuppliersID = '" + Convert.ToInt32(suppliersDGV.CurrentRow.Cells[0].Value) + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    suppliersName = MyReader.GetString(0);
                }
                MyReader.Close();
            }
            connection.Close();
            suppliersReport.SetParameterValue("SuppliersName", suppliersName);
            suppliersReport.SetParameterValue("SuppliersID", Convert.ToInt32(suppliersDGV.CurrentRow.Cells[0].Value));
            suppliersReport.SetParameterValue("BeginDate", dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"));
            suppliersReport.SetParameterValue("EndDate", dateTimePicker2.Value.Date.ToString("yyyy-MM-dd"));
            suppliersReport.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            return;
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            return;
        }
    }
}
