using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Postulaciones
    {
        public Postulaciones()
        {
            HistPostuOferente = new HashSet<HistPostuOferente>();
        }

        public int SedeId { get; set; }
        public int ProcesoId { get; set; }
        public int PersoId { get; set; }
        public DateTime? PostuFecha { get; set; }
        public string CartaPresen { get; set; }
        public bool? Estado { get; set; }
        public bool? PostulacionVoluntaria { get; set; }
        public int PosId { get; set; }
        public bool? VoluntariaTercero { get; set; }
        public int? MotDeclinaId { get; set; }
        public string MotDeclinaOtro { get; set; }
        public string DepartamentoId { get; set; }
        public string DeclinaRol { get; set; }

        public virtual Personas Perso { get; set; }
        public virtual AcpAdminCandPost AcpAdminCandPost { get; set; }
        public virtual ICollection<HistPostuOferente> HistPostuOferente { get; set; }
    }
}
