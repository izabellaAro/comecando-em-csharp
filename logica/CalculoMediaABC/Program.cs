Console.WriteLine("----------------------------");
Console.WriteLine("Saiba sua media - Escola ABC");
Console.WriteLine("----------------------------");

Console.WriteLine("Qual foi sua primeira nota?");
float PNota = float.Parse(Console.ReadLine());

Console.WriteLine("Qual foi sua segunda nota?");
float SNota = float.Parse(Console.ReadLine());

float NFinal = (PNota + SNota) / 2;

Console.WriteLine($"Media: {NFinal}");

if (NFinal >= 9 && NFinal <= 10)
{
    Console.WriteLine("Seu aproveitamento foi: A");
}
else if (NFinal >= 8 && NFinal < 9)
{
    Console.WriteLine("Seu aproveitamento foi: B");
}
else if (NFinal >= 7 && NFinal <= 8)
{
    Console.WriteLine("Seu aproveitamento foi: C");
}
else if (NFinal >= 6 && NFinal <= 7)
{
    Console.WriteLine("Seu aproveitamento foi: D");
}
else if (NFinal >= 5 && NFinal <= 6)
{
    Console.WriteLine("Seu aproveitamento foi: E");
}
else if (NFinal <= 5)
{
    Console.WriteLine("Seu aproveitamento foi: F");
}