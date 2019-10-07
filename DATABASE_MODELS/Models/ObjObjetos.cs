using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class ObjObjetos
    {
        public ObjObjetos()
        {
            RobRolObjeto = new HashSet<RobRolObjeto>();
        }

        public int ObjId { get; set; }
        public string ObjNombre { get; set; }
        public string ObjTipoId { get; set; }
        public string ObjLabel { get; set; }
        public int ObjOwner { get; set; }
        public string ObjData { get; set; }
        public string ObjImagePath { get; set; }
        public int? ObjOrden { get; set; }

        public virtual ICollection<RobRolObjeto> RobRolObjeto { get; set; }
    }
}
