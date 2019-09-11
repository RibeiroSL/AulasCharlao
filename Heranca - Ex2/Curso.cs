using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca___Ex2
{
    class Curso : Estagio
    {
        private string curso;
        private string aprovado;

        public void setCurso(string x)
        {
            curso = x;
        }
        public void cadastraVaga()
        {

        }
        public void cadastraAluno()
        {
        
        }
        public string verificaEstagio()
        {
            string estagio;
            //if (DateTime.Now.Subtract(getData()) >= TimeSpan.FromDays(6574)) //6574 - anos bissextos.
            if (getData().AddYears(18) <= DateTime.Now)
            {
                estagio = "s";
            }
            else estagio = "n";
            return estagio;
        }
    }
}
