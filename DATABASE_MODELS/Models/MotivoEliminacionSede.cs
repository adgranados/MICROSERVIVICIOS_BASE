using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class MotivoEliminacionSede
    {
        public MotivoEliminacionSede()
        {
            SedesEliminadas = new HashSet<SedesEliminadas>();
        }

        public int Id { get; set; }
        public string Motivo { get; set; }

        public virtual ICollection<SedesEliminadas> SedesEliminadas { get; set; }
    }
}
