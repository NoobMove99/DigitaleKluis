using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitaleKluis
{
    class DigitaleKluis
    {
        private int code;
        private bool canshowcode;
        private int level;
        private int codecounter;
        public DigitaleKluis(int kode)
        {
            code = kode;
        }
        

        public bool CanShowCode
        {
            get { return canshowcode; }
            set { canshowcode = value; }
        }
        public int CodeLevel
        {
            get
            {
                level = code / 1000;
                return level;
            }
        }

        public int Code
        {
            get
            {
                if (CanShowCode)
                {
                    return code;
                }
                else
                {
                    return -666;
                }
            }
            private set
            {
                code = value;
            }
        }
        public bool TryCode(int codetotry)
        {
            do
            {
                if (codetotry == -666)
                {
                    Console.WriteLine("De gebruiker is een cheater!");
                    codecounter++;
                }
                else
                {
                    Console.WriteLine("Deze code is niet correct");
                    codecounter++;
                }
            }
            while (codetotry != Code);
            Console.WriteLine("Deze code is geldig!");
            Console.WriteLine("De gebruiker heeft {0} keer geprobeerd",codecounter);
            return true;
        }
    }
}
