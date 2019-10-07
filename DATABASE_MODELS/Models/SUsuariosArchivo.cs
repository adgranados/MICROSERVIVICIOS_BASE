using System;

namespace DATABASE_MODELS.Models
{
    public partial class SUsuariosArchivo
    {
        public int PersoId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Estado { get; set; }
        public int Sesiones { get; set; }
        public int RolId { get; set; }
        public int? SeguPregId { get; set; }
        public string SeguResp { get; set; }
        public int? MotivoCierreId { get; set; }
        public string OtroMotivo { get; set; }
        public DateTime? FechaCierre { get; set; }
        public bool? AceptaTermCond { get; set; }
        public bool? AceptaTratDatos { get; set; }
        public string Clave { get; set; }
        public string TipoCierre { get; set; }
        public DateTime? UltimoAcceso { get; set; }
        public DateTime? FechaUltimoAcceso { get; set; }
        public DateTime? FechaCambioContrasena { get; set; }
        public int? PersoIdPrestador { get; set; }
        public int Id { get; set; }
    }
}
