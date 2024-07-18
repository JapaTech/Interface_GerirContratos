using GerirContratos.Entidades;
using GerirContratos.Servicos;
using System.Globalization;

namespace GerirContratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira o ID do contrato: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Insira a data inicial do contrato: ");
            DateTime dataInicial = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Insira o Valor inicial do contrato: ");
            float f = float.Parse(Console.ReadLine());
            Contrato contrato = new Contrato(id, dataInicial, f);
            Console.Write("Insira a quantidade de parcelas: ");
            int i = int.Parse(Console.ReadLine());

            CriarContratoService contratoService = new CriarContratoService(contrato, i, new PayPal());
            contratoService.CriarContrato();

            Console.WriteLine("\n"+contrato.ToString());
            Console.ReadKey();
        }
    }
}
