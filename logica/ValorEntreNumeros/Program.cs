Console.WriteLine("////////////////////////////////////");
Console.WriteLine("Saiba a diferença entre números inteiros");
Console.WriteLine("////////////////////////////////////");
Console.WriteLine("");

Console.WriteLine("Qual o primeiro número? ");
int primeiroNumero = int.Parse(Console.ReadLine());
Console.WriteLine("");

Console.WriteLine("Qual o segundo número? ");
int segundoNumero = int.Parse(Console.ReadLine());
Console.WriteLine("");

int calculo = primeiroNumero - segundoNumero;

if (segundoNumero > primeiroNumero)
{
    calculo = segundoNumero - primeiroNumero;
}

Console.WriteLine($"A diferença entre os números apresentados é de: {calculo}!"); 