using System;
using System.Windows.Markup;

namespace PropertyOpdracht3
{
    internal class Mens
    {
        private int leeftijd;

        public int Leeftijd
        {
            get
            {
                return leeftijd;
            }
            set
            {
                if (value > leeftijd) 
                { 
                    leeftijd = value;
                    Console.WriteLine("Oop je wordt iets ouder !!")
                }
                else
                {
                    Console.WriteLine("Begin maar helemaal op nieuw");
                }
            }
        }

        public Mens(int leeftijd)
        {
            this.leeftijd = leeftijd;
        }
    }
}