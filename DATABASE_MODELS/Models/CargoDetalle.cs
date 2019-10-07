namespace DATABASE_MODELS.Models
{
    public partial class CargoDetalle
    {
        public int CargoDetalleId { get; set; }
        public string CargoId { get; set; }
        public string EstuNivelId { get; set; }
        public int EstuOrden { get; set; }
        public int MesesExpRequeridos { get; set; }
        public int IdGrupoOcupacional { get; set; }
        public int IdSalarioRango { get; set; }

        public virtual Cargos Cargo { get; set; }
        public virtual EstuNivel EstuNivel { get; set; }
        public virtual GruposDenominaciones IdGrupoOcupacionalNavigation { get; set; }
        public virtual SalarioRango IdSalarioRangoNavigation { get; set; }
    }
}
