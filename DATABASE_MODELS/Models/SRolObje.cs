namespace DATABASE_MODELS.Models
{
    public partial class SRolObje
    {
        public int RolId { get; set; }
        public int ObjetoId { get; set; }

        public virtual SObjetos Objeto { get; set; }
        public virtual SRoles Rol { get; set; }
    }
}
