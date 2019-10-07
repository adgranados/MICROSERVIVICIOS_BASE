namespace DATABASE_MODELS.Models
{
    public partial class CcnConceptoConvenio
    {
        public int CcnId { get; set; }
        public int CcnConvenio { get; set; }
        public string CcnConcepto { get; set; }
        public decimal CcnValor { get; set; }
        public int? CcnPrfId { get; set; }
    }
}
