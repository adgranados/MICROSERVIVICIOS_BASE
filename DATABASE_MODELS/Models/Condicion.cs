namespace DATABASE_MODELS.Models
{
    public partial class Condicion
    {
        public int CondicionId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int? CantDias { get; set; }
    }
}
