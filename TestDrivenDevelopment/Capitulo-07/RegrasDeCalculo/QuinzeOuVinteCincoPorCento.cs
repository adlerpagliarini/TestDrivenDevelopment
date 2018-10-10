﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Capitulo_07
{
    public sealed class QuinzeOuVinteCincoPorCento : RegraDeCalculo
    {
        protected override int Limite()
        {
            return 2500;
        }

        protected override double PorcentagemAcimaDoLimite()
        {
            return 0.75;
        }

        protected override double PorcentagemBase()
        {
            return 0.85;
        }
    }
}
