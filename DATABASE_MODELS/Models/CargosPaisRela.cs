namespace DATABASE_MODELS.Models
{
    public partial class CargosPaisRela
    {
        public string CargoId { get; set; }
        public string PaisId { get; set; }

        public virtual Cargos Cargo { get; set; }
        public virtual PaisesHome Pais { get; set; }
    }
}
