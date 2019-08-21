    public class ContaCorrente
    {
        //atributos da classe
        private int nconta;
        private System.String nome;
        private double saldo;


        //metodos da classe
        public ContaCorrente(double saldoinicio) { }
        public int getConta()
        {
            return this.nconta;
        }
        public System.String getNome()
        {
            return nome;
        }
        public double getSaldo()
        {
            return saldo;
        }
        public void setConta(int c)
        {
            this.nconta = c;
        }
        public void setNome(System.String no)
        {
            this.nome = no;
        }
        public void setSaldo(double s)
        {
            this.saldo = s;
        }
        public void credita(double valor)
        {
            this.setSaldo(this.getSaldo() + valor);
        }
        public void debita(double valor)
        {
            this.setSaldo(this.getSaldo() - valor);
        }

    }


