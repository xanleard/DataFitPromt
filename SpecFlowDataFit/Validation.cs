using System;

namespace SpecFlowDataFit
{
    public class Validation
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public string enables { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int ValitacionFacturaCero()
        {
                if (FirstNumber >= 0 )
                {
                    return FirstNumber;
                }
            return -1;
        }

        public int ProductoValidacion()
        {
            if (FirstNumber >= 0)
            {
                return FirstNumber;
            }
            return -1;
        }

        public int ValidarClienteActivo()
        {
            //1 activo 0 inactivo
            if (enables =="Activo")
            {
                return 1;
            }
            return 0;
        }

        public int ValidarNombreCliente()
        {
            //1 activo 0 inactivo
            if (enables != "ClienteTest")
            {
                return 1;
            }
            return 0;
        }

        public int ValidarNombreProducto()
        {
            //1 nombre valido  0 invalido
            if (enables != "" )
            {
                return 1;
            }
            return 0;
        }

        public int ValidarStrings()
        {
            //1 nombre valido  0 invalido
            if (enables != "")
            {
                return 1;
            }
            return 0;
        }
    }
}
