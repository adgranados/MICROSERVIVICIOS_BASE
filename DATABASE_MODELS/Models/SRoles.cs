using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class SRoles
    {
        public SRoles()
        {
            SRolObje = new HashSet<SRolObje>();
            SRolUsua = new HashSet<SRolUsua>();
            SSesiones = new HashSet<SSesiones>();
            SUsuarios = new HashSet<SUsuarios>();
            SUsuariosEmpresa1 = new HashSet<SUsuariosEmpresa1>();
        }

        public int RolId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<SRolObje> SRolObje { get; set; }
        public virtual ICollection<SRolUsua> SRolUsua { get; set; }
        public virtual ICollection<SSesiones> SSesiones { get; set; }
        public virtual ICollection<SUsuarios> SUsuarios { get; set; }
        public virtual ICollection<SUsuariosEmpresa1> SUsuariosEmpresa1 { get; set; }
    }
}
