using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ResolverEcuacionCuadratica
{
    class ResolverEcuacionCuadratica
    {
        public void ResolverLaEcuacionCuadratica(double primerNumero, double segundoNumero, double tercerNumero, ref double primeraRaiz, ref double segundaRaiz)
        {
            //calcular discriminante
            CalcularDiscriminante accionCalcularcDiscriminante = new CalcularDiscriminante();
            double discriminante = accionCalcularcDiscriminante.CalculoDiscriminante(primerNumero, segundoNumero, tercerNumero);
            //validar discriminante
            ValidarDiscriminante validacionDiscriminante = new ValidarDiscriminante();

            if (validacionDiscriminante.ValidarDiscriminanteMayorqueCero(discriminante))
            {
                //calcular raices
                CalcularRaices accionCalcularRaices = new CalcularRaices();
                accionCalcularRaices.CalculoRaices(discriminante, primerNumero, segundoNumero, tercerNumero, ref primeraRaiz, ref segundaRaiz);
            }else{
                //excepcion
                Exception ex = new Exception(string.Format("Ocurrio un error al calcular las raices, ya que el discriminante"
                    +"[(0)]es menor que [(0)]", discriminante.ToString(),"0.0"));
                throw ex;
            }
        }
    }
}
