using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeIO
{
    internal class CriarPasta()
    {
        public static void CriarPastas()
        {

            while (true)
            {
                Console.WriteLine("***-----***");
                Console.WriteLine("| MENU    |");
                Console.WriteLine("| Criar   |");
                Console.WriteLine("| Pasta   |");
                Console.WriteLine("***-----***\n");

                Console.WriteLine("\n1° Exibir pastas existentes: ");
                Console.WriteLine("2° Criar pasta: ");
                Console.WriteLine("3° Editar nome da pasta: ");
                Console.WriteLine("4° Voltar: ");
                Console.WriteLine("Escolha uma opção!\n");

                var opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        ExibirPastasExistentes();
                        break;
                    case "2":
                        CriarPasta();
                        break;
                    case "3":
                        EditarNomePasta();
                        break;
                    case "4":
                        return;                   
                    default:
                        Console.WriteLine("Opção inválida!\n");
                        Console.ReadKey();
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

            static void CriarPasta()
            {
                Console.Clear();
                Console.Write("Digite o nome da pasta: \n");
                string nomePasta = Console.ReadLine();

                if (Directory.Exists(nomePasta))
                {
                    Console.WriteLine("A pasta já existe!\n");
                }
                else
                {
                    Directory.CreateDirectory(nomePasta);
                    Console.WriteLine($"Pasta '{nomePasta}' criada com sucesso.\n");
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...\n");
                Console.ReadKey();
            }

            static void EditarNomePasta()
            {
                Console.Clear();
                Console.Write("Digite o nome da pasta que deseja editar: \n");
                string nomePastaAntigo = Console.ReadLine();

                if (Directory.Exists(nomePastaAntigo))
                {
                    Console.Write("Digite o novo nome para a pasta: \n");
                    string nomePastaNovo = Console.ReadLine();
                    Directory.Move(nomePastaAntigo, nomePastaNovo);
                    Console.WriteLine($"Pasta renomeada para '{nomePastaNovo}' com sucesso.\n");
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

