using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
     class Aviao
    {
        string modelo;
        int companhia;
        int capacidade;
        int fabricacao;

        public string Modelo { get => modelo; set => modelo = value; }
        public int Companhia { get => companhia; set => companhia = value; }
        public int Capacidade { get => capacidade; set => capacidade = value; }
        public int Fabricacao { get => fabricacao; set => fabricacao = value; }
    }
}
