namespace DATABASE_MODELS.Models
{
    public partial class EstuNivelPaisRela
    {
        public string EstuNivelId { get; set; }
        public string PaisId { get; set; }

        public virtual EstuNivel EstuNivel { get; set; }
        public virtual PaisesHome Pais { get; set; }
    }
}
