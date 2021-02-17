namespace Tarefa2.Models
{
    public class Galho
    {
        public int Numero { get; set; }
        public Galho Proximo { get; set; }
        
        public Galho(int numero)
        {
            this.Numero = numero;
            this.Proximo = null;            
        }
    }
}
