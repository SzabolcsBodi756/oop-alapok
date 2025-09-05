using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_alapok
{

    public class Szemely
    {
        protected string Nev { get; set; }

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

    public class BankSzamla
    {
        public int Egyenleg { get; set; }

        public BankSzamla(int egyenleg)
        {
            Egyenleg = egyenleg;
        }

        public void Betesz(int plusz)
        {
            Egyenleg += plusz;
        }

        public void Kivesz(int minus)
        {
            Egyenleg -= minus >= 0 ? Egyenleg -= minus : Egyenleg = 0;
        }
    }

    public class Hallgato : Szemely
    {

        public string _NeptunKod;

        public string NeptunKod
        {
            get => _NeptunKod;
            set => _NeptunKod = value.Length <= 6 ? value : "-1";
        }

        public Hallgato(string neptunKod, string nev, int kor) : base(nev, kor)
        {
            NeptunKod = neptunKod;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo = new Szemely("Kiss Máté", 19);

            Console.WriteLine(tanulo);

            BankSzamla szamla = new BankSzamla(1000);

            Console.WriteLine(szamla.Egyenleg);

            szamla.Betesz(500);

            Console.WriteLine(szamla.Egyenleg);

            szamla.Kivesz(750);

            Console.WriteLine(szamla.Egyenleg);

            Hallgato hallgato = new Hallgato("654123", "Kiss Anita", 21);

            Console.WriteLine(hallgato);
            Console.WriteLine(hallgato._NeptunKod);
                
        }
    }
}
