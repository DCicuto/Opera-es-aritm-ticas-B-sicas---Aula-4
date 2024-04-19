int n1, n2, operacao;
Console.WriteLine("digite n1");
n1 = Int32.Parse(Console.ReadLine());
Console.WriteLine("digite n2");
n2 = Int32.Parse(Console.ReadLine());
//Console.WriteLine("digite n2"); 
Console.WriteLine("Digite qual operação degeja realizar: \n 1 - divisão \n 2 - subtração \n 3 - adição \n 4 - multiplicação");
operacao = Int32.Parse(Console.ReadLine());

if (operacao == 1)
{
    int div = n1 / n2;
    Console.WriteLine($" O resultado da divisão é: {div}");
}

else if (operacao == 2)
{
    int sub = n1 - n2;
    Console.WriteLine($" O resultado da subtração é: {sub}");
}

else if (operacao == 3)
{
    int soma = n1 + n2;
    Console.WriteLine($" O resultado da adiçao é: {soma}");
}
else if (operacao == 4)
{
    int sub = n1 * n2;
    Console.WriteLine($" O resultado da Multiplicação é: {sub}");
}


//Console.WriteLine(($" soma = {soma} /sub = {sub} /div = {div} mult = {mult}"));
Console.ReadKey();
  