using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_Solis_CobrarBecaGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox1.Text) >= 19 && comboBox1.Text == "100,001-200,000" || comboBox1.Text == "Más de 200,000")
            {
                MessageBox.Show("FELICIDADES TENES LA BECA!!");
            }
            else if (int.Parse(textBox1.Text) <=18 && comboBox1.Text == "0-50,000" || comboBox1.Text == "50,001-100,000")
            {
                MessageBox.Show("NO HAY BECA!!");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
