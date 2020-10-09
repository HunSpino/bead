using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarcosProjekt
{
    class Harcos
    {
        private string nev;
        private int szint;
        private int tapasztalat;
        private int eletero;
        private int alapEletero;
        private int alapSebzes;

        public Harcos(string nev,int ertekAlapsablon)
        {
            this.nev = nev;
            this.szint = 1;
            this.Tapasztalat = 0;

            switch (ertekAlapsablon)
            {
                case 1: this.alapEletero = 15;this.alapSebzes = 3;break;
                case 2: this.alapEletero = 12; this.alapSebzes = 4; break;
                case 3: this.alapEletero = 8; this.alapSebzes = 5; break;

                default:this.alapEletero = 15; this.alapSebzes = 3;break;
            }
            this.eletero = alapEletero;

        }
        public string Nev
        {
            get => nev;
            set => nev = value;
        }
        public int Szint
        {
            get => szint;
            set
            {
                if (value>szint+1)
                {
                    value = szint;
                }
                szint = value;
            }
        }
        
        public int Tapasztalat
        {
            get => tapasztalat;

            set
            {

                if (value > SzintLepeshez)
                {
                    Szint++;
                    Tapasztalat = value - SzintLepeshez;
                    Eletero = MaxEletero;
                }

            }
        }
        public int Eletero 
        { 
            get => eletero;
            set
            {
                if (value == 0)
                {
                    Tapasztalat = 0;
                }
                if (value > MaxEletero)
                {
                    value = MaxEletero;
                }
                if (value < 0)
                {
                    value = 0;
                }
                Eletero = value;
            }
        }
        public int AlapEletero 
        { 
            get => alapEletero; 
        }
        public int AlapSebzes 
        { 
            get => alapSebzes; 
        }
        public int Sebzes
        {
            get
            {
                return alapSebzes + szint;
            }
        }
        public int SzintLepeshez
        {
            get
            {
                return 10 + szint * 5;
            }
        }

        public int MaxEletero
        {
            get
            {
                var s = alapEletero + (szint * 3);
                return s;
            }
        }
        public void Megkuzd(Harcos egyik, Harcos masik)
        {
            if (egyik.Nev == masik.Nev)
            {
                Console.WriteLine("A nevek ne egyezzenek meg,válassz másik nevet");
            }
            else if (egyik.Eletero == 0 || masik.Eletero == 0)
            {
                Console.WriteLine("A küzdelem véget ért");
            }
            else
            {
                masik.eletero -= egyik.Sebzes;
                if (masik.eletero > 0)
                {
                    egyik.tapasztalat += 5;
                    masik.tapasztalat += 5;
                }
                else
                {
                    egyik.tapasztalat += 5;
                }
            }

        }
        public void Gyogyul()
        {
            if (this.Eletero < 1)
            {
                Eletero = MaxEletero;
            }
            else
            {
                Eletero = 3 + szint;
            }
        }
        public override string ToString()
        {
            string st = string.Format("Név: {0}\t Szint:{1}\t EXP: {2}/{3}\t Életerő:{4}/{5}\t Sebzés: {6}", this.nev, this.szint, this.tapasztalat, SzintLepeshez, this.eletero, this.MaxEletero, this.Sebzes);
            return st;
        }
    }

}
