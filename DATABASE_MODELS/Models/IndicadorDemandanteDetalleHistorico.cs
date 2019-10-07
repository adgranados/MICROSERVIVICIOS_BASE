using System;

namespace DATABASE_MODELS.Models
{
    public partial class IndicadorDemandanteDetalleHistorico
    {
        public Guid Id { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public int? IdEmpresa { get; set; }
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string RazonSocial { get; set; }
        public string Naturaleza { get; set; }
        public string TipoEmpresa { get; set; }
        public string ActividadEconomica { get; set; }
        public string Sector { get; set; }
        public string Tamanio { get; set; }
        public int? IdSede { get; set; }
        public string NombreSede { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string TipoSede { get; set; }
        public string Ciudad { get; set; }
        public string Departamento { get; set; }
        public bool? Autoregistro { get; set; }
        public DateTime? FechaCreacionSede { get; set; }
        public int? EstadoSede { get; set; }
        public int? IdAdministrador { get; set; }
        public string TipoDocumentoAdmin { get; set; }
        public string NumeroDocumentoAdmin { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Cargo { get; set; }
        public string CorreoElectronico { get; set; }
        public string TelefonoAdmin { get; set; }
        public int? IdPrestadorAprobo { get; set; }
        public string PrestadorAprobo { get; set; }
        public int? IdAgenciaAprobo { get; set; }
        public string AgenciaAprobo { get; set; }
        public int? IdAgente { get; set; }
        public string NombreAgente { get; set; }
        public string CorreoElectronicoAgente { get; set; }
        public DateTime? FechaAprobacion { get; set; }
        public int? IdPrestador { get; set; }
        public string Prestador { get; set; }
        public int? IdAgencia { get; set; }
        public string Agencia { get; set; }
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string CorreoElectronicoUsuario { get; set; }
        public string TipoUsuario { get; set; }
        public int? IdEstado { get; set; }
        public string Estado { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
