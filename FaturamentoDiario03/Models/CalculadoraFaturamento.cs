using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Reflection;

namespace FaturamentoDiario03.Models
{

    internal static class CalculadoraFaturamento
    {
        static string conteudoArquivo = File.ReadAllText("dados.json");
        static List<FaturamentoDia> deserializado = JsonConvert.DeserializeObject<List<FaturamentoDia>>(conteudoArquivo);
        public static void MenorValor()
        {
            string conteudoArquivo = File.ReadAllText("dados.json");
            double menorValor = deserializado[0].Valor;
            int dia = deserializado[0].Dia;
            foreach (var item in deserializado)
            {
                if (item.Valor > 0)
                {
                    if (item.Valor < menorValor)
                    {
                        menorValor = item.Valor;
                        dia = item.Dia;
                    }

                }
            }
            Console.WriteLine($"O dia {dia} teve o menor faturamento: {menorValor}");
        }

        public static void MaiorValor()
        {
            double maiorValor = deserializado[0].Valor;
            int dia = deserializado[0].Dia;
            foreach (var item in deserializado)
            {
                if (item.Valor > 0)
                {
                    if (item.Valor > maiorValor)
                    {
                        maiorValor = item.Valor;
                        dia = item.Dia;
                    }

                }
            }
            Console.WriteLine($"O dia {dia} teve o maior faturamento: {maiorValor}");
        }

        public static void DiasAcimaDaMedia()
        {
            double media = CalcularMedia();
            List<FaturamentoDia> faturamentos = new List<FaturamentoDia>();
            foreach (var item in deserializado)
            {
                if (item.Valor > media)
                {
                    faturamentos.Add(item);
                }
            }
            if (faturamentos.Count > 0)
            {
                int count = 0;
                Console.WriteLine($"Dias com vendas acima da média mensal({media.ToString("F4")}):");
                foreach (var item in faturamentos)
                {
                    Console.WriteLine($"Dia: {item.Dia}, Valor: {item.Valor}");
                    count++;
                }
                Console.WriteLine($"Total de dias: {count}");
            }
            else
            {
                Console.WriteLine("Nenhum dia vendeu mais que a média");
            }

        }

        public static double CalcularMedia()
        {
            double media = 0;
            foreach (var item in deserializado)
            {
                if (item.Valor > 0)
                {
                    media += item.Valor;

                }
            }
            return media / deserializado.Count;
        }
    }




}
