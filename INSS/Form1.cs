using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INSS
{
    public partial class Form1 : Form
    {
        Empregado e = new Empregado();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, System.EventArgs e)
        {
            this.e.setNome(textBox1.Text);
            this.e.setSalario(System.Convert.ToDouble(textBox2.Text));
            this.e.setSexo(textBox3.Text);
            this.e.setIdade(System.Convert.ToInt32(textBox4.Text));
            this.e.setMatricula(textBox5.Text);
            MessageBox.Show("Desconto INSS: " + System.Convert.ToString(System.Math.Round(this.e.DescontoINSS(), 2)) + 
                "\nNome: " + this.e.getNome() + "\nSalario: " + this.e.getSalario() + "\nSexo: " + this.e.getSexo() + 
                "\nIdade: " + this.e.getIdade() +  "\nMatricula: " + this.e.getMatricula());

        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
