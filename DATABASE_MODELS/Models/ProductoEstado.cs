using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class ProductoEstado
    {
        public ProductoEstado()
        {
            ProduInterOrga = new HashSet<ProduInterOrga>();
        }

        public string ProduEstaId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<ProduInterOrga> ProduInterOrga { get; set; }
    }
}
