using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class RolRol
    {
        public RolRol()
        {
            RobRolObjeto = new HashSet<RobRolObjeto>();
            RusRolUsuario = new HashSet<RusRolUsuario>();
        }

        public int RolId { get; set; }
        public string RolNombre { get; set; }

        public virtual ICollection<RobRolObjeto> RobRolObjeto { get; set; }
        public virtual ICollection<RusRolUsuario> RusRolUsuario { get; set; }
    }
}
