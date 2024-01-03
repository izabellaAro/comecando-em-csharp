Console.WriteLine("*********************************************************");
Console.WriteLine("Descubra se o valor é Par ou Impar e Positivo ou Negativo");
Console.WriteLine("*********************************************************");
Console.WriteLine();

Console.WriteLine("Digite um valor qualquer: ");
int valor = int.Parse(Console.ReadLine());

if (valor % 2 == 0) 
{
    Console.WriteLine("O valor informado é par");
} else
{
    Console.WriteLine("O valor informado é ímpar");
}

if (valor < 0) 
{ 
    Console.WriteLine("O valor informado é negativo");
} else if (valor > 0) 
{
    Console.WriteLine("O valor informado é positivo"); 
}else
{
    Console.WriteLine("O valor informado é neutro");
}