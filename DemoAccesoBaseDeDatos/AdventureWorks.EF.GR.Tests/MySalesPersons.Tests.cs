using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventureWorks2014.EF.GR;
using AdventureWorks2014.Model.Models;
using System.Linq;

namespace AdventureWorks.EF.GR.Tests
{
    [TestClass]
    public class MySalesPersonsTests
    {
        [TestMethod]
        public void QueryBySalesLastYear()
        {
            const decimal limite = (decimal)0.011;
            var cantidadMinimaEsperada = 1;
            var cantidadReal = 0;

            // invoque al método que consulta en la tabla de stores
            var repos = new  RepSalesPersons(true);
            repos.IsLazyLoading = false;
            var listaSalesPersons = repos.QueryPercentGreaterThan(limite).ToList();
            cantidadReal = listaSalesPersons.Count();

            Assert.IsTrue(cantidadReal >= cantidadMinimaEsperada);
        }
    }
}
