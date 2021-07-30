using ClientVersionForms.Entities;
using HtmlAgilityPack;
using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Net;
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

        }

        private void BtnSearchArchive_Click(object sender, EventArgs e)
        {
            OpenSelectFile();

        }

        private void BntSearchVersionClient_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            SearchVersionClient();
        }


        public void SearchVersionClient()
        {
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

                    ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, errors) =>

                    {
                        return true;
                    };
                    var version = docVersion.DocumentNode.Descendants().Where(d => d.Attributes.Contains("class") && d.Attributes["class"].Value.Contains("vmx-login-versao"));

                    int found;
                    foreach (var ver in version)
                    {
                        var versao = ver.InnerText;
                        dataGridView1.Rows.Add(client.NameClient, versao.Substring(found = 7), client.UrlClient);
                    }
                }
            }
        }

        private void OpenSelectFile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            var archiver = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = @"c:\";
                openFileDialog.Filter = "Files (*.csv)|*.csv";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;


                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file (Obtenha o caminho do arquivo especificado)
                    filePath = openFileDialog.FileName;
                    txtBoxDirectory.Text = filePath;

                    //Read the contents of the file into a stream (Leia o conteúdo do arquivo em um fluxo)
                    var fileStream = openFileDialog.OpenFile();
                }
            }

        }

        private void LblQuestion_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxDirectory_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
