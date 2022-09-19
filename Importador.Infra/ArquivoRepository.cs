using Importador.Domain.Classes;
using Importador.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importador.Infra
{
    public class ArquivoRepository : IArquivoRepository
    {
        public bool GravarArquivoApi(List<double> valores)
        {
            using (StreamWriter file = new("D:\\testeee\\atual.csv", append: true))
            {
                file.WriteLineAsync("R");
                foreach (double value in valores)
                {
                    file.WriteLine(value.ToString().Replace(".",","));
                }
            }
            return true;
                
        }

        public Arquivo LerArquivo()
        {

            if (Directory.EnumerateFileSystemEntries("D:\\testeee\\ca").Any())
            {
                var caminhoArquivo = Directory.EnumerateFileSystemEntries("D:\\testeee\\ca").First();
                Arquivo arquivo = new Arquivo();
                arquivo.a = new List<int>();
                arquivo.b = new List<int>();
                try
                {
                    String[] linhas = File.ReadAllLines(caminhoArquivo);
                    File.Delete(caminhoArquivo);
                    String valorA;
                    String valorB;
                    int tempParseA, tempParseB;

                    foreach (var linha in linhas)
                    {
                        String[] valores = linha.Split(";");
                        if (int.TryParse(valores[0], out tempParseA))
                            arquivo.a.Add(tempParseA);
                        if (int.TryParse(valores[1], out tempParseB))
                            arquivo.b.Add(tempParseB);

                    }
                }
                catch
                {
                    return null;
                }

                return arquivo;
            }
            else return null;
        }
    }
}
