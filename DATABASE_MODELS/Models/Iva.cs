using System;

namespace DATABASE_MODELS.Models
{
    public partial class Iva
    {
        public int IvaId { get; set; }
        public string Descripcion { get; set; }
        public decimal? Valor { get; set; }
        public DateTime? FechaCreacion { get; set; }
    }
}
