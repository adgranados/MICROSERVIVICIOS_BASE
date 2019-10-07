using System;

namespace DATABASE_MODELS.Models
{
    public partial class LogDemandante
    {
        public long LogAccionRealizadaId { get; set; }
        public int UsuarioId { get; set; }
        public int PrestadorId { get; set; }
        public int AgenciaId { get; set; }
        public string AccionControladorId { get; set; }
        public DateTime? AuditoriaFechaCreacion { get; set; }
        public int? RolId { get; set; }
        public long? AfectadoId { get; set; }
        public string RegistroAfectadoId { get; set; }
        public string Ip { get; set; }
        public string TablaRegistroAfectado { get; set; }
        public string TablaAfectado { get; set; }
        public string Usuario { get; set; }
        public string Prestador { get; set; }
        public string Agencia { get; set; }
        public string Afectado { get; set; }
        public string RegistroAfectado { get; set; }
        public string Datos { get; set; }
    }
}
