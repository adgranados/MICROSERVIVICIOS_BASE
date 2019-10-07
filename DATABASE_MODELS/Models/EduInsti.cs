using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class EduInsti
    {
        public EduInsti()
        {
            EduInstiPaisRela = new HashSet<EduInstiPaisRela>();
            HvEstu = new HashSet<HvEstu>();
        }

        public string InstiId { get; set; }
        public string Nombre { get; set; }
        public int? EntId { get; set; }
        public string EntNit { get; set; }

        public virtual ICollection<EduInstiPaisRela> EduInstiPaisRela { get; set; }
        public virtual ICollection<HvEstu> HvEstu { get; set; }
    }
}
