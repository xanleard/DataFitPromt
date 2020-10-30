using System;

namespace DataFit.DomainService
{
    public class ProductoLog
    {
        public bool ValidarPrecio(int precio)
        {
            if (precio > 0)
            {
                return true;
            }
            return false;

        }

    }
}
