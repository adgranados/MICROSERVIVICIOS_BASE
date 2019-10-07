namespace DATABASE_MODELS.Models
{
    public partial class EmpreSectorPaisRela
    {
        public string EmpreSectoId { get; set; }
        public string PaisId { get; set; }

        public virtual PaisesHome Pais { get; set; }
    }
}
