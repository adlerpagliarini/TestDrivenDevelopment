using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Capitulo_07
{
    public sealed class DezOuVintePorCento : RegraDeCalculo
    {
        protected override int Limite()
        {
            return 3000;
        }

        protected override double PorcentagemAcimaDoLimite()
        {
            return 0.8;
        }

        protected override double PorcentagemBase()
        {
            return 0.9;
        }
    }
}
