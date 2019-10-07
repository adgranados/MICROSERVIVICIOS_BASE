namespace DATABASE_MODELS.Models
{
    public partial class HabiPaisRela
    {
        public string HabiId { get; set; }
        public string PaisId { get; set; }

        public virtual Habilidades Habi { get; set; }
        public virtual PaisesHome Pais { get; set; }
    }
}
