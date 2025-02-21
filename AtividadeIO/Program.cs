using System.ComponentModel;

namespace AtividadeIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.WriteLine("*** -------------- ***");
                Console.WriteLine("*** MENU PRINCIPAL ***");
                Console.WriteLine("*** -------------- ***\n");

                Console.WriteLine("1º Criar Pasta: ");
                Console.WriteLine("2° Criar Arquivo: ");
                Console.WriteLine("3° Deletar Pasta: ");
                Console.WriteLine("4° Deletar Arquivos: ");
                Console.WriteLine("5° Sair!\n");

                var opc = Console.ReadLine();

                switch (opc) {
                    case "1":
                        CriarPasta.CriarPastas();
                        break;

                    case "2":
                        CriarArquivo.CriarArquivos();
                        break;

                    case "3":
                        DeletarPasta.DeletarPastas();
                        break;

                    case "4":
                        DeletarArquivo.DeletarArquivos();
                        break;

                    case "5":
                        return;

                    default:
                        Console.WriteLine("Opção inválida. Pressione qualquer tecla para tentar novamente.\n");
                        Console.ReadKey();
                        break;
                }
            }
        }       
    }
}

