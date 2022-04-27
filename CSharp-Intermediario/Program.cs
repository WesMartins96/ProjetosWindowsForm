using System;
using System.IO;

namespace Aula1_Intermediario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Visualizar conteudo disco(drive)
            //System.IO.DriveInfo di = new System.IO.DriveInfo(@"C:\");
            //Console.WriteLine("Free Space in disk: " + di.TotalFreeSpace);

            //// Comandos para criar pasta no sistema - (Criar Pastas ou Diretório)
            //string pastaCriada = @"C:\\teste";

            ////Verificar se já foi criado uma pasta, e mandar uma mensagem que já foi criado se caso já foi
            //if (!System.IO.Directory.Exists(pastaCriada))
            //{
            //    System.IO.Directory.CreateDirectory(pastaCriada);
            //}
            //else
            //{
            //    Console.WriteLine("Já foi criado uma pasta");
            //}

            // Deletar Pasta
            //System.IO.Directory.Delete(pastaCriada);

            // Copia de Arquivos(Diretórios)

            string nomeArquivo = "texto.txt";
            string pastaOrigem = @"C:\\teste";
            string pastaDestino = @"C:\\teste\subdir";

            string arquivoOrigem = System.IO.Path.Combine(pastaOrigem, nomeArquivo);
            string arquivoDestino = System.IO.Path.Combine(pastaDestino, nomeArquivo);

            System.IO.File.Delete(@"C:\\teste\texto.txt");

            //Mover arquivo. Batas usar o metodo Move();
            //System.IO.File.Move(arquivoOrigem, arquivoDestino, true);
        }
    }
}
