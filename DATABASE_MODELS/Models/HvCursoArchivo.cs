using System;

namespace DATABASE_MODELS.Models
{
    public partial class HvCursoArchivo
    {
        public int PersoId { get; set; }
        public int CursosOrdi { get; set; }
        public string TituNombre { get; set; }
        public string InstiId { get; set; }
        public string InstiNombre { get; set; }
        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
        public string ResuLogros { get; set; }
        public string PractiCk { get; set; }
        public bool? Desertado { get; set; }
        public int? IdTipoCertificado { get; set; }
        public bool? EstadoCertificacion { get; set; }
        public string CantidadHora { get; set; }
        public int Iduk { get; set; }
    }
}
