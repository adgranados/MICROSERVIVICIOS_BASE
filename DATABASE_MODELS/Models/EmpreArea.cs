using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class EmpreArea
    {
        public EmpreArea()
        {
            EmpreAreaPaisRela = new HashSet<EmpreAreaPaisRela>();
            PersonasEmpresa = new HashSet<PersonasEmpresa>();
        }

        public string EmpreAreaId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<EmpreAreaPaisRela> EmpreAreaPaisRela { get; set; }
        public virtual ICollection<PersonasEmpresa> PersonasEmpresa { get; set; }
    }
}
