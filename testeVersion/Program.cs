using HtmlAgilityPack;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using static System.Console;

namespace testeVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            string clientVersion = @"C:\Users\Paulo S Ribeiro\Documents\Documentos\testeVersion\clientVersion.txt";
            string clientName = @"C:\Users\Paulo S Ribeiro\Documents\Documentos\testeVersion\clientName.txt";
            /*
            StreamReader sr = null;
            sr = File.OpenText(sourcePath);
            */
            try
            {

                using (StreamReader srVersion = File.OpenText(clientVersion))
                {
                    using (StreamReader srName = File.OpenText(clientName))
                    {
                        while (!srVersion.EndOfStream)
                        {
                            //string[] lines = File.ReadAllLines(sourcePath);
                            string lineVersion = srVersion.ReadLine(); 
                            string lineName = srName.ReadLine();

                            var doc = new HtmlWeb().Load(lineVersion);
                            var versoes = doc.DocumentNode.Descendants().Where(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("vmx-login-versao"));

                            foreach (var version in versoes)
                            {
                                foreach (var name in lineName)
                                {
                                    Write(name);
                                   
                                }
                                WriteLine(" -> " + version.InnerText);
                                //Thread.Sleep(300);
                            }

                        }
                    }
                }

            }
            catch (IOException e)
            {
                WriteLine("An error occurred" + e.Message);
            }
        }
    }
}
