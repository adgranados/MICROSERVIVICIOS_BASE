using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class SalarioRango
    {
        public SalarioRango()
        {
            CargoDetalle = new HashSet<CargoDetalle>();
            HvInfoBasica = new HashSet<HvInfoBasica>();
            PrfPreferenciasUsuario = new HashSet<PrfPreferenciasUsuario>();
            Publicaciones = new HashSet<Publicaciones>();
        }

        public int SalarioRangoId { get; set; }
        public string Nombre { get; set; }
        public long? Inicio { get; set; }
        public long? Fin { get; set; }
        public string MoneId { get; set; }
        public string SalarioRango1 { get; set; }

        public virtual Monedas Mone { get; set; }
        public virtual ICollection<CargoDetalle> CargoDetalle { get; set; }
        public virtual ICollection<HvInfoBasica> HvInfoBasica { get; set; }
        public virtual ICollection<PrfPreferenciasUsuario> PrfPreferenciasUsuario { get; set; }
        public virtual ICollection<Publicaciones> Publicaciones { get; set; }
    }
}
