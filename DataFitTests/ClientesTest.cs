using DataFit.DomainService;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataFitTests
{
    [TestClass]
    public class ClientesTest 
    {
        ClienteLog clientes = new ClienteLog();

        [TestMethod]
        public void ValidarNombreCliente()
        {
            //arrange
            string nom = "Rudy Cardona";

            //acts
            var resultado = clientes.ValidarNombre(nom);

            //assert
            Assert.IsTrue(resultado);

        }
    }
}
