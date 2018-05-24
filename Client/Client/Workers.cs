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
    public partial class Workers : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = client; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();

        public Workers()
        {
            InitializeComponent();
        }

        private void Workers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "workersList.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.workersList.DataTable);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = workersList.Tables[0].DefaultView;
            dataView.RowFilter = "WorkerName LIKE '" + workerNameTB.Text + "%'";
            if (workerPostTB.Text != "")
            {
                dataView.RowFilter += "AND WorkerPost = '" + workerPostTB.Text + "'";
            }
            workersDGV.DataSource = dataView;
            connection.Close();
        }

        private void workerPostButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            DataView dataView = workersList.Tables[0].DefaultView;
            dataView.RowFilter = "WorkerPost = '" + workerPostTB.Text + "'";
            if (workerNameTB.Text != "")
            {
                dataView.RowFilter += "AND WorkerName LIKE '" + workerNameTB.Text + "%'";
            }
            workersDGV.DataSource = dataView;
            connection.Close();
        }

        private void showAllWorkersButton_Click(object sender, EventArgs e)
        {
            workerNameTB.Clear();
            workerPostTB.Clear();
            connection.Open();
            DataView dataView = workersList.Tables[0].DefaultView;
            dataView.RowFilter = "";
            workersDGV.DataSource = dataView;
            dataTableBindingSource.Filter = "";
            connection.Close();
        }
    }
}
