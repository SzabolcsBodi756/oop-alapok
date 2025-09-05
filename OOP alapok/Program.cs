using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_alapok
{

    public class Szemely
    {
        public string Nev { get; set; }

        private int _Kor;
        public int Kor
        {
            get => _Kor;
            set => _Kor = value >= 0 ? value : -1;
        }

        public Szemely(string nev, int kor)
        {
            this.Nev = nev;
            this.Kor = kor;
        }

        public override string ToString()
        {
            return $"{Nev} jelenleg {Kor} éves";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo = new Szemely("Kiss Máté", 19);

            Console.WriteLine(tanulo);
                

        }
    }
}
