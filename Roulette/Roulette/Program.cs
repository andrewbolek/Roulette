using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Roulette!\n\n    Do your betting and then press Enter to get your results.\n\n");
            Console.ReadLine();
            Random();
            
            Console.ReadLine();
        }
        static void Random()
        {
            Console.Clear();
            Bets bet = new Bets();
            Random random = new Random();
            int[] rednumber = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35 };
            int[] blacknumber = { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36 };

            var a = random.Next(0, 38);

            if (a != 0 && a != 37)
            {
                if (a < 17)
                {
                    int rresult;
                    rresult = rednumber[new Random().Next(0, rednumber.Length)];
                    Console.WriteLine($"Red {rresult}\n");
                    Bets.Indnumb(rresult);
                    Bets.Odd();
                    Bets.Red();
                    Bets.HiLo(rresult);
                    bet.Column(rresult);
                    bet.Street(rresult);
                    bet.DStreet(rresult);
                    bet.Split(rresult);
                    bet.Corner(rresult);
                }
                if (a > 16)
                {
                    int bresult;

                    bresult = blacknumber[new Random().Next(0, blacknumber.Length)];
                    Console.WriteLine($"Black {bresult}\n");
                    Bets.Indnumb(bresult);
                    Bets.Even();
                    bet.Black();
                    Bets.HiLo(bresult);
                    bet.Column(bresult);
                    bet.Street(bresult);
                    bet.DStreet(bresult);
                    bet.Split(bresult);
                    bet.Corner(bresult);
                }
            }
            if (a == 0)
            {
                Console.WriteLine("0\n");
                Bets.Indnumb(a);
                Bets.Zero();
                Bets.HiLo(a);
                bet.Column(a);
                bet.Street(a);
                bet.DStreet(a);
                bet.Split(a);
                bet.Corner(a);
            }
            if (a == 37)
            {
                Console.WriteLine("00 \n");
                int b = 37;
                Bets.Indnumb(b);
                Bets.Zero();
                Bets.HiLo(b);
                bet.Column(b);
                bet.Street(b);
                bet.DStreet(b);
                bet.Split(b);
                bet.Corner(a);
            }
            Console.WriteLine("\n\nWould you like a new number? \n\n\n [1] Yes\n\n [2] to exit ");
            double result;
            double.TryParse(Console.ReadLine(), out result);
            switch (result)
            {
                case 1:
                    Random();
                    return;
                case 2:
                    Exit();
                    return;
                default:
                    Random();
                    return;
            }
          

            
           
            

        }
       public static void Exit()
        {

        }
        
    }
}
