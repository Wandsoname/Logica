// See https://aka.ms/new-console-template for more information
Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine()!;

Console.WriteLine("Informe sua idade: ");
int idade = int.Parse(Console.ReadLine()!);

Console.WriteLine("Informe sua altura: ");
double altura = double.Parse(Console.ReadLine()!);

Console.WriteLine("Possui CNH? (True/False) ");
bool cnh = bool.Parse(Console.ReadLine()!);

Console.WriteLine("Meu nome é: " + nome);
Console.WriteLine("Minha idade é: " + idade);
Console.WriteLine("Minha altura é: " + altura);
Console.WriteLine(cnh);