namespace DATABASE_MODELS.Models
{
    public partial class TarTarifaInicial
    {
        public int TarIniId { get; set; }
        public string TarIniConcepto { get; set; }
        public decimal TarIniValor { get; set; }
        public int TarIniPrfId { get; set; }
        public decimal ValorCuota { get; set; }
    }
}
