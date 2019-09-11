using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca___Ex2
{
    class Aluno
    {
        string nome;
        System.DateTime datanasc;
        string matricula;

        public string getNome()
        {
            return nome;
        }
        public System.DateTime getData()
        {
            return datanasc;
        }
        public string getMatricula()
        {
            return matricula;
        }
        public void setNome(string n)
        {
            nome = n;
        }
        public void setData(System.DateTime dn)
        {
            datanasc = dn;
        }
        public void setMatricula(string ma)
        {
            matricula = ma;
        }
    }
}
