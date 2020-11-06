using System;
using System.Collections.Generic;
using System.Text;

namespace DataFit.DomainService
{
    public class FacturaLog
    {
        public bool ValidarTotalFactura(int total)
        {
            if (total > 0)
            {
                return true;
            }
            return false;

        }

        public bool ValidarSubTotalFactura(int subtotal)
        {
            if (subtotal > 0)
            {
                return true;
            }
            return false;

        }

    }
}
