using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int i = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //i++，实现第i张；
            i++;
            string filePath = Application.StartupPath + "\\tp\\" + i.ToString() + ".jpg";
            this.pictureBox1.Image = Image.FromFile(filePath);
            //当i=5时，i变为0，然后重新开始；
            if (i == 5)
            {
                i = 0;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
