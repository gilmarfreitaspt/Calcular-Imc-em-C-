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
    public partial class Form2 : Form

    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {

            if (txtNome.Text.Trim() != "")
            {
                StreamWriter x;
                string ficheiro = "dados.txt";
                x = File.AppendText(ficheiro);
                x.WriteLine(txtNome.Text);
                x.Close();
                MessageBox.Show("dados inseridos com sucesso");
            }
            else
            {
                MessageBox.Show("Preencha um nome!", "Erro dados");

            }
            txtNome.Text ="";
            /*            if (txt_nome.Text.Trim()!="")
            {
                StreamWriter x;
                //Colocando o endereço físico (caminho do ficheiro texto)
                string Caminho = "C:\\dados\\lista_clientes.txt";
                //usando o metodo e abrir o ficheiro texto
                x = File.AppendText(Caminho);
                //continuar a escrever neste ficheiro
                //escrever a partir da ultima linha
                x.WriteLine(txt_nome.Text);
                x.Close();
                MessageBox.Show("Dados inseridos com sucesso!", "Dados Clientes");
            }
            else
            {
                MessageBox.Show("Preencha um nome!", "Erro Dados ");
            }
            txt_nome.Text = "";
            txt_nome.Focus();*/
         
        }

        private void bttFechar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
    }



   
 }

