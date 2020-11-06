using DataFit.DomainService;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DataFitTests
{
    [TestClass]
    public class ProductoTest
    {
        ProductoLog clientes = new ProductoLog();


        [TestMethod]
        public void ValidarNombreProducto()
        {
            //arrange
            string nombreP = "Producto1";

            //acts
            var resultado = clientes.ValidarNombre(nombreP);

            //assert
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void ValidarDescripcionProducto()
        {
            //arrange
            string descripcionP = "Producto1 pamper 123";

            //acts
            var resultado = clientes.ValidarDescripcion(descripcionP);

            //assert
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void ValidarPrecioRealProducto()
        {
            //arrange
            int preR = 5;

            //acts
            var resultado = clientes.ValidarPrecioReal(preR);

            //assert
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void ValidarPrecioVentaProducto()
        {
            //arrange
            int preV = 5;

            //acts
            var resultado = clientes.ValidarPrecioReal(preV);

            //assert
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void ValidarFechaProducto()
        {
            //arrange
            DateTime fechaC = DateTime.Today;

            //acts
            var resultado = clientes.ValidarFechaCreacion(fechaC);

            //assert
            Assert.IsTrue(resultado);

        }

    }
}
