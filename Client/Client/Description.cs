using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace Client
{
    public partial class Description : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = root; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public string description { get; set; }
        public string goodsName { get; set; }
        public string goodsManufacturer { get; set; }
        public int warrantyPeriod { get; set; }
        public byte[] image { get; set; }

        public Description()
        {
            InitializeComponent();
        }

        private void DescriptionWindow_Load(object sender, EventArgs e)
        {
            goodsNameLabel.Text = goodsManufacturer + " " + goodsName;
            descriptionRTB.Text += "Гарантия: " + warrantyPeriod + " мес.\n";
            descriptionRTB.Text += description;
            var memoryStream = new MemoryStream(image);
            goodsImagePB.Image = Image.FromStream(memoryStream);
        }
    }
}
