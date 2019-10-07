using System;

namespace DATABASE_MODELS.Models
{
    public partial class SSesiones
    {
        public int SessionId { get; set; }
        public int PersoId { get; set; }
        public int RolId { get; set; }
        public string Ip { get; set; }
        public DateTime Expiration { get; set; }
        public int PostuPersoId { get; set; }
        public string InterOrgaId { get; set; }

        public virtual SRoles Rol { get; set; }
    }
}
