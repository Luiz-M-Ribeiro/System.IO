using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeIO
{
    internal class CriarArquivo()
    {
        public static void CriarArquivos()
        {
            while (true)
            {
                Console.WriteLine("***-----***");
                Console.WriteLine("| MENU    |");
                Console.WriteLine("| Criar   |");
                Console.WriteLine("| Arquivo |");
                Console.WriteLine("***-----***\n");

                Console.WriteLine("1° Exibir arquivo existente: ");
                Console.WriteLine("2° Criar arquivo: ");
                Console.WriteLine("3° Editar nome do arquivo: ");
                Console.WriteLine("4° Adicionar texto ao arquivo: ");
                Console.WriteLine("5° Voltar: ");
                Console.Write("Escolha uma opção: \n");
                var opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        ExibirArquivosExistentes();
                        break;
                    case "2":
                        CriarArquivo();
                        break;
                    case "3":
                        EditarNomeArquivo();
                        break;
                    case "4":
                        AdicionarTextoAoArquivo();
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!\n");
                        Console.ReadKey();
                        break;
                }
            }
            static void ExibirArquivosExistentes()
            {
                string[] arquivos = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");
                if (arquivos.Length == 0)
                {
                    Console.WriteLine("Nenhum arquivo encontrado.\n");
                }
                else
                {
                    foreach (var arquivo in arquivos)
                    {
                        Console.WriteLine(arquivo);
                    }
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...\n");
                Console.ReadKey();
            }

            static void CriarArquivo()
            {
                Console.Clear();
                Console.Write("Digite o nome do arquivo: \n");
                string nomeArquivo = Console.ReadLine();
                string caminhoArquivo = nomeArquivo + ".txt";

                if (File.Exists(caminhoArquivo))
                {
                    Console.WriteLine("O arquivo já existe!\n");
                }
                else
                {
                    Console.Write("Digite o texto a ser adicionado ao arquivo: \n");
                    string texto = Console.ReadLine();
                    File.WriteAllText(caminhoArquivo, texto);
                    Console.WriteLine($"Arquivo '{caminhoArquivo}' criado com sucesso.\n");
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...\n");
                Console.ReadKey();
            }

            static void EditarNomeArquivo()
            {
                Console.Clear();
                Console.Write("Digite o nome do arquivo que deseja editar: \n");
                string nomeArquivoAntigo = Console.ReadLine() + ".txt";

                if (File.Exists(nomeArquivoAntigo))
                {
                    Console.Write("Digite o novo nome para o arquivo: \n");
                    string nomeArquivoNovo = Console.ReadLine() + ".txt";
                    File.Move(nomeArquivoAntigo, nomeArquivoNovo);
                    Console.WriteLine($"Arquivo renomeado para '{nomeArquivoNovo}' com sucesso.\n");
                }
                else
                {
                    Console.WriteLine("O arquivo não existe.\n");
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...\n");
                Console.ReadKey();
            }

            static void AdicionarTextoAoArquivo()
            {
                Console.Clear();
                Console.Write("Digite o nome do arquivo que deseja editar: \n");
                string nomeArquivo = Console.ReadLine() + ".txt";

                if (File.Exists(nomeArquivo))
                {
                    Console.Write("Digite o texto a ser adicionado: \n");
                    string texto = Console.ReadLine();
                    File.AppendAllText(nomeArquivo, texto);
                    Console.WriteLine($"Texto adicionado ao arquivo '{nomeArquivo}' com sucesso.\n");
                }
                else
                {
                    Console.WriteLine("O arquivo não existe.\n");
                }
                Console.WriteLine("Pressione qualquer tecla para continuar...\n");
                Console.ReadKey();
            }
        }
    }
}
