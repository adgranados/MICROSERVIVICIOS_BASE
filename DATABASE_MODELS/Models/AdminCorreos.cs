using System;

namespace DATABASE_MODELS.Models
{
    public partial class AdminCorreos
    {
        public int IdCorreo { get; set; }
        public int IdTipocorreo { get; set; }
        public int InterOrgaId { get; set; }
        public int PersoId { get; set; }
        public string Texto { get; set; }
        public bool Estado { get; set; }
        public DateTime Fecha { get; set; }

        public virtual TipoCorreos IdTipocorreoNavigation { get; set; }
        public virtual SUsuariosEmpresa1 Perso { get; set; }
    }
}
