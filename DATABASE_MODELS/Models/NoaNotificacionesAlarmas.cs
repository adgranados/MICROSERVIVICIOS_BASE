using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class NoaNotificacionesAlarmas
    {
        public NoaNotificacionesAlarmas()
        {
            NfpNotificacionesProcesos = new HashSet<NfpNotificacionesProcesos>();
            NfrNotificacionesRegistro = new HashSet<NfrNotificacionesRegistro>();
            NfvNotificacionesVacantes = new HashSet<NfvNotificacionesVacantes>();
        }

        public int NoaId { get; set; }
        public string NoaNombre { get; set; }
        public bool NoaEstado { get; set; }
        public int? NoaEntidadPadre { get; set; }
        public bool NoaEsNotificacion { get; set; }

        public virtual ICollection<NfpNotificacionesProcesos> NfpNotificacionesProcesos { get; set; }
        public virtual ICollection<NfrNotificacionesRegistro> NfrNotificacionesRegistro { get; set; }
        public virtual ICollection<NfvNotificacionesVacantes> NfvNotificacionesVacantes { get; set; }
    }
}
