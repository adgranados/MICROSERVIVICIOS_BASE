namespace DATABASE_MODELS.Models
{
    public partial class MonePaisRela
    {
        public string MoneId { get; set; }
        public string PaisId { get; set; }

        public virtual Monedas Mone { get; set; }
        public virtual PaisesHome Pais { get; set; }
    }
}
