using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class ProductoTipo
    {
        public ProductoTipo()
        {
            Producto = new HashSet<Producto>();
        }

        public string ProduTipoId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Producto> Producto { get; set; }
    }
}
