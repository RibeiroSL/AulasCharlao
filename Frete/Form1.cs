using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frete
{
    public partial class Form1 : Form
    {
        Frete frete = new Frete();
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            frete.setCode(System.Convert.ToInt32(textBox3.Text));
            frete.setDest(textBox2.Text);
            if (radioButton1.Checked)
            {
                frete.setValue(System.Convert.ToInt32(frete.freteSP(System.Convert.ToInt32(textBox1.Text))));
            }
            else
            {
                frete.setValue(frete.freteOutros(System.Convert.ToDouble(textBox1.Text)));
            }
            MessageBox.Show("Codigo: " + frete.getCode() + "\nValor total: " + frete.getValue() + "\nDestino: " + frete.getDest());
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
        }
    }
}
