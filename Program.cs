using desafio.entities;

internal class Program
{
  private static char opcao = '0';
  private static void Main(string[] args)
  {
    System.Console.WriteLine("Seja bem-vindo ao desafio de número 03");

    do
    {
      criacaoHeroi();

      System.Console.Write("Deseja criar mais algum personagem? (S/N) ");
      opcao = char.Parse(Console.ReadLine());

      while (opcao != 's' && opcao != 'S' && opcao != 'n' && opcao != 'N')
      {
        System.Console.WriteLine("Opção inválida, Digite novamente (S/N)");
        opcao = char.Parse(Console.ReadLine());
      }

    } while (opcao == 's' || opcao == 'S');
  }

  public static void menu()
  {
    System.Console.WriteLine();
    System.Console.WriteLine("Crie seu personagem:");
    System.Console.WriteLine("1 - Guerreiro");
    System.Console.WriteLine("2 - Mago");
    System.Console.WriteLine("3 - Monge");
    System.Console.WriteLine("4 - Ninja");
  }

  public static void criacaoHeroi()
  {
    menu();
    char escolha = char.Parse(Console.ReadLine());
    string tipo;
    string nome;
    int idade;

    switch (escolha)
    {
      case '1':
        tipo = "Guerreiro";
        System.Console.WriteLine("Digite o nome do seu Guerreiro");
        nome = Console.ReadLine();
        System.Console.WriteLine("Digite a idade do seu Guerreiro");
        idade = int.Parse(Console.ReadLine());
        Guerreiro guerreiro = new Guerreiro(nome, idade, tipo);
        System.Console.WriteLine($"Personagem criado: {guerreiro.atacar()}");
        break;

      case '2':
        tipo = "Mago";
        System.Console.WriteLine("Digite o nome do seu Mago");
        nome = Console.ReadLine();
        System.Console.WriteLine("Digite a idade do seu Mago");
        idade = int.Parse(Console.ReadLine());
        Mago mago = new Mago(nome, idade, tipo);
        System.Console.WriteLine($"Personagem criado: {mago.atacar()}");
        break;

      case '3':
        tipo = "Monge";
        System.Console.WriteLine("Digite o nome do seu Monge");
        nome = Console.ReadLine();
        System.Console.WriteLine("Digite a idade do seu Monge");
        idade = int.Parse(Console.ReadLine());
        Monge monge = new Monge(nome, idade, tipo);
        System.Console.WriteLine($"Personagem criado: {monge.atacar()}");
        break;

      case '4':
        tipo = "Ninja";
        System.Console.WriteLine("Digite o nome do seu Ninja");
        nome = Console.ReadLine();
        System.Console.WriteLine("Digite a idade do seu Ninja");
        idade = int.Parse(Console.ReadLine());
        Ninja ninja = new Ninja(nome, idade, tipo);
        System.Console.WriteLine($"Personagem criado: {ninja.atacar()}");
        break;

      default:
        System.Console.WriteLine("Opção inválida. Tente novamente.");
        break;
    }
  }
}