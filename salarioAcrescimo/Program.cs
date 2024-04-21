float salAtual = 0, salNovo = 0, acrescimo = 0;

Console.WriteLine("Digite o salário atual: R$ ");
salAtual = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o salário com acréscimo: R$ ");
salNovo = float.Parse(Console.ReadLine());

if (salNovo <= salAtual)
{
    Console.WriteLine("O valor do salário com acréscimo deve ser maior que o salário atual");
}
else
{
    acrescimo = ((salNovo - salAtual) / salAtual * 100);
    Console.WriteLine("O acréscimo salarial foi de: " + acrescimo + "%");
}
