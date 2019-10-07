namespace DATABASE_MODELS.Models
{
    public partial class AocAsistenciaOferenteConvocatoriaEliminados
    {
        public int CnvId { get; set; }
        public int PersoId { get; set; }
        public decimal HorasAsistidas { get; set; }
        public string EstadoAsistencia { get; set; }
    }
}
