using System;

namespace ConsoleApp3
{
    public class Umnojeniena2
    {
        private int umnojennoe;

        private Umnojeniena2() { }
        public Umnojeniena2(int vvod)
        {
            umnojennoe = vvod;
        }

        public void Umnojenie (int chislo)
            {
            umnojennoe = chislo * 2;
            }

        public int Vivod
        {
            get { return umnojennoe; }
        }

        public static void Main()
        {
            Umnojeniena2 ba = new Umnojeniena2(2);

            Console.WriteLine(ba.Vivod);
        }
    }
}
