using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
   public class CalcularRaices
    {
        public void CalculoRaices(double discriminante,double primerNumero,double segundoNumero,double tercerNumero, ref double primerRaiz, ref double segundaRaiz)
        {
            primerRaiz=(-segundoNumero+Math.Sqrt(discriminante))/(2 * primerNumero);
            segundaRaiz=(-segundoNumero+Math.Sqrt(discriminante))/(2 * primerNumero);
        }
    }
}
