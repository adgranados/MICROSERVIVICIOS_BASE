using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            InterOrga = new HashSet<InterOrga>();
            Personas = new HashSet<Personas>();
            PersonasEmpresa = new HashSet<PersonasEmpresa>();
            UsrUsuario = new HashSet<UsrUsuario>();
        }

        public string CodTipoDocumento { get; set; }
        public string NombreTipoDocumento { get; set; }

        public virtual ICollection<InterOrga> InterOrga { get; set; }
        public virtual ICollection<Personas> Personas { get; set; }
        public virtual ICollection<PersonasEmpresa> PersonasEmpresa { get; set; }
        public virtual ICollection<UsrUsuario> UsrUsuario { get; set; }
    }
}
