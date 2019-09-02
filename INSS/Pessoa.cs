using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSS
{
    class Pessoa
    {
        private string nome;
        private string sexo;
        private int idade;

        public string getNome()
        {
            return nome;
        }

        public string getSexo()
        {
            return sexo;
        }
        public int getIdade()
        {
            return idade;
        }

        public void setNome(string n)
        {
            nome = n;
        }
        public void setSexo(string s)
        {
            sexo = s;
        }
        public void setIdade(int id)
        {
            idade = id;
        }

    }
}
