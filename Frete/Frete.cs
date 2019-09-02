using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frete
{
    class Frete
    {
        
        private int codigo;
        private double valornota;
        private String destino;

        public void setCode(int cod)
        {
            codigo = cod;
        }
        public void setDest(String d)
        {
            destino = d;
        }
        public void setValue(double va)
        {
            valornota = va;
        }
        public int getCode()
        {
            return codigo;
        }
        public String getDest()
        {
            return destino;
        }
        public double getValue()
        {
            return valornota;
        }
        public double freteSP(double v)
        {
            if(v < 3000)
            {
                v = (v + (0.05 * v));
            }
            else if (v >= 3000 && v <= 5000)
            {
                v = (v + (0.1 * v));
            }
            else if (v > 5000)
            {
                v = (v + (0.15 * v));
            }
            return v;
        }
        public double freteOutros(double v)
        {
            v = v + (0.2 * v);
            return v;
        }
        

    }
}
