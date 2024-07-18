using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerirContratos.Entidades
{
    internal class Parcelas
    {
        public float Valor { get; private set; }
        public DateTime DiaPagamento { get; private set; }

        public Parcelas(float valor, DateTime diaPagamento)
        {
            Valor = valor;
            DiaPagamento = diaPagamento;
        }
    }
}
