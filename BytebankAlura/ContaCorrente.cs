//Criando nossa primeira classe:

using System.Runtime.InteropServices;

namespace BytebankAlura
{
    public class ContaCorrente
    {
        public string titular; //--> Podemos chamar isso de campo com variável
        public string conta;
        public int numero_agencia;
        public string nome_agencia;
        public double saldo;

        // ----- Criadno métodos, definindo o comportamento sacar para o componente:

        public bool Sacar(double valor)
        {
            if(saldo < valor)
            {
                return false;
            }
            if(valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            saldo = saldo + valor;
        }
    }
}
