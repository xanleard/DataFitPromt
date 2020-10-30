using DataFit.DomainService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataFitTests
{
    [TestClass]
    public class ClientesTest 
    {
        Class1 clientes = new Class1();

        [TestMethod]
        public void ValidarPrecioProducto()
        {
            //arrange
            int pre = 0;

            //acts
            var resultado = clientes.ValidarPrecio(pre);

            //assert
            Assert.IsTrue(resultado);

        }
    }
}
