using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Ciudades
    {
        public Ciudades()
        {
            Agencia = new HashSet<Agencia>();
            MedioImpreso = new HashSet<MedioImpreso>();
            PersonasEmpresa = new HashSet<PersonasEmpresa>();
            UsrUsuario = new HashSet<UsrUsuario>();
            Veredas = new HashSet<Veredas>();
        }

        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<Agencia> Agencia { get; set; }
        public virtual ICollection<MedioImpreso> MedioImpreso { get; set; }
        public virtual ICollection<PersonasEmpresa> PersonasEmpresa { get; set; }
        public virtual ICollection<UsrUsuario> UsrUsuario { get; set; }
        public virtual ICollection<Veredas> Veredas { get; set; }
    }
}
