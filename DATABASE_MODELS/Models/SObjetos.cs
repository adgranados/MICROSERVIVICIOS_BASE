using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class SObjetos
    {
        public SObjetos()
        {
            SRolObje = new HashSet<SRolObje>();
        }

        public int ObjetoId { get; set; }
        public string Nombre { get; set; }
        public string ObjeTipoId { get; set; }
        public string Label { get; set; }
        public int Owner { get; set; }
        public string Data { get; set; }
        public string ImagePath { get; set; }
        public int? Orden { get; set; }
        public int? IdCodigoModulo { get; set; }

        public virtual ICollection<SRolObje> SRolObje { get; set; }
    }
}
