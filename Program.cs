using System;
using System.Collections.Generic;
using System.Numerics;
using SingleLinkedList;
namespace Exempel
{
    class Program
    {
        static void Main(string[] args)
        {
            var sort = new SortingExempel();
            
            //ListTest();
            //JärnvägsAlgoritm a = new JärnvägsAlgoritm();
            //a.Algo();
            //var p = new Calculator();

            // MyStack<int> stack = new MyStack<int>();
            // stack.Push(5);
            // int tal;
            // if(stack.TryPop(out tal)) 
            // {
            //     Console.WriteLine(tal);
            // }
            // else 
            // {
            //     Console.WriteLine("Hittar inget på stacken");
            // }

            // if(stack.TryPeek(out tal)) 
            // {
            //     Console.WriteLine(tal);
            // }
            // else 
            // {
            //     Console.WriteLine("Hittar inget på stacken");
            // }


            // stack.Push(6);
            // stack.Push(1);
            // stack.Push(2);
            // stack.Push(3);

            // Console.WriteLine(stack.Pop());
            // Console.WriteLine(stack.Pop());
            // Console.WriteLine(stack.Pop());
            // Console.WriteLine(stack.Pop());
        }

        static void ListTest()
        {
            SingleLinkedList<ImageNode> imageList = new SingleLinkedList<ImageNode>();
            imageList = new SingleLinkedList<ImageNode>();
            for(int i = 0; i<20;i++)
            {
                var name = "bild-" + i + ".png";
                ImageNode n = new ImageNode();
                n.Data = name;
                imageList.AddLast(n);
            }
            Console.WriteLine(imageList);
            var addFirst = new ImageNode("addFirst.png");
            var addAfter = new ImageNode("AddAfter.png");
            var addBefore = new ImageNode("AddBefore.png");
            imageList.AddFirst(addFirst);
            imageList.AddAfter(addFirst, addAfter);
            imageList.AddBefore(addFirst, addBefore);
            Console.WriteLine(imageList);

            imageList.Remove(addFirst);
            Console.WriteLine(imageList);
            imageList.Remove(addAfter);
            Console.WriteLine(imageList);
            imageList.Remove(addBefore);
            Console.WriteLine(imageList);
            //
        }
        static BigInteger Pow(int val, int ex)
        {
            BigInteger total = val;
            for(int i = 1; i < ex; i++) {
                total = total * val;
            }
            Console.WriteLine(total);
            return total;
        }
        static void Sieve(int n)
        {
            int[] primes = new int[n + 1];
            for (int i = 2; i < n; i++)
            {
                primes[i] = i;
            }
            for (int p = 2; p < Math.Sqrt(n); p++)
            {
                if (primes[p] != 0)
                {
                    int j = p * p;
                    while (j <= n)
                    {
                        primes[j] = 0;
                        j = j + p;
                    }
                }
            }
            List<int> realPrimes = new List<int>();
            for (int j = 0; j < primes.Length; j++)
            {
                if (primes[j] != 0)
                {
                    realPrimes.Add(primes[j]);
                }
            }
            realPrimes.ForEach(n => Console.WriteLine(n));
        }

        ///<summary>
        ///Beräknar den största gemensamma delaren för två heltal m och n.
        ///</summary>
        ///<paramname="n">Måste vara större än 0.</param>
        ///<returns>Sant eller falskt beroende på om det är ett primtal eller inte.</returns>
        public static bool IsPrime(int n)
        {
            //Alla tal mindre än 3 är primtal
            if(n <= 1) {
                return false;
            }
            if(n < 4) {
                return true;
            }
            if(n % 2 == 0) {
                return false;
            }
            //För varje tal från 4 och till n
            double sqrt = Math.Sqrt(n);
            for (int i = 3; i <= n; i += 2)
            {
                //om vi inte får någon rest, räkna upp a.
                if (n % i == 0)
                {
                    return false;
                }
            }
            //Om a är två, vi har ett primtal, annars inte.
            
            return false;
        }
        public static bool IsPrimeStart(long n) {
            int a = 0;
            //För varje tal från 0 och till n
            for(long i = 1; i <= n; i++) {
                //om vi inte får någon rest, räkna upp a.
                if(n % i == 0) {
                    a++;
                }
            }
            //Om a är två har vi ett primtal, annars inte.
            return a == 2;
        }

        //Shuffle(values)
        //Givet: antal värden, minst 2
        //Erhålls: Slumpvist blandade värden
        public static int[] Shuffle(int[] values) 
        {
            Random rnd = new Random();
            for(int i = 0; i < values.Length - 2; i++) {
                int j = rnd.Next(0, values.Length - 1);
                int tmp = values[i];
                values[i] = values[j];
                values[j] = tmp;
            }
            return values;
        }
    }


            // Pow(5, 2);
            // Console.WriteLine(Math.Pow(5, 2));
            // Pow(5, 3);
            // Console.WriteLine(Math.Pow(5, 3));
            // Pow(5, 4);
            // Console.WriteLine(Math.Pow(5, 4));
            // Pow(5, 5);
            // Console.WriteLine(Math.Pow(5, 5));
            // Pow(5, 6);
            // Console.WriteLine(Math.Pow(5, 6));

            // Sieve(120);
            // int n;
            // while(true) {
            //     Console.WriteLine("Ange ett heltal");
            //     while(!int.TryParse(Console.ReadLine(), out n)) {
            //         Console.WriteLine("Felaktigt tal, försök igen.");
            //     }
            //     if(n == -1) break;
            //     Console.WriteLine(IsPrime(n));
            //     Console.WriteLine(IsPrimeStart(n));
            // }

}