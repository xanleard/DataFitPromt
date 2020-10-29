using System;
using System.Collections.Generic;
using System.Text;

namespace DataFit.DataBase.Models
{
    public class Clientes
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Dirrecion { get; set; }

        public string Telefono { get; set; }

        public DateTime FechaCreacion { get; set; }

        public ICollection<Facturas> SubFields { get; set; }

    }
}
