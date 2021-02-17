using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tarefa2.Models
{
    public class Raiz
    {
        public int Numero { get; set; }
        public Galho Esquerda { get; set; }
        public Galho Direita { get; set; }

        public Raiz(int numero)
        {
            this.Numero = numero;
            this.Esquerda = null;
            this.Direita = null;
        }
    }
}
