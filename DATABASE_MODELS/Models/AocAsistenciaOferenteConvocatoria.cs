namespace DATABASE_MODELS.Models
{
    public partial class AocAsistenciaOferenteConvocatoria
    {
        public int CnvId { get; set; }
        public int PersoId { get; set; }
        public decimal HorasAsistidas { get; set; }
        public string EstadoAsistencia { get; set; }

        public virtual CnvConvocatoria Cnv { get; set; }
        public virtual Personas Perso { get; set; }
    }
}
