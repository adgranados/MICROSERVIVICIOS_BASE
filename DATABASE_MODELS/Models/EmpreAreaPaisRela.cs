namespace DATABASE_MODELS.Models
{
    public partial class EmpreAreaPaisRela
    {
        public string EmpreAreaId { get; set; }
        public string PaisId { get; set; }

        public virtual EmpreArea EmpreArea { get; set; }
        public virtual PaisesHome Pais { get; set; }
    }
}
