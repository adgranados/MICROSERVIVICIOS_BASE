using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class EscEstadoCandidatura
    {
        public EscEstadoCandidatura()
        {
            AcpAdminCandPost = new HashSet<AcpAdminCandPost>();
        }

        public int EscId { get; set; }
        public string EscNombre { get; set; }

        public virtual ICollection<AcpAdminCandPost> AcpAdminCandPost { get; set; }
    }
}
