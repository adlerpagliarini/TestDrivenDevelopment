using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestDrivenDevelopment
{
    public class ConversorDeNumeroRomano
    {
        private Dictionary<string, int> tabelaNumeroRomano;
        public ConversorDeNumeroRomano()
        {
            tabelaNumeroRomano = new Dictionary<string, int>
            {
                {"I", 1},
                {"V", 5},
                {"X", 10},
                {"L", 50},
                {"C", 100},
                {"D", 500},
                {"M", 1000}
            };
        }
        public int Converte(string numeroEmRomano)
        {
            int ultimoVizinhoDaDireita = 0;
            return numeroEmRomano.Reverse().Aggregate(0, (acc, value) => {
                int valorAtual = tabelaNumeroRomano[value.ToString()];

                if (valorAtual < ultimoVizinhoDaDireita) acc -= valorAtual; else acc += valorAtual; 

                ultimoVizinhoDaDireita = valorAtual;
                return acc;
             });

            //return numeroEmRomano.Aggregate(0, (acc, value) => acc + tabelaNumeroRomano[value.ToString()]);

            /*return tabelaNumeroRomano.Aggregate(0, (acc, element) => 
                    element.Key == numeroEmRomano ? acc + element.Value : acc
            );*/
        }
    }
}
