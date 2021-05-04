using DIO.Bank.Enum;
using System;

namespace DIO.Bank.Classes
{
    public class Conta
    {
        public Conta(TipoConta tipoConta, string nome, double saldo, double credito)
        {
            this._TipoConta = tipoConta;
            this._Nome = nome;
            this._Saldo = saldo;
            this._Credito = credito;
        }

        private TipoConta _TipoConta;

        private string _Nome { get; set; }

        private double _Saldo { get; set; }

        private double _Credito { get; set; }

        public bool Sacar (double valorSaque)
        {
            if(this._Saldo - valorSaque < (this._Credito * .1))
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }

            this._Saldo -= valorSaque;

            Console.WriteLine("Saldo atual da conta {0} é de {1}", this._Nome, this._Saldo);

            return true;
        }

        public void Depositar(double valorDeposito)
        {
            this._Saldo += valorDeposito;

            Console.WriteLine("Saldo atual da conta {0} é de {1}", this._Nome, this._Saldo);
        }

        public void Transferir(double valorTransferir, Conta conta)
        {
            if (this.Sacar(valorTransferir))
            {
                conta.Depositar(valorTransferir);
            }
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Tipo Conta: " + this._TipoConta + " | ";
            retorno += "Nome: " + this._Nome + " | ";
            retorno += "Saldo: " + this._Saldo + " | ";
            retorno += "Crédito: " + this._Credito;

            return retorno;
        }
    }
}
