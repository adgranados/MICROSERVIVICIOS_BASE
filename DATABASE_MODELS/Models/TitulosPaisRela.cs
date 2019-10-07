namespace DATABASE_MODELS.Models
{
    public partial class TitulosPaisRela
    {
        public string TituId { get; set; }
        public string PaisId { get; set; }

        public virtual PaisesHome Pais { get; set; }
    }
}
