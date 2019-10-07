using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class UprUsuarioPruebas
    {
        public UprUsuarioPruebas()
        {
            UpeUsuarioPruebasEval = new HashSet<UpeUsuarioPruebasEval>();
        }

        public int UprId { get; set; }
        public int PersoId { get; set; }
        public int PrpId { get; set; }

        public virtual Personas Perso { get; set; }
        public virtual PrpPruebasProcesos Prp { get; set; }
        public virtual ICollection<UpeUsuarioPruebasEval> UpeUsuarioPruebasEval { get; set; }
    }
}
