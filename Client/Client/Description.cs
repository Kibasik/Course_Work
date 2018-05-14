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

namespace Client
{
    public partial class Description : Form
    {
        public string description { get; set; }
        public string goodsName { get; set; }
        public string manufacturer { get; set; }
        public string goodsID { get; set; }
        public byte[] image { get; set; }

        public Description()
        {
            InitializeComponent();
        }

        private void DescriptionWindow_Load(object sender, EventArgs e)
        {
            goodsNameLabel.Text = manufacturer + " " + goodsName;
            descriptionRTB.Text = description;
            var memoryStream = new MemoryStream(image);
            goodsImagePB.Image = Image.FromStream(memoryStream);
        }
    }
}
