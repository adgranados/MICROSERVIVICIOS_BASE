using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Paises
    {
        public Paises()
        {
            Agencia = new HashSet<Agencia>();
            Departamentos = new HashSet<Departamentos>();
            PersonasAdmin = new HashSet<PersonasAdmin>();
            UsrUsuario = new HashSet<UsrUsuario>();
        }

        public string PaisId { get; set; }
        public string Nombre { get; set; }
        public string Nacionalidad { get; set; }

        public virtual ICollection<Agencia> Agencia { get; set; }
        public virtual ICollection<Departamentos> Departamentos { get; set; }
        public virtual ICollection<PersonasAdmin> PersonasAdmin { get; set; }
        public virtual ICollection<UsrUsuario> UsrUsuario { get; set; }
    }
}
