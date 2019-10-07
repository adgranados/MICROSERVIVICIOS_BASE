using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class AcpAdminCandPost
    {
        public AcpAdminCandPost()
        {
            UppUsuarioPruebasProceso = new HashSet<UppUsuarioPruebasProceso>();
        }

        public int PosId { get; set; }
        public bool? AcpPreseleccionado { get; set; }
        public bool? AcpPendiente { get; set; }
        public bool? AcpDescartado { get; set; }
        public DateTime? AcpFechaAccionPreseleccion { get; set; }
        public int? PersoIdAgentePreseleccion { get; set; }
        public bool? AcpEvalAprobado { get; set; }
        public bool? AcpEvalPendiente { get; set; }
        public bool? AcpEvalDescartado { get; set; }
        public DateTime? AcpFechaAccionEvaluacion { get; set; }
        public int? PersoIdAgenteSelec { get; set; }
        public bool? AcpRemitidoEmpresa { get; set; }
        public DateTime? AcpFechaAccionRemisionEmpresa { get; set; }
        public int? PersoIdAgenteRemiteEmpresa { get; set; }
        public int? EscId { get; set; }
        public DateTime? AcpFechaEscId { get; set; }
        public DateTime? AcpFechaRespuestaEmpresa { get; set; }
        public bool? AcpRespuestaEmpresaSeleccionado { get; set; }
        public bool? AcpRespuestaEmpresaDescartado { get; set; }
        public bool? AcpVerEntreOri { get; set; }
        public bool? AcpVistoEmp { get; set; }
        public DateTime? AcpFechaPostulacion { get; set; }
        public int? EscIdAnterior { get; set; }
        public int? PersoIdAgenteNoselec { get; set; }

        public virtual EscEstadoCandidatura Esc { get; set; }
        public virtual Postulaciones Pos { get; set; }
        public virtual PcdProcesoCausalDescarte PcdProcesoCausalDescarte { get; set; }
        public virtual ICollection<UppUsuarioPruebasProceso> UppUsuarioPruebasProceso { get; set; }
    }
}
