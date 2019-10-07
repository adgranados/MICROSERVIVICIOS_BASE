using System;

namespace DATABASE_MODELS.Models
{
    public partial class SUsuarioAgencia
    {
        public int PersoId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Estado { get; set; }
        public int? RolId { get; set; }
        public int? Sesiones { get; set; }
        public int? AgenciaId { get; set; }
        public string UsaCodigo { get; set; }
        public string UsaNombres { get; set; }
        public string UsaApellidos { get; set; }
        public string UsaCodage { get; set; }
        public string UsaFijo1 { get; set; }
        public string UsaFijo2 { get; set; }
        public string UsaCelular { get; set; }
        public int? UsaPreg { get; set; }
        public bool? UsaEscoord { get; set; }
        public int? UsaNumRoles { get; set; }
        public string UsaRespuesta { get; set; }
        public int? UsaEntId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaUltimoAcceso { get; set; }
        public DateTime? FechaCambioContasena { get; set; }
        public string Clave { get; set; }
        public bool? Esmultiagencia { get; set; }
        public int? AgenciaRegistro { get; set; }
    }
}
