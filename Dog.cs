using System;

class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
        }

        public void ChooseSound()
        {
            Console.WriteLine("Elige el sonido que hará el perro:");
            Console.WriteLine("1. Guau");
            Console.WriteLine("2. Miau");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                MakeSound("¡Guau!");
            }
            else if (choice == "2")
            {
                MakeSound("¡Miau!");
            }
            else
            {
                Console.WriteLine("Opción no válida. El perro no hará ningún sonido.");
            }
        }
    }