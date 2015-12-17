using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorks.BL.Tests
{
    [TestClass]
    public class MySalesPersonsTests
    {
        [TestMethod]
        public void QueryBySalesLastYear()
        {
            const double limite = 0;
            var cantidadMinimaEsperada = 1;
            var cantidadReal = 0;

            // invoque al método que consulta en la tabla de stores
            var repos = new AdventureWorks2014.BL.Repositorios.RepSalesPersons();
            var listaSalesPersons = repos.QueryPercentGreaterThan(limite).ToList();
            //var primerSalesPerson = listaSalesPersons.FirstOrDefault();
            //var nomberPrimerSalesPerson = primerSalesPerson.CommissionPct;
            cantidadReal = listaSalesPersons.Count();

            Assert.IsTrue(cantidadReal >= cantidadMinimaEsperada);
        }
    }
}
