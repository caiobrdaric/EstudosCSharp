using CSharp.Treinamento.ConsoleAppDemo.Model;

var trabalhador = new Trabalhador();

Console.WriteLine("Digite o nome do trabalhador:");
trabalhador.nome = Console.ReadLine();

Console.WriteLine("Digite o salário do trabalhador");
trabalhador.salario = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Digite o valor do bonus");
double bonus = Convert.ToDouble(Console.ReadLine());
trabalhador.AcrescentaBonus(bonus);

Console.WriteLine($"O nome digitado foi:{trabalhador.nome}. E o salário digitado foi: {trabalhador.salario}");

