Console.WriteLine("Qual o valor do emprestimo?");
float valorInicial = float.Parse(Console.ReadLine());

Console.WriteLine("Em quantas parcelas deseja pagar?");
int qntParcelas = int.Parse(Console.ReadLine());

float juros = valorInicial * 0.2f;
float valorFinal = valorInicial + juros;
float valorParcelas = valorFinal / qntParcelas;

Console.WriteLine($"Então terá {qntParcelas} parcelas de R${valorParcelas}");
