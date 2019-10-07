using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class PubliEstado
    {
        public PubliEstado()
        {
            Publicaciones = new HashSet<Publicaciones>();
        }

        public string PubliEstaId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Publicaciones> Publicaciones { get; set; }
    }
}
