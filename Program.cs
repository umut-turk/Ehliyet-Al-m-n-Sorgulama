using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ehliyet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //yaş  degşeknini  aldık
            Console.WriteLine("yaş girin");
            string yas1 = Console.ReadLine();
            int yas = Convert.ToInt32(yas1);




            //  egtim  durumunu  aldık
            Console.WriteLine("Egtim  durumunz  nedır?");
            string ed = Console.ReadLine();

            if (yas >= 18 && ed == "lise")
            {
                Console.WriteLine("Ehlıyet  alablrsınız");
            }
            else if (yas >= 18 && ed == "üniversite " || ed == "üni")
            {
                Console.WriteLine("Ehlıyet  alablrsınız");
            }
            else if (yas < 18 || ed == "ilkokul" || ed == "orta okul")
            {
                Console.WriteLine("Ehlıyet  alamazsiniz");


            }
            Console.ReadLine();

        }
    }
}
