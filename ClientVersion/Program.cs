using System;
using static System.Console;
using System.IO;
using HtmlAgilityPack;
using System.Linq;
using ClientVersion.Entites;
using System.Net;

namespace ClientVersionConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Caminho de Acesso ao Arquivo: ");
            string filesPath = ReadLine();

            try
            {
                string[] docLines = File.ReadAllLines(filesPath);


                using (StreamReader srVersion = File.OpenText(filesPath))
                {

                    foreach (string line in docLines)
                    {
                        string[] fields = line.Split(',');
                        string nameClient = fields[0];
                        string urlClient = fields[1];

                        Client client = new Client(nameClient, urlClient);

                        var docVersion = new HtmlWeb().Load(urlClient);

                        ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, errors) =>
                        
                        {
                            return true;
                        };
                        
                        var version = docVersion.DocumentNode.Descendants().Where(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("vmx-login-versao"));

                        foreach (var ver in version)
                        {
                            foreach (char name in nameClient)
                            {
                                Write($"{name}");
                            }

                            WriteLine($" ->  {ver.InnerText}");
                        }
                    }
                }
            }
            catch (IOException e)
            {

                WriteLine($"An error accurred {e.Message}");
            }
        }
    }
}
