using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeIO
{
    internal class DeletarPasta
    {
        public static void DeletarPastas()
        {
            while (true)
            {
                Console.WriteLine("***-----***");
                Console.WriteLine("| MENU    |");
                Console.WriteLine("| Deletar |");
                Console.WriteLine("| Pasta   |");
                Console.WriteLine("***-----***\n");

                Console.WriteLine("1° Exibir pastas: ");
                Console.WriteLine("2° Deletar pasta: ");
                Console.WriteLine("3° Voltar: ");
                Console.Write("Escolha uma opção: \n");

                var opc = Console.ReadLine();

                switch (opc) {
                    case "1":
                        ExibirPastasExistentes();
                        break;

                    case "2":
                        DeletarPasta();
                        break;

                    case "3":
                        return;
                        default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            }

            static void ExibirPastasExistentes()
            {
                string[] pastas = Directory.GetDirectories(Directory.GetCurrentDirectory());
                if (pastas.Length == 0)
                {
                    Console.WriteLine("Nenhuma pasta encontrada.\n");
                }
                else
                {
                    foreach (var pasta in pastas)
                    {
                        Console.WriteLine(pasta);
                    }
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...\n");
                Console.ReadKey();
            }

            static void DeletarPasta()
            {
                Console.Clear();
                Console.Write("Digite o nome da pasta que deseja deletar: \n");
                string nomePasta = Console.ReadLine();

                if (Directory.Exists(nomePasta))
                {
                    Directory.Delete(nomePasta, true);
                    Console.WriteLine($"Pasta '{nomePasta}' deletada com sucesso.\n");
                }
                else
                {
                    Console.WriteLine("A pasta não existe.\n");
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...\n");
                Console.ReadKey();
            }
        }
    }
}
