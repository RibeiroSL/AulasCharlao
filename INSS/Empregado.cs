using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    class Empregado : Pessoa
    {
        double salario;
        string matricula;

        public string getMatricula()
        {
            return matricula;
        }
        public double getSalario()
        {
            return salario;
        }
        public void setmatricula(string m)
        {
            matricula = m;
        }
        public void setSalario(double sal)
        {
            salario = sal;
        }

        public double DescontoINSS()
        {
            double desconto = 0;
            if (getSalario() <= 3000)
            {
                desconto = getSalario() * 0.03;
            }
            else if (getSalario() >= 3001 && getSalario() <= 7000)
            {
                desconto =  getSalario() * 0.05;
            }
            else if (getSalario() > 7000)
            {
                desconto = getSalario() * 0.1;
            }
            return desconto;
        }
    }
}
