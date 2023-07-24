using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Análisis_y_visualización_de_datos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            int b = Convert.ToInt32(textBox2.Text);

            int n= dataGridView1.Rows.Add();
            dataGridView1.Rows[n].Cells[0].Value = a;
            dataGridView1.Rows[n].Cells[1].Value = b;

            textBox1.Clear();
            textBox2.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].XValueMember = "Categoria";
            chart1.Series[0].XValueMember = "Valor";
            chart1.DataBind();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}