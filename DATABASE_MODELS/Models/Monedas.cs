using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Monedas
    {
        public Monedas()
        {
            MonePaisRela = new HashSet<MonePaisRela>();
            SalarioRango = new HashSet<SalarioRango>();
        }

        public string MoneId { get; set; }
        public string Nombre { get; set; }

        public virtual ICollection<MonePaisRela> MonePaisRela { get; set; }
        public virtual ICollection<SalarioRango> SalarioRango { get; set; }
    }
}
