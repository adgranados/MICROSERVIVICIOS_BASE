using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class FfdFosfecDetalleVersion
    {
        public FfdFosfecDetalleVersion()
        {
            FfaFosfecCriteriosAudit = new HashSet<FfaFosfecCriteriosAudit>();
        }

        public int FfdId { get; set; }
        public int FfvId { get; set; }
        public int PersoId { get; set; }
        public long FfvSalario { get; set; }
        public string FfvCriterio1 { get; set; }
        public string FfvCriterio2 { get; set; }
        public string FfvCriterio3 { get; set; }
        public string FfvCriterio4 { get; set; }
        public bool? FfvEstado { get; set; }
        public int? EntId { get; set; }

        public virtual FfvFosfecVersiones Ffv { get; set; }
        public virtual Personas Perso { get; set; }
        public virtual ICollection<FfaFosfecCriteriosAudit> FfaFosfecCriteriosAudit { get; set; }
    }
}
