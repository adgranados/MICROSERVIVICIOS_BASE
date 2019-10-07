namespace DATABASE_MODELS.Models
{
    public partial class HvHabi
    {
        public int PersoId { get; set; }
        public int HabiOrdi { get; set; }
        public string HabiId { get; set; }
        public string HabiNombre { get; set; }
        public int Nivel { get; set; }

        public virtual HvInfoBasica Perso { get; set; }
    }
}
