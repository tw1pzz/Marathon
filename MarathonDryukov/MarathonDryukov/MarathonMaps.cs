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
    public partial class MarathonMaps : Form
    {
        public MarathonMaps()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Btn 1");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            checkpointLabel.Text = "45 км";
            landMarkLabel.Visible = false;
            panel1.Visible = true;
            tableLayoutPanel1.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            checkpointLabel.Text = "25 км";
            landMarkLabel.Visible = false;
            panel1.Visible = true;
            tableLayoutPanel1.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            checkpointLabel.Text = "5 км";
            landMarkLabel.Visible = false;
            panel1.Visible = true;
            tableLayoutPanel1.Visible = false;
        }

        private void hideRows(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int n = arr[i];
                tableLayoutPanel1.RowStyles[n].Height = 0;
            }
        }

        private void checkpoint_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            panel1.Visible = true;
            landMarkLabel.Visible = true;
            tableLayoutPanel1.Visible = true;
            checkpointLabel.Text = "Checkpoint" + clickedLabel.Text;

            int[] arr;
            for (int i = 0; i < tableLayoutPanel1.RowStyles.Count; i++)
            {
                tableLayoutPanel1.RowStyles[i].Height = 60;
            }

            if (clickedLabel.Text == "1")
            {
                landMarkLabel.Text = "Avenida Rudge";
                arr = new int[3] { 2, 3, 4 };
                hideRows(arr);
            }
            else if (clickedLabel.Text == "2")
            {
                landMarkLabel.Text = "Theatro Municipal";
                arr = new int[0] { };
                hideRows(arr);
            }
            else if (clickedLabel.Text == "3")
            {
                landMarkLabel.Text = "Parque do Ibirapuera";
                arr = new int[2] { 3, 4 };
                hideRows(arr);
            }
            else if (clickedLabel.Text == "4")
            {
                landMarkLabel.Text = "Jardim Luzitania";
                arr = new int[1] { 4 };
                hideRows(arr);
            }
            else if (clickedLabel.Text == "5")
            {
                landMarkLabel.Text = "Iguatemi";
                arr = new int[1] { 3 };
                hideRows(arr);
            }
            else if (clickedLabel.Text == "6")
            {
                landMarkLabel.Text = "Rua Lisboa";
                arr = new int[2] { 3, 4 };
                hideRows(arr);
            }
            else if (clickedLabel.Text == "7")
            {
                landMarkLabel.Text = "Cemitério da Consolação";
                arr = new int[0] { };
                hideRows(arr);
            }
            else if (clickedLabel.Text == "8")
            {
                landMarkLabel.Text = "Cemitério da Consolação";
                arr = new int[0] { };
                hideRows(arr);
            }
        }
    }
}
