using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace GerirContratos.Servicos
{
    internal interface IServicoPagamento
    {
        public float Juros(float numParcela, float valor);

        public float TaxaPagamento(float valor);

    }
}
