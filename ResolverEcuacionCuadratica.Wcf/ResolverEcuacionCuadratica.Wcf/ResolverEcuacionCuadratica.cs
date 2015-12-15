using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using REcuacionCuadratica;

namespace REcuacionCuadratica.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ResolverEcuacionCuadratica : IResolverEcuacionCuadratica
    {
        public void ResolverLaEcuacionCuadratica(Double Primer,Double Segundo,Double Tercer,Double Discriminante,ref Double Raiz1, ref Double Raiz2)
        {
             ResolverEcuacionCuadratica resolverEcuacion = new ResolverEcuacionCuadratica();

            resolverEcuacion.ResolverLaEcuacionCuadratica(Primer,Segundo,Tercer,Discriminante,ref Raiz1, ref Raiz2);
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
