using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Cargos
    {
        public Cargos()
        {
            CargoDetalle = new HashSet<CargoDetalle>();
            CargosPaisRela = new HashSet<CargosPaisRela>();
            PersonasEmpresa = new HashSet<PersonasEmpresa>();
        }

        public string CargoId { get; set; }
        public string Nombre { get; set; }
        public int? IdDenominacion { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string Tareas { get; set; }
        public bool EsHidrocarburos { get; set; }
        public string IdCargoHidro { get; set; }
        public bool? ManoObraCalificada { get; set; }
        public bool EsEstandarizado { get; set; }

        public virtual ICollection<CargoDetalle> CargoDetalle { get; set; }
        public virtual ICollection<CargosPaisRela> CargosPaisRela { get; set; }
        public virtual ICollection<PersonasEmpresa> PersonasEmpresa { get; set; }
    }
}
