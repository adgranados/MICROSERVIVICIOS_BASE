using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class SUsuariosEmpresa1
    {
        public SUsuariosEmpresa1()
        {
            AdminCorreos = new HashSet<AdminCorreos>();
            ConsulPerso = new HashSet<ConsulPerso>();
            ProceUsuario = new HashSet<ProceUsuario>();
            ProduInterOrgaPublicaciones = new HashSet<ProduInterOrgaPublicaciones>();
        }

        public int PersoId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Estado { get; set; }
        public int Sesiones { get; set; }
        public int RolId { get; set; }
        public int SeguPregId { get; set; }
        public string SeguResp { get; set; }
        public int? RespoPersoId { get; set; }
        public bool? AceptaTermCond { get; set; }
        public bool? AceptaTratDatos { get; set; }
        public int? IdSede { get; set; }
        public string Clave { get; set; }

        public virtual Sedes IdSedeNavigation { get; set; }
        public virtual PersonasEmpresa Perso { get; set; }
        public virtual SRoles Rol { get; set; }
        public virtual ICollection<AdminCorreos> AdminCorreos { get; set; }
        public virtual ICollection<ConsulPerso> ConsulPerso { get; set; }
        public virtual ICollection<ProceUsuario> ProceUsuario { get; set; }
        public virtual ICollection<ProduInterOrgaPublicaciones> ProduInterOrgaPublicaciones { get; set; }
    }
}
