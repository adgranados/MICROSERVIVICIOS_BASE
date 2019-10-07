using System;

namespace DATABASE_MODELS.Models
{
    public partial class AprAuditPruebasProcesos
    {
        public int AprId { get; set; }
        public int? AprIdAnterior { get; set; }
        public DateTime AprFechaCambio { get; set; }
        public int PrpId { get; set; }
        public string TipMov { get; set; }
        public int StpId { get; set; }
        public string PrpNombre { get; set; }
        public string PrpDescripcion { get; set; }
        public string PrpComentarios { get; set; }
        public DateTime PrpFechaCrea { get; set; }
        public int PersoIdCre { get; set; }
        public DateTime? PrpFechaMod { get; set; }
        public int? PersoIdMod { get; set; }
        public int IdAgencia { get; set; }
        public int? PrpEstado { get; set; }
        public string PrpFile { get; set; }
    }
}
