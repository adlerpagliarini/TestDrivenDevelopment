using System;
using System.Collections.Generic;
using System.Text;

namespace TestDrivenDevelopment.Capitulo_08
{
    public class NotaFiscalSAP : IAcaoAposGerarNota
    {
        public virtual void AcaoAposGerarNotaFiscal(NotaFiscal notaFiscal)
        {
            Envia(notaFiscal);
        }

        public virtual string Envia(NotaFiscal notaFiscal)
        {
            return "SAP Envia";
        }
    }
}
