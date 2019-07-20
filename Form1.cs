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
    public partial class Form1 : Form
    {
        public object chartCellLine { get; private set; }
        public string strPicPath { get; private set; }
        public object Value { get; private set; }

        public Form1()
        {
            InitializeComponent();
            skinEngine1.SkinFile = Application.StartupPath + "bin\\Debug\\DiamondBlue.ssk";

        }

        private void Choose_picture_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.InitialDirectory = "d:";
            OFD.Filter = "image(*.jpg)|*.jpg|image(*.png)|*.png";
            OFD.RestoreDirectory = true;
            OFD.FilterIndex = 1;
            DialogResult dresult = OFD.ShowDialog();
            if (dresult == DialogResult.OK)
            {
                tb_path.Text = OFD.FileName;
                pictureBox1.Image = Image.FromFile(tb_path.Text);
            }
            else
            {
                MessageBox.Show("未选择图片");
            }
            pictureBox1.Image = Image.FromFile(tb_path.Text);

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 f2 = new Form3();
            f2.Show();

            

        }
        private void Delete_picture_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void AxWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ShowDialog();
            axWindowsMediaPlayer1.URL = openFile.FileName;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Point screenPoint = axWindowsMediaPlayer1.PointToScreen(new Point());
            Rectangle rect = new Rectangle(screenPoint, Size);
            using (Image img = new Bitmap(rect.Width, rect.Height))
            {
                Graphics g = Graphics.FromImage(img);
                g.CopyFromScreen(rect.X - 150, rect.Y - 150, 150, 150, rect.Size);
                img.Save(Application.StartupPath + ".png");
                MessageBox.Show("截图成功");


            }

            //截图窗体上任意位置的控件
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(Value.ToString());
        }

        private void MenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 说明文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            说明文档 f2 = new 说明文档();
            f2.Show();
        }

        private void 文件ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 帮组ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.fullScreen = true;
        }
    }
}

