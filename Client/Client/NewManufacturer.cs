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
    public partial class NewManufacturer : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = root; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();

        public NewManufacturer()
        {
            InitializeComponent();
        }

        private void addNewManufacturerButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            command = new MySqlCommand("INSERT INTO goodsmanufacturer (goodsmanufacturer.GoodsManufacturerName) VALUES " +
                                       "('" + newManufacturerTB.Text + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            Close();
        }
    }
}
