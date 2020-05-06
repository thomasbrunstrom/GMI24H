using System;
using System.Numerics;

namespace Exempel
{
    public class Rekursion
    {
        public BigInteger F(BigInteger n)
        {
            //Beräknar n! rekursivt
            //Input: Ett positivt heltal (BigInteger)
            //Output: Värdet av n!
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return F(n - 1) * n;
            }
        }
        public void movetower(int n, int from, int to, int other)
        {
            if (n > 0)
            {
                movetower(n - 1, from, other, to);
                Console.WriteLine("Flytta disk {0} från pinne {1} till pinne {2}", n, from, to);
                movetower(n - 1, other, to, from);
            }
        }

        public int Add01(int[] a)
        {
            //Beräknar summan av n antal tal
            //Indata: ett fält med tal a[0..n-1] som ska adderas
            //Utdata: Summan av talen
            int summa = 0;
            for (int i = 0; i < a.Length; i++)
            {
                summa += a[i];
            }
            return summa;
        }
        public int Add02(int[] a, int start, int end)
        {
            if (start == end)
            {
                return a[start];
            }

            if (start < end)
            {
                int mid = (start + end) / 2;
                int lsum = Add02(a, start, mid - 1);
                int rsum = Add02(a, mid + 1, end);
                return lsum + rsum + a[mid];
            }
            return 0;
        }
    }
}