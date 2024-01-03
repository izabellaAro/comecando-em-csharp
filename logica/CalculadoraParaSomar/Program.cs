Console.WriteLine("////////////////////////////////");
Console.WriteLine("Some e compare valores inteiros");
Console.WriteLine("///////////////////////////////");
Console.WriteLine();

Console.WriteLine("Digite o valor de A: ");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de B: ");
int numB = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o valor de C: ");
int numC = int.Parse(Console.ReadLine());

int somaAB = numA + numB;

if (somaAB < numC) 
{
    Console.WriteLine($"A soma entre o valor A e B é de: {somaAB} sendo menor que o valor C");
} else
{
    Console.WriteLine($"A soma entre o valor A e B é de: {somaAB} sendo maior que o valor C");
}