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

        public Harcos(string nev, int szint, int tapasztalat, int eletero, int alapEletero, int alapSebzes)
        {
            this.nev = nev;
            this.szint = szint;
            this.tapasztalat = tapasztalat;
            this.eletero = eletero;
            this.alapEletero = alapEletero;
            this.alapSebzes = alapSebzes;
        }

        public string Nev
        {
            get {return nev;}
        }
        public int Szint
        {
            get
            {return szint;}
            set
            {
                value=1;
            }
        }
        public int Eletero
        {
            get
            {
                return eletero;
            }
            
        }
        public int Tapasztalat
        {
            get
            {
                return tapasztalat;
            }
            set
            {
                value = 0;
            }
        }
        public int AlapEletero
        {
            get
            {
                return alapEletero;
            }
            
        }
        public int AlapSebzes
        {
            get
            {
                return alapSebzes;
            }
        }
        public int Sebzes
        {
            get
            {
                return alapSebzes+szint;
            }
        }
        public int SzintLepeshez
        {
            get { return 10+szint * 5; }
        }

        public int MaxEletero
        {
            get
            {
                return alapEletero+szint*3;
            }
        }

        public void Megkuzd(Harcos masikHarcos)
        {

          
        }
        public void Gyogyul()
        {

        }
    }

}
