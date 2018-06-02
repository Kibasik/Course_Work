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
    public partial class SupplyStructure : Form
    {
        MySqlConnection connection = new MySqlConnection("Data Source = localhost; User = root; Initial Catalog = course; SSL Mode = none; CharSet = utf8");
        MySqlCommand command = new MySqlCommand();
        public int supplyID;

        public SupplyStructure()
        {
            InitializeComponent();
        }

        private void SupplyStructure_Load(object sender, EventArgs e)
        {
            connection.Open();
            supplyStructureDGV.Rows.Clear();
            command = new MySqlCommand("SELECT typecategory.TypeCategoryName, categorygoods.CategoryGoodsName, goodsmanufacturer.GoodsManufacturerName, " +
                                       "goodscatalog.GoodsName, goodscatalog.GoodsCost, supplystructure.GoodsAmount, supplystructure.GoodsID FROM goodscatalog INNER JOIN goodsmanufacturer " +
                                       "ON goodscatalog.GoodsManufacturerID = goodsmanufacturer.GoodsManufacturerID INNER JOIN categorygoods " +
                                       "ON goodscatalog.CategoryGoodsID = categorygoods.CategoryGoodsID INNER JOIN typecategory " +
                                       "ON categorygoods.TypeCategoryID = typecategory.TypeCategoryID INNER JOIN supplystructure " +
                                       "ON supplystructure.GoodsID = goodscatalog.GoodsID WHERE supplystructure.SupplyID = '" + supplyID + "'", connection);
            using (MySqlDataReader MyReader = command.ExecuteReader())
            {
                int j = 0;
                while (MyReader.Read())
                {
                    supplyStructureDGV.Rows.Add();
                    supplyStructureDGV[0, j].Value = MyReader.GetString(0);
                    supplyStructureDGV[1, j].Value = MyReader.GetString(1);
                    supplyStructureDGV[2, j].Value = MyReader.GetString(2);
                    supplyStructureDGV[3, j].Value = MyReader.GetString(3);
                    supplyStructureDGV[4, j].Value = MyReader.GetDouble(4);
                    supplyStructureDGV[5, j].Value = MyReader.GetInt32(5);
                    supplyStructureDGV[6, j].Value = MyReader.GetInt32(6);
                    j++;
                }
                MyReader.Close();
            }
            connection.Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            if (supplyStructureDGV.SelectedRows.Count == 1 || supplyStructureDGV.GetCellCount(DataGridViewElementStates.Selected) == 1)
            {
                command = new MySqlCommand("DELETE FROM supplystructure WHERE supplystructure.SupplyID = '" + supplyID + "' " +
                                           "AND supplystructure.GoodsID = '" + Convert.ToInt32(supplyStructureDGV.CurrentRow.Cells[6].Value) + "'", connection);
                command.ExecuteNonQuery();
                supplyStructureDGV.Rows.RemoveAt(supplyStructureDGV.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Выберите комплектующее!");
            }
            supplyStructureDGV.ClearSelection();
            connection.Close();
        }
    }
}
