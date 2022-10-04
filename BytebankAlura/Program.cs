﻿using BytebankAlura;


Console.WriteLine("Boas vindas a seu banco");

ContaCorrente conta1 = new ContaCorrente(); // --> "Conta1" seria o objeto da classe ContaCorrente.
conta1.titular = "Luigi Toniolo";
conta1.conta = "10123-X";
conta1.numero_agencia = 23;
conta1.nome_agencia = "Agencia central";
conta1.saldo = 95.50;

ContaCorrente conta2 = new ContaCorrente();

conta2.titular = "Luigi Toniolo";
conta2.conta = "10123-X";
conta2.numero_agencia = 23;
conta2.nome_agencia = "Agencia central";
conta2.saldo = 95.50;

conta1 = conta2;

Console.WriteLine(conta1 == conta2); // --> Essa comparação vai dar falsa, mesmo que possuem os mesmos valores, pois estão em endereços de memórias diferentes.

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


Console.ReadKey(); // --> Vai exibir as informações das variáveis e o console fica esperando a gente digitar alguma tecla para sair!