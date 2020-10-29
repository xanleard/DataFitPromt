using System;
using System.Collections.Generic;
using System.Text;

namespace DataFit.DataBase.Models
{
   public class Productos
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal PrecioReal { get; set; }

        public decimal PrecioVenta { get; set; }

        public DateTime FechaCreacion { get; set; }

        public DateTime FechaModificacion { get; set; }

        public ICollection<DetalleFactura> DetalleFacturas { get; set; }

    }
}
