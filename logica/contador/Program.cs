Console.WriteLine("**************");
Console.WriteLine("Vamos contar?");
Console.WriteLine("**************");

Console.WriteLine("");
Console.WriteLine("Até quanto você quer contar?");
int valor = int.Parse(Console.ReadLine());

for (int contador = 1; contador <= valor; contador++)
{
    Console.WriteLine(contador);
}