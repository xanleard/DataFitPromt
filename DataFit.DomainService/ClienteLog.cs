using System;

namespace DataFit.DomainService
{
    public class ClienteLog
    {

        public bool ValidarNombre(string nombre)
        {
            if (nombre != "")
            {
                return true;
            }
            return false;

        }

        public bool ValidarDireccion(string direccion)
        {
            if (direccion != "")
            {
                return true;
            }
            return false;

        }


        public bool ValidarTelefono(int telefono)
        {
            if (telefono > 0)
            {
                return true;
            }
            return false;

        }
    }
}
