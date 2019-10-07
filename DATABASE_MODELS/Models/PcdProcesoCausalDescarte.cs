namespace DATABASE_MODELS.Models
{
    public partial class PcdProcesoCausalDescarte
    {
        public int PosId { get; set; }
        public int CdcId { get; set; }
        public string PdcObservacion { get; set; }
        public decimal? PdcSalario { get; set; }

        public virtual CdcCausalesDescarte Cdc { get; set; }
        public virtual AcpAdminCandPost Pos { get; set; }
    }
}
