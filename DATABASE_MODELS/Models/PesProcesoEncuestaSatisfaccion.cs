namespace DATABASE_MODELS.Models
{
    public partial class PesProcesoEncuestaSatisfaccion
    {
        public int ProcesoId { get; set; }
        public int InterOrgaId { get; set; }
        public int EnpId { get; set; }
        public bool TotalmenteDeAcuerdo { get; set; }
        public bool BastanteDeAcuerdo { get; set; }
        public bool DeAcuerdo { get; set; }
        public bool PocoDeAcuerdo { get; set; }
        public bool EnDesacuerdo { get; set; }

        public virtual EnpEncuestaPreguntas Enp { get; set; }
        public virtual Procesos Procesos { get; set; }
    }
}
