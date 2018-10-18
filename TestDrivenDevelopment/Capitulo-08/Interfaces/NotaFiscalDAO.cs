using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Capitulo_08
{
    public class NotaFiscalDAO : IAcaoAposGerarNota
    {
        public virtual void AcaoAposGerarNotaFiscal(NotaFiscal notaFiscal)
        {
            Persiste(notaFiscal);
        }

        public virtual string Persiste(NotaFiscal notaFiscal)
        {
            return "NotaFiscalDAO";
        }
    }
}
