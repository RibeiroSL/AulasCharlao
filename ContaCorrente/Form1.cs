using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClasseConta
{
    public partial class Form1 : Form

    {
        ContaCorrente x = new ContaCorrente(0);
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            //MessageBox.Show(" "); - janela de mensagem.


        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                radioButton2.Checked = false;

            }
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                radioButton1.Checked = false;

            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            x.setConta(Convert.ToInt32(textBox1.Text));
            x.setNome(textBox2.Text);
            x.setSaldo(Convert.ToDouble(textBox3.Text));
            MessageBox.Show("Cadastro de " + x.getNome() + " realizado com sucesso");

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked){
                x.credita(Convert.ToDouble(textBox4.Text));
                MessageBox.Show("Crédito de " + textBox4.Text + " Reais realizado com sucesso");
            }
            else if (radioButton2.Checked)
            {
                x.debita(Convert.ToDouble(textBox4.Text));
                MessageBox.Show("Débito de " + textBox4.Text + " Reais realizado com sucesso");

            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saldo na conta de " + x.getNome() + " é " + Convert.ToString(x.getSaldo()) + " Reais ");
        }
    }
}
