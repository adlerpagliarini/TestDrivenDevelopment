using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment
{
    public class ConversorDeNumeroRomano
    {
        public int Converte(string numeroEmRomano)
        {
            if(numeroEmRomano.Equals("I"))
                return 1;
            if (numeroEmRomano.Equals("V"))
                return 5;
            if (numeroEmRomano.Equals("X"))
                return 10;

            return 0;
        }
    }
}
