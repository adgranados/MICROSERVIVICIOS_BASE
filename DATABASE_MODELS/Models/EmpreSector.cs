namespace DATABASE_MODELS.Models
{
    public partial class EmpreSector
    {
        public string EmpreSectoId { get; set; }
        public string Nombre { get; set; }
        public string EmpreIndusId { get; set; }

        public virtual EmpreIndus EmpreIndus { get; set; }
    }
}
