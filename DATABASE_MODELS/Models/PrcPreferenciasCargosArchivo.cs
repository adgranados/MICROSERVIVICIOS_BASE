using System;

namespace DATABASE_MODELS.Models
{
    public partial class PrcPreferenciasCargosArchivo
    {
        public int PersoId { get; set; }
        public string CargoId { get; set; }
        public int? IdGrupoOcupacional { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public int? IdAreaOcupacional { get; set; }
        public int Id { get; set; }
    }
}
