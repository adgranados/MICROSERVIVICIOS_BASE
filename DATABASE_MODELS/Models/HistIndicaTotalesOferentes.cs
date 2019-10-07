namespace DATABASE_MODELS.Models
{
    public partial class HistIndicaTotalesOferentes
    {
        public int Id { get; set; }
        public int IdAgencia { get; set; }
        public int EntId { get; set; }
        public int Mes { get; set; }
        public int Year { get; set; }
        public int IdIndicador { get; set; }
        public int? Valor { get; set; }

        public virtual EntEntidad Ent { get; set; }
        public virtual Agencia IdAgenciaNavigation { get; set; }
        public virtual IndicadoresTotalesPorGrupo IdIndicadorNavigation { get; set; }
    }
}
