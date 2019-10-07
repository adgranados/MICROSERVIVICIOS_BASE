namespace DATABASE_MODELS.Models
{
    public partial class Adjuntos
    {
        public int PersoId { get; set; }
        public int AdjunOr { get; set; }
        public string TipoAdjunId { get; set; }
        public string Nombre { get; set; }

        public virtual HvInfoBasica Perso { get; set; }
        public virtual AdjunTipo TipoAdjun { get; set; }
    }
}
