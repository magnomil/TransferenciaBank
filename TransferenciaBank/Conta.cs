using System;

namespace TransferenciaBank
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }
        private double Saldo { get; set; }
        private double Credito { get; set; }
        private string Nome { get; set; }
        public double ValordoSaque { get; private set; }

        public Conta(TipoConta tipoConta, double saldo, double credito, string nome)
        {
            this.Saldo = saldo;
            this.Credito = credito;
            this.Nome = nome;
            this.TipoConta = tipoConta;

        }
        public bool Sacar(double ValorSacar)
        {
            if(this.Saldo - ValordoSaque  < (this.Credito * -1))
            {
                Console.WriteLine("Saldo Insuficiente");
                return false;
            }
           
            this.Saldo -= ValordoSaque;
            Console.WriteLine("Saldo atual da conta de {0} é {1}", this.Nome, this.Saldo);
            return true;
        }
        public void Depositar(double ValorDeposito)
        {
            this.Saldo += ValorDeposito;
            
        }

        public void Transferir(double valorTransferir, Conta contaDestino)
        {
            if (this.Sacar(valorTransferir))
            {
                contaDestino.Depositar(valorTransferir);
            }
        }

        public override string ToString()
        {
            string retorno = "  ";
            retorno += "Tipo de Conta" + "   " + this.TipoConta + " |  ";
            retorno += "Nome"  + "   " +   this.Nome + "  |  "  ;
            retorno += "Saldo" + "  " +  this.Saldo   + "  |  ";
            retorno += "Credito" +"  " +   this.Credito   + " | ";
            return retorno;
            
        }
    }

    
}





























