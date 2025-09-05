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
            set
            {
                if (value > -1)
                {
                    _Kor = value;
                }
                else
                {
                    Console.WriteLine("Az életkor nem lehet negatív szám!");
                    _Kor = 0;
                }
            }
        }

        public Szemely(string nev, int kor)
        {
            this.Nev = nev;
            this.Kor = kor;
        }

        public override string ToString()
        {
            return $"Az személy neve: {Nev}";
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
            set
            {
                if (value.Length < 7)
                {
                    _NeptunKod = value;
                }
                else
                {
                    Console.WriteLine("A Neptunkód nem lehet 6 számjegynél hosszabb!");
                    _NeptunKod = "123456";
                }
            }

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

            List<Hallgato> lista = new List<Hallgato>();

            /*Szemely tanulo = new Szemely("Kiss Máté", 19);

            Console.WriteLine(tanulo);

            BankSzamla szamla = new BankSzamla(1000);

            Console.WriteLine(szamla.Egyenleg);

            szamla.Betesz(500);

            Console.WriteLine(szamla.Egyenleg);

            szamla.Kivesz(750);

            Console.WriteLine(szamla.Egyenleg);

            Hallgato hallgato = new Hallgato("654123", "Kiss Anita", 21);

            Console.WriteLine(hallgato._NeptunKod);*/

            Hallgato hallgato1 = new Hallgato("000001", "Kiss Anita", 21);

            lista.Add(hallgato1);

            Hallgato hallgato2 = new Hallgato("000002", "Kiss Máté", 22);

            lista.Add(hallgato2);

            Hallgato hallgato3 = new Hallgato("000003", "Kiss András", 23);

            lista.Add(hallgato3);

            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }


        }
    }
}
