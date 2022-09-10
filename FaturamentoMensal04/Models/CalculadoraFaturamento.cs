using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaturamentoMensal04.Models
{
    internal static class CalculadoraFaturamento
    {
        static string conteudoArquivo = File.ReadAllText("dados.json");
        static List<FaturamentoMensal> deserializado = JsonConvert.DeserializeObject<List<FaturamentoMensal>>(conteudoArquivo);


       public static void PorcentagemValor()
        {
            double totalFaturamento = TotalFaturamento();
            Console.WriteLine($"Valor Total: {totalFaturamento} \nPorcentegem de cada estado: ");
            foreach (var item in deserializado)
            {
                double porcentagem = (item.Valor / totalFaturamento) * 100;
                Console.WriteLine($"O estado {item.Estado} representa {porcentagem.ToString("F2")}% de vendas.");
            }
        }

        static double TotalFaturamento()
        {
            double total = 0;
            foreach (var item in deserializado)
            {
                total += item.Valor;
            }
            return total;
        }

    }
}
