using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT1_Slide
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Timer1_Tick(object sender, EventArgs e)
        {
            #region tự động chuyển ảnh
            if (pictureBox1.Visible == true && pictureBox1_4.Visible == true && pictureBox2_5.Visible == true && pictureBox3_1.Visible == true && pictureBox4_2.Visible == true && pictureBox5_3.Visible == true)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox1_4.Visible = false;
                pictureBox1_5.Visible = true;
                pictureBox2_5.Visible = false;
                pictureBox2_1.Visible = true;
                pictureBox3_1.Visible = false;
                pictureBox3_2.Visible = true;
                pictureBox4_2.Visible = false;
                pictureBox4_3.Visible = true;
                pictureBox5_3.Visible = false;
                pictureBox5_4.Visible = true;
            }
            else if (pictureBox2.Visible == true && pictureBox1_5.Visible == true && pictureBox2_1.Visible == true && pictureBox3_2.Visible == true && pictureBox4_3.Visible == true && pictureBox5_4.Visible == true)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox1_5.Visible = false;
                pictureBox1_1.Visible = true;
                pictureBox2_1.Visible = false;
                pictureBox2_2.Visible = true;
                pictureBox3_2.Visible = false;
                pictureBox3_3.Visible = true;
                pictureBox4_3.Visible = false;
                pictureBox4_4.Visible = true;
                pictureBox5_4.Visible = false;
                pictureBox5_5.Visible = true;
            }
            else if (pictureBox3.Visible == true && pictureBox1_1.Visible == true && pictureBox2_2.Visible == true && pictureBox3_3.Visible == true && pictureBox4_4.Visible == true && pictureBox5_5.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                pictureBox1_1.Visible = false;
                pictureBox1_2.Visible = true;
                pictureBox2_2.Visible = false;
                pictureBox2_3.Visible = true;
                pictureBox3_3.Visible = false;
                pictureBox3_4.Visible = true;
                pictureBox4_4.Visible = false;
                pictureBox4_5.Visible = true;
                pictureBox5_5.Visible = false;
                pictureBox5_1.Visible = true;
            }
            else if (pictureBox4.Visible == true && pictureBox1_2.Visible == true && pictureBox2_3.Visible == true && pictureBox3_4.Visible == true && pictureBox4_5.Visible == true && pictureBox5_1.Visible == true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                pictureBox1_2.Visible = false;
                pictureBox1_3.Visible = true;
                pictureBox2_3.Visible = false;
                pictureBox2_4.Visible = true;
                pictureBox3_4.Visible = false;
                pictureBox3_5.Visible = true;
                pictureBox4_5.Visible = false;
                pictureBox4_1.Visible = true;
                pictureBox5_1.Visible = false;
                pictureBox5_2.Visible = true;
            }
            else if (pictureBox5.Visible == true && pictureBox1_3.Visible == true && pictureBox2_4.Visible == true && pictureBox3_5.Visible == true && pictureBox4_1.Visible == true && pictureBox5_2.Visible == true)
            {
                pictureBox5.Visible = false;
                pictureBox1.Visible = true;
                pictureBox1_5.Visible = false;
                pictureBox1_1.Visible = true;
                pictureBox2_5.Visible = false;
                pictureBox2_1.Visible = true;
                pictureBox3_5.Visible = false;
                pictureBox3_1.Visible = true;
                pictureBox4_5.Visible = false;
                pictureBox4_1.Visible = true;
                pictureBox5_5.Visible = false;
                pictureBox5_1.Visible = true;

            }

            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
