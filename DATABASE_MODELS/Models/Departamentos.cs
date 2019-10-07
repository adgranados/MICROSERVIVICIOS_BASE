using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Departamentos
    {
        public Departamentos()
        {
            Agencia = new HashSet<Agencia>();
            UsrUsuario = new HashSet<UsrUsuario>();
        }

        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string Nombre { get; set; }

        public virtual Paises Pais { get; set; }
        public virtual ICollection<Agencia> Agencia { get; set; }
        public virtual ICollection<UsrUsuario> UsrUsuario { get; set; }
    }
}
