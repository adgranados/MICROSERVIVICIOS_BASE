using System;

namespace DATABASE_MODELS.Models
{
    public partial class LogAuditoria1
    {
        public long Id { get; set; }
        public DateTime Fecha { get; set; }
        public int ModuloId { get; set; }
        public int AccionId { get; set; }
        public int FuncionalidadId { get; set; }
        public string Ip { get; set; }
        public int PersoIdResponsable { get; set; }
        public int? IdPuntoResponsable { get; set; }
        public int? PersoIdAfectado { get; set; }
        public string Datos { get; set; }

        public virtual Acciones Accion { get; set; }
        public virtual Funcionalidades Funcionalidad { get; set; }
        public virtual Modulos Modulo { get; set; }
    }
}
