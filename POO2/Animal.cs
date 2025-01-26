using System;


namespace POO2
{
/* Por ser a classe Pai ela acaba se tornando uma classe bastante abstrata, ent meio que ela cobra ter..... 
.... Classe Filha, para que seja melhor direcionada*/
    internal class Animal     
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public decimal Peso { get; set; }
        public string Genero { get; set; }

        public void Andar()
        {
            Console.WriteLine($"{Nome} está andando");
        }

        public void Comer(decimal quantidade) // Quando comer ele vai receber um valor que vai ser chamada de qtd.
        {
            Peso += quantidade;               // A quantidade que receber vai ser adicionada ao peso.
            Console.WriteLine($"{Nome} comeu e agora está pesando {Peso} kg");
        }

        public void Dormir()
        {
            Console.WriteLine($"{Nome} está dormindo...");
        }
    }
}
