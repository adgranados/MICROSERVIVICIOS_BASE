namespace DATABASE_MODELS.Models
{
    public partial class Clasificados
    {
        public int ClasificadoId { get; set; }
        public string Nombre { get; set; }
        public int? Columnas { get; set; }
        public int Centimetros { get; set; }
        public int NumCaracteresTitulo { get; set; }
        public int NumCaracteresDescripcion { get; set; }
        public int? NumCaracteresDescLogo { get; set; }
    }
}
