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
            get
            {
                return nev;
            }
        }
        public int Szint
        {
            get
            {
                return szint;
            }
            set
            {
                if (value>=0)
                {
                    szint = value;
                }
                else
                {
                    szint = 0;
                }
            }
        }
        public int Eletero
        {
            get
            {
                return eletero;
            }
            set
            {
                if (value >= 0)
                {
                    eletero = value;
                }
                else
                {
                    eletero = 0;
                }
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
                if (value >= 0)
                {
                    tapasztalat = value;
                }
                else
                {
                    tapasztalat = 0;
                }
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

            }
        }


    }
}
