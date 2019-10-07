using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Producto
    {
        public Producto()
        {
            ProduInterOrga = new HashSet<ProduInterOrga>();
        }

        public int ProduId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ProduTipoId { get; set; }
        public string Valor { get; set; }
        public int? DiasVencimiento { get; set; }
        public int? CantHv { get; set; }
        public int? CantClasificados { get; set; }

        public virtual ProductoTipo ProduTipo { get; set; }
        public virtual ICollection<ProduInterOrga> ProduInterOrga { get; set; }
    }
}
