using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeIO
{
    internal class DeletarArquivo
    {
        public static void DeletarArquivos()
        {
            while (true)
            {
                Console.WriteLine("***-----***");
                Console.WriteLine("| MENU    |");
                Console.WriteLine("| Deletar |");
                Console.WriteLine("| Arquivo |");
                Console.WriteLine("***-----***\n");

                Console.WriteLine("1° Exibir os arquivos: ");
                Console.WriteLine("2° Deletar arquivos: ");                
                Console.WriteLine("3° Voltar: ");
                Console.Write("Escolha uma opção: \n");
                var opc = Console.ReadLine();

                switch (opc)
                {
                    case "1":
                        ExibirArquivosExistentes();
                        break;

                    case "2":
                        DeletarArquivo();
                        break;

                    case "3":
                        return;
                    default:
                        Console.WriteLine("Opção inválida!\n");
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
                Console.WriteLine("Pressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
            
            static void DeletarArquivo()
            {
                Console.Clear();
                Console.Write("Digite o nome do arquivo que deseja deletar: ");
                string nomeArquivo = Console.ReadLine() + ".txt";

                if (File.Exists(nomeArquivo))
                {
                    File.Delete(nomeArquivo);
                    Console.WriteLine($"Arquivo '{nomeArquivo}' deletado com sucesso.\n");
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
