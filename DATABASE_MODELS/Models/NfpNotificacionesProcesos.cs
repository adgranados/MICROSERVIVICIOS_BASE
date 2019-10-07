namespace DATABASE_MODELS.Models
{
    public partial class NfpNotificacionesProcesos
    {
        public int ProId { get; set; }
        public int PersoId { get; set; }
        public int NoaId { get; set; }
        public bool NtpEstado { get; set; }
        public int InterOrgaId { get; set; }

        public virtual NoaNotificacionesAlarmas Noa { get; set; }
        public virtual PersonasAgencia Perso { get; set; }
        public virtual Procesos Procesos { get; set; }
    }
}
