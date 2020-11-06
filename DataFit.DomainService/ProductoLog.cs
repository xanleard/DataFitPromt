using System;

namespace DataFit.DomainService
{
    public class ProductoLog
    {

        public bool ValidarNombre(string nombre)
        {
            if (nombre != "")
            {
                return true;
            }
            return false;

        }

        public bool ValidarDescripcion(string descipcion)
        {
            if (descipcion != "")
            {
                return true;
            }
            return false;

        }

        public bool ValidarPrecioReal(int precioR)
        {
            if (precioR > 0)
            {
                return true;
            }
            return false;

        }

        public bool ValidarPrecioVenta(int precioV)
        {
            if (precioV > 0)
            {
                return true;
            }
            return false;

        }

        public bool ValidarDiferenciaPrecio(int precioV , int precioR)
        {
            if (precioR < precioV)
            {
                return true;
            }
            return false;

        }

        public bool ValidarFechaCreacion(DateTime fechaCreacion)
        {
            if (fechaCreacion >= DateTime.Today)
            {
                return true;
            }
            return false;

        }


    }
}
