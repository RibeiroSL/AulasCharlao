using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heranca___Ex2
{
    public partial class Form1 : Form
    {
        Curso c = new Curso();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            c.setNome(textBox1.Text);
            c.setData(dateTimePicker1.Value);
            c.setMatricula(textBox3.Text);
            c.setCurso(textBox4.Text);
            MessageBox.Show("Cadastrado com sucesso!");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (c.verificaEstagio().Equals("s"))
            {
                c.setVaga(textBox6.Text);
                c.setEmpresa(textBox7.Text);
                c.setCargaHora(Convert.ToInt32(textBox8.Text));

                MessageBox.Show("Nome: " + c.getNome()
                + "\nCurso: " + textBox4.Text +
                "\nVaga: " + c.getVaga() +
                "\nAluno aprovado para estagio");

            }
            else
            {
                MessageBox.Show("Nome: " + c.getNome()
                + "\nCurso: " + textBox4.Text +
                "\nVaga: " + c.getVaga() +
                "\nAluno nao aprovado para estagio");
            }
        }
    }
}
