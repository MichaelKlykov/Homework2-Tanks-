using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using MyClassLib.WorldOfTanks;
namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {

            Tank[] t34 = new Tank[5];
            Tank[] pantera = new Tank[5];
            int vivod;
            int countWin = 0;
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                t34[i] = new Tank("T34", rnd);
                pantera[i] = new Tank("Pantera", rnd);
                t34[i].coutTank();
                pantera[i].coutTank();
                vivod = t34[i] ^ pantera[i];
                if(vivod == 1)
                {
                    WriteLine("Победа Т34");
                    countWin++;
                }
                else if (vivod == 0)
                {
                    WriteLine("Победа пантеры");
                }
                else
                {
                    WriteLine("Оба танка уничтожены");
                }
            }
            ReadKey();
        }
    }
}
