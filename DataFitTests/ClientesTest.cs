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


        [TestMethod]
        public void ValidarDireccionCliente()
        {
            //arrange
            string direccion = "Col. Potrerrillos";

            //acts
            var resultado = clientes.ValidarDireccion(direccion);

            //assert
            Assert.IsTrue(resultado);

        }

        [TestMethod]
        public void ValidarTelefonoCliente()
        {
            //arrange
            int telefono = 333333232;

            //acts
            var resultado = clientes.ValidarTelefono(telefono);

            //assert
            Assert.IsTrue(resultado);

        }

    }
}
