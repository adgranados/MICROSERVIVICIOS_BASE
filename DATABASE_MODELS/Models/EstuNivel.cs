using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class EstuNivel
    {
        public EstuNivel()
        {
            CargoDetalle = new HashSet<CargoDetalle>();
            EstuNivelPaisRela = new HashSet<EstuNivelPaisRela>();
            HvEstu = new HashSet<HvEstu>();
            PrfPreferenciasUsuario = new HashSet<PrfPreferenciasUsuario>();
            Publicaciones = new HashSet<Publicaciones>();
            Titulos = new HashSet<Titulos>();
        }

        public string EstuNivelId { get; set; }
        public string Nombre { get; set; }
        public int? EstuOrden { get; set; }
        public string Encurso { get; set; }
        public string CodigoNivel { get; set; }
        public string CodigoSispe { get; set; }

        public virtual ICollection<CargoDetalle> CargoDetalle { get; set; }
        public virtual ICollection<EstuNivelPaisRela> EstuNivelPaisRela { get; set; }
        public virtual ICollection<HvEstu> HvEstu { get; set; }
        public virtual ICollection<PrfPreferenciasUsuario> PrfPreferenciasUsuario { get; set; }
        public virtual ICollection<Publicaciones> Publicaciones { get; set; }
        public virtual ICollection<Titulos> Titulos { get; set; }
    }
}
