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
    public partial class ChangeDescription : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = root; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public int componentID = 0;
        public int componentDescriptionID = 0;
        public string componentName { get; set; }
        public string componentManufacturer { get; set; }
        public byte[] image { get; set; }
        public string description { get; set; }
        public Image img;

        public ChangeDescription()
        {
            InitializeComponent();
        }

        private void ChangeDescription_Load(object sender, EventArgs e)
        {
            componentNameLabel.Text = componentManufacturer + " " + componentName;
            componentDescriptionRTB.Text = description;
            var memoryStream = new MemoryStream(image);
            componentPB.Image = Image.FromStream(memoryStream);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (componentDescriptionRTB.Text == "")
            {
                MessageBox.Show("Описание не может быть пустым!");
            }
            else
            {
                command = new MySqlCommand("UPDATE goodsdescription SET goodsdescription.GoodsDescription = '" + componentDescriptionRTB.Text + "' " +
                                           "WHERE goodsdescription.GoodsDescriptionID = '" + componentDescriptionID + "'", connection);
                command.ExecuteNonQuery();
                try
                {
                    var newImg = ImageToByte(img);
                    command = new MySqlCommand("UPDATE goodscatalog SET goodscatalog.GoodsImage = @Image)", connection);
                    var blobImg = new MySqlParameter("@Image", MySqlDbType.LongBlob, newImg.Length);
                    blobImg.Value = newImg;
                    command.Parameters.Add(blobImg);
                    command.ExecuteNonQuery();
                }
                catch
                {
                }
            }
            connection.Close();
            Close();
        }

        private void changeImageButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.bmp";
            if (file.ShowDialog() == DialogResult.OK)
            {
                img = Image.FromFile(file.FileName);
            }
        }

        private byte[] ImageToByte(Image img)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                img.Save(memoryStream, img.RawFormat);
                return memoryStream.ToArray();
            }
        }
    }
}
