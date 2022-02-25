using System;

namespace Labb1Generics
{
    class Program
    {
        static void Main(string[] args)
        {
           

            LådaCollection Test2 = new LådaCollection();

            
            Test2.Add(new Låda(10, 10, 10));
            Test2.Add(new Låda(15, 5, 5));
            Test2.Add(new Låda(10, 8, 6));
            Test2.Add(new Låda(14, 17, 10));
            Test2.Add(new Låda(13, 12, 11));

            Display(Test2);

            //Test if you can add two identical boxes
            Console.WriteLine("Testar att lägga till en låda med samma dimensioner, som en låda som redan finns i listan:");
            var testBox = new Låda(15, 5, 5);
            Test2.Add(testBox);
            Console.WriteLine("----------------------------");
            Console.ReadKey();

            //Remove a box test
            Console.WriteLine("Testar att ta bort en låda:");
            Test2.Remove(new Låda(10, 10, 10));
            Console.WriteLine("Lådan med dimensionerna höjd: 10, längd: 10 och bredd: 10 har tagits bort");

            Display(Test2);

            //Test Contains
            if (Test2.Contains(testBox))
            {
                Console.WriteLine("Lådan med dimensionerna 15,5,5 finns i listan");
            }
            else
            {
                Console.WriteLine("Lådan finns inte");
            }
            Console.WriteLine("--------------------------");
            Console.ReadKey();

            Låda BoxCheck = new Låda(16, 5, 5);
            Console.WriteLine("Kollar om det finns den låda med dimesnsionerna höjd: {0}, längd: {1}, bredd {2}" , BoxCheck.höjd, BoxCheck.längd, BoxCheck.bredd);
            
            if (Test2.Contains(BoxCheck))
            {
                Console.WriteLine("En Låda med dimensionerna finns i listan");
            }
            else
            {
                Console.WriteLine("En låda med dimensionerna finns inte i listan");
            }

            Console.WriteLine("-----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Kollar om det finns den låda med samma volym som en låda med: höjd: {0}, längd: {1}, bredd: {2}", BoxCheck.höjd, BoxCheck.längd, BoxCheck.bredd);

            if(Test2.Contains(BoxCheck, new LådaSameVol()))
            {
                Console.WriteLine("Det finns en låda med samma volym");
            }
            else
            {
                Console.WriteLine("Det finns ingen låda med samma volym");
            }
            Console.ReadKey();

        }
        static void Display(LådaCollection Test2)
        {
            Console.WriteLine("Höjd \t Längd \t Bredd");
            foreach (var item in Test2)
            {
                Console.WriteLine(item.höjd + "\t " + item.längd + "\t " + item.bredd);
            }
            Console.WriteLine("---------------------");
            Console.ReadKey();
        }
    }
}
