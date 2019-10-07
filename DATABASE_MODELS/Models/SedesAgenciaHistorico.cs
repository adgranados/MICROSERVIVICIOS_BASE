using System;

namespace DATABASE_MODELS.Models
{
    public partial class SedesAgenciaHistorico
    {
        public decimal IdSedeAgenciaHistorico { get; set; }
        public int IdSede { get; set; }
        public int IdAgencia { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? IdMotivo { get; set; }
        public string TipoMotivo { get; set; }
        public string OtroMotivo { get; set; }
        public DateTime? FechaMotivo { get; set; }
        public int? IdAgenciaNuevo { get; set; }

        public virtual MotivoCambioPrestadorSede IdMotivoNavigation { get; set; }
    }
}
