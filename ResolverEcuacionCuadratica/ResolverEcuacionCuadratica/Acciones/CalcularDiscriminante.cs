using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolverEcuacionCuadratica
{
    public class CalcularDiscriminante
    {
        public double CalculoDiscriminante(double primerNumero,double segundoNumero,double tercerNumero)
        {
            double resultado = 0;
            resultado = (Math.Pow(segundoNumero, 2)) - 4 * primerNumero + tercerNumero;
            return (resultado);
        }
    }
}
