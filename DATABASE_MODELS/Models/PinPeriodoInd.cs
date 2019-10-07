namespace DATABASE_MODELS.Models
{
    public partial class PinPeriodoInd
    {
        public int PinId { get; set; }
        public int TpeId { get; set; }
        public int Anio { get; set; }
        public int Valor { get; set; }

        public virtual TpeTipoPeriodoInd Tpe { get; set; }
    }
}
