using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Procesos
    {
        public Procesos()
        {
            CandidatosArchivo = new HashSet<CandidatosArchivo>();
            DistriVacantes = new HashSet<DistriVacantes>();
            NfpNotificacionesProcesos = new HashSet<NfpNotificacionesProcesos>();
            NfvNotificacionesVacantes = new HashSet<NfvNotificacionesVacantes>();
            PesProcesoEncuestaSatisfaccion = new HashSet<PesProcesoEncuestaSatisfaccion>();
            PreSeleccionFiltros = new HashSet<PreSeleccionFiltros>();
            ProceUsuario = new HashSet<ProceUsuario>();
            ProcesosInterOrgaSedes = new HashSet<ProcesosInterOrgaSedes>();
        }

        public int SedeId { get; set; }
        public int ProcesoId { get; set; }
        public string Nombre { get; set; }
        public int? RespoPersoId { get; set; }
        public string SolicitaNom { get; set; }
        public string TeleContac { get; set; }
        public string MailContac { get; set; }
        public string CargoId { get; set; }
        public int? Idareaocupacional { get; set; }
        public string CargoEqui1 { get; set; }
        public int? Idareaocupacional1 { get; set; }
        public string CargoEquiv2 { get; set; }
        public int? Idareaocupacional2 { get; set; }
        public int? NoVacantes { get; set; }
        public bool? Personasacargo { get; set; }
        public string Observacion { get; set; }
        public bool? RequiereViajar { get; set; }
        public string ProceEstaId { get; set; }
        public DateTime? FechaCreacionProceso { get; set; }
        public string EstuNivelId { get; set; }
        public bool? Graduado { get; set; }
        public string Idnucleoconoc { get; set; }
        public string TituloId { get; set; }
        public bool? RequiereExperiencia { get; set; }
        public int? MesExpeDesde { get; set; }
        public int? MesExpeHasta { get; set; }
        public bool? RequiereCapacitacion { get; set; }
        public string InfoCapacitacion { get; set; }
        public DateTime? FechaEnvio { get; set; }
        public DateTime? FechaIniCargo { get; set; }
        public DateTime? FechaIncorporacion { get; set; }
        public string ContraTipoId { get; set; }
        public int? SalarioRangoId { get; set; }
        public int? PersoIdCrea { get; set; }
        public DateTime? IniFecha { get; set; }
        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public string EmpreCampoId { get; set; }
        public string EmpreAreaId { get; set; }
        public string ConfiChk { get; set; }
        public bool? Publicada { get; set; }
        public int EsvId { get; set; }
        public int? IdAgencia { get; set; }
        public int? PersoIdAgente { get; set; }
        public DateTime? ProceEstaFecha { get; set; }
        public int? PersoIdAgenteCrea { get; set; }
        public bool? Teletrabajo { get; set; }
        public int? PersoidAprobo { get; set; }
        public DateTime? FechaRespPresta { get; set; }
        public bool? Excepcional { get; set; }
        public int? MotivoExcepcional { get; set; }
        public bool? RequiereGestion { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public int? TipoVacante { get; set; }
        public int? JornadaId { get; set; }
        public int? IdGrupoOcupacional1 { get; set; }
        public int? IdGrupoOcupacional2 { get; set; }
        public int? IdGrupoOcupacional3 { get; set; }
        public int? MotCancelId { get; set; }
        public bool? Suplementario { get; set; }
        public int? TipoLocalizacion { get; set; }
        public int? LocalizacionId { get; set; }
        public int? MotRechaId { get; set; }
        public string MotRechaOtro { get; set; }
        public int? PersoIdRechazo { get; set; }
        public DateTime? FechaRechazo { get; set; }
        public int? PersoIdAgenciaCancela { get; set; }
        public int? PersoIdAgenciaDevuelve { get; set; }
        public string SedeProcesoIds { get; set; }
        public string MotivoCancelacion { get; set; }
        public int IdUnique { get; set; }
        public string Veredas { get; set; }
        public bool PerteneceSectorPetroleo { get; set; }
        public bool EsHidrocarburos { get; set; }
        public bool EsNacional { get; set; }
        public int? TipoProyectoId { get; set; }
        public int NumeroRemisiones { get; set; }
        public bool ManoObraCalificada { get; set; }
        public int NumeroRemisionesMaximo { get; set; }
        public DateTime? FechaBaseAmpliacion { get; set; }
        public bool? VacanteCreadaPorPrestador { get; set; }
        public string CodigoInternoVacante { get; set; }
        public int? NoEstandarizadoMesExpeDesde { get; set; }
        public string NoEstandarizadoEstuNivelId { get; set; }
        public string NoEstandarizadoDetalle { get; set; }
        public bool? NoEstandarizadoCargo1 { get; set; }
        public bool? NoEstandarizadoCargo2 { get; set; }
        public bool? NoEstandarizadoCargo3 { get; set; }
        public int? SectorHidrocarburos { get; set; }
        public int? SubsectorHidrocarburos { get; set; }

        public virtual MotivoRechazoVacante MotRecha { get; set; }
        public virtual ProceEstado ProceEsta { get; set; }
        public virtual ProcesosSectorHidrocarburos SectorHidrocarburosNavigation { get; set; }
        public virtual ProcesosSubsectorHidrocarburos SubsectorHidrocarburosNavigation { get; set; }
        public virtual ProcesosTipoProyectosHidrocarburos TipoProyecto { get; set; }
        public virtual Publicaciones Publicaciones { get; set; }
        public virtual ICollection<CandidatosArchivo> CandidatosArchivo { get; set; }
        public virtual ICollection<DistriVacantes> DistriVacantes { get; set; }
        public virtual ICollection<NfpNotificacionesProcesos> NfpNotificacionesProcesos { get; set; }
        public virtual ICollection<NfvNotificacionesVacantes> NfvNotificacionesVacantes { get; set; }
        public virtual ICollection<PesProcesoEncuestaSatisfaccion> PesProcesoEncuestaSatisfaccion { get; set; }
        public virtual ICollection<PreSeleccionFiltros> PreSeleccionFiltros { get; set; }
        public virtual ICollection<ProceUsuario> ProceUsuario { get; set; }
        public virtual ICollection<ProcesosInterOrgaSedes> ProcesosInterOrgaSedes { get; set; }
    }
}
