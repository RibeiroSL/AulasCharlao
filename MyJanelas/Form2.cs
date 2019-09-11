using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyJanelas
{
    public partial class Form2 : Form
    {
        int valor = 0;
        double valor2 = 0;
        public Form2(int x, double y)
        {
            InitializeComponent();
            valor = x;
            valor2 = y;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(valor.ToString() + " " + valor2.ToString());
            Close();
        }
    }
}
