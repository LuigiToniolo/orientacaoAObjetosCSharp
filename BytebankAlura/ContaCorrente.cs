//Criando nossa primeira classe:

using BytebankAlura.Titular;
using System.Runtime.InteropServices;

namespace BytebankAlura
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        private string _conta;
        public string Conta
        {
            get
            {
                return _conta;
            }
            set
            {
                if(value == null)
                {
                    return;
                }
                else
                {
                    _conta = value; 
                }
            }
        }

        private int _numero_agencia; 
        public int Numero_agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if(value <= 0)
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }
        public string nome_agencia { get; set; }

        private double saldo;

        // ----- Criadno métodos, definindo o comportamento sacar para o componente:

        public bool Sacar(double valor) //--> Esse método bool retorna algum valor
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor) // --> O método void não retorna nada, só executa!
        {
            if (valor < 0)
            {
                return;
            }
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

        //public void DefinirSaldo(double valor)
        //    public void SetSaldo(double valor)
        //    {
        //        if(valor < 0)
        //        {
        //            return; // --> Irá retornar nada quando for < 0!
        //        } 
        //        else
        //        {
        //            saldo = saldo + valor;
        //        }
        //    }

        //    //public double ObterSaldo()
        //    public double GetSaldo()
        //    {
        //        return saldo;
        //    }
        //}

        public ContaCorrente(int numero_agencia, string conta)
        {
            Numero_agencia = numero_agencia;
            Conta = conta;
        }

        public double Saldo
        {
            get
            {
                return saldo;
            }
            set
            {
                if(value < 0)
                {
                    return;
                }
                saldo = value; 
            }
        }

    }
}
