// See https://aka.ms/new-console-template for more information
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($@"
----------------------
| Calcule sua idade  |
| com o nosso sistema|
----------------------
");
Console.ResetColor();

Console.WriteLine($"Digite o nome: ");
string nome = Console.ReadLine();

Console.WriteLine($"Digite sua idade : ");
int idade = int.Parse(Console.ReadLine());


int mes = (idade*12);

int dias = (idade*365);

int horas = (idade*8766);

int minutos = (idade*525960);

Console.ForegroundColor= ConsoleColor.Magenta;
Console.WriteLine($"O {nome} tem {idade} anos, ou {mes} meses, ou {dias} dias, ou {horas} horas ou {minutos} minutos de idade. ");
Console.ResetColor();