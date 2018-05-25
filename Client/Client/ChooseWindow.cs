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
    public partial class ChooseWindow : Form
    {
        public ChooseWindow()
        {
            InitializeComponent();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            if (managerRB.Checked == true)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.ShowDialog();
            }
            if (storekeeperRB.Checked == true)
            {
                Warehouse warehouse = new Warehouse();
                warehouse.ShowDialog();
            }
        }
    }
}
