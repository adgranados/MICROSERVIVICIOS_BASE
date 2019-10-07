using System;

namespace DATABASE_MODELS.Models
{
    public partial class PersonaBeneficiarioSubsidio
    {
        public int IdBeneficiarioSubsidio { get; set; }
        public int PersoId { get; set; }
        public DateTime Fecha { get; set; }
        public int AgenciaId { get; set; }
        public int PersoIdAsesor { get; set; }
        public DateTime? FechaAsignacionBeneficio { get; set; }

        public virtual Agencia Agencia { get; set; }
        public virtual Personas Perso { get; set; }
        public virtual PersonasAgencia PersoIdAsesorNavigation { get; set; }
    }
}
