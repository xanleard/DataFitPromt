using System;

namespace DataFit.DomainService
{
    public class Class1
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
