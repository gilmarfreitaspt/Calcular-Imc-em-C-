using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

            //declarar a variavel Streamreader
            StreamReader st_imc;

            //definir caminho físico
            string Caminho = "imc.txt";

            //abrir um ficheiro texto
            st_imc = File.OpenText(Caminho);
            //enquanto nao chegar ao fim do ficheiro

            while (st_imc.EndOfStream != true) //quer dizer que nao chegar a final do ficheiro
            {
                //instancia onde a pessoa atribui valores
                Pessoa p = new Pessoa();
                p.Nome = st_imc.ReadLine();
                p.Sexo = st_imc.ReadLine();
                p.Peso = float.Parse(st_imc.ReadLine());
                p.Altura = float.Parse(st_imc.ReadLine());
                p.Imc = float.Parse(st_imc.ReadLine());
                p.Data = st_imc.ReadLine();
                //ler separador
                st_imc.ReadLine();
                //if (p.Nome ==cbNome.Text)
                pessoas.Add(p);
            }
            st_imc.Close();//fecho o streamreader

            foreach (var pes in pessoas)
            {
                DataGridViewRow row = (DataGridViewRow)Grelha.Rows[0].Clone();
                row.Cells[0].Value = pes.Nome;
                row.Cells[1].Value = pes.Sexo;
                row.Cells[2].Value = pes.Peso;
                row.Cells[3].Value = pes.Altura;
                row.Cells[4].Value = pes.Imc;
                row.Cells[5].Value = calcula(pes.Imc, pes.Sexo);
                row.Cells[6].Value = pes.Data;

              Grelha.Rows.Add(row);

            }

            string calcula(double imc, string sexo)
            {
                string res = "";
                if (sexo == "Feminino")
                {// no caso de escolher F
                    if (imc < 19)
                        res = "Abaixo do Peso";
                    if (imc >= 19 && imc < 23.9)
                        res = "Peso Normal";
                    if (imc >= 24 && imc < 28.9)
                        res = "Obesidade Grau I";
                    if (imc >= 29 && imc < 38.9)
                        res = "Obesidade Grau II";
                    if (imc > 39)
                        res = "Obesidade Grau III";
                }
                else
                {
                    if (imc < 20)
                        res = "Abaixo do Peso";
                    if (imc >= 20 && imc < 24.9)
                        res = "Peso Normal";
                    if (imc >= 25 && imc < 29.9)
                        res = "Obesidade Grau I";
                    if (imc >= 30 && imc < 39.9)
                        res = "Obesidade Grau II";
                    if (imc > 40)
                        res = "Obesidade Grau III";
                }

                return res;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }
}


