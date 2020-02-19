using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface3
{
    interface Iairborne
    {
        void fly();
    }
    class helicopter : Iairborne
    {
        public void fly()
        {
            Console.WriteLine("hello helicopter");
        }
    }
    class Aeroplane : Iairborne
    {
        public void fly()
        {
            Console.WriteLine("hello aeroplane");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            helicopter h = new helicopter();
            Aeroplane a = new Aeroplane();
            h.fly();
            a.fly();
        }
    }
}
