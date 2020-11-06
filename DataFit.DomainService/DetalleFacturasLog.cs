using System;
using System.Collections.Generic;
using System.Text;

namespace DataFit.DomainService
{
    public class DetalleFacturasLog
    {
        public bool ValidarCantidadDetalle(int cantidad)
        {
            if (cantidad > 0)
            {
                return true;
            }
            return false;

        }

        public bool ValidarPrecioDetalle(double precio)
        {
            if (precio > 0.00)
            {
                return true;
            }
            return false;

        }
    }
}
