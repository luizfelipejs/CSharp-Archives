
    class Program // Aprendendo sobre herança
    {
        class Person
        {
            public string local = "brazil";


            public void Comer ()
            {
                Console.WriteLine("comendo...");
            }

        }
        class Estudant : Person
        {
            public void Falar()
            {
                Console.WriteLine($"eu estudo no {this.local}");
            }
        }
        static void Main ()
        {
            Estudant mario = new Estudant();
            mario.Falar();
        }
    }
}
