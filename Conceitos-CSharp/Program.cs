//tipos reaiscw 
using System.Threading.Channels;

byte b = 10;
int idade = 25;
long populacao = 8000000000000;

//tipos reais
float peso = 60.2f;
double altura = 1.78;
decimal salario = 2500.99m;


//lógicos e texto
bool aprovado = true;
char inicial = 'J';
string nome = "Júlia";
string profissao;

//inferência com var
var cidade = "São Paulo";
var cidadeT = 'S';
var nota = 8.5;
var letra = 'A';
var boleana = true;

double media;

double n1;
double n2;
//Console.WriteLine("Nome: "+ nome);
//Console.WriteLine($"Nome: {nome}");
//Console.WriteLine($"Idade: {idade}");
//Console.WriteLine("Digite sua profissão: ");
//profissao = Console.ReadLine();
//Console.WriteLine(profissao);


Console.WriteLine("Digite uma nota: ");
n1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite outra nota: ");
n2 = Convert.ToDouble(Console.ReadLine());
media = (n1 + n2)/2;
Console.WriteLine("A média é: "+media);








