using System;
using System.IO;

namespace Aula11_Intermediario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] linhas = {"text1", "text2", "text3" };
            StreamWriter file = new StreamWriter(@"C:\\teste\arquivo2.txt");

            foreach (string linha in linhas)
            {
                if (!linha.Contains("text2"))
                {
                    
                }
            }


            //// Passar caminho de criação do arquivo
            //StreamWriter sw = new StreamWriter(@"C:\\teste\arquivo.txt");
            //sw.WriteLine("Primeira Linha de Texto");
            //sw.WriteLine("Segunda Linha do Texto");
            
            //// Close() = metodo que fecha a conexão com o arquivo texto
            //sw.Close();
            
            ////sw.Flush();

            //string text = System.IO.File.ReadAllText(@"C:\\teste\arquivo.txt");
            //Console.WriteLine(text);
        }
    }
}
