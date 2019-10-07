namespace DATABASE_MODELS.Models
{
    public partial class PcdProcesoCausalDescarteEliminados
    {
        public int PosId { get; set; }
        public int CdcId { get; set; }
        public string PdcObservacion { get; set; }
        public decimal? PdcSalario { get; set; }
    }
}
