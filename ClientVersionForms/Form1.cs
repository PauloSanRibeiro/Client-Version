using ClientVersionForms.Entities;
using HtmlAgilityPack;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ClientVersionForms
{
    public partial class VersionClient : Form
    {
        public VersionClient()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            /*
              //Criando uma tabela
            DataTable dt = new DataTable();

            //Lendo linhas do csv
            string[] lines = File.ReadAllLines(@"C:\Users\Paulo S Ribeiro\Documents\Documentos\ClientVersion\testeVersion\Files\client.csv");

            //Percorrer todas as linhas que foram lidas do arquivo CSV
            for(int i = 0; i < lines.Length; i++)
            {
                //Pega linha atual e a cada virgula coloca o novo text em outra posição array
                string[] fields = lines[i].Split(Convert.ToChar(","));
                //string nameClient = fields[0];
                //string urlClient = fields[1];

                /*foreach (var field in fields)
                {
                    //Cria coluna
                    //DataColumn col = new DataColumn();

                    //Adiciona a columa ma table DT
                    dt.Columns.Add(field);
                }*/
            /*
                if (i == 0)
                {
                    for (int i2 = 0; i2 < fields.Length; i2++)
                    {
                        //Cria coluna
                        DataColumn col = new DataColumn();

                        //Adiciona a columa ma table DT
                        dt.Columns.Add(col);
                    }
                }

                //Adiciona linhas ao datatable dt
                dt.Rows.Add(fields);
            }
            //Depois de montado o datatable, vamos falar para o grid
            //que a fonte de dados para ele exibir, será o datatable que 
            //a gente acabou de criar

            dataGridView1.DataSource = dt;*/
        }

        public void SearchVersionClient()
        {
            /*
             *StreamReader clientVersion = new StreamReader(@"C:\Users\Paulo S Ribeiro\Documents\Documentos\ClientVersion\testeVersion\Files\client.csv");
            string lines;
            string[] fields;

            while ((lines = clientVersion.ReadLine()) != null)
            {
                fields = lines.Split(',');
                dataGridView1.Rows.Add(fields);
            }
            */


            string filesPath = txtBoxDirectory.Text;  // @"C:\Users\Paulo S Ribeiro\Documents\Documentos\ClientVersion\testeVersion\Files\client.csv";
            string lines;

            string[] fields = File.ReadAllLines(filesPath);

            using (StreamReader srVersion = File.OpenText(filesPath))
            {

                while ((lines = srVersion.ReadLine()) != null)
                {
                    fields = lines.Split(',');
                    string nameClient = fields[0];
                    string urlClient = fields[1];

                    Clients client = new Clients(nameClient, urlClient);

                    var docVersion = new HtmlWeb().Load(urlClient);
                    var version = docVersion.DocumentNode.Descendants().Where(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("vmx-login-versao"));

                    foreach (var ver in version)
                    {
                        var versao = ver.InnerText;
                        dataGridView1.Rows.Add(client.NameClient, client.UrlClient, versao);
                    }



                    /*foreach (var ver in version)
                    {
                        foreach (char name in nameClient)
                        {
                            Write($"{name}");
                        }

                        WriteLine($" ->  {ver.InnerText}");


                    }*/
                }
            }
            /*
                string clientVersion = @"C:\Users\Paulo S Ribeiro\Documents\Documentos\ClientVersion\testeVersion\Files\client.txt";
                string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
                DataTable dt;

                using (OleDbConnection cn = new OleDbConnection(@"Provider=Microsoft.Jet.OleDb.4.0;" +
                                                                 "Data Source=" + directoryName + ";" +
                                                                 "Extended Properties=\"Text;HDR=Yes;FMT=Delimited\""))//("Provider=Microsoft.Jet.OleDb.4.0;" + "Data Source =" + directoryName + "," + "Extended Properties=\"Text;HDR=Yes;FMT=Delimited\"")) ;
                {
                    cn.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT * FROM " + clientVersion, cn))
                    {
                        dt = new DataTable("Clientes");
                        adapter.Fill(dt);
                    }


                }

                ExibirTexto();
                dataGridView1.DataSource = dt;*/

        }

        private void BntSearchVersionClient_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SearchVersionClient();
        }

        private void LblQuestion_Click(object sender, EventArgs e)
        {

        }
        /*
private void ExibirTexto()
{
string caminhoArquivo = @"C:\Users\Paulo S Ribeiro\Documents\Documentos\ClientVersion\testeVersion\Files\client.txt";
string[] consulta = File.ReadAllLines(caminhoArquivo);

foreach (var item in consulta)
{
lsBoxText.Visible = true;
lsBoxText.Items.Add(item);
}
}*/

    }
}
