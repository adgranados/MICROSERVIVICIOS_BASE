namespace DATABASE_MODELS.Models
{
    public partial class CcniConceptoInicial
    {
        public int CcniId { get; set; }
        public int CcniConvenio { get; set; }
        public string CcniConcepto { get; set; }
        public decimal CcniValorTotal { get; set; }
        public int CcniPfId { get; set; }
        public decimal CcniValorCuota { get; set; }
    }
}
