namespace DATABASE_MODELS.Models
{
    public partial class PrfPerfiles
    {
        public int PrfId { get; set; }
        public string PrfNombre { get; set; }
        public int TpmId { get; set; }

        public virtual TpmTipoModulo Tpm { get; set; }
    }
}
