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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form

    {
        List<Pessoa> pessoa = new List<Pessoa>();
        public Form1()
        {
            InitializeComponent();
            int i;
            for (i = 110; i < 220; i++)
                cbAltura.Items.Add(i / 100.0);
            for (i = 20; i < 200; i++)
                cbPeso.Items.Add(i);
            cbSexo.SelectedIndex = 0;

        }

        private void bttCalcular_Click(object sender, EventArgs e)
        {
            double imc;
            imc = double.Parse(cbPeso.Text) / Math.Pow(double.Parse(cbAltura.Text), 2);
            lblImc.Text = imc.ToString("F");

            lbl1.BackColor = Color.LightGray;
            lbl1a.BackColor = Color.LightGray;
            lbl2.BackColor = Color.LightGray;
            lbl2a.BackColor = Color.LightGray;
            lbl3.BackColor = Color.LightGray;
            lbl3a.BackColor = Color.LightGray;
            lbl4.BackColor = Color.LightGray;
            lbl4a.BackColor = Color.LightGray;
            lbl5.BackColor = Color.LightGray;
            lbl5a.BackColor = Color.LightGray;

            if (cbSexo.SelectedIndex == 0)
            {
                if (imc <= 19)
                {
                    lbl1.BackColor = Color.Cyan;
                    lbl1a.BackColor = Color.Cyan;
                }

                if (imc >= 19 && imc < 23)
                {
                    lbl2.BackColor = Color.Cyan;
                    lbl2a.BackColor = Color.Cyan;
                }
                if (imc >= 24 && imc < 28.9)
                {
                    lbl3.BackColor = Color.Yellow;
                    lbl3a.BackColor = Color.Yellow; ;
                }
                if (imc >= 29 && imc < 38.9)
                {
                    lbl4.BackColor = Color.Yellow;
                    lbl4a.BackColor = Color.Yellow;
                }
                if (imc > 39)
                {
                    lbl5.BackColor = Color.Yellow;
                    lbl5a.BackColor = Color.Yellow;
                }
            }
            else {

                if (imc <= 20)
                {
                    lbl1.BackColor = Color.Cyan;
                    lbl1a.BackColor = Color.Cyan;
                }

                if (imc >= 20 && imc < 24.9)
                {
                    lbl2.BackColor = Color.Cyan;
                    lbl2a.BackColor = Color.Cyan;
                }
                if (imc >= 25 && imc < 29.9)
                {
                    lbl3.BackColor = Color.Yellow;
                    lbl3a.BackColor = Color.Yellow; ;
                }
                if (imc >= 30 && imc < 39.9)
                {
                    lbl4.BackColor = Color.Yellow;
                    lbl4a.BackColor = Color.Yellow;
                }
                if (imc > 40)
                {
                    lbl5.BackColor = Color.Yellow;
                    lbl5a.BackColor = Color.Yellow;

                }
            }
        }

        private void bttResert_Click(object sender, EventArgs e)
        {
            lbl1.BackColor = Color.Cyan;
            lbl1a.BackColor = Color.Cyan;
            lbl2.BackColor = Color.Cyan;
            lbl2a.BackColor = Color.Cyan;
            lbl3.BackColor = Color.Yellow;
            lbl3a.BackColor = Color.Yellow;
            lbl4.BackColor = Color.Yellow;
            lbl4a.BackColor = Color.Yellow;
            lbl5.BackColor = Color.Yellow;
            lbl5a.BackColor = Color.Yellow;

            lblImc.Text = "0,0";
            cbPeso.Text = "";
            cbPeso.SelectedIndex = -1;
            cbAltura.Text = "";
            cbAltura.SelectedIndex = -1;



        }



        private void bttSair_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void cbSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSexo.SelectedIndex == 0)
            {
                // valores femininos
                lbl1a.Text = "Abaixo de 19,0";
                lbl2a.Text = "19,9 a 23,9";
                lbl3a.Text = "24.0 a 28.9";
                lbl4a.Text = "29.0 a 38.9";
                lbl5a.Text = "acima de 39";
            }

            else
            {
                lbl1a.Text = "Abaixo de 20,0";
                lbl2a.Text = "20 a 24,9";
                lbl3a.Text = "25.0 a 29.9";
                lbl4a.Text = "30.0 a 39.9";
                lbl5a.Text = "acima de 40";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //declarar a variavel do tipo StreamWriter
            StreamReader st_cli;
            //Colocando o caminho fisico
            string Caminho = "dados.txt";

            //abrir um ficheiro texto
            st_cli = File.OpenText(Caminho);
            //enquanto nao retornar valor booleano true

            while (st_cli.EndOfStream != true) //quer dizer que não chegou no fim do ficheiro
            {
                //le conteúdo da linha
                cbNome.Items.Add(st_cli.ReadLine());
            }
            //após sair do while, é porque leu todo o conteúdo, então
            //temos que fechar o ficheiro texto que está aberto
            st_cli.Close();

          /*  string ficheiro = "dados.txt";
            using (StreamReader x = new StreamReader(ficheiro))
                while (!x.EndOfStream) {
                    cbNome.Items.Add(ficheiro);

                }*/

        }

        private void bttMais_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void bttGravar_Click(object sender, EventArgs e)
        {


            Pessoa p = new Pessoa();
            p.Nome = cbNome.Text;
            p.Sexo = cbSexo.Text;
            p.Peso = Double.Parse(cbPeso.Text);
            p.Altura = Double.Parse(cbAltura.Text);
            p.Imc = Double.Parse(lblImc.Text);
            p.Data = dtData.Text;
            StreamWriter x;

            string Caminho = "imc.txt";
            x = File.AppendText(Caminho);
            x.WriteLine(p.Nome);
            x.WriteLine(p.Sexo);
            x.WriteLine(p.Peso);
            x.WriteLine(p.Altura);
            x.WriteLine(p.Imc);
            x.WriteLine(p.Data);
            x.WriteLine("------");
            x.Close();

            MessageBox.Show("Dados inseridos com sucesso!", "Dados Clientes");

        }

        private void BttListar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void buscar_Click(object sender, EventArgs e)
        {

            List<Pessoa> pessoas = new List<Pessoa>();

            {

                //declarar a variavel Streamreader
                StreamReader st_imc;

                //definir caminho físico
                string Caminho = "dados.txt";

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
                    if (p.Nome == cbNome.Text)
                        pessoas.Add(p);
                }
                st_imc.Close();//fecho o streamreader

                string msg ="", titulo ="";
                foreach (var pes in pessoas)
                {
                    titulo = pes.Nome;
                    msg = msg + pes.Imc + "------" + pes.Data + "\n";

                }
                MessageBox.Show(msg, "IMC de " + titulo);
                this.Hide();
                Form1 f1 = new Form1();
                f1.ShowDialog();
                this.Close();
            }
         }
      }
  }
    

    

