using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class SecretSanta
        {
            string name;
            string gift;
            

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;

            }

           
            public string Hero
            {
                get { return name; }
            }

            public string Wish
            {
                get { return gift; }
            }

           
        }
        static void Main(string[] args)
        {
            //Anna wants new earrings for Christmas;
            List<SecretSanta> myChristmas = new List<SecretSanta>();
            string[] wishesFromFile = GetDataFromFile();

            foreach (string line in wishesFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SecretSanta newWish = new SecretSanta(tempArray[0], tempArray[1]);
                myChristmas.Add(newWish);
            }

            foreach (SecretSanta wishesFromList in myChristmas)
            {
                Console.WriteLine($"{wishesFromList.Hero} wants {wishesFromList.Wish}.");
            }
        }

        public static void DisplayElementsFromArray(string[] someArray)
        {
            foreach (string element in someArray)
            {
                Console.WriteLine($"String from array: {element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\opilane53\samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
