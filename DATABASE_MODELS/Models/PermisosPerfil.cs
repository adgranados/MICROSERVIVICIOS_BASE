namespace DATABASE_MODELS.Models
{
    public partial class PermisosPerfil
    {
        public int IdPermiso { get; set; }
        public int? TipoPerfil { get; set; }
        public int? IdRol { get; set; }
        public string CodigoModulo { get; set; }
        public int? IdCodigoModulo { get; set; }
    }
}
