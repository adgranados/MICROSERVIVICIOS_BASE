using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class AdjunTipo
    {
        public AdjunTipo()
        {
            Adjuntos = new HashSet<Adjuntos>();
        }

        public string AdjunTipoId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Adjuntos> Adjuntos { get; set; }
    }
}
