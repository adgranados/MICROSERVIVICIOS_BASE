using System;

namespace DATABASE_MODELS.Models
{
    public partial class SedesEliminadas
    {
        public int Id { get; set; }
        public int InterOrgaId { get; set; }
        public string RazonSocial { get; set; }
        public string Nit { get; set; }
        public string Email { get; set; }
        public int SedeId { get; set; }
        public string NombreSede { get; set; }
        public int MotivoId { get; set; }
        public DateTime Fecha { get; set; }
        public int AgenteId { get; set; }
        public int AgenciaId { get; set; }
        public int Registrados { get; set; }
        public string TipoSede { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Pais { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public int? Cerrados { get; set; }
        public int? Cancelados { get; set; }

        public virtual MotivoEliminacionSede Motivo { get; set; }
    }
}
