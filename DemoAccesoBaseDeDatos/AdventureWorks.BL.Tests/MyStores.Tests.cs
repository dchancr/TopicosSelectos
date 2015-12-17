using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdventureWorks.BL.Tests
{
    [TestClass]
    public class MyStoresTests
    {
        [TestMethod]
        public void QueryByName()
        {
            const string patron = "Bike";
            var cantidadMinimaEsperada = 1;
            var cantidadReal = 0;

            // invoque al método que consulta en la tabla de stores
            var repos = new AdventureWorks2014.BL.Repositorios.RepStores();
            var listaStores = repos.ListarStoresPorNombre(patron);
            var myStore = new AdventureWorks2014.Model.Models.Store ();
            cantidadReal = listaStores.Count();

            Assert.IsTrue(cantidadReal >= cantidadMinimaEsperada);
        }
    }
}
