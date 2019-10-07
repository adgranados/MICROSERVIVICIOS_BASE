namespace DATABASE_MODELS.Models
{
    public partial class NfrNotificacionesRegistro
    {
        public int InterOrgaId { get; set; }
        public int PersoId { get; set; }
        public int NoaId { get; set; }
        public bool NfrEstado { get; set; }

        public virtual InterOrga InterOrga { get; set; }
        public virtual NoaNotificacionesAlarmas Noa { get; set; }
        public virtual PersonasAgencia NoaNavigation { get; set; }
    }
}
