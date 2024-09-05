 using System;
 
 class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa el nombre del perro: ");
            string dogName = Console.ReadLine();

            Dog myDog = new Dog(dogName);

            myDog.ChooseSound();

            Console.ReadLine();
        }
    }