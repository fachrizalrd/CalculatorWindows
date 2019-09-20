using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsFormsApp
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private int Penambahan(int a, int b)
        {
            return a + b;
        }

        private int Pengurangan(int a, int b)
        {
            return a - b;
        }

        private int Perkalian(int a, int b)
        {
            return a * b;
        }

        private int Pembagian(int a, int b)
        {
            return a / b;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            CBOperasi.Items.Add(string.Format("Penambahan"));
            CBOperasi.Items.Add(string.Format("Pengurangan"));
            CBOperasi.Items.Add(string.Format("Perkalian"));
            CBOperasi.Items.Add(string.Format("Pembagian"));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var a = int.Parse(txtNilaiA.Text);
            var b = Convert.ToInt32(txtNilaiB.Text);

           


        }

        private void txthasil_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
