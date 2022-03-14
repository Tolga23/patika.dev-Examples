using System;
using System.Collections.Generic;
using System.Linq;

namespace Patika.dev
{
    class Program
    {

        static void Main(string[] args)
        {

            List<int> numbers = new List<int>();
            // ADD
            numbers.Add(23);
            numbers.Add(2);
            numbers.Add(92);
            
            List<string> colors = new List<string>();

            colors.Add("Blue");
            colors.Add("Green");
            colors.Add("Black");
            colors.Add("White");

            //Count
            Console.WriteLine("Total number: " + numbers.Count);

            // Foreach ve List.ForEach ile elemanlara erişim
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

            colors.ForEach(clr => Console.WriteLine(clr));

            // Remove ve RemovAt()
            numbers.Remove(92);
            numbers.RemoveAt(1); // index'te bulunan sayı silinir

            numbers.ForEach(num => Console.WriteLine(num));

            // Search
            if (numbers.Contains(23))
                Console.WriteLine("23 sayısı listede var.");

            // Diziyi List çevirme

            string[] animals = { "Kedi ", "Köpek ", "Kartal " };

            List<string> animal = new List<string>(animals);

            foreach (var anm in animal)
            {
                Console.WriteLine(anm);
            }

            // Liste içerisinde nesne tutmak

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();
            Kullanıcılar k1 = new Kullanıcılar();
            k1._name = "Tolga ";
            k1._surname = "Hardal ";
            k1._age = 30;

            kullanıcıListesi.Add(k1);

            List<Kullanıcılar> newList = new List<Kullanıcılar>();

            newList.Add(new Kullanıcılar()
            {
                _name = "Alper",
                _surname ="Har",
                _age = 26
           });

            foreach (var person in kullanıcıListesi)
            {
                Console.WriteLine("Name: " + person._name + "\nSurname: " + person._surname+ "\nAge: " + person._age);
            }


        }
    }

    public class Kullanıcılar
    {
        
        private string name;
        private string surname;
        private int age;

        public string _name { get => name; set => name = value; }
        public string _surname { get => surname; set => surname = value; }

        public int _age { get => age; set => age = value; }
    }

}



