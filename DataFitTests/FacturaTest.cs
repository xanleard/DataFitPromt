using DataFit.DomainService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFitTests
{
    [TestClass]
    public class FacturaTest
    {

        FacturaLog factura = new FacturaLog();

        [TestMethod]
        public void ValidarTotalFactura()
        {
            //arrange
            int total = 1500;

            //acts
            var resultado = factura.ValidarTotalFactura(total);

            //assert
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void ValidarSubTotalFactura()
        {
            //arrange
            int subT = 1000;

            //acts
            var resultado = factura.ValidarSubTotalFactura(subT);

            //assert
            Assert.IsTrue(resultado);

        }

    }
}
