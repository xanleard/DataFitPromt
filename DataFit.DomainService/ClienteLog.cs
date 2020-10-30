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

    }
}
