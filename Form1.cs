using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Gallery_in_c_sharp
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void goNext(object sender, EventArgs e)
        {
            i++;
            if(i > 5)
            {
                i = 1;
            }

            ChangeImage(i);

        }

        private void goBack(object sender, EventArgs e)
        {
            i--;
            if( i < 1)
            {
                i = 5;
            }

            ChangeImage(i);
        }

        private void ChangeImage(int num)
        {
            switch (num)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._1;
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources._3;
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources._4;
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources._5;
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources._6;
                    break;
            }
        }
    }
}
