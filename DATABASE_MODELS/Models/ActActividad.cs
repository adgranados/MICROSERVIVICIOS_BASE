namespace DATABASE_MODELS.Models
{
    public partial class ActActividad
    {
        public int ActId { get; set; }
        public int ActCodigo { get; set; }
        public string ActNombre { get; set; }
        public int IndId { get; set; }
        public int SecId { get; set; }

        public virtual IndIndustria Ind { get; set; }
        public virtual SecSector Sec { get; set; }
    }
}
