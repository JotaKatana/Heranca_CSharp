using System;

namespace POO //name
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gato gato1 = new Gato();
            gato1.Nome = "Bichano";
            gato1.Andar();
            gato1.Miar();

            Cachorro cachorro1 = new Cachorro();
            cachorro1.Nome = "Totó";
            cachorro1.Comer(0.5m);
            cachorro1.Latir();
        }
    }
}