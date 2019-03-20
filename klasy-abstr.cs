using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    
    public abstract class Samochod
    {
        public abstract string WyswietlModel();
        public abstract string WyswietlKolor();
        public abstract int WyswietlPojemnosc();
    }
    
    class Fiat : Samochod
    {

        string model;
        string kolor;
        int pojemnosc;
        public override string WyswietlModel()
        {
            return model;
        }
        public override string WyswietlKolor()
        {
            return kolor;
        }
        public override int WyswietlPojemnosc()
        {
            return pojemnosc;
        }

        public Fiat (string m, string k, int p)
        {
            model = m;
            kolor = k;
            pojemnosc = p;
        }
    }

    class Opel : Samochod
    {
        string model;
        string kolor;
        int pojemnosc;

        public override string WyswietlModel()
        {
            return model;
        }
        public override string WyswietlKolor()
        {
            return kolor;
        }
        public override int WyswietlPojemnosc()
        {
            return pojemnosc;
        }

        public Opel(string m, string k, int p)
        {
            model = m;
            kolor = k;
            pojemnosc = p;
        }
    }

        class Program
    {
        static void Main(string[] args)
        {
            Samochod o = new Opel("Opel","czarny",1000);
            Samochod s = new Fiat("Fiat", "Czerwony", 900);
            ArrayList arr = new ArrayList();
            arr.Add(o);
            arr.Add(s);
            foreach(object i in arr)
            {
                Console.WriteLine(o.WyswietlModel());
                Console.WriteLine(o.WyswietlKolor());
                Console.WriteLine(o.WyswietlPojemnosc()+"\n");
            }

            Console.ReadLine();
        }
    }
}
