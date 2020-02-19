using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Pessoa
    {
        public Pessoa(string nome, string sexo, double peso, double altura, double imc, string data)
        {
            Nome = nome;
            Sexo = sexo;
            Peso = peso;
            Altura = altura;
            Imc = imc;
            Data = data;
        }
        public Pessoa()
        {
            
        }
        public string Nome { get; set; }
        public string Sexo { get; set; }
        public Double Peso { get; set; }
        public Double Altura { get; set; }
        public Double Imc { get; set; }
        public string Data { get; set; }
    }
}
