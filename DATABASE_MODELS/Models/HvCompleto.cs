namespace DATABASE_MODELS.Models
{
    public partial class HvCompleto
    {
        public int ItemId { get; set; }
        public string Descripcion { get; set; }
        public int? Puntaje { get; set; }
        public string Sp { get; set; }
        public string Link { get; set; }
        public bool? PostuReque { get; set; }
    }
}
