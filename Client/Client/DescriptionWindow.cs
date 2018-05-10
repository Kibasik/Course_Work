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
    public partial class DescriptionWindow : Form
    {
        public string description { get; set; }
        public string goodsName { get; set; }
        public string manufacturer { get; set; }

        public DescriptionWindow()
        {
            InitializeComponent();
        }

        private void DescriptionWindow_Load(object sender, EventArgs e)
        {
            goodsNameLabel.Text = manufacturer + " " + goodsName;
            descriptionRTB.Text = description;
        }
    }
}
