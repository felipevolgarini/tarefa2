using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarefa2.Services
{
    public class ArvoreService
    {
        public int[] TransformarParaArrayInteiro(string entrada)
        {
            string[] arrayParcial = entrada.Split(",");
            List<int> lista = new List<int>();
            foreach (string item in arrayParcial)
            {
                lista.Add(Int32.Parse(item));
            }
            return lista.ToArray();
        }
    }
}
