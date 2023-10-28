// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//if (numero <= 0)
//{
//    Console.WriteLine("Número inválido");
//}
//else
//{
//    Console.WriteLine("Número Inválido");
//}

// Console.WriteLine("Deseja continuar?");
// string opcao = Console.ReadLine()!.ToUpper();

// bool continuar opcao == "S";

//while(opcao == "S")

//{
  // Console.WriteLine("Deseja encerrar? Digite N para sair.");
   //opcao = Console.ReadLine()!.ToUpper();
//}


// SequênciaPares

//int numero;
//int numeroPar = 0;
//int numeroInt = 0;

//do
//{
  //Console.Write("Digite um número inteiro e positivo: ");
  //Int32.TryParse(Console.ReadLine(), out numero);
  ///numero = Convert.ToInt32(Console.ReadLine());
//}
//while (numero <= 0);

//while (numeroPar <= numero)
//{
  //  Console.Write($"{numeroPar} ");
   // numeroPar += 2;
//}

//SequenciaLimites

Console.Clear();

int numeroUm;
int numeroDois;
int aux;

do
{

    Console.Write("Início: ");
    Int32.TryParse(Console.ReadLine(), out numeroUm);

    Console.Write("Fim: ");
    Int32.TryParse(Console.ReadLine(), out numeroDois);
    
}
while(numeroUm > numeroDois);

aux = numeroUm;
{
    Console.Write($"{aux}");
    aux++;
}

Console.WriteLine();
Console.WriteLine($"Esta foi a sequência de números de {numeroUm} a {numeroDois}");
Console.WriteLine();

while(numeroUm <= numeroDois)
{
    Console.Write($"{numeroUm}");
    //numeroUm = numeroDois +1;
    numeroUm++;
}

Console.WriteLine(numeroUm);
Console.WriteLine();



