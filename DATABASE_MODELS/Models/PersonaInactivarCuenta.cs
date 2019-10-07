using System;

namespace DATABASE_MODELS.Models
{
    public partial class PersonaInactivarCuenta
    {
        public int Id { get; set; }
        public int MotivoId { get; set; }
        public DateTime Fecha { get; set; }
        public string OtroMotivo { get; set; }
        public int? PersoId { get; set; }
    }
}
