using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MaterialSkin;
using MaterialSkin.Controls;

namespace BlenderConsoleRender
{
    public partial class Form2 : MaterialForm
    {

        MaterialSkinManager materialSkinManager;
        public Form2()
        {
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue600, Primary.Red100, Accent.Yellow700, TextShade.WHITE);

            //PictureBox pb = new PictureBox();
            //pictureBox1.Location = new Point(0, 0);
            //pictureBox1.Size = new Size(50, 50);
            //pictureBox1.Image = Image.FromFile(@"/IMG\V&DAppsBlack.png");
            //pictureBox1.Visible = true;
            //this.Controls.Add(pb);
            materialLabel1.Font = new Font("Verdana", 16, FontStyle.Bold);

        }
        private void Form2_Load()
        {
            materialLabel1.Font = new Font("Verdana", 16, FontStyle.Bold);
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
