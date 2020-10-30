using DataFit.DomainService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataFitTests
{
    [TestClass]
    public class ProductoTest
    {
        ProductoLog clientes = new ProductoLog();

        [TestMethod]
        public void ValidarPrecioProducto()
        {
            //arrange
            int pre = 5;

            //acts
            var resultado = clientes.ValidarPrecio(pre);

            //assert
            Assert.IsTrue(resultado);

        }

    }
}
