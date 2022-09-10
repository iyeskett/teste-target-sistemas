using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterCaracteres05.Models
{
    internal static class Palavra
    {
        public static string Inverter(string palavra)
        {
            string contrario = "";
            int numeroCaracteres = palavra.Length;

            for (int i = numeroCaracteres -1; i >= 0; i--)
            {
                contrario += palavra[i];
            }
            return contrario;
        }
    }
}
