using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataFit.DataBase.Models
{
    public class DetalleFactura
    {
        public int Id { get; set; }

        public int Cantidad { get; set; }

        public decimal Precio { get; set; }

        [ForeignKey(nameof(Facturas))]
        public int FacturaId { get; set; }

        public Facturas Facturas { get; set; }


        [ForeignKey(nameof(Productos))]
        public int ProductoId { get; set; }

        public Productos Productos { get; set; }


    }
}
