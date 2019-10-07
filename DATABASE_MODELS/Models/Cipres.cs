using System;

namespace DATABASE_MODELS.Models
{
    public partial class Cipres
    {
        public Guid Id { get; set; }
        public DateTime? FechaEjecucion { get; set; }
        public int PrestadoresNuevo { get; set; }
        public string DetalleprestadoresNuevo { get; set; }
        public int PrestadoresActualizado { get; set; }
        public string DetallePrestadoresActualizado { get; set; }
        public int AgenciaNuevo { get; set; }
        public string DetalleAgenciaNuevo { get; set; }
        public int AgenciaActualizado { get; set; }
        public string DetalleAgenciaActualizado { get; set; }
        public int UsuarioNuevo { get; set; }
        public string DetalleUsuarioNuevo { get; set; }
        public int UsuarioActualizado { get; set; }
        public string XmlPrestador { get; set; }
        public string XmlPunto { get; set; }
    }
}
