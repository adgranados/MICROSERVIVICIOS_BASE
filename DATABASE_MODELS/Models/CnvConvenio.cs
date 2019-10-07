using System;

namespace DATABASE_MODELS.Models
{
    public partial class CnvConvenio
    {
        public int CnvId { get; set; }
        public int EntId { get; set; }
        public int CnvTscId { get; set; }
        public DateTime CnvFechaIniVig { get; set; }
        public DateTime CnvFechaFinVig { get; set; }
        public bool CnvRenovAutom { get; set; }
        public int CnvPrfContrato { get; set; }
        public decimal CnvTarifaInicial { get; set; }
        public int CnvTarId { get; set; }
        public int? CnvPrfFactura { get; set; }
        public int? CnvPrfRangos { get; set; }
        public int? CnvPrfOtros { get; set; }
        public int? CnvNoLic { get; set; }
        public int? CnvTotalLic { get; set; }
        public decimal? CnvValorRango { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public string CnvDireccion { get; set; }

        public virtual EntEntidad Ent { get; set; }
    }
}
