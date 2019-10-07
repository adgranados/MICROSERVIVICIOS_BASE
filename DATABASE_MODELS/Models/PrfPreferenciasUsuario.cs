using System;

namespace DATABASE_MODELS.Models
{
    public partial class PrfPreferenciasUsuario
    {
        public int PersoId { get; set; }
        public string CargoId { get; set; }
        public int? SectorId { get; set; }
        public int? EmpreIndusId { get; set; }
        public bool? PrfOfertasEmail { get; set; }
        public int? PerId { get; set; }
        public string EstuNivelId { get; set; }
        public string ContraTipoId { get; set; }
        public int? SalarioRangoId { get; set; }
        public int? ExrId { get; set; }
        public DateTime? PrfFechaEnvioMail { get; set; }

        public virtual ContraTipos ContraTipo { get; set; }
        public virtual EstuNivel EstuNivel { get; set; }
        public virtual ExrExperienciaRango Exr { get; set; }
        public virtual PerPeriodicidad Per { get; set; }
        public virtual Personas Perso { get; set; }
        public virtual SalarioRango SalarioRango { get; set; }
    }
}
