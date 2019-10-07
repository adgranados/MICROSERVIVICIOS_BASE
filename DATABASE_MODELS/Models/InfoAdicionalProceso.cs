namespace DATABASE_MODELS.Models
{
    public partial class InfoAdicionalProceso
    {
        public int ProcesoId { get; set; }
        public int SedeId { get; set; }
        public int ProgramaGobiernoId { get; set; }
        public int TipoPoblacion { get; set; }
        public int? TipoLocalicacion { get; set; }
        public int? LocalizacionId { get; set; }
        public string InfoAdiEmpleos { get; set; }
        public int? TipoDiscapacidad { get; set; }
        public int Id { get; set; }
    }
}
