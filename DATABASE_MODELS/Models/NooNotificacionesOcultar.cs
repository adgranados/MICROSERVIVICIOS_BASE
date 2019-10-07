namespace DATABASE_MODELS.Models
{
    public partial class NooNotificacionesOcultar
    {
        public int NotId { get; set; }
        public int? ProcesoId { get; set; }
        public int? InterOrgId { get; set; }
        public int? PersoId { get; set; }
        public int? RolId { get; set; }
        public int? IdAgencia { get; set; }
        public int? NtiId { get; set; }
        public int? AuiId { get; set; }
        public int? AprId { get; set; }
        public int? AupId { get; set; }
        public int? IdSede { get; set; }
    }
}
