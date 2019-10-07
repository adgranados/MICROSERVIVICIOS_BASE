using System;

namespace DATABASE_MODELS.Models
{
    public partial class UsuarioCierreCuenta
    {
        public int Id { get; set; }
        public int PersoId { get; set; }
        public int MotivoCierreId { get; set; }
        public DateTime FechaCierre { get; set; }
        public string OtroMotivo { get; set; }
    }
}
