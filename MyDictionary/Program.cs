using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionaryHomework<int, string> People = new MyDictionaryHomework<int, string>();


            People.Add(1, "Can");
            People.Add(2, "Lefter");
            People.Add(3, "Alex");
            People.Add(4, "Vesley");
            People.Add(5, "Özil");
            People.Add(6, "Gustavo");
            People.Add(7, "Volkan");
            People.Add(8, "Lugano");
            People.Add(9, "Emre");
            People.Add(10, "Carlos");


            foreach (var people in People.Items)
            {
                Console.WriteLine("List Number : " + people.Item1 + "        " + "Name or Surname :" + people.Item2);
            }

        }
    }
}
