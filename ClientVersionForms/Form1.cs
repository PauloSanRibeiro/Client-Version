using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            //Criando uma tabela
            DataTable dt = new DataTable();

            //Lendo linhas do csv
            string[] lines = File.ReadAllLines(@"C:\Users\wikihow2\Documents\Vivver\PauloSantos\ClientVersion\testeVersion\Files\client.csv");

            //Percorrer todas as linhas que foram lidas do arquivo CSV
            foreach (string line in lines)
            {
                //Pega linha atual e a cada virgula coloca o novo text em outra posição array
                string[] fields = line.Split(',');
                //string nameClient = fields[0];
                //string urlClient = fields[1];
                foreach (var field in fields)
                {
                    //Cria coluna
                    //DataColumn col = new DataColumn();

                    //Adiciona a columa ma table DT
                    dt.Columns.Add(field);
                }
                //Adiciona linhas ao datatable dt
                dt.Rows.Add(fields);
            }
            //Depois de montado o datatable, vamos falar para o grid
            //que a fonte de dados para ele exibir, será o datatable que 
            //a gente acabou de criar

            dataGridView1.DataSource = dt;
        }


    }
}
