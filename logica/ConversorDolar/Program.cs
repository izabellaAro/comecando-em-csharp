Console.WriteLine("----------------------------");
Console.WriteLine("Converta reais para dolares");
Console.WriteLine("----------------------------");

Console.WriteLine("Quantos reais voce tem? ");
float reais = float.Parse(Console.ReadLine());

float dolar = reais * 4.79f;

Console.WriteLine($"Então tera U${dolar}");