using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerirContratos.Servicos
{
    internal class PayPal : IServicoPagamento
    {
        public float JuroMensal { get; set; } = 1;
        public float Taxa { get; set; } = 2;


        public float TaxaPagamento(float valor)
        {
            return valor + valor * Taxa * 0.01f ;
        }

        public float Juros(float numParcela, float valor)
        {
            return ((numParcela * JuroMensal/100) * TaxaPagamento(valor)) + TaxaPagamento(valor);
        }
    }
}
