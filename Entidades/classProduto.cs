using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ProgramaTrainee.Entidades
{
    public class classProduto
    {
        public int ID_Produtos { get; set; }

        public string Nome { get; set; }

        public string Cor { get; set; }

        public double Valor { get; set; }

        public int Quantidade { get; set; }

        public string Tecido { get; set; }

        public string Tamanho { get; set; }

        public DateTime Data_Criacao { get; set; }

        public DateTime Data_Alteracao { get; set; }

    }
}