namespace DATABASE_MODELS.Models
{
    public partial class SRolUsua
    {
        public int PersoId { get; set; }
        public int RolId { get; set; }

        public virtual SRoles Rol { get; set; }
    }
}
