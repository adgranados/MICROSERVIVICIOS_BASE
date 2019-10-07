namespace DATABASE_MODELS.Models
{
    public partial class EduInstiPaisRela
    {
        public string InstiId { get; set; }
        public string PaisId { get; set; }

        public virtual EduInsti Insti { get; set; }
    }
}
