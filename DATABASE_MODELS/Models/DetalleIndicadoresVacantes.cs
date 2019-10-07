using System;

namespace DATABASE_MODELS.Models
{
    public partial class DetalleIndicadoresVacantes
    {
        public int IdDetalleIndicadoresVacantes { get; set; }
        public int IdAgencia { get; set; }
        public int? IdEntidad { get; set; }
        public int? IdIndicador { get; set; }
        public string CodigoProceso { get; set; }
        public string NombreVacante { get; set; }
        public string Cargo { get; set; }
        public int? NumeroPostulados { get; set; }
        public string NombreEmpresa { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public DateTime? FechaVencimiento { get; set; }
        public string EstadoActual { get; set; }
        public string TipoVacante { get; set; }
        public string ProgramaGobierno { get; set; }
        public string Ubicacion { get; set; }
        public string Discapacidad { get; set; }
        public int? PuestosTrabajo { get; set; }
        public string TipoContrato { get; set; }
        public string AgenteAprobo { get; set; }
        public string ProceEstaId { get; set; }
        public bool? Excepcional { get; set; }
        public int? Mes { get; set; }
        public int? Year { get; set; }
        public DateTime? FechaCrea { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public string PerteneceHidrocarburos { get; set; }
        public string TipoDeProyectoHidrocarburos { get; set; }
        public string EsManoDeObraCalificada { get; set; }
    }
}
