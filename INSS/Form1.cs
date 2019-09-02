using System;
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

        private void Button1_Click(object sender, EventArgs e)
        {
            this.e.setNome(Convert.ToString(textBox1.Text));
            MessageBox.Show(this.e.getNome());
        }
    }
}
