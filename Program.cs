int x;
int y;
double divisao;

Console.WriteLine("Digite o valor de X:");
x = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Digite o valor de y");
y = Convert.ToInt32(Console.ReadLine());

divisao = (double) x / y;
int soma = x + y;
int subtracao = x - y;
int multiplicacao = x * y;

Console.WriteLine($"O valor da divisão entre {x} e {y} é igual a: {divisao}");

Console.WriteLine("O valor da soma entre {0} e {1} é igual a: {2}", x, y, soma);
Console.WriteLine("O valor da subtracao entre {0} e {1} é igual a: {2}", x, y, subtracao);

Console.WriteLine("O valor da multiplicacao é igual a:" + multiplicacao + " parabens");