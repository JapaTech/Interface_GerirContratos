using System.Globalization;

namespace GerirContratos.Entidades
{
    internal class Contrato
    {
        public int Id { get; private set; }
        public DateTime DataInicial { get; private set; }
        public float Valor { get; private set; }
        
        public List<Parcelas> Parcelas;

        public Contrato(int id, DateTime dataInicial, float valor)
        {
            Id = id;
            DataInicial = dataInicial;
            Valor = valor;
            Parcelas = new List<Parcelas>();
        }

        public string ValorTotal()
        {
            if (Parcelas.Count > 0)
            {
                float total = 0;

                for (int i = 0; i < Parcelas.Count; i++)
                {
                    total += Parcelas[i].Valor;
                }

                return total.ToString("2F", CultureInfo.InvariantCulture);
            }
            else
            {
                return Valor.ToString("2F", CultureInfo.InvariantCulture);
            }
        }

        public override string ToString()
        {
            string s = "";
            float total = 0;
            for (int i = 0; i < Parcelas.Count; i++)
            {
                s += $"Parcela {i+1}; Valor: {Parcelas[i].Valor.ToString("F2", CultureInfo.InvariantCulture)}\n";
                total += Parcelas[i].Valor;
            }
            return $"Contrado Id: {Id}, Valor Inicial {Valor.ToString("F2", CultureInfo.InvariantCulture)}\n\n{s} \nValor total: {total.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
