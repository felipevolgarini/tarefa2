namespace Tarefa2.Models
{
    public class Galho
    {
        public int Numero { get; set; }
        public Galho Esquerda { get; set; }
        public Galho Direita { get; set; }
        
        public Galho(int numero)
        {
            this.Numero = numero;
            this.Esquerda = null;
            this.Direita = null;
        }
    }
}
