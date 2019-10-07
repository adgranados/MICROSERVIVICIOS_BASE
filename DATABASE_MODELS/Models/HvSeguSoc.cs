namespace DATABASE_MODELS.Models
{
    public partial class HvSeguSoc
    {
        public int PersoId { get; set; }
        public string PensoEntiId { get; set; }
        public string PensvEntiId { get; set; }
        public string CesantEntiId { get; set; }
        public string SaludEntiId { get; set; }
        public string CompenEntiId { get; set; }

        public virtual SeguSocEnti CesantEnti { get; set; }
        public virtual SeguSocEnti CompenEnti { get; set; }
        public virtual SeguSocEnti PensoEnti { get; set; }
        public virtual SeguSocEnti PensvEnti { get; set; }
        public virtual HvInfoBasica Perso { get; set; }
    }
}
