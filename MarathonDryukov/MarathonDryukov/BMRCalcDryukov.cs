using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarathonDryukov
{
    public partial class BMRCalcDryukov : Form
    {
        private int gender = 0;

        public BMRCalcDryukov()
        {
            InitializeComponent();
        }

        private void BMRCalcDryukov_Load(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            gender = 0;
            pictureBox1.BackColor = Color.LightGray;
            pictureBox2.BackColor = Color.White;
            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            label10.Text = null;
            label18.Text = "0";
            label19.Text = "0";
            label20.Text = "0";
            label21.Text = "0";
            label22.Text = "0";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gender = 0; // мужчина
            pictureBox1.BackColor = Color.LightGray;
            pictureBox2.BackColor = Color.White;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            gender = 1; // женщина
            pictureBox2.BackColor = Color.LightGray;
            pictureBox1.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float h = Convert.ToInt32(textBox1.Text);
            float m = Convert.ToInt32(textBox2.Text);
            float y = Convert.ToInt32(textBox3.Text);

            float bmr = 0;
            if (gender == 0)
            {
                bmr = (float)(66 + (13.7 * m) + (5 * h) - (6.8 * y));
            }
            else if (gender == 1)
            {
                bmr = (float)(655 + (9.6 * m) + (1.8 * h) - (4.7 * y));
            }

            label10.Text = Math.Round(bmr, 2).ToString();

            label18.Text = Math.Round((bmr * 1.2), 2).ToString();
            label19.Text = Math.Round((bmr * 1.375), 2).ToString();
            label20.Text = Math.Round((bmr * 1.55), 2).ToString();
            label21.Text = Math.Round((bmr * 1.725), 2).ToString();
            label22.Text = Math.Round((bmr * 1.9), 2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            new BRMCalcInfo().Show();
        }
    }
}
