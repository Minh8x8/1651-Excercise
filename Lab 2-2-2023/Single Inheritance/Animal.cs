﻿namespace Farm
{
    public class Animal
    {
        public void Eat() => Console.WriteLine("eating...");
    }

    public class Dog : Animal
    {
        public void Bark() => Console.WriteLine("barking");
    }

    public class Puppy : Dog
    {
        public void Weep() => Console.WriteLine("weeping");
    }

    public class Cat : Animal
    {
        public void Meow() => Console.WriteLine("meowing...");
    }
    

    public class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();
            
            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}

