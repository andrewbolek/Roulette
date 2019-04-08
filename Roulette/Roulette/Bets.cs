using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    public class Bets
    {
        public int[] column1 = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        public int[] column2 = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        public int[] column3 = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

        //1
        public static void Indnumb(int a)
        {
            if (a == 37)
            {
                Console.WriteLine($"If you bet exactly on 00 you win 1:35\n ");
            }
            else
            {
                Console.WriteLine($"If you bet exactly on {a} you win 1:35\n ");
            }

        }
        //2
        public static void Even()
        {
            Console.WriteLine("If you bet on even you win 1:1\n");
        }
        public static void Odd()
        {
            Console.WriteLine("If you bet on odd you win 1:1\n");
        }
        public static void Zero()
        {
            Console.WriteLine("If you bet even or odd you didnt win.\n");
        }
        // 3
        public static void Red()
        {
            Console.WriteLine("If you bet red you win 1:1\n");
        }
        public void Black()
        {
            Console.WriteLine("If you bet black you win 1:1\n");
        }
        public void CZero()
        {
            Console.WriteLine("If you bet black or red you didnt win.\n");
        }
        //4
        public static void HiLo(int a)
        {
            if (a == 0 || a == 37)
            {
                Console.WriteLine("If you bet high or low you didn't win\n");
            }
            if (a >= 17 && a <= 36)
            {
                Console.WriteLine("If you bet high you won 1:1\n");
            }
            if (a <= 16 && a >= 1)
            {
                Console.WriteLine("If you bet low you won 1:1\n");
            }

        }
        //5
        public static void Dozen(int a)
        {
            if (a >= 1 && a <= 12)
            {
                Console.WriteLine("If you bet 1-12 you won 2:1\n");
                return;
            }
            if (a >= 13 && a <= 24)
            {
                Console.WriteLine("If you bet 13-24 you won 2:1\n");
                return;
            }
            if (a >= 25 && a <= 36)
            {
                Console.WriteLine("If you bet 25-36 you won 2:1\n");
                return;
            }
            else
            {
                Console.WriteLine("If you bet on thirds you didn't win\n");
                return;
            }
        }
        //6 columns
        public void Column(int a)
        {


            if (column1.Contains(a))
            {
                Console.WriteLine("If you bet on the first column you won 2:1 \n");
                return;
            }
            if (column2.Contains(a))
            {
                Console.WriteLine("If you bet on the second column you won 2:1 \n");
                return;
            }
            if (column3.Contains(a))
            {
                Console.WriteLine("If you bet on the third column you won 2:1 \n");
                return;
            }
            else
            {
                Console.WriteLine("If you bet on any column you lost\n");
                return;
            }
        }
        //7 
        public void Street(int a)
        {
            int a1 = a + 1;
            int a2 = a + 2;
            int b1 = a - 1;
            int b2 = a + 1;
            int c1 = a - 1;
            int c2 = a - 2;
            if (column1.Contains(a))
            {
                Console.WriteLine($"If your number was row {a} {a1} {a2} you won 11:1\n");
                return;
            }
            if (column2.Contains(a))
            {
                Console.WriteLine($"If your number was row {b1} {a} {b2} you won 11:1\n");
                return;
            }
            if (column3.Contains(a))
            {
                Console.WriteLine($"If your number was row {c2} {c1} {a} you won 11:1\n");
                return;
            }
            else
            {
                Console.WriteLine("If you bet on a row you lost\n");
                return;
            }

        }
        // 8 
        public void DStreet(int a)
        {
            int a1 = a + 1; int a2 = a + 2; int a3 = a + 3; int a4 = a + 4; int a5 = a + 5; int a6 = a - 3; int a7 = a - 2; int a8 = a - 1;
            int b1 = a - 1; int b2 = a + 1; int b3 = a + 2; int b4 = a + 3; int b5 = a + 4; int b6 = a - 4; int b7 = a - 3; int b8 = a - 2;
            int c1 = a - 2; int c2 = a - 1; int c3 = a - 5; int c4 = a - 4; int c5 = a - 3; int c6 = a + 1; int c7 = a + 2; int c8 = a + 3;

            if (column1.Contains(a))
            {
                Console.WriteLine($"If your number was in row {a},{a1},{a2} and {a3},{a4},{a5} OR row {a6},{a7},{a8} and {a},{a1},{a2} you won 5:1\n");
                return;
            }
            if (column2.Contains(a))
            {
                Console.WriteLine($"If your number was in row {b1},{a},{b2} and {b3},{b4},{b5} OR row {b6},{b7},{b8} and {b1},{a},{b2} you won 5:1\n");
                return;
            }
            if (column3.Contains(a))
            {
                Console.WriteLine($"If your number was row {c1},{c2},{a} and {c3},{c4},{c5} OR row {c6},{c7} ,{c8} and {c1},{c2},{a} you won 5:1\n");
                return;
            }
            else
            {
                Console.WriteLine("If you bet on a double row you lost\n");
                return;
            }
        }
        //9 
        public void Split(int a)
        {
            int a1 = a + 1; int a2 = a + 3; int a3 = a - 3; int a4 = a - 1;



            if (column1.Contains(a))
            {
                Console.WriteLine($"If your number was split between {a} and {a1}, OR {a} and {a2}, OR {a} and {a3} you won 17:1\n");
                return;
            }
            if (column2.Contains(a))
            {
                Console.WriteLine($"If your number was split between {a} and {a1}, OR {a} and {a2}, OR {a} and {a3} OR {a} and {a4} you won 17:1\n");
                return;
            }
            if (column3.Contains(a))
            {
                Console.WriteLine($"If your number was split between {a} and {a4}, OR {a} and {a2}, OR {a} and {a3} you won 17:1\n");
                return;
            }
            else
            {
                Console.WriteLine("If you bet on a split you lost\n");
                return;
            }
        }
        //10
        public void Corner(int a)
            {

            int a1 = a + 1; int a2 = a + 3; int a3 = a + 4;     int a4 = a - 1; int a5 = a - 3; int a6 = a - 4;
            int a7 = a + 2; int a8 = a - 2;
            int five = a + 5; int mfive = a - 5;

            if (column1.Contains(a))
            {
                Console.WriteLine($"If your number was on the corner of {a},{a1},{a2},{a3} OR {a5},{a8},{a1},{a} you won 8:1\n");
                return;
            }
            if (column2.Contains(a))
            {
                Console.WriteLine($"If your number was on the corner of {a1},{a},{a2},{a3} OR {a4},{a},{a7},{a2} OR" +
                    $" {a1},{a},{a8},{a5} OR {a4},{a},{a5},{a6} you won 8:1\n");
                return;
            }
            if (column3.Contains(a))
            {
                Console.WriteLine($"If your number was on the corner of {a},{a4},{a7},{a2} or {a6},{a5},{a4},{a} you won 8:1\n");
                return;
            }
            else
            {
                Console.WriteLine("If you bet on a corner you lost\n");
                return;
            }

        }
    }
}

