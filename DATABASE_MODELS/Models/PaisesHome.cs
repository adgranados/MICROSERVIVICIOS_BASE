using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class PaisesHome
    {
        public PaisesHome()
        {
            CargosPaisRela = new HashSet<CargosPaisRela>();
            EmpreAreaPaisRela = new HashSet<EmpreAreaPaisRela>();
            EmpreIndusPaisRela = new HashSet<EmpreIndusPaisRela>();
            EmpreSectorPaisRela = new HashSet<EmpreSectorPaisRela>();
            EstuNivelPaisRela = new HashSet<EstuNivelPaisRela>();
            HabiPaisRela = new HashSet<HabiPaisRela>();
            MonePaisRela = new HashSet<MonePaisRela>();
            TitulosPaisRela = new HashSet<TitulosPaisRela>();
        }

        public string PaisId { get; set; }
        public string Descripcion { get; set; }
        public string Idioma { get; set; }

        public virtual ICollection<CargosPaisRela> CargosPaisRela { get; set; }
        public virtual ICollection<EmpreAreaPaisRela> EmpreAreaPaisRela { get; set; }
        public virtual ICollection<EmpreIndusPaisRela> EmpreIndusPaisRela { get; set; }
        public virtual ICollection<EmpreSectorPaisRela> EmpreSectorPaisRela { get; set; }
        public virtual ICollection<EstuNivelPaisRela> EstuNivelPaisRela { get; set; }
        public virtual ICollection<HabiPaisRela> HabiPaisRela { get; set; }
        public virtual ICollection<MonePaisRela> MonePaisRela { get; set; }
        public virtual ICollection<TitulosPaisRela> TitulosPaisRela { get; set; }
    }
}
