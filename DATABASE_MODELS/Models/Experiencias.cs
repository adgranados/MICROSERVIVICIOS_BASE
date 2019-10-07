namespace DATABASE_MODELS.Models
{
    public partial class Experiencias
    {
        public int PersoId { get; set; }
        public int Idgrupoocupacional { get; set; }
        public string GrupoOcupacional { get; set; }
        public int? Meses { get; set; }
    }
}
