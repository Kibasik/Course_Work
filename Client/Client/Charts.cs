using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Charts : Form
    {
        public Charts()
        {
            InitializeComponent();
        }

        private void Charts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "warehouseQuantity.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter2.Fill(this.warehouseQuantity.DataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "goodsQuantity.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter.Fill(this.goodsQuantity.DataTable);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "softwareQuantity.DataTable". При необходимости она может быть перемещена или удалена.
            this.dataTableTableAdapter1.Fill(this.softwareQuantity.DataTable);
        }
    }
}
