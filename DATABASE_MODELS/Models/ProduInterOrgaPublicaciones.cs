using System;

namespace DATABASE_MODELS.Models
{
    public partial class ProduInterOrgaPublicaciones
    {
        public int InterOrgaId { get; set; }
        public int ProcesoId { get; set; }
        public int ProduId { get; set; }
        public int ProduOr { get; set; }
        public DateTime Fecha { get; set; }
        public int PersoId { get; set; }
        public int Republicaciones { get; set; }

        public virtual SUsuariosEmpresa1 Perso { get; set; }
        public virtual ProduInterOrga ProduInterOrga { get; set; }
        public virtual Publicaciones Publicaciones { get; set; }
    }
}
