using System;

namespace DATABASE_MODELS.Models
{
    public partial class HvLaboExpeArchivo
    {
        public int PersoId { get; set; }
        public int LaboExpeOrdi { get; set; }
        public string EmpreNombre { get; set; }
        public string EmpreCampoId { get; set; }
        public string CargoId { get; set; }
        public string CargoNombre { get; set; }
        public string CargoEquivId { get; set; }
        public string AreaTag1 { get; set; }
        public string AreaTag2 { get; set; }
        public string AreaTag3 { get; set; }
        public int EmpreIndusId { get; set; }
        public int? EmpreSectoId { get; set; }
        public string EmpreTel { get; set; }
        public string EmpreJefe { get; set; }
        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
        public string FuncLogros { get; set; }
        public string MotivoRetiro { get; set; }
        public int? IdGrupoOcupacional { get; set; }
        public int? IdTipoExperienciaLaboral { get; set; }
        public string ProductoComercializar { get; set; }
        public string CantidadPersonas { get; set; }
        public int Iduk { get; set; }
    }
}
