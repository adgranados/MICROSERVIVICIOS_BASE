using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Repositorio
    {
        public Repositorio()
        {
            DetalleTransmision = new HashSet<DetalleTransmision>();
        }

        public Guid Id { get; set; }
        public long PrestadorId { get; set; }
        public long AgenciaId { get; set; }
        public string UsuarioCorreo { get; set; }
        public string UsuarioDocumento { get; set; }
        public string UsuarioClave { get; set; }
        public int RegistrosTransmitidosRepositorio { get; set; }
        public DateTime FechaTransmisionRepositorio { get; set; }
        public string Archivo { get; set; }
        public bool ProcesadoSise { get; set; }
        public DateTime? FechaProceoSise { get; set; }
        public int RegistrosProcesadosSise { get; set; }
        public int RegistrosRechazadosSise { get; set; }
        public string DetalleRegistrosRechazadosSise { get; set; }
        public string IpCliente { get; set; }
        public string VersionCliente { get; set; }
        public bool ErrorProceso { get; set; }
        public string DetalleErrorProceso { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? RegistrosActualizados { get; set; }

        public virtual ICollection<DetalleTransmision> DetalleTransmision { get; set; }
    }
}
