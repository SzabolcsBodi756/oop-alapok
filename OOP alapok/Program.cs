using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP_alapok
{

    //1. feladat:
    public class Szemely
    {

        //8. feladat:
        protected string Nev { get; set; }

        //3. feladat:
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

        //2. feladat:
        public Szemely(string nev, int kor)
        {
            Nev = nev;
            Kor = kor;
        }

        //4. feladat:
        public override string ToString()
        {
            return $"Az személy neve: {Nev}";
        }


        //10. feladat, polimorf metódus:
        public virtual void Fizetes()
        {

        }
    }

    //5. feladat:
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

        //10. feladat, polimorf metódus:
        public void Kivesz(int minus)
        {
            Egyenleg -= minus >= 0 ? Egyenleg -= minus : Egyenleg = 0;
        }
    }

    //6. feladat:
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

        //10. feladat, polimorf metódus:
        public override void Fizetes()
        {
            Console.WriteLine("A hallgató jelenleg tanul, ezért nincs bére.");
        }

    }

    public class Dolgozo : Szemely
    {
        public int Ber { get; set; }
    
        public Dolgozo(int ber, string nev, int kor) : base(nev, kor)
        {
            Ber = ber;
        }

        public override void Fizetes()
        {
            Console.WriteLine($"A dolgozó már végez munkát, ez a bére: {Ber}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //lista a 9. feladathoz:
            List<Hallgato> lista = new List<Hallgato>();

            //kiíratások a különféle feladatokhoz kapcsolódóan:
            Szemely szemely = new Szemely("Kiss Máté", 19);

            Console.WriteLine(szemely);
            Console.WriteLine(szemely.Kor);

            BankSzamla szamla = new BankSzamla(1000);

            Console.WriteLine(szamla.Egyenleg);

            szamla.Betesz(500);

            Console.WriteLine(szamla.Egyenleg);

            szamla.Kivesz(750);

            Console.WriteLine(szamla.Egyenleg);

            //9. feladat:
            Hallgato hallgato = new Hallgato("654123", "Kiss Anita", 21);

            Console.WriteLine(hallgato._NeptunKod);

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

            //10. feladat:
            Dolgozo dolgozo = new Dolgozo(350000, "Dolgozó Béla", 43);

            dolgozo.Fizetes();

            hallgato1.Fizetes();
        }
    }
}
