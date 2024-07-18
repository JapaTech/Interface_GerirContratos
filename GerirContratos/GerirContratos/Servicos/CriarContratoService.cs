using GerirContratos.Entidades;
using System.Diagnostics.Tracing;

namespace GerirContratos.Servicos
{
    internal class CriarContratoService
    {
        public Contrato Contrato { get; set; }
        public int Meses { get; set; }

        private IServicoPagamento servicoPagamento;

        public CriarContratoService(Contrato contrato, int meses, IServicoPagamento servicoPagamento)
        {
            Contrato = contrato;
            Meses = meses;
            this.servicoPagamento = servicoPagamento;
        }

        public void CriarContrato()
        {
            float valorParcela = Contrato.Valor/Meses;

            for (int i = 0; i < Meses; i++) 
            {
                Parcelas p = new Parcelas(servicoPagamento.Juros(i + 1, valorParcela), Contrato.DataInicial.AddMonths(i + 1));
                Contrato.Parcelas.Add(p);
            }
        }
    }
}
