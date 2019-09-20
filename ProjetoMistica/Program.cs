using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoMistica
{
    class Program
    {
        static void Main(string[] args)
        {
            Veiculo[] v = new Veiculo[2];

            int[] numeros = new int[10];
            v[0] = new Automovel("Ferrari");
            v[1] = new Automovel("Tucano");

            System.Console.WriteLine(v[0].Tipo);
            v[0].Mover();
            System.Console.WriteLine(v[1].Tipo);
            v[1].Mover();

            Console.ReadKey();
        }
    }
}
