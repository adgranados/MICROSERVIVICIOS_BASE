namespace DATABASE_MODELS.Models
{
    public partial class HistoricoTotalesVacantes
    {
        public int Id { get; set; }
        public int IdAgencia { get; set; }
        public int EntId { get; set; }
        public int Mes { get; set; }
        public int Year { get; set; }
        public int IdIndicador { get; set; }
        public int? Valor { get; set; }
    }
}
