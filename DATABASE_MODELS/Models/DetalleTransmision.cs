using System;

namespace DATABASE_MODELS.Models
{
    public partial class DetalleTransmision
    {
        public Guid Id { get; set; }
        public Guid LoteId { get; set; }
        public int ConsecutivoRegistro { get; set; }
        public string ClaveRegistro { get; set; }
        public string Archivo { get; set; }
        public bool ProcesadoSise { get; set; }
        public bool RechazadoSise { get; set; }
        public bool ErrorProceso { get; set; }
        public string DetalleRechazoSise { get; set; }
        public string DetalleErrorProceso { get; set; }
        public DateTime FechaRegistro { get; set; }

        public virtual Repositorio Lote { get; set; }
    }
}
