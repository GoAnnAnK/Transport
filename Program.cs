using System;

namespace Paskaita_9_Uzduotis
{
    class Program
    {
        //Paveldejimai

        /*UZDUOTS
     * Klasės: TransportoPriemone, Masina, Sunkvezimis, Motociklas
    ● Bendri duomenys: ratų sk., markė, spalva
    ● Bendri netodai: Judeti(), Sustok(), Kairen(), Desinen()
    ● Kiekviena vaikinė klasė turi pridėti
    ○ bent du naujus laukus
    ○ bent du naujus metodus*/
        static void Main(string[] args)
        {
            var auto = new Auto(4, "VW", "Juoda");
            var fura = new Fura(12, "MB", "Sidabrine");
            var bike = new Bike(2, "Suzuki", "Raudona");

         //   Console.WriteLine(auto);
         //   Console.WriteLine(fura);
         //   Console.WriteLine(bike);

            auto.Prisistatyk();
            auto.Judek();
            Auto.KuroTipas("Elektra"); 
            auto.Amzius(3);

            

        }
    }
    class Transport
    {
        protected  int _ratai;
        protected string _marke;
        protected  string _spalva;
        //public string _name;

        public void Judek()
        {
            Console.WriteLine("As vaziuoju pirmin!!!");
        }
        public void Sustok()
        {
            Console.WriteLine("OOouuuu, raudona!!! \n As sustojau.");;
        }
        public void Kairen()
        {
            Console.WriteLine("Pavojingas manevras i kaire :O ");
        }
        public void Desinen()
        {
            Console.WriteLine("I desne visada laisva!!! ");
        }
    }

    class Auto : Transport
    {
        public Auto(int ratai, string marke, string spalva) : base()
        {
            _ratai = ratai;
            _marke = marke;
            _spalva = spalva;
          
        }

        protected readonly string _kebulas;
        private string _vietos;

        public static void KuroTipas(string kuras)
        {
            kuras = "elektra";
            Console.WriteLine($"Mano maistas {kuras}");
        }


        public void Amzius(int amzius)
        {
            //amzius = 3;
            Console.WriteLine($"Man {amzius} metai");

        }
        public void Prisistatyk() 
        {
            Console.WriteLine($"------------\n Labas! As Auto {_kebulas}:) \n As turiu {_ratai} ratus. \n Mano logo {_marke} \n Mano spalva {_spalva} \n Galiu vezti {_vietos} keleiviu. ");
        }
    }
    class Fura : Transport
    {
        public Fura(int ratai, string marke, string spalva) : base()
        {
            _ratai = ratai;
            _marke = marke;
            _spalva = spalva;
            Console.WriteLine($"------\nFURA\n As turiu {_ratai} ratu. \n Mano logo {_marke} \n Mano spalva {_spalva} ");
        }
        private string _keliamojiJega;
        private string _krovimoTipas;

        public void KrovTalpa(int talpa)
        {

        }
        public void VairuotuojuSk(int vairuotojas)
        {

        }
    }
    class Bike : Transport
    {
        public Bike(int ratai, string marke, string spalva) : base()
        {
            _ratai = ratai;
            _marke = marke;
            _spalva = spalva;
            Console.WriteLine($"-----\n BIKE\n As turiu {_ratai} ratus. \n Mano logo {_marke} \n Mano spalva {_spalva} ");
        }
        private string _tipas;
        private string _svoris;

        public void TopIsibegejimas(int laikas)
        {

        }

        public void MaxKuras(int maxK)
        {

        }


    }
}
