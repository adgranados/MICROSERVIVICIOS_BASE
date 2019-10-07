namespace DATABASE_MODELS.Models
{
    public partial class RobRolObjeto
    {
        public int ObjId { get; set; }
        public int RolId { get; set; }

        public virtual ObjObjetos Obj { get; set; }
        public virtual RolRol Rol { get; set; }
    }
}
