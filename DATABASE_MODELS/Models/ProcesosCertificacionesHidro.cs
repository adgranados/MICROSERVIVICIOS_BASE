using System;

namespace DATABASE_MODELS.Models
{
    public partial class ProcesosCertificacionesHidro
    {
        public int Id { get; set; }
        public string CodigoCertificadoDeptal { get; set; }
        public string CodigoCertificadoNal { get; set; }
        public DateTime? FechaCertificadoDeptal { get; set; }
        public DateTime? FechaCertificadoNal { get; set; }
        public int? AgenteIdCertificadoDeptal { get; set; }
        public int? AgenteIdCertificadoNal { get; set; }
        public int? SedeId { get; set; }
        public int? ProcesoId { get; set; }
        public int? MotivoIdCertificadoDeptal { get; set; }
        public int? MotivoIdCertificadoNal { get; set; }
        public int? ResultadoMatch { get; set; }
        public int? TotalRemitidos { get; set; }
        public int? TotalColocados { get; set; }

        public virtual PersonasAgencia AgenteIdCertificadoDeptalNavigation { get; set; }
        public virtual PersonasAgencia AgenteIdCertificadoNalNavigation { get; set; }
        public virtual Sedes Sede { get; set; }
    }
}
