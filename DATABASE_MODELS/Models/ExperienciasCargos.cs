namespace DATABASE_MODELS.Models
{
    public partial class ExperienciasCargos
    {
        public int Id { get; set; }
        public int PersoId { get; set; }
        public string CargoId { get; set; }
        public int Meses { get; set; }
    }
}
