using System;

class Program
{

static List<string> Cadastros = new List<string>();

    static void MostrarMenu()
    {
        Console.WriteLine("1 - Cadastrar");
        Console.WriteLine("2 - Consultar");
        Console.WriteLine("3 - Excluir");
        Console.WriteLine("0 - Sair");
    }

    static int LerOpcao()
    {
        int opcao;
        bool valido;
        do
        {
            Console.Write("Escolha uma opção: ");
            valido = int.TryParse(Console.ReadLine(), out opcao);
            if (!valido)
            {
                Console.WriteLine("Entrada inválida. Digite um número.");
            }
        } while (!valido);
        return opcao;
    }

static void Cadastrar()
    {
        string nome;
        Console.Write("Digite o nome: ");
        nome = Console.ReadLine();
        Cadastros.Add(nome);
        Console.WriteLine("Cadastro realizado com sucesso!");
    }

    static void Consultar()
    {
        Console.WriteLine("Consultar Cadastros: ");
        foreach (string nome in Cadastros)
        {
            Console.WriteLine(nome);
        }
    }

    static void Excluir()
    {
        Console.WriteLine("Excluir");
        Console.Write("Digite o nome a ser excluído: ");
        string nome = Console.ReadLine();
        if (Cadastros.Contains(nome))
        {
            Cadastros.Remove(nome);
            Console.WriteLine("Cadastro excluído com sucesso!");
        }
        else
        {
            Console.WriteLine("Cadastro não encontrado.");
        }

    }

    static void ProcessarOpcao(int opcao)
    {
        switch (opcao)
        {
            case 1:
                Console.WriteLine("Cadastro de nome");
                Cadastrar();

                break;
            case 2:
                Console.WriteLine("Consulta de nome");
                Consultar();
                break;
            case 3:
                Console.WriteLine("Excluir nome");
                Excluir();
                break;
            case 0:
                Console.WriteLine("Saindo...");
                break;
            default:
                Console.WriteLine("Opção inválida");
                break;
        }
    }

    static void Executar()
    {
        int opcao;
        do
        {
            MostrarMenu();
            opcao = LerOpcao();
            ProcessarOpcao(opcao);
            Console.WriteLine();
        } while (opcao != 0);
    }

    static void Main(string[] args)
    {
        Executar();
    }
}

 //Validar se não está vazio
 //Mensagem para lista vazia na consulta
 //Exclusão por índice vs nome
//Evitar mensagens duplicadas
//Validar entrada de dados
//Refatorar código
//Persistência de dados

//Validações robustas (evitar nomes vazios)
//
//Tratamento de case insensitive na exclusão
//
//Opção de editar cadastros
//
//Persistência em arquivo
//
//Interface mais amigável (cores, formatação)