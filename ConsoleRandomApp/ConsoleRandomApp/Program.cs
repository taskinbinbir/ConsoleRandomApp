using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleRandomApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> randomList = new List<int>(9);

            Random random = new Random();

            int randomCagirimAdedi = 1;
            int rnd;

            randomList.Add(random.Next(1, 10));



            bool b = true;

            while (b)
            {
                rnd = random.Next(1, 10);
                randomCagirimAdedi++;

                for (int i=0; i<randomList.Count(); i++)
                {

                    if (!randomList.Contains(rnd))
                    {
                        randomList.Add(rnd);
                    }                   

                }
                                

                if (randomList.Count() == 9)
                {
                    b = false;
                }
                
            }

            for (int i = 0; i < randomList.Count(); i++)
            {
                if(i < 8)
                {
                    Console.Write(randomList[i] + ",");
                }
                else
                {
                    Console.Write(randomList[i] + " ");
                }
            }

            Console.Write("Random fonksiyonu " + randomCagirimAdedi + " kere çalışmıştır.");



            Console.ReadLine();


        }
    }
}
