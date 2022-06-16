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
    public partial class BMICalcDryukov : Form
    {
        public BMICalcDryukov()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox1.Image;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox3.Image = pictureBox2.Image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float h = Convert.ToInt32(textBox1.Text);
            float m = Convert.ToInt32(textBox2.Text);
            h = Convert.ToInt32(h / 100);
            float bmi = m / (h * h);
            label6.Text = Convert.ToString(bmi);

            if(bmi <= 18.5) { label7.Text = "Недостаточный вес"; }
            else if (bmi > 18.5 && bmi <= 24.9) { label7.Text = "Здоровый вес"; }
            else if (bmi > 24.9 && bmi <= 29.9) { label7.Text = "Избыточный вес"; }
            else { label7.Text = "Ожирение"; }

            if (bmi < 50) { trackBar1.Value = Convert.ToInt32(bmi); }
            else { trackBar1.Value = 50; }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
