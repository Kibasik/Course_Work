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
using System.IO;

namespace Client
{
    public partial class NewComponent : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = root; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public bool imageCheck = false;
        public byte[] image { get; set; }
        public int componentTypeID = 0;
        public int componentCategoryID = 0;
        public int manufactureCountryID = 0;
        public int warrantyID = 0;
        public int manufacturerNameID = 0;
        public int componentDescriptionID = 0;
        public Image img;

        public NewComponent()
        {
            InitializeComponent();
        }

        private void NewComponent_Load(object sender, EventArgs e)
        {
            connection.Open();
            componentTypeCB.Items.Clear();
            warrantyPeriodCB.Items.Clear();
            manufactureCountryNameCB.Items.Clear();
            manufacturerNameCB.Items.Clear();
            command = new MySqlCommand("SELECT typecategory.TypeCategoryName FROM typecategory", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    componentTypeCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT warranty.WarrantyPeriod FROM warranty", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    warrantyPeriodCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT manufacturecountry.ManufactureCountryName FROM manufacturecountry", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    manufactureCountryNameCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT goodsmanufacturer.GoodsManufacturerName FROM goodsmanufacturer", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    manufacturerNameCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void countryManufacturerTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void manufacturerNameTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void componentCostTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void componentTypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            componentCategoryCB.Items.Clear();
            command = new MySqlCommand("SELECT typecategory.TypeCategoryID FROM typecategory " +
                                       "WHERE typecategory.TypeCategoryName = '" + componentTypeCB.SelectedItem.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    componentTypeID = MyReader.GetInt32(0);
                }
                MyReader.Close();
            }
            command = new MySqlCommand("SELECT categorygoods.CategoryGoodsName FROM categorygoods " +
                                       "WHERE categorygoods.TypeCategoryID = '" + componentTypeID + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    componentCategoryCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void chooseImageButton_Click(object sender, EventArgs e)
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (componentTypeCB.SelectedItem == null || componentCategoryCB.SelectedItem == null || manufactureCountryNameCB.SelectedItem == null ||
                warrantyPeriodCB.SelectedItem == null || manufacturerNameCB.SelectedItem == null || componentNameTB.Text == "" ||
                componentCostTB.Text == "" || componentDescriptionRTB.Text == "" || img == null)
            {
                MessageBox.Show("Введите все поля!");
            }
            else
            {
                connection.Open();
                var newImg = ImageToByte(img);
                command = new MySqlCommand("INSERT INTO goodsdescription (goodsdescription.GoodsDescription) VALUES " +
                                           "('" + componentDescriptionRTB.Text + "')", connection);
                command.ExecuteNonQuery();
                command = new MySqlCommand("SELECT goodsdescription.GoodsDescriptionID FROM goodsdescription " +
                                           "WHERE goodsdescription.GoodsDescription = '" + componentDescriptionRTB.Text + "'", connection);
                using (MySqlDataReader MyReader = command.ExecuteReader())
                {
                    while (MyReader.Read())
                    {
                        componentDescriptionID = MyReader.GetInt32(0);
                    }
                    MyReader.Close();
                }
                command = new MySqlCommand("INSERT INTO goodscatalog (goodscatalog.GoodsName, goodscatalog.GoodsAmount, goodscatalog.CategoryGoodsID," +
                                           "goodscatalog.ManufactureCountryID, goodscatalog.WarrantyID, goodscatalog.GoodsDescriptionID," +
                                           "goodscatalog.GoodsCost, goodscatalog.GoodsManufacturerID, goodscatalog.GoodsImage) VALUES " +
                                           "('" + componentNameTB.Text + "', '" + 0 + "', '" + componentCategoryID + "', " +
                                           "'" + manufactureCountryID + "', '" + warrantyID + "', '" + componentDescriptionID + "', " +
                                           "'" + Convert.ToDecimal(componentCostTB.Text) + "', '" + manufacturerNameID + "', @Image)", connection);
                var blobImg = new MySqlParameter("@Image", MySqlDbType.LongBlob, newImg.Length);
                blobImg.Value = newImg;
                command.Parameters.Add(blobImg);
                command.ExecuteNonQuery();
                connection.Close();
                componentNameTB.Clear();
                componentCostTB.Clear();
                componentCategoryCB.Items.Clear();
                componentDescriptionRTB.Clear();
                img = null;
                newImg = null;
                NewComponent_Load(null, null);
            }
        }

        private void componentCategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            command = new MySqlCommand("SELECT categorygoods.CategoryGoodsID FROM categorygoods " +
                                       "WHERE categorygoods.TypeCategoryID = '" + componentTypeID + "' AND categorygoods.CategoryGoodsName = '" + componentCategoryCB.SelectedItem.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    componentCategoryID = MyReader.GetInt32(0);
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void manufactureCountryNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            command = new MySqlCommand("SELECT manufacturecountry.ManufactureCountryID FROM manufacturecountry " +
                                       "WHERE manufacturecountry.ManufactureCountryName = '" + manufactureCountryNameCB.SelectedItem.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    manufactureCountryID = MyReader.GetInt32(0);
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void warrantyPeriodCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            command = new MySqlCommand("SELECT warranty.WarrantyID FROM warranty " +
                                       "WHERE warranty.WarrantyPeriod = '" + warrantyPeriodCB.SelectedItem.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    warrantyID = MyReader.GetInt32(0);
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void manufacturerNameCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            command = new MySqlCommand("SELECT goodsmanufacturer.GoodsManufacturerID FROM goodsmanufacturer " +
                                       "WHERE goodsmanufacturer.GoodsManufacturerName = '" + manufacturerNameCB.SelectedItem.ToString() + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    manufacturerNameID = MyReader.GetInt32(0);
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void newManufacturerButton_Click(object sender, EventArgs e)
        {
            NewManufacturer newManufacturer = new NewManufacturer();
            newManufacturer.ShowDialog();
            connection.Open();
            manufacturerNameCB.Items.Clear();
            command = new MySqlCommand("SELECT goodsmanufacturer.GoodsManufacturerName FROM goodsmanufacturer", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                while (MyReader.Read())
                {
                    manufacturerNameCB.Items.Add(MyReader.GetString(0));
                }
                MyReader.Close();
            }
            connection.Close();
        }
    }
}
