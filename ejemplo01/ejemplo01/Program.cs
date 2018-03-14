using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
    Universidad Autonoma Del Estado de Mexico
    C.U. UAEM Zumpango 
    Ingenieria en Computacion
    Algoritmos Geneticos
    Juan Carlos Angeles Vazquez
    18/Febrero/2018

*/
namespace ejemplo01
{
    class Program
    {
        public static void Main(string[] args)
        {
            Individuo i = new Individuo(7);
            //Individuo gray = new Individuo(7);
            //gray.setIsGray(true);
            Console.WriteLine(i+"\n");
            //Console.WriteLine("\n" + gray);
            Individuo[] hijos = i.Cross1P(new Individuo(7));
            for(int j = 0; j < 2; j++)
            {
                Console.WriteLine("\n" + hijos[j]);
            }
            Console.ReadLine();
            Console.WriteLine("");
        }
    }
}
