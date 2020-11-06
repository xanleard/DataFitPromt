using DataFit.DomainService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataFitTests
{
    [TestClass]
    public class DetalleFacturasTest
    {
        DetalleFacturasLog detalleFactura = new DetalleFacturasLog();

        [TestMethod]
        public void ValidarTotalFactura()
        {
            //arrange
            int cantidad = 12;

            //acts
            var resultado = detalleFactura.ValidarCantidadDetalle(cantidad);

            //assert
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void ValidarSubTotalFactura()
        {
            //arrange
            double precio = 10.00;

            //acts
            var resultado = detalleFactura.ValidarPrecioDetalle(precio);

            //assert
            Assert.IsTrue(resultado);

        }

    }
}
