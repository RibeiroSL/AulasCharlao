using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca___Ex2
{
    class Estagio : Aluno
    {
        string vaga;
        string empresa;
        int cargahoraria;

        public void setVaga(String v)
        {
            vaga = v;
        }
        public void setEmpresa(string e)
        {
            empresa = e;
        }
        public void setCargaHora(int ch)
        {
            cargahoraria = ch;
        }

        public string getVaga()
        {
            return vaga;
        }
        public string getEmpresa()
        {
            return empresa;
        }
        public int getCarga()
        {
            return cargahoraria;
        }
    }
}
