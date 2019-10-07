namespace DATABASE_MODELS.Models
{
    public partial class RusRolUsuario
    {
        public int RolId { get; set; }
        public int UsrId { get; set; }

        public virtual RolRol Rol { get; set; }
        public virtual UsrUsuario Usr { get; set; }
    }
}
