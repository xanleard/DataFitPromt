using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataFit.DataBase.Models
{
   public class Facturas
    {
        public int Id { get; set; }

        public decimal Total { get; set; }

        public decimal Subtotal { get; set; }

        public DateTime FechaCreacion { get; set; }

        [ForeignKey(nameof(Clientes))]
        public int ClienteId { get; set; }

        public Clientes Clientes { get; set; }

        public ICollection<DetalleFactura> DetalleFacturas { get; set; }

    }
}
