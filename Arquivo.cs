using System;
using System.IO;

namespace Ex5
{
    class Arquivo
    {
            public static void Ler(int numeroArquivo)
            {
                string line;

                string verificaCaminho = @"C:\Users\tiago.melo\Desktop\C-Sharp-Exercises\Ex5-FuncaoRecursiva\arquivo" + (numeroArquivo) +".txt";
                if(File.Exists(verificaCaminho)){
                    System.IO.StreamReader file = new System.IO.StreamReader(verificaCaminho);
                    while((line = file.ReadLine()) != null)  
                    {  
                        Console.WriteLine($"Entrou no arquivo {numeroArquivo}, linha: "+line);
                    }
                    file.Close();
                }
                string verificaProximoCaminho = @"C:\Users\tiago.melo\Desktop\C-Sharp-Exercises\Ex5-FuncaoRecursiva\arquivo" + (numeroArquivo+1) +".txt";
                if(File.Exists(verificaProximoCaminho)){
                    System.IO.StreamReader nextFile = new System.IO.StreamReader(verificaProximoCaminho);
                        while((line = nextFile.ReadLine()) != null)  
                            {  
                                Console.WriteLine($"Entrou no arquivo {numeroArquivo+1}, linha: "+line);
                            }
                nextFile.Close();
                numeroArquivo++;
                Arquivo.Ler(numeroArquivo+1);
                }
            }
    }
}