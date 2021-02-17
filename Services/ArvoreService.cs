using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tarefa2.Models;

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

        public Galho GerarArvore(int[] arrayInteiro)
        {
            if (arrayInteiro != null)
            {
                int max = arrayInteiro.Max();
                int posMax = Array.IndexOf(arrayInteiro, max);

                int[] arrayEsquerda = new int[posMax];
                Array.Copy(arrayInteiro, arrayEsquerda, posMax);
                Array.Sort(arrayEsquerda, new Comparison<int>((i1,i2) => i2.CompareTo(i1)));

                int[] arrayDireita = new int[arrayInteiro.Length - (posMax + 1)];
                Array.Copy(arrayInteiro, posMax + 1, arrayDireita, 0, arrayInteiro.Length - (posMax + 1));
                Array.Sort(arrayDireita, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

                Galho raiz = new Galho(max);
                
                Galho atual = raiz;
                foreach(int numero in arrayEsquerda)
                {
                    Galho galho = new Galho(numero);
                    atual.Esquerda = galho;
                    atual = atual.Esquerda;
                }

                atual = raiz;
                foreach (int numero in arrayDireita)
                {
                    Galho galho = new Galho(numero);
                    atual.Direita = galho;
                    atual = atual.Direita;
                }

                return raiz;
            }

            return null;
        }
    }
}
