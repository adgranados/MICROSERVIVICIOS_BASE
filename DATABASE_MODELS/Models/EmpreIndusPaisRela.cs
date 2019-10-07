namespace DATABASE_MODELS.Models
{
    public partial class EmpreIndusPaisRela
    {
        public string EmpreIndusId { get; set; }
        public string PaisId { get; set; }

        public virtual EmpreIndus EmpreIndus { get; set; }
        public virtual PaisesHome Pais { get; set; }
    }
}
