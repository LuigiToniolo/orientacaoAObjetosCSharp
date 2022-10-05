using BytebankAlura;
using BytebankAlura.Titular;

Console.WriteLine("Boas vindas a seu banco");

//ContaCorrente conta1 = new ContaCorrente(); // --> "Conta1" seria o objeto da classe ContaCorrente.
//conta1.titular = "Luigi Toniolo";
//conta1.conta = "10123-X";
//conta1.numero_agencia = 23;
//conta1.nome_agencia = "Agencia central";
//conta1.saldo = 100;

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = "Flávia Remédio";
//conta2.conta = "10299-X";
//conta2.numero_agencia = 22;
//conta2.nome_agencia = "Agencia central";
//conta2.saldo = 100;

//Console.WriteLine("Saldo da Flávia pré-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do Luigi pré-transferência: " + conta1.saldo);
//conta1.Transferir(50, conta2); // --> Com isso, iremos transferir 50 reais para a flávia (conta2)
//bool transferencia = conta1.Transferir(50, conta2);
//Console.WriteLine("Transferência realizada com sucesso");
//Console.WriteLine("Saldo da Flávia pós-transferência: " + conta2.saldo);
//Console.WriteLine("Saldo do Luigi pós-transferência: " + conta1.saldo);

//Console.WriteLine("Saldo da amanda pré-saque: " + conta2.saldo);

//bool saque = conta2.Sacar(50);
//Console.WriteLine("Saque realizado?" + saque);

//Console.WriteLine("Saldo da amanda pós-saque: " + conta2.saldo);

//conta2.Depositar(230);
//Console.WriteLine("Saldo da Flávia pós-saque: " + conta2.saldo);

//conta1 = conta2; // --> Dessa forma vai dar "true" pois esses dois objetos apontam pro mesmo endereço de memória.

///Console.WriteLine(conta1 == conta2); // --> Essa comparação vai dar falsa, mesmo que possuem os mesmos valores, pois estão em endereços de memórias diferentes.

//Console.WriteLine("Titular: " + conta1.titular);
//Console.WriteLine("Conta: " + conta1.conta);
//Console.WriteLine("Número da Agência: " + conta1.numero_agencia);
//Console.WriteLine("Nome da Agência: " + conta1.nome_agencia);
//Console.WriteLine($"Saldo R$ {String.Format("{0:0.00}", conta1.saldo)}");


//double saldo = 100;
//double saldo2 = conta1.saldo;
//conta1.saldo = 200;

//Console.WriteLine(conta1.saldo == saldo2);
//Console.WriteLine(saldo == saldo2);

//Cliente cliente = new Cliente();
//cliente.nome = "Luigi Toniolo";
//cliente.Cpf = "38012144444";
//cliente.profissao = "Programador front-end";

//ContaCorrente conta3 = new ContaCorrente();

//conta3.titular = new Cliente();

//conta3.titular.nome = "Luigi Toniolo";
//conta3.titular.Cpf = "38012144444";
//conta3.titular.profissao = "Programador front-end";

//conta3.conta = "213445-X";
//conta3.numero_agencia = 35;
//conta3.nome_agencia = "Agencia central";

//Console.WriteLine(conta3.titular.nome);

//if(conta3.titular == null)
//{
//    Console.WriteLine("O campo titular está nulo");
//} else
//{
//    Console.WriteLine("O campo é: " + conta3.titular.nome + "E o CPF é: " + conta3.titular.Cpf);
//}

//Cliente sarah = new Cliente();
//sarah.Nome = "Sarah Silva";

//ContaCorrente conta4 = new ContaCorrente(235, "123456-X");
//conta4.Saldo = 150;
//conta4.Titular = sarah;

//Console.WriteLine($"O saldo é: R$ {String.Format("{0:0.00}", conta4.Saldo)}");
//Console.WriteLine(conta4.Titular.Nome);
//Console.WriteLine(conta4.Numero_agencia);
//Console.WriteLine(conta4.Conta);

//ContaCorrente conta5 = new ContaCorrente(235, "123456-X");
//conta5.TotalDeContasCriadas = 1;

//ContaCorrente conta6 = new ContaCorrente(335, "133434-X");
//conta6.TotalDeContasCriadas += 1;

//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//Console.WriteLine(conta5.TotalDeContasCriadas);
//Console.WriteLine(conta6.TotalDeContasCriadas);


Cliente sarah = new Cliente();
sarah.Nome = "Sarah Silva";
sarah.Profissao = "Professora";
sarah.Cpf = "11111111-12";

Cliente ester = new Cliente();
ester.Nome = "Ester Almeida";
ester.Profissao = "Advogada";
ester.Cpf = "868524125-32";

Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);

ContaCorrente contaAndre = new ContaCorrente(159, "152869-x");
contaAndre.Titular = new Cliente();
contaAndre.Titular.Nome = " André Pereira";
contaAndre.Titular.Profissao = "Auxiliar Administrativo";
contaAndre.Saldo = 100;

Console.WriteLine("Total de clientes: " + Cliente.TotalClientesCadastrados);

Console.ReadKey(); // --> Vai exibir as informações das variáveis e o console fica esperando a gente digitar alguma tecla para sair!
