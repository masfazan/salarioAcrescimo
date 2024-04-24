float salAtual = 0, salNovo = 0, acrescimo = 0;

Console.WriteLine("Digite o salário atual: R$ ");
salAtual = float.Parse(Console.ReadLine());

Console.WriteLine("Digite o salário com acréscimo: R$ ");
salNovo = float.Parse(Console.ReadLine());

switch (acrescimo)
{
    case (salNovo <= salAtual):
    Console.WriteLine("O valor do salário com acréscimo deve ser maior que o salário atual");
        break;
    default:
    acrescimo = ((salNovo - salAtual) / salAtual) * 100;
    Console.WriteLine("O acréscimo salarial foi de: " + acrescimo + "%"); 
       break;
}
//LOCALIZAR ERRO
