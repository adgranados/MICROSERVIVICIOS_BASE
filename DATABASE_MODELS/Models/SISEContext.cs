using Microsoft.EntityFrameworkCore;

namespace DATABASE_MODELS.Models
{
    public partial class SISEContext : DbContext
    {
        public SISEContext()
        {
        }

        public SISEContext(DbContextOptions<SISEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Acciones> Acciones { get; set; }
        public virtual DbSet<AcpAdminCandPost> AcpAdminCandPost { get; set; }
        public virtual DbSet<ActActividad> ActActividad { get; set; }
        public virtual DbSet<AdjunTipo> AdjunTipo { get; set; }
        public virtual DbSet<Adjuntos> Adjuntos { get; set; }
        public virtual DbSet<AdminCorreos> AdminCorreos { get; set; }
        public virtual DbSet<Agencia> Agencia { get; set; }
        public virtual DbSet<AgenciaEmpresas> AgenciaEmpresas { get; set; }
        public virtual DbSet<AgenciaInterOrga> AgenciaInterOrga { get; set; }
        public virtual DbSet<Aglomeracion> Aglomeracion { get; set; }
        public virtual DbSet<AocAsistenciaOferenteConvocatoria> AocAsistenciaOferenteConvocatoria { get; set; }
        public virtual DbSet<AocAsistenciaOferenteConvocatoriaEliminados> AocAsistenciaOferenteConvocatoriaEliminados { get; set; }
        public virtual DbSet<AprAuditPruebasProcesos> AprAuditPruebasProcesos { get; set; }
        public virtual DbSet<AreaDesempenio> AreaDesempenio { get; set; }
        public virtual DbSet<AreaOcupacional> AreaOcupacional { get; set; }
        public virtual DbSet<AsiAsistencia> AsiAsistencia { get; set; }
        public virtual DbSet<AucAuditCursosTalleres> AucAuditCursosTalleres { get; set; }
        public virtual DbSet<CandiCondiContrata> CandiCondiContrata { get; set; }
        public virtual DbSet<CandiEsta> CandiEsta { get; set; }
        public virtual DbSet<CandidatosArchivo> CandidatosArchivo { get; set; }
        public virtual DbSet<CargoDetalle> CargoDetalle { get; set; }
        public virtual DbSet<Cargos> Cargos { get; set; }
        public virtual DbSet<CargosPaisRela> CargosPaisRela { get; set; }
        public virtual DbSet<CcnConceptoConvenio> CcnConceptoConvenio { get; set; }
        public virtual DbSet<CcniConceptoInicial> CcniConceptoInicial { get; set; }
        public virtual DbSet<CcoPeriodicidadConvocatoria> CcoPeriodicidadConvocatoria { get; set; }
        public virtual DbSet<CctCausalNoContratacion> CctCausalNoContratacion { get; set; }
        public virtual DbSet<CdcCausalesDescarte> CdcCausalesDescarte { get; set; }
        public virtual DbSet<CentroPoblado> CentroPoblado { get; set; }
        public virtual DbSet<CepColectivosEspPersona> CepColectivosEspPersona { get; set; }
        public virtual DbSet<CepColectivosEspPersonaArchivo> CepColectivosEspPersonaArchivo { get; set; }
        public virtual DbSet<CesColectivosEsp> CesColectivosEsp { get; set; }
        public virtual DbSet<CgiGrupoIndicador> CgiGrupoIndicador { get; set; }
        public virtual DbSet<CinConceptoIndicador> CinConceptoIndicador { get; set; }
        public virtual DbSet<Cipres> Cipres { get; set; }
        public virtual DbSet<CitCita> CitCita { get; set; }
        public virtual DbSet<CitHistoria> CitHistoria { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<ClasePrestador> ClasePrestador { get; set; }
        public virtual DbSet<Clasificados> Clasificados { get; set; }
        public virtual DbSet<CnvConvenio> CnvConvenio { get; set; }
        public virtual DbSet<CnvConvocatoria> CnvConvocatoria { get; set; }
        public virtual DbSet<CodigoActivacion> CodigoActivacion { get; set; }
        public virtual DbSet<CodigoLog> CodigoLog { get; set; }
        public virtual DbSet<CodigoLog1> CodigoLog1 { get; set; }
        public virtual DbSet<ComplementoHojaVida> ComplementoHojaVida { get; set; }
        public virtual DbSet<ComplementoHojaVidaHist> ComplementoHojaVidaHist { get; set; }
        public virtual DbSet<Condicion> Condicion { get; set; }
        public virtual DbSet<ConfiguracionReportes> ConfiguracionReportes { get; set; }
        public virtual DbSet<ConsulPerso> ConsulPerso { get; set; }
        public virtual DbSet<ContacCateg> ContacCateg { get; set; }
        public virtual DbSet<ContraTipos> ContraTipos { get; set; }
        public virtual DbSet<CtaCursosTalleres> CtaCursosTalleres { get; set; }
        public virtual DbSet<CtgCatalogos> CtgCatalogos { get; set; }
        public virtual DbSet<CtnContactenos> CtnContactenos { get; set; }
        public virtual DbSet<DataDictionary> DataDictionary { get; set; }
        public virtual DbSet<Departamentos> Departamentos { get; set; }
        public virtual DbSet<DetalleIndicadoresVacantes> DetalleIndicadoresVacantes { get; set; }
        public virtual DbSet<DetalleTransmision> DetalleTransmision { get; set; }
        public virtual DbSet<DetallehistoricoIndicadoresVacantes> DetallehistoricoIndicadoresVacantes { get; set; }
        public virtual DbSet<DireccionParametrizada> DireccionParametrizada { get; set; }
        public virtual DbSet<DireccionParametrizadaArchivo> DireccionParametrizadaArchivo { get; set; }
        public virtual DbSet<DistriVacantes> DistriVacantes { get; set; }
        public virtual DbSet<Documentos> Documentos { get; set; }
        public virtual DbSet<EduInsti> EduInsti { get; set; }
        public virtual DbSet<EduInstiPaisRela> EduInstiPaisRela { get; set; }
        public virtual DbSet<EmpreArea> EmpreArea { get; set; }
        public virtual DbSet<EmpreAreaPaisRela> EmpreAreaPaisRela { get; set; }
        public virtual DbSet<EmpreCantiEmple> EmpreCantiEmple { get; set; }
        public virtual DbSet<EmpreIndus> EmpreIndus { get; set; }
        public virtual DbSet<EmpreIndusPaisRela> EmpreIndusPaisRela { get; set; }
        public virtual DbSet<EmpreNaturaleza> EmpreNaturaleza { get; set; }
        public virtual DbSet<EmpreSector> EmpreSector { get; set; }
        public virtual DbSet<EmpreSectorPaisRela> EmpreSectorPaisRela { get; set; }
        public virtual DbSet<EmpreTipo> EmpreTipo { get; set; }
        public virtual DbSet<EnpEncuestaPreguntas> EnpEncuestaPreguntas { get; set; }
        public virtual DbSet<EntEntidad> EntEntidad { get; set; }
        public virtual DbSet<EscEstadoCandidatura> EscEstadoCandidatura { get; set; }
        public virtual DbSet<EstadoCivil> EstadoCivil { get; set; }
        public virtual DbSet<EstadoCuenta> EstadoCuenta { get; set; }
        public virtual DbSet<EstadoNivelEducativo> EstadoNivelEducativo { get; set; }
        public virtual DbSet<EstadosSede> EstadosSede { get; set; }
        public virtual DbSet<EstuNivel> EstuNivel { get; set; }
        public virtual DbSet<EstuNivelPaisRela> EstuNivelPaisRela { get; set; }
        public virtual DbSet<EstuNivelSupra> EstuNivelSupra { get; set; }
        public virtual DbSet<EsvEstadoVacante> EsvEstadoVacante { get; set; }
        public virtual DbSet<EtapaProceso> EtapaProceso { get; set; }
        public virtual DbSet<EvaEvaluacion> EvaEvaluacion { get; set; }
        public virtual DbSet<Experiencias> Experiencias { get; set; }
        public virtual DbSet<ExperienciasCargos> ExperienciasCargos { get; set; }
        public virtual DbSet<ExrExperienciaRango> ExrExperienciaRango { get; set; }
        public virtual DbSet<FfaFosfecCriteriosAudit> FfaFosfecCriteriosAudit { get; set; }
        public virtual DbSet<FfcCargue> FfcCargue { get; set; }
        public virtual DbSet<FfdFosfecDetalleVersion> FfdFosfecDetalleVersion { get; set; }
        public virtual DbSet<FfvFosfecVersiones> FfvFosfecVersiones { get; set; }
        public virtual DbSet<FiltroPalabraClave> FiltroPalabraClave { get; set; }
        public virtual DbSet<Funcionalidades> Funcionalidades { get; set; }
        public virtual DbSet<GrupoReportes> GrupoReportes { get; set; }
        public virtual DbSet<GruposDenominaciones> GruposDenominaciones { get; set; }
        public virtual DbSet<HabiPaisRela> HabiPaisRela { get; set; }
        public virtual DbSet<Habilidades> Habilidades { get; set; }
        public virtual DbSet<HistEstadoVacante> HistEstadoVacante { get; set; }
        public virtual DbSet<HistIndicaTotales> HistIndicaTotales { get; set; }
        public virtual DbSet<HistIndicaTotalesOferentes> HistIndicaTotalesOferentes { get; set; }
        public virtual DbSet<HistIndicaTotalesRemitidos> HistIndicaTotalesRemitidos { get; set; }
        public virtual DbSet<HistIndicador40Mil> HistIndicador40Mil { get; set; }
        public virtual DbSet<HistIndicadorDiscap> HistIndicadorDiscap { get; set; }
        public virtual DbSet<HistIndicadorVictima> HistIndicadorVictima { get; set; }
        public virtual DbSet<HistPostuOferente> HistPostuOferente { get; set; }
        public virtual DbSet<HistoricoTotalesVacantes> HistoricoTotalesVacantes { get; set; }
        public virtual DbSet<HistoricoVistos> HistoricoVistos { get; set; }
        public virtual DbSet<HvCompleto> HvCompleto { get; set; }
        public virtual DbSet<HvCurso> HvCurso { get; set; }
        public virtual DbSet<HvCursoArchivo> HvCursoArchivo { get; set; }
        public virtual DbSet<HvEstu> HvEstu { get; set; }
        public virtual DbSet<HvEstuArchivo> HvEstuArchivo { get; set; }
        public virtual DbSet<HvHabi> HvHabi { get; set; }
        public virtual DbSet<HvIdio> HvIdio { get; set; }
        public virtual DbSet<HvIdioArchivo> HvIdioArchivo { get; set; }
        public virtual DbSet<HvInfoBasica> HvInfoBasica { get; set; }
        public virtual DbSet<HvInfoBasicaArchivo> HvInfoBasicaArchivo { get; set; }
        public virtual DbSet<HvLaboExpe> HvLaboExpe { get; set; }
        public virtual DbSet<HvLaboExpeArchivo> HvLaboExpeArchivo { get; set; }
        public virtual DbSet<HvOfimaticas> HvOfimaticas { get; set; }
        public virtual DbSet<HvOfimaticasArchivo> HvOfimaticasArchivo { get; set; }
        public virtual DbSet<HvSeguSoc> HvSeguSoc { get; set; }
        public virtual DbSet<Idiomas> Idiomas { get; set; }
        public virtual DbSet<IhoIntensidadHoraria> IhoIntensidadHoraria { get; set; }
        public virtual DbSet<IndIndicador> IndIndicador { get; set; }
        public virtual DbSet<IndIndustria> IndIndustria { get; set; }
        public virtual DbSet<IndicadorDemandanteDetalleHistorico> IndicadorDemandanteDetalleHistorico { get; set; }
        public virtual DbSet<IndicadorDemandanteDetalleMes> IndicadorDemandanteDetalleMes { get; set; }
        public virtual DbSet<IndicadorDemandanteTotalesHistorico> IndicadorDemandanteTotalesHistorico { get; set; }
        public virtual DbSet<IndicadoresTotalesPorGrupo> IndicadoresTotalesPorGrupo { get; set; }
        public virtual DbSet<InfoAdicionalProceso> InfoAdicionalProceso { get; set; }
        public virtual DbSet<InsInscripciones> InsInscripciones { get; set; }
        public virtual DbSet<InterOrga> InterOrga { get; set; }
        public virtual DbSet<Iva> Iva { get; set; }
        public virtual DbSet<Localidades> Localidades { get; set; }
        public virtual DbSet<LogAuditoria> LogAuditoria { get; set; }
        public virtual DbSet<LogAuditoria1> LogAuditoria1 { get; set; }
        public virtual DbSet<LogCandidatos> LogCandidatos { get; set; }
        public virtual DbSet<LogDemandante> LogDemandante { get; set; }
        public virtual DbSet<LogErrores> LogErrores { get; set; }
        public virtual DbSet<LogOferente> LogOferente { get; set; }
        public virtual DbSet<LogOfertas> LogOfertas { get; set; }
        public virtual DbSet<LogPrestador> LogPrestador { get; set; }
        public virtual DbSet<MatchingVistos> MatchingVistos { get; set; }
        public virtual DbSet<MctMisCta> MctMisCta { get; set; }
        public virtual DbSet<MedioImpreso> MedioImpreso { get; set; }
        public virtual DbSet<Modulos> Modulos { get; set; }
        public virtual DbSet<MonePaisRela> MonePaisRela { get; set; }
        public virtual DbSet<Monedas> Monedas { get; set; }
        public virtual DbSet<MotivoCambioPrestador> MotivoCambioPrestador { get; set; }
        public virtual DbSet<MotivoCambioPrestadorSede> MotivoCambioPrestadorSede { get; set; }
        public virtual DbSet<MotivoCierreCta> MotivoCierreCta { get; set; }
        public virtual DbSet<MotivoEliminacionSede> MotivoEliminacionSede { get; set; }
        public virtual DbSet<MotivoExcepcional> MotivoExcepcional { get; set; }
        public virtual DbSet<MotivoInactivarCuenta> MotivoInactivarCuenta { get; set; }
        public virtual DbSet<MotivoRechazoSede> MotivoRechazoSede { get; set; }
        public virtual DbSet<MotivoRechazoVacante> MotivoRechazoVacante { get; set; }
        public virtual DbSet<MotivosCertificadoHidro> MotivosCertificadoHidro { get; set; }
        public virtual DbSet<NfoNotificacionesOtros> NfoNotificacionesOtros { get; set; }
        public virtual DbSet<NfpNotificacionesProcesos> NfpNotificacionesProcesos { get; set; }
        public virtual DbSet<NfrNotificacionesRegistro> NfrNotificacionesRegistro { get; set; }
        public virtual DbSet<NfvNotificacionesVacantes> NfvNotificacionesVacantes { get; set; }
        public virtual DbSet<NivelUniversidad> NivelUniversidad { get; set; }
        public virtual DbSet<Niveles> Niveles { get; set; }
        public virtual DbSet<NoaNotificacionesAlarmas> NoaNotificacionesAlarmas { get; set; }
        public virtual DbSet<NooNotificacionesOcultar> NooNotificacionesOcultar { get; set; }
        public virtual DbSet<NtiNotificacionTipos> NtiNotificacionTipos { get; set; }
        public virtual DbSet<NucleoBasicoConocimiento> NucleoBasicoConocimiento { get; set; }
        public virtual DbSet<ObjObjetos> ObjObjetos { get; set; }
        public virtual DbSet<OfiTipo> OfiTipo { get; set; }
        public virtual DbSet<OriDescartes> OriDescartes { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<PaisesHome> PaisesHome { get; set; }
        public virtual DbSet<PcdProcesoCausalDescarte> PcdProcesoCausalDescarte { get; set; }
        public virtual DbSet<PcdProcesoCausalDescarteEliminados> PcdProcesoCausalDescarteEliminados { get; set; }
        public virtual DbSet<PerPeriodicidad> PerPeriodicidad { get; set; }
        public virtual DbSet<PermisosPerfil> PermisosPerfil { get; set; }
        public virtual DbSet<PersAreaprof> PersAreaprof { get; set; }
        public virtual DbSet<PersoTeletrabajo> PersoTeletrabajo { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<PersonaBeneficiarioSubsidio> PersonaBeneficiarioSubsidio { get; set; }
        public virtual DbSet<PersonaBeneficiarioSubsidioHist> PersonaBeneficiarioSubsidioHist { get; set; }
        public virtual DbSet<PersonaCambioPrestador1> PersonaCambioPrestador1 { get; set; }
        public virtual DbSet<PersonaInactivarCuenta> PersonaInactivarCuenta { get; set; }
        public virtual DbSet<Personas> Personas { get; set; }
        public virtual DbSet<PersonasAdmin> PersonasAdmin { get; set; }
        public virtual DbSet<PersonasAgencia> PersonasAgencia { get; set; }
        public virtual DbSet<PersonasArchivo> PersonasArchivo { get; set; }
        public virtual DbSet<PersonasEmpresa> PersonasEmpresa { get; set; }
        public virtual DbSet<PesProcesoEncuestaSatisfaccion> PesProcesoEncuestaSatisfaccion { get; set; }
        public virtual DbSet<PicPreinscripcionesCta> PicPreinscripcionesCta { get; set; }
        public virtual DbSet<PinPeriodoInd> PinPeriodoInd { get; set; }
        public virtual DbSet<PostuEstado> PostuEstado { get; set; }
        public virtual DbSet<Postulaciones> Postulaciones { get; set; }
        public virtual DbSet<PostulacionesMiSpe> PostulacionesMiSpe { get; set; }
        public virtual DbSet<PostuladoUltimoAcceso> PostuladoUltimoAcceso { get; set; }
        public virtual DbSet<Postulantes> Postulantes { get; set; }
        public virtual DbSet<PprPruebasXProceso> PprPruebasXProceso { get; set; }
        public virtual DbSet<PrcPreferenciasCargosArchivo> PrcPreferenciasCargosArchivo { get; set; }
        public virtual DbSet<PreSeleccionBusquedas> PreSeleccionBusquedas { get; set; }
        public virtual DbSet<PreSeleccionCandidatos> PreSeleccionCandidatos { get; set; }
        public virtual DbSet<PreSeleccionCriterios> PreSeleccionCriterios { get; set; }
        public virtual DbSet<PreSeleccionFiltroAnosDeExperiencia> PreSeleccionFiltroAnosDeExperiencia { get; set; }
        public virtual DbSet<PreSeleccionFiltroEdad> PreSeleccionFiltroEdad { get; set; }
        public virtual DbSet<PreSeleccionFiltroIdiomas> PreSeleccionFiltroIdiomas { get; set; }
        public virtual DbSet<PreSeleccionFiltroInstituciones> PreSeleccionFiltroInstituciones { get; set; }
        public virtual DbSet<PreSeleccionFiltroNombre> PreSeleccionFiltroNombre { get; set; }
        public virtual DbSet<PreSeleccionFiltroSexo> PreSeleccionFiltroSexo { get; set; }
        public virtual DbSet<PreSeleccionFiltros> PreSeleccionFiltros { get; set; }
        public virtual DbSet<PreguntasSeguridad> PreguntasSeguridad { get; set; }
        public virtual DbSet<PrfPerfiles> PrfPerfiles { get; set; }
        public virtual DbSet<PrfPeriodicidadFacturacion> PrfPeriodicidadFacturacion { get; set; }
        public virtual DbSet<PrfPreferenciasUsuario> PrfPreferenciasUsuario { get; set; }
        public virtual DbSet<ProceEstado> ProceEstado { get; set; }
        public virtual DbSet<ProceTipo> ProceTipo { get; set; }
        public virtual DbSet<ProceUsuario> ProceUsuario { get; set; }
        public virtual DbSet<Procesos> Procesos { get; set; }
        public virtual DbSet<ProcesosCertificacionesHidro> ProcesosCertificacionesHidro { get; set; }
        public virtual DbSet<ProcesosInterOrgaSedes> ProcesosInterOrgaSedes { get; set; }
        public virtual DbSet<ProcesosSectorHidrocarburos> ProcesosSectorHidrocarburos { get; set; }
        public virtual DbSet<ProcesosSubsectorHidrocarburos> ProcesosSubsectorHidrocarburos { get; set; }
        public virtual DbSet<ProcesosTipoProyectosHidrocarburos> ProcesosTipoProyectosHidrocarburos { get; set; }
        public virtual DbSet<ProduInterOrga> ProduInterOrga { get; set; }
        public virtual DbSet<ProduInterOrgaPublicaciones> ProduInterOrgaPublicaciones { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoEstado> ProductoEstado { get; set; }
        public virtual DbSet<ProductoTipo> ProductoTipo { get; set; }
        public virtual DbSet<ProgramaXProcesoYSede> ProgramaXProcesoYSede { get; set; }
        public virtual DbSet<ProgramaXgobierno> ProgramaXgobierno { get; set; }
        public virtual DbSet<PrpPruebasProcesos> PrpPruebasProcesos { get; set; }
        public virtual DbSet<PruPerfilesUsuario> PruPerfilesUsuario { get; set; }
        public virtual DbSet<PubliEstado> PubliEstado { get; set; }
        public virtual DbSet<Publicaciones> Publicaciones { get; set; }
        public virtual DbSet<Repositorio> Repositorio { get; set; }
        public virtual DbSet<RobRolObjeto> RobRolObjeto { get; set; }
        public virtual DbSet<RolRol> RolRol { get; set; }
        public virtual DbSet<RolUnidad> RolUnidad { get; set; }
        public virtual DbSet<RusRolUsuario> RusRolUsuario { get; set; }
        public virtual DbSet<SObjetos> SObjetos { get; set; }
        public virtual DbSet<SRolObje> SRolObje { get; set; }
        public virtual DbSet<SRolUsua> SRolUsua { get; set; }
        public virtual DbSet<SRolUsuaEliminados> SRolUsuaEliminados { get; set; }
        public virtual DbSet<SRoles> SRoles { get; set; }
        public virtual DbSet<SSesiones> SSesiones { get; set; }
        public virtual DbSet<SUsuarioAdmin> SUsuarioAdmin { get; set; }
        public virtual DbSet<SUsuarioAgencia> SUsuarioAgencia { get; set; }
        public virtual DbSet<SUsuarios> SUsuarios { get; set; }
        public virtual DbSet<SUsuariosArchivo> SUsuariosArchivo { get; set; }
        public virtual DbSet<SUsuariosEmpresa1> SUsuariosEmpresa1 { get; set; }
        public virtual DbSet<SadSuperAdministrador> SadSuperAdministrador { get; set; }
        public virtual DbSet<SalarioRango> SalarioRango { get; set; }
        public virtual DbSet<SecSector> SecSector { get; set; }
        public virtual DbSet<Sedes> Sedes { get; set; }
        public virtual DbSet<SedesAgencia> SedesAgencia { get; set; }
        public virtual DbSet<SedesAgenciaHistorico> SedesAgenciaHistorico { get; set; }
        public virtual DbSet<SedesEliminadas> SedesEliminadas { get; set; }
        public virtual DbSet<Sedesocultas> Sedesocultas { get; set; }
        public virtual DbSet<SeguSocEnti> SeguSocEnti { get; set; }
        public virtual DbSet<SeguSocTipoEnti> SeguSocTipoEnti { get; set; }
        public virtual DbSet<SituacionLaboral> SituacionLaboral { get; set; }
        public virtual DbSet<StpSubtipoPruebas> StpSubtipoPruebas { get; set; }
        public virtual DbSet<TarTarifa> TarTarifa { get; set; }
        public virtual DbSet<TarTarifaInicial> TarTarifaInicial { get; set; }
        public virtual DbSet<TblIngresoDemandante> TblIngresoDemandante { get; set; }
        public virtual DbSet<TblIngresoOferente> TblIngresoOferente { get; set; }
        public virtual DbSet<TblIngresoPrestador> TblIngresoPrestador { get; set; }
        public virtual DbSet<TblIngresoUnidad> TblIngresoUnidad { get; set; }
        public virtual DbSet<TipTipoPruebas> TipTipoPruebas { get; set; }
        public virtual DbSet<TipoCertificacion> TipoCertificacion { get; set; }
        public virtual DbSet<TipoCorreos> TipoCorreos { get; set; }
        public virtual DbSet<TipoDocumento> TipoDocumento { get; set; }
        public virtual DbSet<TipoExperienciaLaboral> TipoExperienciaLaboral { get; set; }
        public virtual DbSet<TipoJornadaLab> TipoJornadaLab { get; set; }
        public virtual DbSet<TipoLocalizacion> TipoLocalizacion { get; set; }
        public virtual DbSet<TipoPermiso> TipoPermiso { get; set; }
        public virtual DbSet<TipoPoblacionXProcesoYSede> TipoPoblacionXProcesoYSede { get; set; }
        public virtual DbSet<TipoPunto> TipoPunto { get; set; }
        public virtual DbSet<TipoRemu> TipoRemu { get; set; }
        public virtual DbSet<Titulos> Titulos { get; set; }
        public virtual DbSet<TitulosPaisRela> TitulosPaisRela { get; set; }
        public virtual DbSet<TmpBuscarTrabajo> TmpBuscarTrabajo { get; set; }
        public virtual DbSet<TpdTipoDocumento> TpdTipoDocumento { get; set; }
        public virtual DbSet<TpeTipoPeriodoInd> TpeTipoPeriodoInd { get; set; }
        public virtual DbSet<TpmTipoModulo> TpmTipoModulo { get; set; }
        public virtual DbSet<TpsTipoSolicitud> TpsTipoSolicitud { get; set; }
        public virtual DbSet<TrazaColocados20190312> TrazaColocados20190312 { get; set; }
        public virtual DbSet<TrazaLog20190312> TrazaLog20190312 { get; set; }
        public virtual DbSet<TrazaMarchingVacante20190507> TrazaMarchingVacante20190507 { get; set; }
        public virtual DbSet<TrazaMatchingHidro09012019tarde> TrazaMatchingHidro09012019tarde { get; set; }
        public virtual DbSet<TrazaMatchingHidro28012019> TrazaMatchingHidro28012019 { get; set; }
        public virtual DbSet<TrazaMatchingHidroCompleta846am> TrazaMatchingHidroCompleta846am { get; set; }
        public virtual DbSet<TrazaMatchingHidroCompleta903am> TrazaMatchingHidroCompleta903am { get; set; }
        public virtual DbSet<TrazaMatchingVacanteHidro20190109> TrazaMatchingVacanteHidro20190109 { get; set; }
        public virtual DbSet<TrazaObtenerDetalleHis20190312> TrazaObtenerDetalleHis20190312 { get; set; }
        public virtual DbSet<TrazaPostulacionesInsert20190312> TrazaPostulacionesInsert20190312 { get; set; }
        public virtual DbSet<Trazadeadlocks20190507> Trazadeadlocks20190507 { get; set; }
        public virtual DbSet<TscTipoServicioContratado> TscTipoServicioContratado { get; set; }
        public virtual DbSet<UpeUsuarioPruebasEval> UpeUsuarioPruebasEval { get; set; }
        public virtual DbSet<UppUsuarioPruebasProceso> UppUsuarioPruebasProceso { get; set; }
        public virtual DbSet<UprUsuarioPruebas> UprUsuarioPruebas { get; set; }
        public virtual DbSet<UsrUsuario> UsrUsuario { get; set; }
        public virtual DbSet<UsuarioCierreCuenta> UsuarioCierreCuenta { get; set; }
        public virtual DbSet<UsuariosCall> UsuariosCall { get; set; }
        public virtual DbSet<Veredas> Veredas { get; set; }
        public virtual DbSet<VlcValorCatalogo> VlcValorCatalogo { get; set; }

        // Unable to generate entity type for table 'dbo.Matching_postulaciones_vigentes_estado'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AuditoriaEmpresa'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.S_Usuarios_eliminados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AuditoriaAgencia'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.sedes_rechazadas'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.rptOferentes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmp_indicadores'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.validacion_hvinfobasica'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hv_segu_soc_elmininados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TELETRABAJO_MUNICIPIOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Postulantes_eliminados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.detalle_historico'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRA_PREFERENCIAS_AREAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_detalle_historico_colocados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_error_indicadores'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.valores_aleatorios'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUDITORIA_ESPERAS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hv_curso_elmininados'. Please see the warning messages.
        // Unable to generate entity type for table 'tmp.PERS_CONOSC_IDIOMA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_detalle_historico_remitidos'. Please see the warning messages.
        // Unable to generate entity type for table 'tmp.PERS_DERIVACION_INSCRIPCION'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Homologa_cargos'. Please see the warning messages.
        // Unable to generate entity type for table 'tmp.persona_cambio_prestador'. Please see the warning messages.
        // Unable to generate entity type for table 'log.Adjuntos_log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.agencia_Log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.detalle_historico_remitidos'. Please see the warning messages.
        // Unable to generate entity type for table 'log.AOC_ASISTENCIA_OFERENTE_CONVOCATORIA_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRC_PREFERENCIAS_CARGOS_eliminados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Auditoria_Bloqueos'. Please see the warning messages.
        // Unable to generate entity type for table 'log.ASI_ASISTENCIA_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'log.CEP_COLECTIVOS_ESP_PERSONA_log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.CES_COLECTIVOS_ESP_OTROS_log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.CIT_CITA_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'log.CNV_CONVOCATORIA_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'log.COA_COORDINADOR_AGENCIA_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CIT_CITA_eliminados'. Please see the warning messages.
        // Unable to generate entity type for table 'log.ComplementoHojaVida_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.postulaciones_elmininados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.detalle_historico_oferentes'. Please see the warning messages.
        // Unable to generate entity type for table 'log.consul_perso_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CES_COLECTIVOS_ESP_OTROS'. Please see the warning messages.
        // Unable to generate entity type for table 'log.CTA_CURSOS_TALLERES_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.detalle_historico_mes_remitidosBkUp20190814'. Please see the warning messages.
        // Unable to generate entity type for table 'tmp.Reporte_personas_fosfec'. Please see the warning messages.
        // Unable to generate entity type for table 'log.ENT_ENTIDAD_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'log.EVA_EVALUACION_log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.FFA_FOSFEC_CRITERIOS_AUDIT_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'log.FFC_CARGUE_log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.FFD_FOSFEC_DETALLE_VERSION_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ACP_ADMIN_CAND_POST_eliminados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PrestadorProgramas'. Please see the warning messages.
        // Unable to generate entity type for table 'log.FFV_FOSFEC_VERSIONES_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hv_estu_elmininados'. Please see the warning messages.
        // Unable to generate entity type for table 'log.HV_curso_log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.HV_estu_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.cargos_homologados_hidro'. Please see the warning messages.
        // Unable to generate entity type for table 'log.HV_idio_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'log.HV_info_basica_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ws_victimas'. Please see the warning messages.
        // Unable to generate entity type for table 'log.HV_labo_expe_log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.hv_ofimaticas_log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.HV_segu_soc_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tmpIndicadores'. Please see the warning messages.
        // Unable to generate entity type for table 'log.IHO_INTENSIDAD_HORARIA_log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.INS_INSCRIPCIONES_log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.logMigracion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.INS_INSCRIPCIONES_eliminados'. Please see the warning messages.
        // Unable to generate entity type for table 'log.Personas_agencia _log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.Personas_Empresa_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.EVA_EVALUACION_eliminados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.motivo_cancel_proceso'. Please see the warning messages.
        // Unable to generate entity type for table 'log.Personas_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.RAV_RANGO_VALOR'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.COA_COORDINADOR_AGENCIA'. Please see the warning messages.
        // Unable to generate entity type for table 'log.PIC_PREINSCRIPCIONES_CTA_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.log_ofertasFINAL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IAG_INDICADORES_PERIODO_AGENCIA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.logMigracion'. Please see the warning messages.
        // Unable to generate entity type for table 'log.Postulaciones_log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.Postulantes_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.detalle_historico_mes_oferentes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.IAS_INDICADORES_PERIODO_ASESOR'. Please see the warning messages.
        // Unable to generate entity type for table 'log.PPR_PRUEBAS_X_PROCESO_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'log.PrestadorProgramas_log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.Procesos_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hv_habi_elmininados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.detalle_historico_mes_remitidos'. Please see the warning messages.
        // Unable to generate entity type for table 'log.S_rol_usua_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CEP_COLECTIVOS_ESP_PERSONA_eliminados'. Please see the warning messages.
        // Unable to generate entity type for table 'log.s_usuario_agencia_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Auditoria'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tbl_control_colocados_faltantes'. Please see the warning messages.
        // Unable to generate entity type for table 'log.S_usuarios_Empresa_log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.S_usuarios_log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.Sedes_Agencia_log'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.permiso_por_tipo'. Please see the warning messages.
        // Unable to generate entity type for table 'log.UPE_USUARIO_PRUEBAS_EVAL_log'. Please see the warning messages.
        // Unable to generate entity type for table 'log.UPP_USUARIO_PRUEBAS_PROCESO_LOG'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUI_AUDIT_INTER_ORGA'. Please see the warning messages.
        // Unable to generate entity type for table 'mig.estado_vacantes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hv_idio_elmininados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.motivo_declina_vacante'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.s_usuario_agencia_acceso'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.AUP_AUDIT_PROCESOS'. Please see the warning messages.
        // Unable to generate entity type for table 'tmp.s_usuarios_empresa'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hv_info_basica_elmininados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.candi_condi_contrata_elmininados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.NOD_NOTIFICACIONES_DIAS'. Please see the warning messages.
        // Unable to generate entity type for table 'mig.homologa_titulos'. Please see the warning messages.
        // Unable to generate entity type for table 'mig.homologa_vlc_catalogo'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.detalle_historico_mes_remitidosBkUp20190814Full'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.detalle_historico_mes_remitidosBkUp20190814_Menor2019'. Please see the warning messages.
        // Unable to generate entity type for table 'tmp.sectores'. Please see the warning messages.
        // Unable to generate entity type for table 'log.ObjetosSleep'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.SeguimientoSesionesDBA'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Sise_Indicadores_metas'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hist_postu_oferente_eliminados'. Please see the warning messages.
        // Unable to generate entity type for table 'tmp.usuario_contacto'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.aud_julian'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.producto_condicion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Inactivos_voluntarios_MatchingV'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TELETRABAJO_GENERAL'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TiempoExperiencia'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PRC_PREFERENCIAS_CARGOS'. Please see the warning messages.
        // Unable to generate entity type for table 'tmp.PERSONAS_EMIGRANTES_RETORNADOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.CiudadesTemporal'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Reporte_sabana_vacantes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hv_consultadas'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.reporte_sabana_colocados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TMP_Nacionalidades'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.reporte_sabana_remitidos'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.tablaCorreos'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TELETRABAJO_NIVELES_EDUCATIVOS'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.reporte_sabana_inscritos'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.TELETRABAJO_AREAS_OCUPACIONALES'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.hv_labo_expe_elmininados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.reporte_sabana_direccionamientos'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.reporte_sabana_demandantes'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.detalle_historico_vacante'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.Productos_iva'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.empre_campo_ocupacion'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.personas_eliminados'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.PIC_PREINSCRIPCIONES_CTA_eliminados'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
// optionsBuilder.UseSqlServer("data Source=13.77.73.90;Initial Catalog=SISE;User id=lvivas;password=Asopagos2020*$;Connection Timeout=120000;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<Acciones>(entity =>
            {
                entity.HasKey(e => e.AccionId);

                entity.ToTable("Acciones", "auditoria");

                entity.Property(e => e.AccionId).HasColumnName("Accion_Id");

                entity.Property(e => e.NombreAccion)
                    .IsRequired()
                    .HasColumnName("nombreAccion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AcpAdminCandPost>(entity =>
            {
                entity.HasKey(e => e.PosId);

                entity.ToTable("ACP_ADMIN_CAND_POST");

                entity.HasIndex(e => new { e.PosId, e.AcpFechaEscId, e.EscId })
                    .HasName("IX_ACP_ADMIN_CAND_POST_EscId_PosId_FechaEscID");

                entity.Property(e => e.PosId)
                    .HasColumnName("POS_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcpDescartado).HasColumnName("ACP_DESCARTADO");

                entity.Property(e => e.AcpEvalAprobado).HasColumnName("ACP_EVAL_APROBADO");

                entity.Property(e => e.AcpEvalDescartado).HasColumnName("ACP_EVAL_DESCARTADO");

                entity.Property(e => e.AcpEvalPendiente).HasColumnName("ACP_EVAL_PENDIENTE");

                entity.Property(e => e.AcpFechaAccionEvaluacion)
                    .HasColumnName("ACP_FECHA_ACCION_EVALUACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcpFechaAccionPreseleccion)
                    .HasColumnName("ACP_FECHA_ACCION_PRESELECCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcpFechaAccionRemisionEmpresa)
                    .HasColumnName("ACP_FECHA_ACCION_REMISION_EMPRESA")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcpFechaEscId)
                    .HasColumnName("ACP_FECHA_ESC_ID")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcpFechaPostulacion)
                    .HasColumnName("ACP_FECHA_POSTULACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcpFechaRespuestaEmpresa)
                    .HasColumnName("ACP_FECHA_RESPUESTA_EMPRESA")
                    .HasColumnType("datetime");

                entity.Property(e => e.AcpPendiente).HasColumnName("ACP_PENDIENTE");

                entity.Property(e => e.AcpPreseleccionado).HasColumnName("ACP_PRESELECCIONADO");

                entity.Property(e => e.AcpRemitidoEmpresa).HasColumnName("ACP_REMITIDO_EMPRESA");

                entity.Property(e => e.AcpRespuestaEmpresaDescartado).HasColumnName("ACP_RESPUESTA_EMPRESA_DESCARTADO");

                entity.Property(e => e.AcpRespuestaEmpresaSeleccionado).HasColumnName("ACP_RESPUESTA_EMPRESA_SELECCIONADO");

                entity.Property(e => e.AcpVerEntreOri).HasColumnName("ACP_VER_ENTRE_ORI");

                entity.Property(e => e.AcpVistoEmp).HasColumnName("ACP_VISTO_EMP");

                entity.Property(e => e.EscId).HasColumnName("ESC_ID");

                entity.Property(e => e.EscIdAnterior).HasColumnName("esc_id_anterior");

                entity.Property(e => e.PersoIdAgenteNoselec).HasColumnName("perso_id_Agente_noselec");

                entity.Property(e => e.PersoIdAgentePreseleccion).HasColumnName("perso_id_Agente_preseleccion");

                entity.Property(e => e.PersoIdAgenteRemiteEmpresa).HasColumnName("perso_id_Agente_remite_empresa");

                entity.Property(e => e.PersoIdAgenteSelec).HasColumnName("perso_id_Agente_selec");

                entity.HasOne(d => d.Esc)
                    .WithMany(p => p.AcpAdminCandPost)
                    .HasForeignKey(d => d.EscId)
                    .HasConstraintName("FK_ESC_ESTADO_CANDIDATURA_ACP_ADMIN_CAND_POST");

                entity.HasOne(d => d.Pos)
                    .WithOne(p => p.AcpAdminCandPost)
                    .HasForeignKey<AcpAdminCandPost>(d => d.PosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACP_ADMIN_CAND_POST_Postulaciones");
            });

            modelBuilder.Entity<ActActividad>(entity =>
            {
                entity.HasKey(e => e.ActId);

                entity.ToTable("ACT_ACTIVIDAD");

                entity.Property(e => e.ActId).HasColumnName("ACT_ID");

                entity.Property(e => e.ActCodigo).HasColumnName("ACT_CODIGO");

                entity.Property(e => e.ActNombre)
                    .IsRequired()
                    .HasColumnName("ACT_NOMBRE")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.IndId).HasColumnName("IND_ID");

                entity.Property(e => e.SecId).HasColumnName("SEC_ID");

                entity.HasOne(d => d.Ind)
                    .WithMany(p => p.ActActividad)
                    .HasForeignKey(d => d.IndId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACT_ACTIVIDAD_IND_INDUSTRIA");

                entity.HasOne(d => d.Sec)
                    .WithMany(p => p.ActActividad)
                    .HasForeignKey(d => d.SecId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACT_ACTIVIDAD_SEC_SECTOR");
            });

            modelBuilder.Entity<AdjunTipo>(entity =>
            {
                entity.ToTable("Adjun_tipo");

                entity.Property(e => e.AdjunTipoId)
                    .HasColumnName("adjun_tipo_id")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Adjuntos>(entity =>
            {
                entity.HasKey(e => new { e.PersoId, e.AdjunOr });

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.AdjunOr).HasColumnName("adjun_or");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.TipoAdjunId)
                    .HasColumnName("tipo_adjun_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.Adjuntos)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Adjuntos_HV_info_basica");

                entity.HasOne(d => d.TipoAdjun)
                    .WithMany(p => p.Adjuntos)
                    .HasForeignKey(d => d.TipoAdjunId)
                    .HasConstraintName("FK_Adjuntos_Adjun_tipo");
            });

            modelBuilder.Entity<AdminCorreos>(entity =>
            {
                entity.HasKey(e => e.IdCorreo);

                entity.ToTable("admin_correos");

                entity.Property(e => e.IdCorreo).HasColumnName("id_correo");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdTipocorreo).HasColumnName("id_tipocorreo");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.Texto)
                    .HasColumnName("texto")
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipocorreoNavigation)
                    .WithMany(p => p.AdminCorreos)
                    .HasForeignKey(d => d.IdTipocorreo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_admin_correos_admin_correos");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.AdminCorreos)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_admin_correos_S_usuarios_Empresa");
            });

            modelBuilder.Entity<Agencia>(entity =>
            {
                entity.HasKey(e => e.IdAgencia);

                entity.ToTable("agencia");

                entity.HasIndex(e => new { e.IdAgencia, e.AgeEntId })
                    .HasName("_dta_index_agencia_5_1726733304__K1_K12_2894");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.AgeActivo)
                    .HasColumnName("AGE_ACTIVO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AgeCiuId)
                    .IsRequired()
                    .HasColumnName("AGE_CIU_ID")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.AgeDepId)
                    .IsRequired()
                    .HasColumnName("AGE_DEP_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AgeDireccion)
                    .HasColumnName("AGE_DIRECCION")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AgeEntId).HasColumnName("AGE_ENT_ID");

                entity.Property(e => e.AgeFax)
                    .HasColumnName("AGE_FAX")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgeFechaAct)
                    .HasColumnName("age_fecha_act")
                    .HasColumnType("datetime");

                entity.Property(e => e.AgeFechaReg)
                    .HasColumnName("age_fecha_reg")
                    .HasColumnType("datetime");

                entity.Property(e => e.AgePaisId)
                    .IsRequired()
                    .HasColumnName("AGE_PAIS_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.AgeTel)
                    .HasColumnName("AGE_TEL")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.AgeTel2)
                    .HasColumnName("AGE_TEL2")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.AgenPublica).HasColumnName("AGEN_PUBLICA");

                entity.Property(e => e.AgenTipo)
                    .HasColumnName("AGEN_TIPO")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoAgencia)
                    .HasColumnName("codigo_agencia")
                    .HasMaxLength(10);

                entity.Property(e => e.NombreAgencia)
                    .HasColumnName("nombre_agencia")
                    .HasMaxLength(500);

                entity.HasOne(d => d.AgeEnt)
                    .WithMany(p => p.Agencia)
                    .HasForeignKey(d => d.AgeEntId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_agencia_ENT_ENTIDAD");

                entity.HasOne(d => d.AgePais)
                    .WithMany(p => p.Agencia)
                    .HasForeignKey(d => d.AgePaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_agencia_Paises");

                entity.HasOne(d => d.Age)
                    .WithMany(p => p.Agencia)
                    .HasForeignKey(d => new { d.AgePaisId, d.AgeDepId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_agencia_Departamentos");

                entity.HasOne(d => d.AgeNavigation)
                    .WithMany(p => p.Agencia)
                    .HasForeignKey(d => new { d.AgePaisId, d.AgeDepId, d.AgeCiuId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_agencia_Ciudades");
            });

            modelBuilder.Entity<AgenciaEmpresas>(entity =>
            {
                entity.ToTable("agencia_empresas");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");
            });

            modelBuilder.Entity<AgenciaInterOrga>(entity =>
            {
                entity.HasKey(e => e.IdAgenciaInteroga);

                entity.ToTable("Agencia_InterOrga");

                entity.Property(e => e.IdAgenciaInteroga).HasColumnName("Id_Agencia_Interoga");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.AgenciaInterOrga)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Agencia_InterOrga_agencia");

                entity.HasOne(d => d.InterOrga)
                    .WithMany(p => p.AgenciaInterOrga)
                    .HasForeignKey(d => d.InterOrgaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Agencia_InterOrga_Inter_orga");
            });

            modelBuilder.Entity<Aglomeracion>(entity =>
            {
                entity.HasKey(e => new { e.AglomeracionId, e.CiudadId });

                entity.Property(e => e.AglomeracionId)
                    .HasColumnName("aglomeracion_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AocAsistenciaOferenteConvocatoria>(entity =>
            {
                entity.HasKey(e => new { e.CnvId, e.PersoId });

                entity.ToTable("AOC_ASISTENCIA_OFERENTE_CONVOCATORIA");

                entity.Property(e => e.CnvId).HasColumnName("CNV_ID");

                entity.Property(e => e.PersoId).HasColumnName("PERSO_ID");

                entity.Property(e => e.EstadoAsistencia)
                    .IsRequired()
                    .HasColumnName("ESTADO_ASISTENCIA")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HorasAsistidas)
                    .HasColumnName("HORAS_ASISTIDAS")
                    .HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.Cnv)
                    .WithMany(p => p.AocAsistenciaOferenteConvocatoria)
                    .HasForeignKey(d => d.CnvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AOC_ASISTENCIA_OFERENTE_CONVOCATORIA_CNV_CONVOCATORIA");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.AocAsistenciaOferenteConvocatoria)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AOC_ASISTENCIA_OFERENTE_CONVOCATORIA_Personas");
            });

            modelBuilder.Entity<AocAsistenciaOferenteConvocatoriaEliminados>(entity =>
            {
                entity.HasKey(e => new { e.CnvId, e.PersoId });

                entity.ToTable("AOC_ASISTENCIA_OFERENTE_CONVOCATORIA_eliminados");

                entity.Property(e => e.CnvId).HasColumnName("CNV_ID");

                entity.Property(e => e.PersoId).HasColumnName("PERSO_ID");

                entity.Property(e => e.EstadoAsistencia)
                    .IsRequired()
                    .HasColumnName("ESTADO_ASISTENCIA")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.HorasAsistidas)
                    .HasColumnName("HORAS_ASISTIDAS")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<AprAuditPruebasProcesos>(entity =>
            {
                entity.HasKey(e => e.AprId)
                    .HasName("PK_APR_PRUEBAS_PROCESOS");

                entity.ToTable("APR_AUDIT_PRUEBAS_PROCESOS");

                entity.Property(e => e.AprId).HasColumnName("APR_ID");

                entity.Property(e => e.AprFechaCambio)
                    .HasColumnName("APR_FECHA_CAMBIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.AprIdAnterior).HasColumnName("APR_ID_ANTERIOR");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.PersoIdCre).HasColumnName("perso_id_cre");

                entity.Property(e => e.PersoIdMod).HasColumnName("perso_id_mod");

                entity.Property(e => e.PrpComentarios)
                    .HasColumnName("PRP_COMENTARIOS")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PrpDescripcion)
                    .HasColumnName("PRP_DESCRIPCION")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PrpEstado).HasColumnName("PRP_ESTADO");

                entity.Property(e => e.PrpFechaCrea)
                    .HasColumnName("PRP_FECHA_CREA")
                    .HasColumnType("date");

                entity.Property(e => e.PrpFechaMod)
                    .HasColumnName("PRP_FECHA_MOD")
                    .HasColumnType("date");

                entity.Property(e => e.PrpFile)
                    .HasColumnName("PRP_FILE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrpId).HasColumnName("PRP_ID");

                entity.Property(e => e.PrpNombre)
                    .IsRequired()
                    .HasColumnName("PRP_NOMBRE")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StpId).HasColumnName("STP_ID");

                entity.Property(e => e.TipMov)
                    .IsRequired()
                    .HasColumnName("TIP_MOV")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AreaDesempenio>(entity =>
            {
                entity.HasKey(e => e.IdAreaDesempeno);

                entity.Property(e => e.IdAreaDesempeno).ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AreaOcupacional>(entity =>
            {
                entity.HasKey(e => e.IdAreaOcupacional);

                entity.Property(e => e.IdAreaOcupacional).ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AsiAsistencia>(entity =>
            {
                entity.HasKey(e => new { e.IhoFecha, e.PersoIdOferente, e.CnvId })
                    .HasName("PK_ASI_ASISTENCIA_1");

                entity.ToTable("ASI_ASISTENCIA");

                entity.HasIndex(e => e.CnvId);

                entity.Property(e => e.IhoFecha)
                    .HasColumnName("IHO_FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersoIdOferente).HasColumnName("PERSO_ID_OFERENTE");

                entity.Property(e => e.CnvId).HasColumnName("CNV_ID");

                entity.Property(e => e.AsiAsistio).HasColumnName("ASI_ASISTIO");

                entity.Property(e => e.AsiJustifica).HasColumnName("ASI_JUSTIFICA");

                entity.Property(e => e.AsiNoAsistio).HasColumnName("ASI_NO_ASISTIO");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AucAuditCursosTalleres>(entity =>
            {
                entity.HasKey(e => e.AucId);

                entity.ToTable("AUC_AUDIT_CURSOS_TALLERES");

                entity.Property(e => e.AucId).HasColumnName("AUC_ID");

                entity.Property(e => e.AucFechaCambio)
                    .HasColumnName("AUC_FECHA_CAMBIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.AucIdAnterior).HasColumnName("AUC_ID_ANTERIOR");

                entity.Property(e => e.AucTipMov)
                    .IsRequired()
                    .HasColumnName("AUC_TIP_MOV")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CtaFechaCreacion)
                    .HasColumnName("CTA_FECHA_CREACION")
                    .HasColumnType("date");

                entity.Property(e => e.CtaFechaUltModif)
                    .HasColumnName("CTA_FECHA_ULT_MODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtaId).HasColumnName("CTA_ID");

                entity.Property(e => e.CtaUsuUltModif).HasColumnName("CTA_USU_ULT_MODIF");

                entity.Property(e => e.CtaUsurioCrea).HasColumnName("CTA_USURIO_CREA");

                entity.Property(e => e.VlcEstadoCuenta).HasColumnName("VLC_ESTADO_CUENTA");
            });

            modelBuilder.Entity<CandiCondiContrata>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId, e.PersoId });

                entity.ToTable("Candi_condi_contrata");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.CondiContrata)
                    .HasColumnName("condi_contrata")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CandiEsta>(entity =>
            {
                entity.ToTable("candi_esta");

                entity.Property(e => e.CandiEstaId)
                    .HasColumnName("candi_esta_id")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CandidatosArchivo>(entity =>
            {
                entity.HasKey(e => e.ArchiId);

                entity.ToTable("Candidatos_Archivo");

                entity.Property(e => e.ArchiId).HasColumnName("archi_id");

                entity.Property(e => e.Archivo)
                    .HasColumnName("archivo")
                    .HasMaxLength(4000);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(4000);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdEtapaProceso).HasColumnName("id_etapa_proceso");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.PersoEmpresaId).HasColumnName("perso_empresa_id");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.TituloArchivo)
                    .HasColumnName("titulo_archivo")
                    .HasMaxLength(255);

                entity.HasOne(d => d.IdEtapaProcesoNavigation)
                    .WithMany(p => p.CandidatosArchivo)
                    .HasForeignKey(d => d.IdEtapaProceso)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Candidatos_Archivo_Etapa_Proceso");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.CandidatosArchivo)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Candidatos_Archivo_Personas");

                entity.HasOne(d => d.Procesos)
                    .WithMany(p => p.CandidatosArchivo)
                    .HasForeignKey(d => new { d.InterOrgaId, d.ProcesoId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Candidatos_Archivo_Procesos");
            });

            modelBuilder.Entity<CargoDetalle>(entity =>
            {
                entity.ToTable("Cargo_detalle");

                entity.Property(e => e.CargoDetalleId).HasColumnName("cargo_detalle_id");

                entity.Property(e => e.CargoId)
                    .IsRequired()
                    .HasColumnName("cargo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EstuNivelId)
                    .IsRequired()
                    .HasColumnName("estu_nivel_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EstuOrden).HasColumnName("estu_orden");

                entity.Property(e => e.IdGrupoOcupacional).HasColumnName("idGrupoOcupacional");

                entity.Property(e => e.IdSalarioRango)
                    .HasColumnName("idSalarioRango")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MesesExpRequeridos).HasColumnName("meses_exp_requeridos");

                entity.HasOne(d => d.Cargo)
                    .WithMany(p => p.CargoDetalle)
                    .HasForeignKey(d => d.CargoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cargo_det__cargo__298F54B0");

                entity.HasOne(d => d.EstuNivel)
                    .WithMany(p => p.CargoDetalle)
                    .HasForeignKey(d => d.EstuNivelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cargo_det__estu___26B2E805");

                entity.HasOne(d => d.IdGrupoOcupacionalNavigation)
                    .WithMany(p => p.CargoDetalle)
                    .HasForeignKey(d => d.IdGrupoOcupacional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cargo_det__idGru__27A70C3E");

                entity.HasOne(d => d.IdSalarioRangoNavigation)
                    .WithMany(p => p.CargoDetalle)
                    .HasForeignKey(d => d.IdSalarioRango)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Cargo_det__idSal__289B3077");
            });

            modelBuilder.Entity<Cargos>(entity =>
            {
                entity.HasKey(e => e.CargoId);

                entity.HasIndex(e => e.EsEstandarizado)
                    .HasName("ix_Cargos_es_estandarizado");

                entity.HasIndex(e => new { e.CargoId, e.IdDenominacion })
                    .HasName("IX_Cargos_IdDenominacion");

                entity.HasIndex(e => new { e.EsHidrocarburos, e.CargoId })
                    .HasName("_dta_index_Cargos_5_1466540358__K7_K1");

                entity.Property(e => e.CargoId)
                    .HasColumnName("cargo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Codigo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EsEstandarizado).HasColumnName("es_estandarizado");

                entity.Property(e => e.EsHidrocarburos).HasColumnName("es_hidrocarburos");

                entity.Property(e => e.IdCargoHidro)
                    .HasColumnName("id_cargo_hidro")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ManoObraCalificada)
                    .HasColumnName("mano_obra_calificada")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(320);
            });

            modelBuilder.Entity<CargosPaisRela>(entity =>
            {
                entity.HasKey(e => new { e.CargoId, e.PaisId })
                    .HasName("PK_Cargo_pais_rela");

                entity.ToTable("Cargos_pais_rela");

                entity.Property(e => e.CargoId)
                    .HasColumnName("cargo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cargo)
                    .WithMany(p => p.CargosPaisRela)
                    .HasForeignKey(d => d.CargoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cargo_pais_rela_Cargos");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.CargosPaisRela)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cargo_pais_rela_Paises_Home");
            });

            modelBuilder.Entity<CcnConceptoConvenio>(entity =>
            {
                entity.HasKey(e => e.CcnId);

                entity.ToTable("CCN_CONCEPTO_CONVENIO");

                entity.Property(e => e.CcnId).HasColumnName("CCN_ID");

                entity.Property(e => e.CcnConcepto)
                    .IsRequired()
                    .HasColumnName("CCN_CONCEPTO")
                    .HasMaxLength(100);

                entity.Property(e => e.CcnConvenio).HasColumnName("CCN_CONVENIO");

                entity.Property(e => e.CcnPrfId).HasColumnName("CCN_PRF_ID");

                entity.Property(e => e.CcnValor)
                    .HasColumnName("CCN_VALOR")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<CcniConceptoInicial>(entity =>
            {
                entity.HasKey(e => e.CcniId)
                    .HasName("PK_CCNI_CONCEPTO_INICAL");

                entity.ToTable("CCNI_CONCEPTO_INICIAL");

                entity.Property(e => e.CcniId).HasColumnName("CCNI_ID");

                entity.Property(e => e.CcniConcepto)
                    .IsRequired()
                    .HasColumnName("CCNI_CONCEPTO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CcniConvenio).HasColumnName("CCNI_CONVENIO");

                entity.Property(e => e.CcniPfId).HasColumnName("CCNI_PF_ID");

                entity.Property(e => e.CcniValorCuota)
                    .HasColumnName("CCNI_VALOR_CUOTA")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CcniValorTotal)
                    .HasColumnName("CCNI_VALOR_TOTAL")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<CcoPeriodicidadConvocatoria>(entity =>
            {
                entity.HasKey(e => new { e.CnvId, e.VlcRepetirCada });

                entity.ToTable("CCO_PERIODICIDAD_CONVOCATORIA");

                entity.Property(e => e.CnvId).HasColumnName("CNV_ID");

                entity.Property(e => e.VlcRepetirCada).HasColumnName("VLC_REPETIR_CADA");

                entity.HasOne(d => d.Cnv)
                    .WithMany(p => p.CcoPeriodicidadConvocatoria)
                    .HasForeignKey(d => d.CnvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CCO_PERIODICIDAD_CONVOCATORIA_CNV_CONVOCATORIA");

                entity.HasOne(d => d.VlcRepetirCadaNavigation)
                    .WithMany(p => p.CcoPeriodicidadConvocatoria)
                    .HasForeignKey(d => d.VlcRepetirCada)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CCO_PERIODICIDAD_CONVOCATORIA_VLC_VALOR_CATALOGO");
            });

            modelBuilder.Entity<CctCausalNoContratacion>(entity =>
            {
                entity.HasKey(e => e.CctId);

                entity.ToTable("CCT_CAUSAL_NO_CONTRATACION");

                entity.Property(e => e.CctId).HasColumnName("CCT_ID");

                entity.Property(e => e.CctNombre)
                    .IsRequired()
                    .HasColumnName("CCT_NOMBRE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CdcCausalesDescarte>(entity =>
            {
                entity.HasKey(e => e.CdcId)
                    .HasName("PK__CDC_CAUS__A70CE9353A1445FE");

                entity.ToTable("CDC_CAUSALES_DESCARTE");

                entity.Property(e => e.CdcId)
                    .HasColumnName("CDC_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdcActiva).HasColumnName("CDC_ACTIVA");

                entity.Property(e => e.CdcNombre)
                    .IsRequired()
                    .HasColumnName("CDC_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CdcNoseleccionadoVhidro).HasColumnName("CDC_NOSELECCIONADO_VHIDRO");

                entity.Property(e => e.CdcNoseleccionadoVnormal).HasColumnName("CDC_NOSELECCIONADO_VNORMAL");

                entity.Property(e => e.CdcTipo)
                    .HasColumnName("CDC_TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CentroPoblado>(entity =>
            {
                entity.HasKey(e => e.PobladoId);

                entity.ToTable("Centro_poblado");

                entity.Property(e => e.PobladoId)
                    .HasColumnName("poblado_id")
                    .HasMaxLength(8)
                    .ValueGeneratedNever();

                entity.Property(e => e.CentroPoblado1)
                    .IsRequired()
                    .HasColumnName("Centro_poblado")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId)
                    .IsRequired()
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5);

                entity.Property(e => e.TipoCentroPoblado)
                    .IsRequired()
                    .HasColumnName("tipo_centro_poblado")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CepColectivosEspPersona>(entity =>
            {
                entity.HasKey(e => new { e.CesId, e.PersoId });

                entity.ToTable("CEP_COLECTIVOS_ESP_PERSONA");

                entity.HasIndex(e => new { e.CesId, e.PersoId })
                    .HasName("IX_CEP_COLECTIVOS_ESP_PERSONA_PERSO_ID");

                entity.HasIndex(e => new { e.PersoId, e.CesId, e.FechaActualizacion })
                    .HasName("IXX_CEP_COLECTIVOS_ESP_PERSONA_CES_ID_fecha_actualizacion");

                entity.Property(e => e.CesId).HasColumnName("CES_ID");

                entity.Property(e => e.PersoId).HasColumnName("PERSO_ID");

                entity.Property(e => e.CesPaisRetornado)
                    .HasColumnName("CES_PAIS_RETORNADO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("fecha_actualizacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCertificacion)
                    .HasColumnName("fecha_certificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVigencia)
                    .HasColumnName("fecha_vigencia")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Ces)
                    .WithMany(p => p.CepColectivosEspPersona)
                    .HasForeignKey(d => d.CesId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CEP_COLECTIVOS_ESP_PERSONA_CES_COLECTIVOS_ESP");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.CepColectivosEspPersona)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CEP_COLECTIVOS_ESP_PERSONA_Personas");
            });

            modelBuilder.Entity<CepColectivosEspPersonaArchivo>(entity =>
            {
                entity.ToTable("CEP_COLECTIVOS_ESP_PERSONA_archivo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CesId).HasColumnName("CES_ID");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("fecha_actualizacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCertificacion)
                    .HasColumnName("fecha_certificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaVigencia)
                    .HasColumnName("fecha_vigencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersoId).HasColumnName("PERSO_ID");
            });

            modelBuilder.Entity<CesColectivosEsp>(entity =>
            {
                entity.HasKey(e => e.CesId);

                entity.ToTable("CES_COLECTIVOS_ESP");

                entity.Property(e => e.CesId).HasColumnName("CES_ID");

                entity.Property(e => e.CesNombre)
                    .IsRequired()
                    .HasColumnName("CES_NOMBRE")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CesOrden).HasColumnName("CES_ORDEN");

                entity.Property(e => e.Tipo)
                    .HasColumnName("TIPO")
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CgiGrupoIndicador>(entity =>
            {
                entity.HasKey(e => e.CgiId)
                    .HasName("PK__CGI_GRUP__D81AEE50E69EBD83");

                entity.ToTable("CGI_GRUPO_INDICADOR");

                entity.Property(e => e.CgiId)
                    .HasColumnName("CGI_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CgiDescripcion)
                    .IsRequired()
                    .HasColumnName("CGI_DESCRIPCION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CgiOrden).HasColumnName("CGI_ORDEN");
            });

            modelBuilder.Entity<CinConceptoIndicador>(entity =>
            {
                entity.HasKey(e => e.CinId)
                    .HasName("PK__CIN_CONC__884C2C76496AB7C2");

                entity.ToTable("CIN_CONCEPTO_INDICADOR");

                entity.Property(e => e.CinId)
                    .HasColumnName("CIN_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CgiId).HasColumnName("CGI_ID");

                entity.Property(e => e.CinDescripcion)
                    .IsRequired()
                    .HasColumnName("CIN_DESCRIPCION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CinOrden).HasColumnName("CIN_ORDEN");

                entity.HasOne(d => d.Cgi)
                    .WithMany(p => p.CinConceptoIndicador)
                    .HasForeignKey(d => d.CgiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CIN_CONCEPTO_INDICADOR_CGI_GRUPO_INDICADOR");
            });

            modelBuilder.Entity<Cipres>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DetalleAgenciaActualizado)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleAgenciaNuevo)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DetallePrestadoresActualizado)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleUsuarioNuevo)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.DetalleprestadoresNuevo)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.FechaEjecucion).HasColumnType("datetime");

                entity.Property(e => e.XmlPrestador).IsUnicode(false);

                entity.Property(e => e.XmlPunto).IsUnicode(false);
            });

            modelBuilder.Entity<CitCita>(entity =>
            {
                entity.HasKey(e => e.CitId);

                entity.ToTable("CIT_CITA");

                entity.HasIndex(e => e.EvaId);

                entity.HasIndex(e => e.PersoIdOferente);

                entity.HasIndex(e => new { e.PersoIdOferente, e.CnvId });

                entity.HasIndex(e => new { e.PersoIdOferente, e.VlcEstadoCita });

                entity.HasIndex(e => new { e.CitId, e.PersoIdOferente, e.VlcEstadoCita })
                    .HasName("IX_CIT_CITA_VLC_ESTADO_CITA");

                entity.HasIndex(e => new { e.CitId, e.PersoIdOferente, e.CitFechaSolicitud, e.VlcEstadoCita })
                    .HasName("IXX_CIT_CITA_VLC_ESTADO_CITA");

                entity.Property(e => e.CitId).HasColumnName("CIT_ID");

                entity.Property(e => e.CitAutoSolicitud).HasColumnName("CIT_AUTO_SOLICITUD");

                entity.Property(e => e.CitFechaEjecucion)
                    .HasColumnName("CIT_FECHA_EJECUCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.CitFechaSolicitud)
                    .HasColumnName("CIT_FECHA_SOLICITUD")
                    .HasColumnType("datetime");

                entity.Property(e => e.CnvId).HasColumnName("CNV_ID");

                entity.Property(e => e.CtaId).HasColumnName("CTA_ID");

                entity.Property(e => e.EvaId).HasColumnName("EVA_ID");

                entity.Property(e => e.PersoIdGestiona).HasColumnName("PERSO_ID_GESTIONA");

                entity.Property(e => e.PersoIdOferente).HasColumnName("PERSO_ID_OFERENTE");

                entity.Property(e => e.PersoIdReco).HasColumnName("PERSO_ID_RECO");

                entity.Property(e => e.VlcEstadoCita).HasColumnName("VLC_ESTADO_CITA");

                entity.HasOne(d => d.PersoIdOferenteNavigation)
                    .WithMany(p => p.CitCita)
                    .HasForeignKey(d => d.PersoIdOferente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CIT_CITA_Personas");

                entity.HasOne(d => d.VlcEstadoCitaNavigation)
                    .WithMany(p => p.CitCita)
                    .HasForeignKey(d => d.VlcEstadoCita)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CIT_CITA_VLC_VALOR_CATALOGO");
            });

            modelBuilder.Entity<CitHistoria>(entity =>
            {
                entity.HasKey(e => e.CihId);

                entity.ToTable("CIT_HISTORIA");

                entity.Property(e => e.CihId).HasColumnName("CIH_ID");

                entity.Property(e => e.CitId).HasColumnName("CIT_ID");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.VlcEstado).HasColumnName("VLC_ESTADO");
            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.HasKey(e => new { e.PaisId, e.DepartamentoId, e.CiudadId });

                entity.HasIndex(e => new { e.Nombre, e.CiudadId })
                    .HasName("IX_Ciudades_ciudad_id");

                entity.HasIndex(e => new { e.Nombre, e.DepartamentoId, e.CiudadId })
                    .HasName("IX_Ciudades_departamento_id_ciudad_id");

                entity.HasIndex(e => new { e.PaisId, e.CiudadId, e.DepartamentoId })
                    .HasName("_dta_index_Ciudades_5_83531381__K1_K3_K2_1240");

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<ClasePrestador>(entity =>
            {
                entity.HasKey(e => e.ClaseId);

                entity.ToTable("Clase_Prestador");

                entity.Property(e => e.ClaseId).HasColumnName("CLASE_ID");

                entity.Property(e => e.ClasePrestador1)
                    .IsRequired()
                    .HasColumnName("CLASE_PRESTADOR")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Clasificados>(entity =>
            {
                entity.HasKey(e => e.ClasificadoId);

                entity.ToTable("clasificados");

                entity.Property(e => e.ClasificadoId).HasColumnName("clasificado_id");

                entity.Property(e => e.Centimetros).HasColumnName("centimetros");

                entity.Property(e => e.Columnas).HasColumnName("columnas");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.NumCaracteresDescLogo).HasColumnName("num_caracteres_descLogo");

                entity.Property(e => e.NumCaracteresDescripcion).HasColumnName("num_caracteres_descripcion");

                entity.Property(e => e.NumCaracteresTitulo).HasColumnName("num_caracteres_titulo");
            });

            modelBuilder.Entity<CnvConvenio>(entity =>
            {
                entity.HasKey(e => e.CnvId);

                entity.ToTable("CNV_CONVENIO");

                entity.Property(e => e.CnvId).HasColumnName("CNV_ID");

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CnvDireccion)
                    .HasColumnName("CNV_DIRECCION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CnvFechaFinVig)
                    .HasColumnName("CNV_FECHA_FIN_VIG")
                    .HasColumnType("datetime");

                entity.Property(e => e.CnvFechaIniVig)
                    .HasColumnName("CNV_FECHA_INI_VIG")
                    .HasColumnType("datetime");

                entity.Property(e => e.CnvNoLic).HasColumnName("CNV_NO_LIC");

                entity.Property(e => e.CnvPrfContrato).HasColumnName("CNV_PRF_CONTRATO");

                entity.Property(e => e.CnvPrfFactura).HasColumnName("CNV_PRF_FACTURA");

                entity.Property(e => e.CnvPrfOtros).HasColumnName("CNV_PRF_OTROS");

                entity.Property(e => e.CnvPrfRangos).HasColumnName("CNV_PRF_RANGOS");

                entity.Property(e => e.CnvRenovAutom).HasColumnName("CNV_RENOV_AUTOM");

                entity.Property(e => e.CnvTarId).HasColumnName("CNV_TAR_ID");

                entity.Property(e => e.CnvTarifaInicial)
                    .HasColumnName("CNV_TARIFA_INICIAL")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.CnvTotalLic).HasColumnName("CNV_TOTAL_LIC");

                entity.Property(e => e.CnvTscId).HasColumnName("CNV_TSC_ID");

                entity.Property(e => e.CnvValorRango)
                    .HasColumnName("CNV_VALOR_RANGO")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EntId).HasColumnName("ENT_ID");

                entity.HasOne(d => d.Ent)
                    .WithMany(p => p.CnvConvenio)
                    .HasForeignKey(d => d.EntId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CNV_CONVENIO_ENT_ENTIDAD");
            });

            modelBuilder.Entity<CnvConvocatoria>(entity =>
            {
                entity.HasKey(e => e.CnvId);

                entity.ToTable("CNV_CONVOCATORIA");

                entity.HasIndex(e => new { e.CtaId, e.CnvFechaInscFin })
                    .HasName("IX_CNV_CONVOCATORIA_CNV_FECHA_INSC_FIN");

                entity.HasIndex(e => new { e.CnvId, e.CnvFechaEjecFin, e.VlcEstadoConvocatoria })
                    .HasName("IX_CNV_CONVOCATORIA_CNV_FECHA_EJEC_FIN_VLC_ESTADO_CONVOCATORIA");

                entity.HasIndex(e => new { e.CnvNombre, e.CnvUsuarioCrea, e.CtaId });

                entity.HasIndex(e => new { e.CnvNombre, e.CtaId, e.VlcEstadoConvocatoria });

                entity.HasIndex(e => new { e.CnvId, e.CnvNombre, e.CnvFechaInscIni, e.CnvFechaEjecIni, e.CnvFechaEjecFin, e.CtaId, e.CiudadId, e.CnvDireccion, e.DepartamentoId, e.CnvFechaInscFin })
                    .HasName("IX_CNV_CONVOCATORIA_departamento_id_CNV_FECHA_INSC_FIN");

                entity.HasIndex(e => new { e.CnvId, e.CnvNombre, e.CnvFechaInscIni, e.CnvFechaEjecIni, e.CnvFechaEjecFin, e.DepartamentoId, e.CiudadId, e.CnvDireccion, e.CtaId, e.CnvFechaInscFin })
                    .HasName("IX_CNV_CONVOCATORIA_CTA_ID_CNV_FECHA_INSC_FIN");

                entity.HasIndex(e => new { e.CnvId, e.CnvNombre, e.CnvFechaInscIni, e.CnvFechaInscFin, e.CnvFechaEjecIni, e.CnvFechaEjecFin, e.VlcEstadoConvocatoria, e.DepartamentoId, e.CiudadId, e.CnvDireccion, e.CtaId })
                    .HasName("IX_CNV_CONVOCATORIA_CTA_ID");

                entity.Property(e => e.CnvId).HasColumnName("CNV_ID");

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CnvCupos).HasColumnName("CNV_CUPOS");

                entity.Property(e => e.CnvDireccion)
                    .HasColumnName("CNV_DIRECCION")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.CnvFechaCreacion)
                    .HasColumnName("CNV_FECHA_CREACION")
                    .HasColumnType("date");

                entity.Property(e => e.CnvFechaEjecFin)
                    .HasColumnName("CNV_FECHA_EJEC_FIN")
                    .HasColumnType("date");

                entity.Property(e => e.CnvFechaEjecIni)
                    .HasColumnName("CNV_FECHA_EJEC_INI")
                    .HasColumnType("date");

                entity.Property(e => e.CnvFechaInscFin)
                    .HasColumnName("CNV_FECHA_INSC_FIN")
                    .HasColumnType("date");

                entity.Property(e => e.CnvFechaInscIni)
                    .HasColumnName("CNV_FECHA_INSC_INI")
                    .HasColumnType("date");

                entity.Property(e => e.CnvNombre)
                    .IsRequired()
                    .HasColumnName("CNV_NOMBRE")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CnvUsuarioCrea).HasColumnName("CNV_USUARIO_CREA");

                entity.Property(e => e.CtaId).HasColumnName("CTA_ID");

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.VlcEstadoConvocatoria).HasColumnName("VLC_ESTADO_CONVOCATORIA");

                entity.HasOne(d => d.Cta)
                    .WithMany(p => p.CnvConvocatoria)
                    .HasForeignKey(d => d.CtaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CNV_CONVOCATORIA_CTA_CURSOS_TALLERES");

                entity.HasOne(d => d.VlcEstadoConvocatoriaNavigation)
                    .WithMany(p => p.CnvConvocatoria)
                    .HasForeignKey(d => d.VlcEstadoConvocatoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CNV_CONVOCATORIA_VLC_VALOR_CATALOGO");
            });

            modelBuilder.Entity<CodigoActivacion>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.ToTable("codigo_activacion");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasMaxLength(11)
                    .ValueGeneratedNever();

                entity.Property(e => e.Activo).HasColumnName("activo");
            });

            modelBuilder.Entity<CodigoLog>(entity =>
            {
                entity.HasKey(e => e.CodLog);

                entity.ToTable("CODIGO_LOG", "auditoria");

                entity.Property(e => e.CodLog)
                    .HasColumnName("codLog")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<CodigoLog1>(entity =>
            {
                entity.HasKey(e => e.CodLog);

                entity.ToTable("CODIGO_LOG");

                entity.Property(e => e.CodLog)
                    .HasColumnName("codLog")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ComplementoHojaVida>(entity =>
            {
                entity.HasIndex(e => e.PersoId);

                entity.HasIndex(e => new { e.PersoId, e.ProgramaGobiernoId });

                entity.Property(e => e.ComplementoHojaVidaId).HasColumnName("ComplementoHojaVida_Id");

                entity.Property(e => e.AgenciaIdVinculacion).HasColumnName("agencia_id_vinculacion");

                entity.Property(e => e.FechaVinculacion)
                    .HasColumnName("fecha_vinculacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.ProgramaGobiernoId).HasColumnName("ProgramaGobiernoID");

                entity.HasOne(d => d.ProgramaGobierno)
                    .WithMany(p => p.ComplementoHojaVida)
                    .HasForeignKey(d => d.ProgramaGobiernoId)
                    .HasConstraintName("FK_ComplementoHojaVida_ProgramaXGobierno");
            });

            modelBuilder.Entity<ComplementoHojaVidaHist>(entity =>
            {
                entity.Property(e => e.ComplementoHojaVidaHistId).HasColumnName("ComplementoHojaVidaHist_Id");

                entity.Property(e => e.AgenciaIdVinculacion).HasColumnName("agencia_id_vinculacion");

                entity.Property(e => e.Automatico).HasColumnName("automatico");

                entity.Property(e => e.FechaVinculacion)
                    .HasColumnName("fecha_vinculacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Marcado)
                    .IsRequired()
                    .HasColumnName("marcado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.PersoIdAsesor).HasColumnName("perso_id_asesor");

                entity.Property(e => e.ProgramaGobiernoId).HasColumnName("ProgramaGobiernoID");

                entity.HasOne(d => d.ProgramaGobierno)
                    .WithMany(p => p.ComplementoHojaVidaHist)
                    .HasForeignKey(d => d.ProgramaGobiernoId)
                    .HasConstraintName("FK_ComplementoHojaVidaHist_ProgramaXGobierno");
            });

            modelBuilder.Entity<Condicion>(entity =>
            {
                entity.ToTable("condicion");

                entity.Property(e => e.CondicionId).HasColumnName("condicion_id");

                entity.Property(e => e.CantDias).HasColumnName("cant_dias");

                entity.Property(e => e.Descripcion).HasColumnName("descripcion");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfiguracionReportes>(entity =>
            {
                entity.HasKey(e => e.Clave);

                entity.ToTable("Configuracion_Reportes");

                entity.Property(e => e.Clave)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Valor)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConsulPerso>(entity =>
            {
                entity.HasKey(e => new { e.PersoId, e.InterOrgaId });

                entity.ToTable("consul_perso");

                entity.HasIndex(e => e.InterOrgaId);

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.HasOne(d => d.InterOrga)
                    .WithMany(p => p.ConsulPerso)
                    .HasForeignKey(d => d.InterOrgaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_consul_perso_Inter_orga");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.ConsulPerso)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_consul_perso_S_usuarios_Empresa");
            });

            modelBuilder.Entity<ContacCateg>(entity =>
            {
                entity.HasKey(e => e.CategId)
                    .HasName("PK_Contacto_categ");

                entity.ToTable("Contac_categ");

                entity.Property(e => e.CategId)
                    .HasColumnName("categ_id")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(250);

                entity.Property(e => e.Mail)
                    .HasColumnName("mail")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ContraTipos>(entity =>
            {
                entity.HasKey(e => e.ContraTipoId)
                    .HasName("PK_contra_tipos");

                entity.ToTable("Contra_tipos");

                entity.Property(e => e.ContraTipoId)
                    .HasColumnName("contra_tipo_id")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodSispe)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CtaCursosTalleres>(entity =>
            {
                entity.HasKey(e => e.CtaId);

                entity.ToTable("CTA_CURSOS_TALLERES");

                entity.HasIndex(e => new { e.CtaNombre, e.EntId })
                    .HasName("IXX_CTA_CURSOS_TALLERES_CTA_NOMBRE_ent_id");

                entity.HasIndex(e => new { e.AgenciaId, e.CtaPeriodicidad, e.VlcEstadoCuenta });

                entity.HasIndex(e => new { e.CtaId, e.CtaNombre, e.CtaLugarImpartic, e.CtaHoras, e.VlcArea, e.VlcTiposCuenta, e.VlcEstadoCuenta, e.EntId })
                    .HasName("IX_CTA_CURSOS_TALLERES_VLC_AREA_VLC_TIPOS_CUENTA_VLC_ESTADO_CUENTA_ent_id");

                entity.HasIndex(e => new { e.CtaId, e.CtaNombre, e.VlcArea, e.VlcTiposCuenta, e.CtaLugarImpartic, e.CtaHoras, e.VlcEstadoCuenta, e.EntId })
                    .HasName("IX_CTA_CURSOS_TALLERES_VLC_ESTADO_CUENTA_ent_id");

                entity.HasIndex(e => new { e.CtaId, e.CtaNombre, e.VlcTiposCuenta, e.CtaLugarImpartic, e.CtaHoras, e.VlcArea, e.VlcEstadoCuenta, e.EntId })
                    .HasName("IX_CTA_CURSOS_TALLERES_VLC_AREA_VLC_ESTADO_CUENTA_ent_id");

                entity.Property(e => e.CtaId).HasColumnName("CTA_ID");

                entity.Property(e => e.AgenciaId).HasColumnName("AGENCIA_ID");

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CtaAdjunto)
                    .HasColumnName("CTA_ADJUNTO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CtaCertificado).HasColumnName("CTA_CERTIFICADO");

                entity.Property(e => e.CtaCodigo)
                    .HasColumnName("CTA_CODIGO")
                    .HasMaxLength(10);

                entity.Property(e => e.CtaCompetencia)
                    .HasColumnName("CTA_COMPETENCIA")
                    .IsUnicode(false);

                entity.Property(e => e.CtaCupos).HasColumnName("CTA_CUPOS");

                entity.Property(e => e.CtaDescripcion)
                    .IsRequired()
                    .HasColumnName("CTA_DESCRIPCION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CtaEsEmprendi).HasColumnName("CTA_ES_EMPRENDI");

                entity.Property(e => e.CtaFechaCreacion)
                    .HasColumnName("CTA_FECHA_CREACION")
                    .HasColumnType("date");

                entity.Property(e => e.CtaFechaUltModif)
                    .HasColumnName("CTA_FECHA_ULT_MODIF")
                    .HasColumnType("datetime");

                entity.Property(e => e.CtaHoras).HasColumnName("CTA_HORAS");

                entity.Property(e => e.CtaLugarImpartic)
                    .IsRequired()
                    .HasColumnName("CTA_LUGAR_IMPARTIC")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CtaModulos)
                    .IsRequired()
                    .HasColumnName("CTA_MODULOS")
                    .IsUnicode(false);

                entity.Property(e => e.CtaNombre)
                    .IsRequired()
                    .HasColumnName("CTA_NOMBRE")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CtaOcupTrabRel)
                    .IsRequired()
                    .HasColumnName("CTA_OCUP_TRAB_REL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CtaPerfiles)
                    .IsRequired()
                    .HasColumnName("CTA_PERFILES")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CtaPeriodicidad).HasColumnName("CTA_PERIODICIDAD");

                entity.Property(e => e.CtaPorcentajeAsis).HasColumnName("CTA_PORCENTAJE_ASIS");

                entity.Property(e => e.CtaPublico).HasColumnName("CTA_PUBLICO");

                entity.Property(e => e.CtaReqAcceso)
                    .IsRequired()
                    .HasColumnName("CTA_REQ_ACCESO")
                    .IsUnicode(false);

                entity.Property(e => e.CtaReqAprob)
                    .IsRequired()
                    .HasColumnName("CTA_REQ_APROB")
                    .IsUnicode(false);

                entity.Property(e => e.CtaReqiereAsis).HasColumnName("CTA_REQIERE_ASIS");

                entity.Property(e => e.CtaTercero).HasColumnName("CTA_TERCERO");

                entity.Property(e => e.CtaTitulo)
                    .HasColumnName("CTA_TITULO")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CtaUsuUltModif).HasColumnName("CTA_USU_ULT_MODIF");

                entity.Property(e => e.CtaUsurioCrea).HasColumnName("CTA_USURIO_CREA");

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EntId).HasColumnName("ent_id");

                entity.Property(e => e.EntidadImparte)
                    .HasColumnName("entidad_imparte")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SegMensual).HasColumnName("SEG_MENSUAL");

                entity.Property(e => e.VlcArea).HasColumnName("VLC_AREA");

                entity.Property(e => e.VlcEstadoCuenta).HasColumnName("VLC_ESTADO_CUENTA");

                entity.Property(e => e.VlcNivelImparticion).HasColumnName("VLC_NIVEL_IMPARTICION");

                entity.Property(e => e.VlcSubtipo).HasColumnName("VLC_SUBTIPO");

                entity.Property(e => e.VlcTiposCuenta).HasColumnName("VLC_TIPOS_CUENTA");

                entity.HasOne(d => d.Agencia)
                    .WithMany(p => p.CtaCursosTalleres)
                    .HasForeignKey(d => d.AgenciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTA_CURSOS_TALLERES_agencia");

                entity.HasOne(d => d.VlcAreaNavigation)
                    .WithMany(p => p.CtaCursosTalleresVlcAreaNavigation)
                    .HasForeignKey(d => d.VlcArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTA_CURSOS_TALLERES_VLC_VALOR_CATALOGO");

                entity.HasOne(d => d.VlcEstadoCuentaNavigation)
                    .WithMany(p => p.CtaCursosTalleresVlcEstadoCuentaNavigation)
                    .HasForeignKey(d => d.VlcEstadoCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTA_CURSOS_TALLERES_VLC_VALOR_CATALOGO3");

                entity.HasOne(d => d.VlcNivelImparticionNavigation)
                    .WithMany(p => p.CtaCursosTalleresVlcNivelImparticionNavigation)
                    .HasForeignKey(d => d.VlcNivelImparticion)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTA_CURSOS_TALLERES_VLC_VALOR_CATALOGO4");

                entity.HasOne(d => d.VlcSubtipoNavigation)
                    .WithMany(p => p.CtaCursosTalleresVlcSubtipoNavigation)
                    .HasForeignKey(d => d.VlcSubtipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTA_CURSOS_TALLERES_VLC_VALOR_CATALOGO2");

                entity.HasOne(d => d.VlcTiposCuentaNavigation)
                    .WithMany(p => p.CtaCursosTalleresVlcTiposCuentaNavigation)
                    .HasForeignKey(d => d.VlcTiposCuenta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTA_CURSOS_TALLERES_VLC_VALOR_CATALOGO1");
            });

            modelBuilder.Entity<CtgCatalogos>(entity =>
            {
                entity.HasKey(e => e.CtgId);

                entity.ToTable("CTG_CATALOGOS");

                entity.Property(e => e.CtgId).HasColumnName("CTG_ID");

                entity.Property(e => e.CtgEntidadPadre)
                    .HasColumnName("CTG_ENTIDAD_PADRE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CtgNombre)
                    .IsRequired()
                    .HasColumnName("CTG_NOMBRE")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CtnContactenos>(entity =>
            {
                entity.HasKey(e => e.CtnId);

                entity.ToTable("CTN_CONTACTENOS");

                entity.Property(e => e.CtnId).HasColumnName("CTN_ID");

                entity.Property(e => e.CtnEmail)
                    .HasColumnName("CTN_EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CtnMensaje)
                    .IsRequired()
                    .HasColumnName("CTN_MENSAJE")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.CtnNIdentificacion)
                    .IsRequired()
                    .HasColumnName("CTN_N_IDENTIFICACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CtnNombre)
                    .IsRequired()
                    .HasColumnName("CTN_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CtnTelefono)
                    .HasColumnName("CTN_TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TpsId).HasColumnName("TPS_ID");

                entity.HasOne(d => d.Tps)
                    .WithMany(p => p.CtnContactenos)
                    .HasForeignKey(d => d.TpsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CTN_CONTACTENOS_TPS_TIPO_SOLICITUD");
            });

            modelBuilder.Entity<DataDictionary>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangeDate).HasColumnType("datetime");

                entity.Property(e => e.Database)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Ddl).HasColumnName("DDL");

                entity.Property(e => e.DiffAnsi)
                    .HasColumnName("DiffANSI")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffAssembly)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffAssemblyClass)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffAssemblyMethod)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffBaseType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffBody)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffBoundDefault)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffBoundDefaults)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffBoundRule)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffBoundRules)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffChangeTracking)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffCheckConstraints)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffClrname)
                    .HasColumnName("DiffCLRName")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffColumnOrder)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffColumns)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffDataspace)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffDefaultConstraints)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffDefaultSchema)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffDurability)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffExtendedProperties)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffFiles)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffForeignKeys)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffFulltextIndex)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffIdentities)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffIndexes)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffLockEscalation)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffManifestFile)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffMemoryOptimized)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffNullable)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffOwner)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffParameters)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffPermissionSet)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffPermissions)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffPrimaryKey)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffReturnType)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffScale)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffSize)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffStatistics)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffType)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DiffUnique)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffUserLogin)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffXmlcolumnSet)
                    .HasColumnName("DiffXMLColumnSet")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DiffXmlindexes)
                    .HasColumnName("DiffXMLIndexes")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.ObjectType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Owner)
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.Server)
                    .HasMaxLength(128)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Departamentos>(entity =>
            {
                entity.HasKey(e => new { e.PaisId, e.DepartamentoId });

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(250);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.Departamentos)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Departamentos_Paises");
            });

            modelBuilder.Entity<DetalleIndicadoresVacantes>(entity =>
            {
                entity.HasKey(e => e.IdDetalleIndicadoresVacantes);

                entity.Property(e => e.AgenteAprobo).HasMaxLength(150);

                entity.Property(e => e.Cargo).HasMaxLength(150);

                entity.Property(e => e.CodigoProceso).HasMaxLength(150);

                entity.Property(e => e.Discapacidad).IsUnicode(false);

                entity.Property(e => e.EsManoDeObraCalificada)
                    .IsRequired()
                    .HasColumnName("es_mano_de_obra_calificada")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('no')");

                entity.Property(e => e.EstadoActual).HasMaxLength(150);

                entity.Property(e => e.Excepcional).HasColumnName("excepcional");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaPublicacion)
                    .HasColumnName("Fecha_Publicacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");

                entity.Property(e => e.NombreEmpresa)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreVacante)
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.PerteneceHidrocarburos)
                    .IsRequired()
                    .HasColumnName("pertenece_hidrocarburos")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('no')");

                entity.Property(e => e.ProceEstaId)
                    .HasColumnName("PROCE_ESTA_ID")
                    .HasMaxLength(2);

                entity.Property(e => e.ProgramaGobierno)
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.TipoContrato).HasMaxLength(150);

                entity.Property(e => e.TipoDeProyectoHidrocarburos)
                    .IsRequired()
                    .HasColumnName("tipo_de_proyecto_hidrocarburos")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoVacante).HasMaxLength(150);

                entity.Property(e => e.Ubicacion).IsUnicode(false);
            });

            modelBuilder.Entity<DetalleTransmision>(entity =>
            {
                entity.ToTable("Detalle_Transmision");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Archivo)
                    .IsRequired()
                    .HasColumnName("archivo");

                entity.Property(e => e.ClaveRegistro)
                    .IsRequired()
                    .HasColumnName("clave_registro")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ConsecutivoRegistro).HasColumnName("consecutivo_registro");

                entity.Property(e => e.DetalleErrorProceso).HasColumnName("detalle_error_proceso");

                entity.Property(e => e.DetalleRechazoSise).HasColumnName("detalle_rechazo_sise");

                entity.Property(e => e.ErrorProceso).HasColumnName("error_proceso");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.LoteId).HasColumnName("lote_id");

                entity.Property(e => e.ProcesadoSise).HasColumnName("procesado_sise");

                entity.Property(e => e.RechazadoSise).HasColumnName("rechazado_sise");

                entity.HasOne(d => d.Lote)
                    .WithMany(p => p.DetalleTransmision)
                    .HasForeignKey(d => d.LoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Detalle_T__lote___61680E15");
            });

            modelBuilder.Entity<DetallehistoricoIndicadoresVacantes>(entity =>
            {
                entity.HasKey(e => e.IdDetallehistoricoIndicadoresVacantes);

                entity.Property(e => e.AgenteAprobo).HasMaxLength(150);

                entity.Property(e => e.Cargo).HasMaxLength(150);

                entity.Property(e => e.CodigoProceso).HasMaxLength(150);

                entity.Property(e => e.Discapacidad).IsUnicode(false);

                entity.Property(e => e.EsManoDeObraCalificada)
                    .IsRequired()
                    .HasColumnName("es_mano_de_obra_calificada")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('no')");

                entity.Property(e => e.EstadoActual).HasMaxLength(150);

                entity.Property(e => e.Excepcional).HasColumnName("excepcional");

                entity.Property(e => e.FechaCrea).HasColumnType("datetime");

                entity.Property(e => e.FechaPublicacion)
                    .HasColumnName("Fecha_Publicacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaVencimiento).HasColumnType("datetime");

                entity.Property(e => e.NombreEmpresa)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NombreVacante)
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.PerteneceHidrocarburos)
                    .IsRequired()
                    .HasColumnName("pertenece_hidrocarburos")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('no')");

                entity.Property(e => e.ProceEstaId)
                    .HasColumnName("PROCE_ESTA_ID")
                    .HasMaxLength(2);

                entity.Property(e => e.ProgramaGobierno)
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.TipoContrato).HasMaxLength(150);

                entity.Property(e => e.TipoDeProyectoHidrocarburos)
                    .IsRequired()
                    .HasColumnName("tipo_de_proyecto_hidrocarburos")
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TipoVacante).HasMaxLength(150);

                entity.Property(e => e.Ubicacion).IsUnicode(false);
            });

            modelBuilder.Entity<DireccionParametrizada>(entity =>
            {
                entity.ToTable("Direccion_Parametrizada");

                entity.HasIndex(e => e.PersoId)
                    .HasName("IX_Direccion_parametrizada_perso_id");

                entity.HasIndex(e => new { e.ViaPrincipalAbreviatura, e.ViaPrincipalValor, e.ViaPrincipalPrimeraLetra, e.ViaPrincipalBis, e.ViaPrincipalSegundaLetra, e.ViaPrincipalCuadrante, e.ViaGeneradoraValor, e.ViaGeneradoraLetra, e.ViaGeneradoraPlaca, e.ViaGeneradoraCuadrante, e.ComplementoDireccion, e.CodigoPostal, e.FechaUltimaActualizacion, e.IdSede })
                    .HasName("ix_Direccion_Parametrizada_Id_Sede_includes");

                entity.Property(e => e.DireccionParametrizadaId).HasColumnName("Direccion_Parametrizada_Id");

                entity.Property(e => e.CodigoPostal).HasColumnName("Codigo_Postal");

                entity.Property(e => e.ComplementoDireccion)
                    .HasColumnName("Complemento_Direccion")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FechaUltimaActualizacion)
                    .HasColumnName("Fecha_Ultima_Actualizacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdSede).HasColumnName("Id_Sede");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.ViaGeneradoraCuadrante)
                    .HasColumnName("Via_Generadora_Cuadrante")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ViaGeneradoraLetra)
                    .HasColumnName("Via_Generadora_Letra")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ViaGeneradoraPlaca)
                    .HasColumnName("Via_Generadora_Placa")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ViaGeneradoraValor)
                    .HasColumnName("Via_Generadora_Valor")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ViaPrincipalAbreviatura)
                    .HasColumnName("Via_Principal_Abreviatura")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ViaPrincipalBis)
                    .HasColumnName("Via_Principal_Bis")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ViaPrincipalCuadrante)
                    .HasColumnName("Via_Principal_Cuadrante")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ViaPrincipalNombre)
                    .HasColumnName("Via_Principal_Nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ViaPrincipalPrimeraLetra)
                    .HasColumnName("Via_Principal_Primera_Letra")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ViaPrincipalSegundaLetra)
                    .HasColumnName("Via_Principal_Segunda_Letra")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ViaPrincipalValor)
                    .HasColumnName("Via_Principal_Valor")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.DireccionParametrizada)
                    .HasForeignKey(d => d.IdAgencia)
                    .HasConstraintName("FK_Direccion_Prestadores");

                entity.HasOne(d => d.IdSedeNavigation)
                    .WithMany(p => p.DireccionParametrizada)
                    .HasForeignKey(d => d.IdSede)
                    .HasConstraintName("FK_Direccion_Demandantes");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.DireccionParametrizada)
                    .HasForeignKey(d => d.PersoId)
                    .HasConstraintName("FK_Direccion_Personas");
            });

            modelBuilder.Entity<DireccionParametrizadaArchivo>(entity =>
            {
                entity.ToTable("Direccion_Parametrizada_archivo");

                entity.Property(e => e.CodigoPostal).HasColumnName("Codigo_Postal");

                entity.Property(e => e.ComplementoDireccion)
                    .HasColumnName("Complemento_Direccion")
                    .HasMaxLength(128)
                    .IsUnicode(false);

                entity.Property(e => e.FechaUltimaActualizacion)
                    .HasColumnName("Fecha_Ultima_Actualizacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdSede).HasColumnName("Id_Sede");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.ViaGeneradoraCuadrante)
                    .HasColumnName("Via_Generadora_Cuadrante")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ViaGeneradoraLetra)
                    .HasColumnName("Via_Generadora_Letra")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ViaGeneradoraPlaca)
                    .HasColumnName("Via_Generadora_Placa")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ViaGeneradoraValor)
                    .HasColumnName("Via_Generadora_Valor")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ViaPrincipalAbreviatura)
                    .HasColumnName("Via_Principal_Abreviatura")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ViaPrincipalBis)
                    .HasColumnName("Via_Principal_Bis")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ViaPrincipalCuadrante)
                    .HasColumnName("Via_Principal_Cuadrante")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ViaPrincipalNombre)
                    .HasColumnName("Via_Principal_Nombre")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ViaPrincipalPrimeraLetra)
                    .HasColumnName("Via_Principal_Primera_Letra")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ViaPrincipalSegundaLetra)
                    .HasColumnName("Via_Principal_Segunda_Letra")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ViaPrincipalValor)
                    .HasColumnName("Via_Principal_Valor")
                    .HasMaxLength(32)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DistriVacantes>(entity =>
            {
                entity.HasKey(e => e.DistribucionId)
                    .HasName("PK_distri_vacantes_1");

                entity.ToTable("distri_vacantes");

                entity.HasIndex(e => e.AgenciaIdAlt);

                entity.HasIndex(e => e.PublicacionCodigo);

                entity.HasIndex(e => e.SedeId);

                entity.HasIndex(e => new { e.DepartamentoId, e.ProcesoId, e.SedeId })
                    .HasName("IX_distri_vacantes_proceso_id_sede_id");

                entity.HasIndex(e => new { e.ProcesoId, e.SedeId, e.AgenciaIdVal })
                    .HasName("IX_distri_vacantes_agencia_id_val");

                entity.HasIndex(e => new { e.ProcesoId, e.SedeId, e.CiudadId })
                    .HasName("IX_distri_vacantes_ciudad_id");

                entity.HasIndex(e => new { e.ProcesoId, e.SedeId, e.DepartamentoId });

                entity.HasIndex(e => new { e.ProcesoId, e.SedeId, e.AgenciaIdVal, e.DepartamentoId })
                    .HasName("IX_distri_vacantes_departamento_id");

                entity.HasIndex(e => new { e.ProcesoId, e.SedeId, e.PublicacionCodigo, e.AgenciaIdVal })
                    .HasName("IX_distri_vacantes_agencia_id_val1");

                entity.HasIndex(e => new { e.ProcesoId, e.SedeId, e.AgenciaIdVal, e.AgenciaIdAlt, e.DepartamentoId })
                    .HasName("IX_distri_vacantes_departamento_id1");

                entity.HasIndex(e => new { e.ProcesoId, e.SedeId, e.DepartamentoId, e.CiudadId, e.AgenciaIdVal })
                    .HasName("IXX_distri_vacantes_agencia_id_val_2");

                entity.HasIndex(e => new { e.ProcesoId, e.SedeId, e.DepartamentoId, e.CiudadId, e.PublicacionCodigo, e.AgenciaIdVal })
                    .HasName("IXX_distri_vacantes_agencia_id_val");

                entity.Property(e => e.DistribucionId).HasColumnName("distribucion_id");

                entity.Property(e => e.AgenciaIdAlt).HasColumnName("agencia_id_alt");

                entity.Property(e => e.AgenciaIdVal).HasColumnName("agencia_id_val");

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EsDepartamental).HasColumnName("es_departamental");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.PublicacionCodigo)
                    .HasColumnName("publicacion_codigo")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PuestoCiu).HasColumnName("puesto_ciu");

                entity.Property(e => e.PuestoDept).HasColumnName("puesto_dept");

                entity.Property(e => e.SedeId).HasColumnName("sede_id");

                entity.Property(e => e.Todos)
                    .HasColumnName("todos")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AgenciaIdValNavigation)
                    .WithMany(p => p.DistriVacantes)
                    .HasForeignKey(d => d.AgenciaIdVal)
                    .HasConstraintName("FK_distri_vacantes_agencia");

                entity.HasOne(d => d.Sede)
                    .WithMany(p => p.DistriVacantes)
                    .HasForeignKey(d => d.SedeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_distri_vacantes_Sedes");

                entity.HasOne(d => d.Procesos)
                    .WithMany(p => p.DistriVacantes)
                    .HasForeignKey(d => new { d.SedeId, d.ProcesoId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_distri_vacantes_Procesos");
            });

            modelBuilder.Entity<Documentos>(entity =>
            {
                entity.ToTable("documentos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Ruta)
                    .IsRequired()
                    .HasColumnName("ruta")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EduInsti>(entity =>
            {
                entity.HasKey(e => e.InstiId);

                entity.ToTable("Edu_insti");

                entity.Property(e => e.InstiId)
                    .HasColumnName("insti_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.EntId).HasColumnName("ent_id");

                entity.Property(e => e.EntNit)
                    .HasColumnName("ent_nit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(320);
            });

            modelBuilder.Entity<EduInstiPaisRela>(entity =>
            {
                entity.HasKey(e => new { e.InstiId, e.PaisId });

                entity.ToTable("Edu_insti_pais_rela");

                entity.Property(e => e.InstiId)
                    .HasColumnName("insti_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Insti)
                    .WithMany(p => p.EduInstiPaisRela)
                    .HasForeignKey(d => d.InstiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Edu_insti_pais_rela_Edu_insti");
            });

            modelBuilder.Entity<EmpreArea>(entity =>
            {
                entity.ToTable("Empre_area");

                entity.Property(e => e.EmpreAreaId)
                    .HasColumnName("empre_area_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(320);
            });

            modelBuilder.Entity<EmpreAreaPaisRela>(entity =>
            {
                entity.HasKey(e => new { e.EmpreAreaId, e.PaisId });

                entity.ToTable("Empre_area_pais_rela");

                entity.Property(e => e.EmpreAreaId)
                    .HasColumnName("empre_area_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.EmpreArea)
                    .WithMany(p => p.EmpreAreaPaisRela)
                    .HasForeignKey(d => d.EmpreAreaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empre_area_pais_rela_Empre_area");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.EmpreAreaPaisRela)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empre_area_pais_rela_Paises_Home");
            });

            modelBuilder.Entity<EmpreCantiEmple>(entity =>
            {
                entity.HasKey(e => e.CantiEmpleId);

                entity.ToTable("Empre_canti_emple");

                entity.Property(e => e.CantiEmpleId)
                    .HasColumnName("canti_emple_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("orden");
            });

            modelBuilder.Entity<EmpreIndus>(entity =>
            {
                entity.ToTable("Empre_indus");

                entity.Property(e => e.EmpreIndusId)
                    .HasColumnName("empre_indus_id")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(320);
            });

            modelBuilder.Entity<EmpreIndusPaisRela>(entity =>
            {
                entity.HasKey(e => new { e.EmpreIndusId, e.PaisId });

                entity.ToTable("Empre_indus_pais_rela");

                entity.Property(e => e.EmpreIndusId)
                    .HasColumnName("empre_indus_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.EmpreIndus)
                    .WithMany(p => p.EmpreIndusPaisRela)
                    .HasForeignKey(d => d.EmpreIndusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empre_indus_pais_rela_Empre_industria");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.EmpreIndusPaisRela)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empre_indus_pais_rela_Paises_Home");
            });

            modelBuilder.Entity<EmpreNaturaleza>(entity =>
            {
                entity.HasKey(e => e.IdNaturaleza);

                entity.ToTable("Empre_Naturaleza");

                entity.Property(e => e.IdNaturaleza)
                    .HasColumnName("id_naturaleza")
                    .ValueGeneratedNever();

                entity.Property(e => e.Naturaleza)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpreSector>(entity =>
            {
                entity.HasKey(e => new { e.EmpreSectoId, e.EmpreIndusId })
                    .HasName("PK_Empre_Sector");

                entity.ToTable("Empre_sector");

                entity.Property(e => e.EmpreSectoId)
                    .HasColumnName("empre_secto_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EmpreIndusId)
                    .HasColumnName("empre_indus_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(320);

                entity.HasOne(d => d.EmpreIndus)
                    .WithMany(p => p.EmpreSector)
                    .HasForeignKey(d => d.EmpreIndusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empre_sector_Empre_indus");
            });

            modelBuilder.Entity<EmpreSectorPaisRela>(entity =>
            {
                entity.HasKey(e => new { e.EmpreSectoId, e.PaisId })
                    .HasName("PK_Empre_secto_pais_rela");

                entity.ToTable("Empre_sector_pais_rela");

                entity.Property(e => e.EmpreSectoId)
                    .HasColumnName("empre_secto_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.EmpreSectorPaisRela)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Empre_sector_pais_rela_Paises_Home");
            });

            modelBuilder.Entity<EmpreTipo>(entity =>
            {
                entity.ToTable("Empre_Tipo");

                entity.Property(e => e.EmpreTipoId)
                    .HasColumnName("empre_tipo_id")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EnpEncuestaPreguntas>(entity =>
            {
                entity.HasKey(e => e.EnpId)
                    .HasName("PK__ENP_ENCU__F8EAED994573B86C");

                entity.ToTable("ENP_ENCUESTA_PREGUNTAS");

                entity.Property(e => e.EnpId)
                    .HasColumnName("ENP_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pregunta)
                    .HasColumnName("PREGUNTA")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EntEntidad>(entity =>
            {
                entity.HasKey(e => e.EntId);

                entity.ToTable("ENT_ENTIDAD");

                entity.HasIndex(e => new { e.EntTipo, e.EntId })
                    .HasName("_dta_index_ENT_ENTIDAD_5_587253247__K1_34_1912");

                entity.Property(e => e.EntId).HasColumnName("ENT_ID");

                entity.Property(e => e.CargoContactoId)
                    .IsRequired()
                    .HasColumnName("CARGO_CONTACTO_ID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EmpreCampoId)
                    .HasColumnName("EMPRE_CAMPO_ID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EntActId).HasColumnName("ENT_ACT_ID");

                entity.Property(e => e.EntActivo)
                    .HasColumnName("ENT_ACTIVO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EntApellidoContacto)
                    .HasColumnName("ENT_APELLIDO_CONTACTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntBanner)
                    .HasColumnName("ENT_BANNER")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntCiuId)
                    .IsRequired()
                    .HasColumnName("ENT_CIU_ID")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EntClase).HasColumnName("ENT_CLASE");

                entity.Property(e => e.EntClaveMail)
                    .HasColumnName("ENT_CLAVE_MAIL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EntCodigo)
                    .HasColumnName("ENT_CODIGO")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EntCodigoAlterno)
                    .HasColumnName("ent_codigo_alterno")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EntCorreoContacto)
                    .IsRequired()
                    .HasColumnName("ENT_CORREO_CONTACTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntDepId)
                    .IsRequired()
                    .HasColumnName("ENT_DEP_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EntDirContacto)
                    .IsRequired()
                    .HasColumnName("ENT_DIR_CONTACTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntEmailEnvi)
                    .HasColumnName("ENT_EMAIL_ENVI")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EntFax)
                    .HasColumnName("ENT_FAX")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntFechaReg)
                    .HasColumnName("ENT_FECHA_REG")
                    .HasColumnType("date");

                entity.Property(e => e.EntIndId).HasColumnName("ENT_IND_ID");

                entity.Property(e => e.EntLogo)
                    .IsRequired()
                    .HasColumnName("ENT_LOGO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntModalidad)
                    .HasColumnName("ent_modalidad")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EntNit)
                    .IsRequired()
                    .HasColumnName("ENT_NIT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntNombre)
                    .IsRequired()
                    .HasColumnName("ENT_NOMBRE")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.EntNombreContacto)
                    .IsRequired()
                    .HasColumnName("ENT_NOMBRE_CONTACTO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EntNumDocu)
                    .HasColumnName("ENT_NUM_DOCU")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EntPaisId)
                    .IsRequired()
                    .HasColumnName("ENT_PAIS_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EntPub).HasColumnName("ENT_PUB");

                entity.Property(e => e.EntPuerto)
                    .HasColumnName("ENT_PUERTO")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.EntRazonSocial)
                    .HasColumnName("ENT_RAZON_SOCIAL")
                    .HasMaxLength(400)
                    .IsUnicode(false);

                entity.Property(e => e.EntResolucion)
                    .HasColumnName("ENT_RESOLUCION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntSectorId).HasColumnName("ENT_SECTOR_ID");

                entity.Property(e => e.EntServidorDominio)
                    .HasColumnName("ent_servidorDominio")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EntSigla)
                    .HasColumnName("ENT_SIGLA")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EntTelContacto)
                    .HasColumnName("ENT_TEL_CONTACTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EntTipo)
                    .HasColumnName("ENT_TIPO")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EntUrlweb)
                    .IsRequired()
                    .HasColumnName("ENT_URLWEB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Imagenbase64)
                    .HasColumnName("imagenbase64")
                    .IsUnicode(false);

                entity.Property(e => e.InstiNombre)
                    .HasColumnName("insti_nombre")
                    .HasMaxLength(640)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocuId)
                    .HasColumnName("TIPO_DOCU_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.EntClaseNavigation)
                    .WithMany(p => p.EntEntidad)
                    .HasForeignKey(d => d.EntClase)
                    .HasConstraintName("FK_ent_entidad_clase_prestador");
            });

            modelBuilder.Entity<EscEstadoCandidatura>(entity =>
            {
                entity.HasKey(e => e.EscId)
                    .HasName("PK__ESC_ESTA__F9A3111778D1CE2B");

                entity.ToTable("ESC_ESTADO_CANDIDATURA");

                entity.Property(e => e.EscId).HasColumnName("ESC_ID");

                entity.Property(e => e.EscNombre)
                    .IsRequired()
                    .HasColumnName("ESC_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadoCivil>(entity =>
            {
                entity.HasKey(e => e.IdEstadoCivil);

                entity.Property(e => e.IdEstadoCivil)
                    .HasColumnName("id_estado_civil")
                    .ValueGeneratedNever();

                entity.Property(e => e.NomEstadoCivil)
                    .IsRequired()
                    .HasColumnName("nom_estado_civil")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadoCuenta>(entity =>
            {
                entity.ToTable("estado_cuenta");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(19)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadoNivelEducativo>(entity =>
            {
                entity.HasKey(e => e.IdEstado);

                entity.Property(e => e.IdEstado).ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstadosSede>(entity =>
            {
                entity.HasKey(e => e.Idestado);

                entity.ToTable("estados_sede");

                entity.Property(e => e.Idestado).HasColumnName("idestado");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("estado")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EstuNivel>(entity =>
            {
                entity.ToTable("Estu_nivel");

                entity.Property(e => e.EstuNivelId)
                    .HasColumnName("estu_nivel_id")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.CodigoNivel)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoSispe)
                    .HasColumnName("CodigoSISPE")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Encurso)
                    .HasColumnName("encurso")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.EstuOrden).HasColumnName("estu_orden");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<EstuNivelPaisRela>(entity =>
            {
                entity.HasKey(e => new { e.EstuNivelId, e.PaisId });

                entity.ToTable("Estu_nivel_pais_rela");

                entity.Property(e => e.EstuNivelId)
                    .HasColumnName("estu_nivel_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.EstuNivel)
                    .WithMany(p => p.EstuNivelPaisRela)
                    .HasForeignKey(d => d.EstuNivelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Estu_nivel_pais_rela_Estu_nivel");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.EstuNivelPaisRela)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Estu_nivel_pais_rela_Paises_Home");
            });

            modelBuilder.Entity<EstuNivelSupra>(entity =>
            {
                entity.HasKey(e => new { e.EstuNivelSupraId, e.EstuNivelId });

                entity.ToTable("estu_nivel_supra");

                entity.Property(e => e.EstuNivelSupraId)
                    .HasColumnName("estu_nivel_supra_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EstuNivelId)
                    .HasColumnName("estu_nivel_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SupraNombre)
                    .HasColumnName("supra_nombre")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SupraOrden).HasColumnName("supra_orden");
            });

            modelBuilder.Entity<EsvEstadoVacante>(entity =>
            {
                entity.HasKey(e => e.EsvId);

                entity.ToTable("ESV_ESTADO_VACANTE");

                entity.Property(e => e.EsvId).HasColumnName("ESV_ID");

                entity.Property(e => e.EsvNombre)
                    .IsRequired()
                    .HasColumnName("ESV_NOMBRE")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EtapaProceso>(entity =>
            {
                entity.HasKey(e => e.IdEtapaProceso);

                entity.ToTable("Etapa_Proceso");

                entity.Property(e => e.IdEtapaProceso).HasColumnName("id_etapa_proceso");

                entity.Property(e => e.NombreEtapaProceso)
                    .HasColumnName("nombre_etapa_proceso")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EvaEvaluacion>(entity =>
            {
                entity.HasKey(e => new { e.EvaId, e.CnvId, e.PersoIdOferente });

                entity.ToTable("EVA_EVALUACION");

                entity.HasIndex(e => e.PersoIdOferente);

                entity.HasIndex(e => new { e.CnvId, e.PersoIdOferente, e.EvaAprobo, e.EvaFechaEval })
                    .HasName("IXX_EVA_EVALUACION_EVA_APROBO_EVA_FECHA_EVAL");

                entity.HasIndex(e => new { e.EvaId, e.EvaFechaEval, e.EvaObservaciones, e.PersoIdEvaluador, e.EvaAprobo, e.CnvId, e.PersoIdOferente })
                    .HasName("IX_EVA_EVALUACION_CNV_ID_perso_id_oferente");

                entity.Property(e => e.EvaId)
                    .HasColumnName("EVA_ID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CnvId).HasColumnName("CNV_ID");

                entity.Property(e => e.PersoIdOferente).HasColumnName("perso_id_oferente");

                entity.Property(e => e.EvaAprobo).HasColumnName("EVA_APROBO");

                entity.Property(e => e.EvaFechaEval)
                    .HasColumnName("EVA_FECHA_EVAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.EvaObservaciones)
                    .IsRequired()
                    .HasColumnName("EVA_OBSERVACIONES")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.EvaRutaCertificado)
                    .HasColumnName("EVA_RUTA_CERTIFICADO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PersoIdEvaluador).HasColumnName("perso_id_evaluador");

                entity.HasOne(d => d.Cnv)
                    .WithMany(p => p.EvaEvaluacion)
                    .HasForeignKey(d => d.CnvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVA_EVALUACION_CNV_CONVOCATORIA");

                entity.HasOne(d => d.PersoIdEvaluadorNavigation)
                    .WithMany(p => p.EvaEvaluacion)
                    .HasForeignKey(d => d.PersoIdEvaluador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVA_EVALUACION_Personas_agencia");

                entity.HasOne(d => d.PersoIdOferenteNavigation)
                    .WithMany(p => p.EvaEvaluacion)
                    .HasForeignKey(d => d.PersoIdOferente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EVA_EVALUACION_Personas");
            });

            modelBuilder.Entity<Experiencias>(entity =>
            {
                entity.HasKey(e => new { e.PersoId, e.Idgrupoocupacional })
                    .HasName("PK__experien__5ABEBFABF6C1601D");

                entity.ToTable("experiencias");

                entity.HasIndex(e => new { e.PersoId, e.Meses, e.Idgrupoocupacional })
                    .HasName("IX_Experiencias_grupo_perso_mes");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.Idgrupoocupacional).HasColumnName("idgrupoocupacional");

                entity.Property(e => e.GrupoOcupacional)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Meses).HasColumnName("MESES");
            });

            modelBuilder.Entity<ExperienciasCargos>(entity =>
            {
                entity.ToTable("experiencias_cargos");

                entity.HasIndex(e => new { e.PersoId, e.CargoId, e.Meses })
                    .HasName("IX_ExpCargos_Perso_id_Cargo_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CargoId)
                    .IsRequired()
                    .HasColumnName("cargo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Meses).HasColumnName("meses");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");
            });

            modelBuilder.Entity<ExrExperienciaRango>(entity =>
            {
                entity.HasKey(e => e.ExrId)
                    .HasName("PK__EXR_EXPE__392FF01DF35FA14A");

                entity.ToTable("EXR_EXPERIENCIA_RANGO");

                entity.Property(e => e.ExrId).HasColumnName("EXR_ID");

                entity.Property(e => e.Desde).HasColumnName("desde");

                entity.Property(e => e.ExrNombre)
                    .HasColumnName("EXR_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hasta).HasColumnName("hasta");
            });

            modelBuilder.Entity<FfaFosfecCriteriosAudit>(entity =>
            {
                entity.HasKey(e => e.FfaId)
                    .HasName("PK__FFA_FOSF__1D4D182D37032B10");

                entity.ToTable("FFA_FOSFEC_CRITERIOS_AUDIT");

                entity.Property(e => e.FfaId).HasColumnName("FFA_ID");

                entity.Property(e => e.FfaCriterio)
                    .IsRequired()
                    .HasColumnName("FFA_CRITERIO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FfaFecha)
                    .HasColumnName("FFA_FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FfaJustificacion)
                    .IsRequired()
                    .HasColumnName("FFA_JUSTIFICACION")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FfaValor)
                    .IsRequired()
                    .HasColumnName("FFA_VALOR")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FfdId).HasColumnName("FFD_ID");

                entity.Property(e => e.PersoIdAgente).HasColumnName("perso_id_agente");

                entity.HasOne(d => d.Ffd)
                    .WithMany(p => p.FfaFosfecCriteriosAudit)
                    .HasForeignKey(d => d.FfdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FFA_FOSFEC_CRITERIOS_AUDIT_FFD_FOSFEC_DETALLE_VERSION");

                entity.HasOne(d => d.PersoIdAgenteNavigation)
                    .WithMany(p => p.FfaFosfecCriteriosAudit)
                    .HasForeignKey(d => d.PersoIdAgente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FFFA_FOSFEC_CRITERIOS_AUDIT_PERSONAS_AGENCIA");
            });

            modelBuilder.Entity<FfcCargue>(entity =>
            {
                entity.ToTable("FFC_CARGUE");

                entity.Property(e => e.FfcCargueId).HasColumnName("FFC_CARGUE_ID");

                entity.Property(e => e.EntId).HasColumnName("ENT_ID");

                entity.Property(e => e.FfcEstado).HasColumnName("FFC_ESTADO");

                entity.Property(e => e.FfcFechaCargue)
                    .HasColumnName("FFC_FECHA_CARGUE")
                    .HasColumnType("datetime");

                entity.Property(e => e.FfcUsuarioCargue)
                    .IsRequired()
                    .HasColumnName("FFC_USUARIO_CARGUE")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FfvAnio)
                    .IsRequired()
                    .HasColumnName("FFV_ANIO")
                    .HasMaxLength(10);

                entity.Property(e => e.FfvMes).HasColumnName("FFV_MES");

                entity.Property(e => e.FfvVersion)
                    .IsRequired()
                    .HasColumnName("FFV_VERSION")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FfdFosfecDetalleVersion>(entity =>
            {
                entity.HasKey(e => e.FfdId)
                    .HasName("PK__FFD_FOSF__AA0682F8A612CD1E");

                entity.ToTable("FFD_FOSFEC_DETALLE_VERSION");

                entity.HasIndex(e => new { e.PersoId, e.FfvEstado });

                entity.Property(e => e.FfdId).HasColumnName("FFD_ID");

                entity.Property(e => e.EntId).HasColumnName("ent_id");

                entity.Property(e => e.FfvCriterio1)
                    .IsRequired()
                    .HasColumnName("FFV_CRITERIO1")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FfvCriterio2)
                    .IsRequired()
                    .HasColumnName("FFV_CRITERIO2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FfvCriterio3)
                    .IsRequired()
                    .HasColumnName("FFV_CRITERIO3")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FfvCriterio4)
                    .IsRequired()
                    .HasColumnName("FFV_CRITERIO4")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FfvEstado).HasColumnName("FFV_ESTADO");

                entity.Property(e => e.FfvId).HasColumnName("FFV_ID");

                entity.Property(e => e.FfvSalario).HasColumnName("FFV_SALARIO");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.HasOne(d => d.Ffv)
                    .WithMany(p => p.FfdFosfecDetalleVersion)
                    .HasForeignKey(d => d.FfvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FFD_FOSFEC_DETALLE_VERSION_FFV_FOSFEC_VERSIONES");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.FfdFosfecDetalleVersion)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FFD_FOSFEC_DETALLE_VERSION_PERSONAS");
            });

            modelBuilder.Entity<FfvFosfecVersiones>(entity =>
            {
                entity.HasKey(e => e.FfvId)
                    .HasName("PK__FFV_FOSF__023D8E40035C1B63");

                entity.ToTable("FFV_FOSFEC_VERSIONES");

                entity.Property(e => e.FfvId).HasColumnName("FFV_ID");

                entity.Property(e => e.FfvAnio).HasColumnName("FFV_ANIO");

                entity.Property(e => e.FfvHistorico).HasColumnName("FFV_HISTORICO");

                entity.Property(e => e.FfvMes).HasColumnName("FFV_MES");

                entity.Property(e => e.FfvVersion)
                    .IsRequired()
                    .HasColumnName("FFV_VERSION")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FiltroPalabraClave>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.ToTable("filtro_palabra_clave");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.PalabraClave)
                    .HasColumnName("palabra_clave")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId).HasColumnName("session_id");
            });

            modelBuilder.Entity<Funcionalidades>(entity =>
            {
                entity.HasKey(e => e.FuncionalidadId);

                entity.ToTable("Funcionalidades", "auditoria");

                entity.Property(e => e.FuncionalidadId).HasColumnName("Funcionalidad_Id");

                entity.Property(e => e.NombreFuncionalidad)
                    .IsRequired()
                    .HasColumnName("nombreFuncionalidad")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GrupoReportes>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<GruposDenominaciones>(entity =>
            {
                entity.HasKey(e => e.IdGrupoOcupacional);

                entity.Property(e => e.IdGrupoOcupacional).ValueGeneratedNever();

                entity.Property(e => e.Denominaciones)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.GrupoOcupacional)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAreaOcupacionalNavigation)
                    .WithMany(p => p.GruposDenominaciones)
                    .HasForeignKey(d => d.IdAreaOcupacional)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GruposDenominaciones_AreaOcupacional");
            });

            modelBuilder.Entity<HabiPaisRela>(entity =>
            {
                entity.HasKey(e => new { e.HabiId, e.PaisId });

                entity.ToTable("Habi_pais_rela");

                entity.Property(e => e.HabiId)
                    .HasColumnName("habi_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Habi)
                    .WithMany(p => p.HabiPaisRela)
                    .HasForeignKey(d => d.HabiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Habi_pais_rela_Habilidades");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.HabiPaisRela)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Habi_pais_rela_Paises_Home");
            });

            modelBuilder.Entity<Habilidades>(entity =>
            {
                entity.HasKey(e => e.HabiId)
                    .HasName("PK_Habilidad");

                entity.Property(e => e.HabiId)
                    .HasColumnName("habi_id")
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<HistEstadoVacante>(entity =>
            {
                entity.ToTable("hist_estado_vacante");

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId, e.ProceEstaId })
                    .HasName("IX_Hist_estado_Vacante_Sede_Proceso_Estado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.ProceEstaId)
                    .IsRequired()
                    .HasColumnName("proce_esta_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.SedeId).HasColumnName("sede_id");
            });

            modelBuilder.Entity<HistIndicaTotales>(entity =>
            {
                entity.ToTable("histIndicaTotales");

                entity.HasIndex(e => new { e.Id, e.IdAgencia, e.Valor, e.Mes, e.Year, e.IdIndicador })
                    .HasName("IX_histIndicaTotales_mes_year_id_indicador");

                entity.HasIndex(e => new { e.Id, e.Valor, e.IdAgencia, e.Mes, e.Year, e.IdIndicador })
                    .HasName("IX_histIndicaTotales_id_agencia_mes_year_id_indicador");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EntId).HasColumnName("ent_id");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdIndicador).HasColumnName("id_indicador");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.Ent)
                    .WithMany(p => p.HistIndicaTotales)
                    .HasForeignKey(d => d.EntId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_histIndicaTotales_ENT_ENTIDAD");

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.HistIndicaTotales)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_histIndicaTotales_agencia");

                entity.HasOne(d => d.IdIndicadorNavigation)
                    .WithMany(p => p.HistIndicaTotales)
                    .HasForeignKey(d => d.IdIndicador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_histIndicaTotales_IndicadoresTotalesPorGrupo");
            });

            modelBuilder.Entity<HistIndicaTotalesOferentes>(entity =>
            {
                entity.ToTable("Hist_Indica_Totales_Oferentes");

                entity.HasIndex(e => new { e.Id, e.IdAgencia, e.Valor, e.Mes, e.Year, e.IdIndicador })
                    .HasName("IX_histIndicaTotalesOferentes_mes_year_id_indicador");

                entity.HasIndex(e => new { e.Id, e.Valor, e.IdAgencia, e.Mes, e.Year, e.IdIndicador })
                    .HasName("IX_histIndicaTotales_Oferentes_id_agencia_mes_year_id_indicador");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EntId).HasColumnName("ent_id");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdIndicador).HasColumnName("id_indicador");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.Ent)
                    .WithMany(p => p.HistIndicaTotalesOferentes)
                    .HasForeignKey(d => d.EntId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_hist_Indica_Totales_Of_ENTIDAD");

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.HistIndicaTotalesOferentes)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_hist_Indica_Totales_oferentes_agencia");

                entity.HasOne(d => d.IdIndicadorNavigation)
                    .WithMany(p => p.HistIndicaTotalesOferentes)
                    .HasForeignKey(d => d.IdIndicador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_histIndicaTotalesOf_IndicadoresTotalesPorGrupo");
            });

            modelBuilder.Entity<HistIndicaTotalesRemitidos>(entity =>
            {
                entity.ToTable("Hist_Indica_Totales_Remitidos");

                entity.HasIndex(e => new { e.Mes, e.Year, e.IdIndicador })
                    .HasName("IX_Remitidos_mes_anio_indicador");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EntId).HasColumnName("ent_id");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdIndicador).HasColumnName("id_indicador");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.Ent)
                    .WithMany(p => p.HistIndicaTotalesRemitidos)
                    .HasForeignKey(d => d.EntId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_hist_Indica_Totales_Rem_ENTIDAD");

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.HistIndicaTotalesRemitidos)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_hist_Indica_Totales_Remitidos_agencia");

                entity.HasOne(d => d.IdIndicadorNavigation)
                    .WithMany(p => p.HistIndicaTotalesRemitidos)
                    .HasForeignKey(d => d.IdIndicador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_histIndicaTotalesRem_IndicadoresTotalesPorGrupo");
            });

            modelBuilder.Entity<HistIndicador40Mil>(entity =>
            {
                entity.ToTable("histIndicador40Mil");

                entity.HasIndex(e => new { e.Id, e.IdAgencia, e.Valor, e.Mes, e.Year, e.IdIndicador })
                    .HasName("IX_histIndica40Mil_mes_year_id_indicador");

                entity.HasIndex(e => new { e.Id, e.Valor, e.IdAgencia, e.Mes, e.Year, e.IdIndicador })
                    .HasName("IX_histIndica40Mil_id_agencia_mes_year_id_indicador");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EntId).HasColumnName("ent_id");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdIndicador).HasColumnName("id_indicador");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.Ent)
                    .WithMany(p => p.HistIndicador40Mil)
                    .HasForeignKey(d => d.EntId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_histIndicador40Mil_ENT_ENTIDAD");

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.HistIndicador40Mil)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_histIndicador40Mil_agencia");

                entity.HasOne(d => d.IdIndicadorNavigation)
                    .WithMany(p => p.HistIndicador40Mil)
                    .HasForeignKey(d => d.IdIndicador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_histIndicador40Mil_IndicadoresTotalesPorGrupo");
            });

            modelBuilder.Entity<HistIndicadorDiscap>(entity =>
            {
                entity.ToTable("histIndicadorDiscap");

                entity.HasIndex(e => new { e.IdAgencia, e.Mes, e.Year, e.IdIndicador })
                    .HasName("ix_histIndicadorDiscap_id_agencia_mes_year_id_indicador");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EntId).HasColumnName("ent_id");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdIndicador).HasColumnName("id_indicador");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.Ent)
                    .WithMany(p => p.HistIndicadorDiscap)
                    .HasForeignKey(d => d.EntId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_histIndicadorDiscap_ENT_ENTIDAD");

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.HistIndicadorDiscap)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_histIndicadorDiscap_agencia");

                entity.HasOne(d => d.IdIndicadorNavigation)
                    .WithMany(p => p.HistIndicadorDiscap)
                    .HasForeignKey(d => d.IdIndicador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_histIndicadorDiscap_IndicadoresTotalesPorGrupo");
            });

            modelBuilder.Entity<HistIndicadorVictima>(entity =>
            {
                entity.ToTable("histIndicadorVictima");

                entity.HasIndex(e => new { e.Id, e.IdAgencia, e.Valor, e.Mes, e.Year, e.IdIndicador })
                    .HasName("IX_histIndicaVictima_mes_year_id_indicador");

                entity.HasIndex(e => new { e.Id, e.Valor, e.IdAgencia, e.Mes, e.Year, e.IdIndicador })
                    .HasName("IX_histIndicaVictima_id_agencia_mes_year_id_indicador");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EntId).HasColumnName("ent_id");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdIndicador).HasColumnName("id_indicador");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.Ent)
                    .WithMany(p => p.HistIndicadorVictima)
                    .HasForeignKey(d => d.EntId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_histIndicadorVictima_ENT_ENTIDAD");

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.HistIndicadorVictima)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_histIndicadorVictima_agencia");

                entity.HasOne(d => d.IdIndicadorNavigation)
                    .WithMany(p => p.HistIndicadorVictima)
                    .HasForeignKey(d => d.IdIndicador)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_histIndicadorVictima_IndicadoresTotalesPorGrupo");
            });

            modelBuilder.Entity<HistPostuOferente>(entity =>
            {
                entity.ToTable("hist_postu_oferente");

                entity.HasIndex(e => new { e.PosId, e.EscId });

                entity.HasIndex(e => new { e.PosId, e.EscId, e.Fecha })
                    .HasName("IX_hist_postu_oferente_esc_id_fecha");

                entity.HasIndex(e => new { e.PosId, e.EscId, e.IdAgenciaEscId })
                    .HasName("IX_hist_postu_oferente_esc_id_id_agencia_esc_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AsesorId).HasColumnName("asesor_id");

                entity.Property(e => e.EscId).HasColumnName("esc_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAgenciaEscId).HasColumnName("id_agencia_esc_id");

                entity.Property(e => e.PosId).HasColumnName("pos_id");

                entity.HasOne(d => d.Pos)
                    .WithMany(p => p.HistPostuOferente)
                    .HasForeignKey(d => d.PosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_hist_postu_oferente_Postulaciones");
            });

            modelBuilder.Entity<HistoricoTotalesVacantes>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EntId).HasColumnName("ent_id");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdIndicador).HasColumnName("id_indicador");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Valor).HasColumnName("valor");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<HistoricoVistos>(entity =>
            {
                entity.ToTable("historico_vistos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgentePersoId).HasColumnName("agente_perso_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdVisto).HasColumnName("id_visto");

                entity.HasOne(d => d.IdVistoNavigation)
                    .WithMany(p => p.HistoricoVistos)
                    .HasForeignKey(d => d.IdVisto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_historico_vistos_matching_vistos");
            });

            modelBuilder.Entity<HvCompleto>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("HV_Completo");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Link)
                    .HasColumnName("link")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PostuReque).HasColumnName("postu_reque");

                entity.Property(e => e.Puntaje).HasColumnName("puntaje");

                entity.Property(e => e.Sp)
                    .HasColumnName("sp")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HvCurso>(entity =>
            {
                entity.HasKey(e => new { e.PersoId, e.CursosOrdi });

                entity.ToTable("HV_curso");

                entity.HasIndex(e => e.Iduk)
                    .HasName("uk_iduk")
                    .IsUnique();

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.CursosOrdi).HasColumnName("cursos_ordi");

                entity.Property(e => e.CantidadHora)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Desertado).HasColumnName("desertado");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIni)
                    .HasColumnName("fecha_ini")
                    .HasColumnType("datetime");

                entity.Property(e => e.Iduk)
                    .HasColumnName("iduk")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InstiId)
                    .HasColumnName("insti_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InstiNombre)
                    .HasColumnName("insti_nombre")
                    .HasMaxLength(320);

                entity.Property(e => e.PaisId)
                    .IsRequired()
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PractiCk)
                    .HasColumnName("practi_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ResuLogros)
                    .HasColumnName("resu_logros")
                    .HasMaxLength(4000);

                entity.Property(e => e.TituNombre)
                    .IsRequired()
                    .HasColumnName("titu_nombre")
                    .HasMaxLength(320);

                entity.HasOne(d => d.IdTipoCertificadoNavigation)
                    .WithMany(p => p.HvCurso)
                    .HasForeignKey(d => d.IdTipoCertificado)
                    .HasConstraintName("FK_HV_curso_TipoCertificacion");
            });

            modelBuilder.Entity<HvCursoArchivo>(entity =>
            {
                entity.HasKey(e => e.Iduk)
                    .HasName("PK_HV_curso_archivo_1");

                entity.ToTable("HV_curso_archivo");

                entity.Property(e => e.Iduk).HasColumnName("iduk");

                entity.Property(e => e.CantidadHora)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CursosOrdi).HasColumnName("cursos_ordi");

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Desertado).HasColumnName("desertado");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIni)
                    .HasColumnName("fecha_ini")
                    .HasColumnType("datetime");

                entity.Property(e => e.InstiId)
                    .HasColumnName("insti_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InstiNombre)
                    .HasColumnName("insti_nombre")
                    .HasMaxLength(320);

                entity.Property(e => e.PaisId)
                    .IsRequired()
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.PractiCk)
                    .HasColumnName("practi_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ResuLogros)
                    .HasColumnName("resu_logros")
                    .HasMaxLength(4000);

                entity.Property(e => e.TituNombre)
                    .IsRequired()
                    .HasColumnName("titu_nombre")
                    .HasMaxLength(320);
            });

            modelBuilder.Entity<HvEstu>(entity =>
            {
                entity.HasKey(e => new { e.PersoId, e.EstuOrdi });

                entity.ToTable("HV_estu");

                entity.HasIndex(e => e.Iduk)
                    .HasName("uk_iduk")
                    .IsUnique();

                entity.HasIndex(e => new { e.PersoId, e.EstuNivelId, e.IdEstado })
                    .HasName("IX_HV_estu_IdEstado");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.EstuOrdi).HasColumnName("estu_ordi");

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Desertado).HasColumnName("desertado");

                entity.Property(e => e.EstuNivelId)
                    .IsRequired()
                    .HasColumnName("estu_nivel_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FechaExpTarjProf).HasColumnType("datetime");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIni)
                    .HasColumnName("fecha_ini")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdNucleoConoc).HasMaxLength(5);

                entity.Property(e => e.Iduk)
                    .HasColumnName("iduk")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InstiId)
                    .HasColumnName("insti_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InstiNombre)
                    .HasColumnName("insti_nombre")
                    .HasMaxLength(320);

                entity.Property(e => e.NumTarjetaProf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.Property(e => e.PaisId)
                    .IsRequired()
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PractiCk)
                    .HasColumnName("practi_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TituEquiv)
                    .HasColumnName("titu_equiv")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TituId)
                    .HasColumnName("titu_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TituNombre)
                    .HasColumnName("titu_nombre")
                    .HasMaxLength(320);

                entity.HasOne(d => d.EstuNivel)
                    .WithMany(p => p.HvEstu)
                    .HasForeignKey(d => d.EstuNivelId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HV_estu_Estu_nivel");

                entity.HasOne(d => d.IdAreaDesempenoNavigation)
                    .WithMany(p => p.HvEstu)
                    .HasForeignKey(d => d.IdAreaDesempeno)
                    .HasConstraintName("FK_HV_estu_AreaDesempenio");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.HvEstu)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK_HV_estu_EstadoNivelEducativo");

                entity.HasOne(d => d.IdNucleoConocNavigation)
                    .WithMany(p => p.HvEstu)
                    .HasForeignKey(d => d.IdNucleoConoc)
                    .HasConstraintName("FK_HV_estu_NucleoBasicoConocimiento");

                entity.HasOne(d => d.Insti)
                    .WithMany(p => p.HvEstu)
                    .HasForeignKey(d => d.InstiId)
                    .HasConstraintName("FK_HV_estu_Edu_insti");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.HvEstu)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HV_estu_HV_info_basica");

                entity.HasOne(d => d.TituEquivNavigation)
                    .WithMany(p => p.HvEstuTituEquivNavigation)
                    .HasForeignKey(d => d.TituEquiv)
                    .HasConstraintName("FK_HV_estu_Titulos1");

                entity.HasOne(d => d.Titu)
                    .WithMany(p => p.HvEstuTitu)
                    .HasForeignKey(d => d.TituId)
                    .HasConstraintName("FK_HV_estu_Titulos");
            });

            modelBuilder.Entity<HvEstuArchivo>(entity =>
            {
                entity.HasKey(e => e.Iduk);

                entity.ToTable("HV_estu_archivo");

                entity.Property(e => e.Iduk).HasColumnName("iduk");

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Desertado).HasColumnName("desertado");

                entity.Property(e => e.EstuNivelId)
                    .IsRequired()
                    .HasColumnName("estu_nivel_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EstuOrdi).HasColumnName("estu_ordi");

                entity.Property(e => e.FechaExpTarjProf).HasColumnType("datetime");

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIni)
                    .HasColumnName("fecha_ini")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdNucleoConoc).HasMaxLength(50);

                entity.Property(e => e.InstiId)
                    .HasColumnName("insti_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InstiNombre)
                    .HasColumnName("insti_nombre")
                    .HasMaxLength(320);

                entity.Property(e => e.NumTarjetaProf)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Observaciones).HasMaxLength(2000);

                entity.Property(e => e.PaisId)
                    .IsRequired()
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.PractiCk)
                    .HasColumnName("practi_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TituEquiv)
                    .HasColumnName("titu_equiv")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TituId)
                    .HasColumnName("titu_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TituNombre)
                    .HasColumnName("titu_nombre")
                    .HasMaxLength(320);
            });

            modelBuilder.Entity<HvHabi>(entity =>
            {
                entity.HasKey(e => new { e.PersoId, e.HabiOrdi });

                entity.ToTable("HV_Habi");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.HabiOrdi).HasColumnName("habi_ordi");

                entity.Property(e => e.HabiId)
                    .HasColumnName("habi_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.HabiNombre)
                    .HasColumnName("habi_nombre")
                    .HasMaxLength(32);

                entity.Property(e => e.Nivel).HasColumnName("nivel");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.HvHabi)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HV_Habi_HV_info_basica");
            });

            modelBuilder.Entity<HvIdio>(entity =>
            {
                entity.HasKey(e => new { e.PersoId, e.IdioId })
                    .HasName("PK_HV_idioma");

                entity.ToTable("HV_idio");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.IdioId)
                    .HasColumnName("idio_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("fecha_actualizacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nivel).HasColumnName("nivel");

                entity.Property(e => e.OtroIdioma)
                    .HasColumnName("otro_idioma")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Idio)
                    .WithMany(p => p.HvIdio)
                    .HasForeignKey(d => d.IdioId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HV_idio_Idiomas");
            });

            modelBuilder.Entity<HvIdioArchivo>(entity =>
            {
                entity.ToTable("HV_idio_archivo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("fecha_actualizacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdioId)
                    .IsRequired()
                    .HasColumnName("idio_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Nivel).HasColumnName("nivel");

                entity.Property(e => e.OtroIdioma)
                    .HasColumnName("otro_idioma")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersoId).HasColumnName("perso_id");
            });

            modelBuilder.Entity<HvInfoBasica>(entity =>
            {
                entity.HasKey(e => e.PersoId);

                entity.ToTable("HV_info_basica");

                entity.Property(e => e.PersoId)
                    .HasColumnName("perso_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CatLicenciaCarroPart)
                    .HasColumnName("cat_licencia_carro_part")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CatLicenciaCarroPub)
                    .HasColumnName("cat_licencia_carro_pub")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CatLicenciaMoto)
                    .HasColumnName("cat_licencia_moto")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DistiPremios)
                    .HasColumnName("disti_premios")
                    .HasMaxLength(4000);

                entity.Property(e => e.FotoVisiCk)
                    .HasColumnName("foto_visi_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InfoCaracolCk)
                    .HasColumnName("info_caracol_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InfoComCk)
                    .HasColumnName("info_com_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InfoCromosCk)
                    .HasColumnName("info_cromos_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InfoElespecCk)
                    .HasColumnName("info_elespec_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InfoProdCk)
                    .HasColumnName("info_prod_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InfoShockCk)
                    .HasColumnName("info_shock_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InterHobbies)
                    .HasColumnName("inter_hobbies")
                    .HasMaxLength(4000);

                entity.Property(e => e.LicenciaCarro)
                    .HasColumnName("licencia_carro")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LicenciaMoto)
                    .HasColumnName("licencia_moto")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PerfilProf)
                    .HasColumnName("perfil_prof")
                    .HasMaxLength(4000);

                entity.Property(e => e.PersoIdAsesorModif).HasColumnName("perso_id_asesor_modif");

                entity.Property(e => e.PropMedioTrans).HasColumnName("prop_medio_trans");

                entity.Property(e => e.SalarioRangoId).HasColumnName("salario_rango_id");

                entity.Property(e => e.SitLabId).HasColumnName("sit_lab_id");

                entity.Property(e => e.TipoPoblacion)
                    .HasColumnName("tipo_poblacion")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TraslaDispoCk)
                    .HasColumnName("trasla_dispo_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VersionActuFecha)
                    .HasColumnName("version_actu_fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.VersionModifFechaAsesor)
                    .HasColumnName("version_modif_fecha_asesor")
                    .HasColumnType("datetime");

                entity.Property(e => e.ViajeDispoCk)
                    .HasColumnName("viaje_dispo_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VigLicenciaCarroPart)
                    .HasColumnName("vig_licencia_carro_part")
                    .HasColumnType("datetime");

                entity.Property(e => e.VigLicenciaCarroPub)
                    .HasColumnName("vig_licencia_carro_pub")
                    .HasColumnType("datetime");

                entity.Property(e => e.VigLicenciaMoto)
                    .HasColumnName("vig_licencia_moto")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.SalarioRango)
                    .WithMany(p => p.HvInfoBasica)
                    .HasForeignKey(d => d.SalarioRangoId)
                    .HasConstraintName("FK_HV_info_basica_Salario");

                entity.HasOne(d => d.SitLab)
                    .WithMany(p => p.HvInfoBasica)
                    .HasForeignKey(d => d.SitLabId)
                    .HasConstraintName("FK_HV_info_basica_Situacion_Laboral");
            });

            modelBuilder.Entity<HvInfoBasicaArchivo>(entity =>
            {
                entity.ToTable("HV_info_basica_archivo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CatLicenciaCarroPart)
                    .HasColumnName("cat_licencia_carro_part")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CatLicenciaCarroPub)
                    .HasColumnName("cat_licencia_carro_pub")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CatLicenciaMoto)
                    .HasColumnName("cat_licencia_moto")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DistiPremios)
                    .HasColumnName("disti_premios")
                    .HasMaxLength(4000);

                entity.Property(e => e.FotoVisiCk)
                    .HasColumnName("foto_visi_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InfoCaracolCk)
                    .HasColumnName("info_caracol_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InfoComCk)
                    .HasColumnName("info_com_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InfoCromosCk)
                    .HasColumnName("info_cromos_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InfoElespecCk)
                    .HasColumnName("info_elespec_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InfoProdCk)
                    .HasColumnName("info_prod_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InfoShockCk)
                    .HasColumnName("info_shock_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.InterHobbies)
                    .HasColumnName("inter_hobbies")
                    .HasMaxLength(4000);

                entity.Property(e => e.LicenciaCarro)
                    .HasColumnName("licencia_carro")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.LicenciaMoto)
                    .HasColumnName("licencia_moto")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PerfilProf)
                    .HasColumnName("perfil_prof")
                    .HasMaxLength(4000);

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.PersoIdAsesorModif).HasColumnName("perso_id_asesor_modif");

                entity.Property(e => e.PropMedioTrans).HasColumnName("prop_medio_trans");

                entity.Property(e => e.SalarioRangoId).HasColumnName("salario_rango_id");

                entity.Property(e => e.SitLabId).HasColumnName("sit_lab_id");

                entity.Property(e => e.TipoPoblacion)
                    .HasColumnName("tipo_poblacion")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TraslaDispoCk)
                    .HasColumnName("trasla_dispo_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VersionActuFecha)
                    .HasColumnName("version_actu_fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.VersionModifFechaAsesor)
                    .HasColumnName("version_modif_fecha_asesor")
                    .HasColumnType("datetime");

                entity.Property(e => e.ViajeDispoCk)
                    .HasColumnName("viaje_dispo_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VigLicenciaCarroPart)
                    .HasColumnName("vig_licencia_carro_part")
                    .HasColumnType("datetime");

                entity.Property(e => e.VigLicenciaCarroPub)
                    .HasColumnName("vig_licencia_carro_pub")
                    .HasColumnType("datetime");

                entity.Property(e => e.VigLicenciaMoto)
                    .HasColumnName("vig_licencia_moto")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<HvLaboExpe>(entity =>
            {
                entity.HasKey(e => new { e.PersoId, e.LaboExpeOrdi });

                entity.ToTable("HV_labo_expe");

                entity.HasIndex(e => e.Iduk)
                    .HasName("uk_iduk")
                    .IsUnique();

                entity.HasIndex(e => new { e.PersoId, e.FechaIni, e.FechaFin, e.IdGrupoOcupacional })
                    .HasName("IX_HV_labo_expe_IdGrupoOcupacional");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.LaboExpeOrdi).HasColumnName("labo_expe_ordi");

                entity.Property(e => e.AreaTag1)
                    .HasColumnName("area_tag1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AreaTag2)
                    .HasColumnName("area_tag2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AreaTag3)
                    .HasColumnName("area_tag3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CantidadPersonas)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CargoEquivId)
                    .HasColumnName("cargo_equiv_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CargoId)
                    .HasColumnName("cargo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CargoNombre)
                    .HasColumnName("cargo_nombre")
                    .HasMaxLength(320);

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EmpreCampoId)
                    .HasColumnName("empre_campo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EmpreIndusId).HasColumnName("empre_indus_id");

                entity.Property(e => e.EmpreJefe)
                    .HasColumnName("empre_jefe")
                    .HasMaxLength(250);

                entity.Property(e => e.EmpreNombre)
                    .IsRequired()
                    .HasColumnName("empre_nombre")
                    .HasMaxLength(320);

                entity.Property(e => e.EmpreSectoId).HasColumnName("empre_secto_id");

                entity.Property(e => e.EmpreTel)
                    .HasColumnName("empre_tel")
                    .HasMaxLength(32);

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIni)
                    .HasColumnName("fecha_ini")
                    .HasColumnType("datetime");

                entity.Property(e => e.FuncLogros)
                    .HasColumnName("func_logros")
                    .HasMaxLength(4000);

                entity.Property(e => e.Iduk)
                    .HasColumnName("iduk")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.MotivoRetiro)
                    .HasColumnName("motivo_retiro")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId)
                    .IsRequired()
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.ProductoComercializar)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGrupoOcupacionalNavigation)
                    .WithMany(p => p.HvLaboExpe)
                    .HasForeignKey(d => d.IdGrupoOcupacional)
                    .HasConstraintName("FK_HV_labo_expe_GruposDenominaciones");

                entity.HasOne(d => d.IdTipoExperienciaLaboralNavigation)
                    .WithMany(p => p.HvLaboExpe)
                    .HasForeignKey(d => d.IdTipoExperienciaLaboral)
                    .HasConstraintName("FK_HV_labo_expe_TipoExperienciaLaboral");
            });

            modelBuilder.Entity<HvLaboExpeArchivo>(entity =>
            {
                entity.HasKey(e => e.Iduk);

                entity.ToTable("HV_labo_expe_archivo");

                entity.Property(e => e.Iduk).HasColumnName("iduk");

                entity.Property(e => e.AreaTag1)
                    .HasColumnName("area_tag1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AreaTag2)
                    .HasColumnName("area_tag2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AreaTag3)
                    .HasColumnName("area_tag3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CantidadPersonas)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CargoEquivId)
                    .HasColumnName("cargo_equiv_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CargoId)
                    .HasColumnName("cargo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CargoNombre)
                    .HasColumnName("cargo_nombre")
                    .HasMaxLength(320);

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EmpreCampoId)
                    .HasColumnName("empre_campo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EmpreIndusId).HasColumnName("empre_indus_id");

                entity.Property(e => e.EmpreJefe)
                    .HasColumnName("empre_jefe")
                    .HasMaxLength(250);

                entity.Property(e => e.EmpreNombre)
                    .IsRequired()
                    .HasColumnName("empre_nombre")
                    .HasMaxLength(320);

                entity.Property(e => e.EmpreSectoId).HasColumnName("empre_secto_id");

                entity.Property(e => e.EmpreTel)
                    .HasColumnName("empre_tel")
                    .HasMaxLength(32);

                entity.Property(e => e.FechaFin)
                    .HasColumnName("fecha_fin")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaIni)
                    .HasColumnName("fecha_ini")
                    .HasColumnType("datetime");

                entity.Property(e => e.FuncLogros)
                    .HasColumnName("func_logros")
                    .HasMaxLength(4000);

                entity.Property(e => e.LaboExpeOrdi).HasColumnName("labo_expe_ordi");

                entity.Property(e => e.MotivoRetiro)
                    .HasColumnName("motivo_retiro")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId)
                    .IsRequired()
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.ProductoComercializar)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HvOfimaticas>(entity =>
            {
                entity.HasKey(e => e.OfimaticaId)
                    .HasName("PK__hv_ofima__BE38A550B4AB6AD4");

                entity.ToTable("hv_ofimaticas");

                entity.HasIndex(e => e.PersoId);

                entity.Property(e => e.OfimaticaId).HasColumnName("ofimatica_id");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("fecha_actualizacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nivel).HasColumnName("nivel");

                entity.Property(e => e.OfiId).HasColumnName("OFI_ID");

                entity.Property(e => e.OfiTipoDesc)
                    .HasColumnName("ofi_tipo_desc")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PersoId).HasColumnName("perso_id");
            });

            modelBuilder.Entity<HvOfimaticasArchivo>(entity =>
            {
                entity.HasKey(e => e.OfimaticaId)
                    .HasName("PK__hv_ofima__BE38A550D48469D7");

                entity.ToTable("hv_ofimaticas_archivo");

                entity.Property(e => e.OfimaticaId).HasColumnName("ofimatica_id");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("fecha_actualizacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nivel).HasColumnName("nivel");

                entity.Property(e => e.OfiId).HasColumnName("OFI_ID");

                entity.Property(e => e.OfiTipoDesc)
                    .HasColumnName("ofi_tipo_desc")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PersoId).HasColumnName("perso_id");
            });

            modelBuilder.Entity<HvSeguSoc>(entity =>
            {
                entity.HasKey(e => e.PersoId)
                    .HasName("PK_HV_SeguSoc");

                entity.ToTable("HV_segu_soc");

                entity.Property(e => e.PersoId)
                    .HasColumnName("perso_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CesantEntiId)
                    .HasColumnName("cesant_enti_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.CompenEntiId)
                    .HasColumnName("compen_enti_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PensoEntiId)
                    .HasColumnName("penso_enti_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.PensvEntiId)
                    .HasColumnName("pensv_enti_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.SaludEntiId)
                    .HasColumnName("salud_enti_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.CesantEnti)
                    .WithMany(p => p.HvSeguSocCesantEnti)
                    .HasForeignKey(d => d.CesantEntiId)
                    .HasConstraintName("FK_HV_segu_soc_Segu_soc_enti");

                entity.HasOne(d => d.CompenEnti)
                    .WithMany(p => p.HvSeguSocCompenEnti)
                    .HasForeignKey(d => d.CompenEntiId)
                    .HasConstraintName("FK_HV_segu_soc_Segu_soc_enti1");

                entity.HasOne(d => d.PensoEnti)
                    .WithMany(p => p.HvSeguSocPensoEnti)
                    .HasForeignKey(d => d.PensoEntiId)
                    .HasConstraintName("FK_HV_segu_soc_Segu_soc_enti2");

                entity.HasOne(d => d.PensvEnti)
                    .WithMany(p => p.HvSeguSocPensvEnti)
                    .HasForeignKey(d => d.PensvEntiId)
                    .HasConstraintName("FK_HV_segu_soc_Segu_soc_enti3");

                entity.HasOne(d => d.Perso)
                    .WithOne(p => p.HvSeguSoc)
                    .HasForeignKey<HvSeguSoc>(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_HV_SeguSoc_HV_info_basica");
            });

            modelBuilder.Entity<Idiomas>(entity =>
            {
                entity.HasKey(e => e.IdioId);

                entity.Property(e => e.IdioId)
                    .HasColumnName("idio_id")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<IhoIntensidadHoraria>(entity =>
            {
                entity.HasKey(e => e.IhoId);

                entity.ToTable("IHO_INTENSIDAD_HORARIA");

                entity.HasIndex(e => e.CnvId);

                entity.HasIndex(e => new { e.IhoFecha, e.CnvId });

                entity.Property(e => e.IhoId).HasColumnName("IHO_ID");

                entity.Property(e => e.CnvId).HasColumnName("CNV_ID");

                entity.Property(e => e.IhoFecha)
                    .HasColumnName("IHO_FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.IhoHoraFin).HasColumnName("IHO_HORA_FIN");

                entity.Property(e => e.IhoHoraInicio).HasColumnName("IHO_HORA_INICIO");

                entity.HasOne(d => d.Cnv)
                    .WithMany(p => p.IhoIntensidadHoraria)
                    .HasForeignKey(d => d.CnvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IHO_INTENSIDAD_HORARIA_CNV_CONVOCATORIA");
            });

            modelBuilder.Entity<IndIndicador>(entity =>
            {
                entity.HasKey(e => e.IndId)
                    .HasName("PK__IND_INDI__10BE4BB15BE79A84");

                entity.ToTable("IND_INDICADOR");

                entity.Property(e => e.IndId)
                    .HasColumnName("IND_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CinId).HasColumnName("CIN_ID");

                entity.Property(e => e.IndDescripcion)
                    .IsRequired()
                    .HasColumnName("IND_DESCRIPCION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IndMetrica)
                    .IsRequired()
                    .HasColumnName("IND_METRICA")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IndOrden).HasColumnName("IND_ORDEN");

                entity.HasOne(d => d.Cin)
                    .WithMany(p => p.IndIndicador)
                    .HasForeignKey(d => d.CinId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IND_INDICADOR_CIN_CONCEPTO_INDICADOR");
            });

            modelBuilder.Entity<IndIndustria>(entity =>
            {
                entity.HasKey(e => e.IndId);

                entity.ToTable("IND_INDUSTRIA");

                entity.Property(e => e.IndId).HasColumnName("IND_ID");

                entity.Property(e => e.IndCodigo)
                    .IsRequired()
                    .HasColumnName("IND_CODIGO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.IndNombre)
                    .IsRequired()
                    .HasColumnName("IND_NOMBRE")
                    .HasMaxLength(450)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IndicadorDemandanteDetalleHistorico>(entity =>
            {
                entity.ToTable("indicador_demandante_detalle_historico");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActividadEconomica)
                    .HasColumnName("actividad_economica")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Agencia)
                    .HasColumnName("agencia")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AgenciaAprobo)
                    .HasColumnName("agencia_aprobo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.Autoregistro).HasColumnName("autoregistro");

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasColumnName("ciudad")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .HasColumnName("correo_electronico")
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronicoAgente)
                    .HasColumnName("correo_electronico_agente")
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronicoUsuario)
                    .IsRequired()
                    .HasColumnName("correo_electronico_usuario")
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasColumnName("departamento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoSede).HasColumnName("estado_sede");

                entity.Property(e => e.FechaAprobacion)
                    .HasColumnName("fecha_aprobacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacionSede)
                    .HasColumnName("fecha_creacion_sede")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAdministrador).HasColumnName("id_administrador");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdAgenciaAprobo).HasColumnName("id_agencia_aprobo");

                entity.Property(e => e.IdAgente).HasColumnName("id_agente");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdPrestador).HasColumnName("id_prestador");

                entity.Property(e => e.IdPrestadorAprobo).HasColumnName("id_prestador_aprobo");

                entity.Property(e => e.IdSede).HasColumnName("id_sede");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Naturaleza)
                    .HasColumnName("naturaleza")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAgente)
                    .HasColumnName("nombre_agente")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSede)
                    .HasColumnName("nombre_sede")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasColumnName("nombre_usuario")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .HasColumnName("numero_documento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoAdmin)
                    .HasColumnName("numero_documento_admin")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Prestador)
                    .HasColumnName("prestador")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PrestadorAprobo)
                    .HasColumnName("prestador_aprobo")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("primer_apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerNombre)
                    .HasColumnName("primer_nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("razon_social")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasColumnName("sector")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("segundo_apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("segundo_nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tamanio)
                    .HasColumnName("tamanio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoAdmin)
                    .HasColumnName("telefono_admin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumento)
                    .HasColumnName("tipo_documento")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumentoAdmin)
                    .HasColumnName("tipo_documento_admin")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEmpresa)
                    .HasColumnName("tipo_empresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSede)
                    .HasColumnName("tipo_sede")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoUsuario)
                    .IsRequired()
                    .HasColumnName("tipo_usuario")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IndicadorDemandanteDetalleMes>(entity =>
            {
                entity.ToTable("indicador_demandante_detalle_mes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActividadEconomica)
                    .HasColumnName("actividad_economica")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.Agencia)
                    .HasColumnName("agencia")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AgenciaAprobo)
                    .HasColumnName("agencia_aprobo")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.Autoregistro).HasColumnName("autoregistro");

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Ciudad)
                    .HasColumnName("ciudad")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .HasColumnName("correo_electronico")
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronicoAgente)
                    .HasColumnName("correo_electronico_agente")
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronicoUsuario)
                    .IsRequired()
                    .HasColumnName("correo_electronico_usuario")
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasColumnName("departamento")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoSede).HasColumnName("estado_sede");

                entity.Property(e => e.FechaAprobacion)
                    .HasColumnName("fecha_aprobacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacionSede)
                    .HasColumnName("fecha_creacion_sede")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAdministrador).HasColumnName("id_administrador");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdAgenciaAprobo).HasColumnName("id_agencia_aprobo");

                entity.Property(e => e.IdAgente).HasColumnName("id_agente");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdPrestador).HasColumnName("id_prestador");

                entity.Property(e => e.IdPrestadorAprobo).HasColumnName("id_prestador_aprobo");

                entity.Property(e => e.IdSede).HasColumnName("id_sede");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.Naturaleza)
                    .HasColumnName("naturaleza")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAgente)
                    .HasColumnName("nombre_agente")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSede)
                    .HasColumnName("nombre_sede")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasColumnName("nombre_usuario")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumento)
                    .HasColumnName("numero_documento")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroDocumentoAdmin)
                    .HasColumnName("numero_documento_admin")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Prestador)
                    .HasColumnName("prestador")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PrestadorAprobo)
                    .HasColumnName("prestador_aprobo")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("primer_apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerNombre)
                    .HasColumnName("primer_nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("razon_social")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasColumnName("sector")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("segundo_apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("segundo_nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tamanio)
                    .HasColumnName("tamanio")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoAdmin)
                    .HasColumnName("telefono_admin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumento)
                    .HasColumnName("tipo_documento")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocumentoAdmin)
                    .HasColumnName("tipo_documento_admin")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEmpresa)
                    .HasColumnName("tipo_empresa")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSede)
                    .HasColumnName("tipo_sede")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TipoUsuario)
                    .IsRequired()
                    .HasColumnName("tipo_usuario")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IndicadorDemandanteTotalesHistorico>(entity =>
            {
                entity.ToTable("indicador_demandante_totales_historico");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Anio).HasColumnName("anio");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdIndicador1).HasColumnName("id_indicador_1");

                entity.Property(e => e.IdIndicador2).HasColumnName("id_indicador_2");

                entity.Property(e => e.IdIndicador3).HasColumnName("id_indicador_3");

                entity.Property(e => e.IdIndicador4).HasColumnName("id_indicador_4");

                entity.Property(e => e.IdIndicador5).HasColumnName("id_indicador_5");

                entity.Property(e => e.IdIndicador6).HasColumnName("id_indicador_6");

                entity.Property(e => e.IdIndicador7).HasColumnName("id_indicador_7");

                entity.Property(e => e.IdIndicador8).HasColumnName("id_indicador_8");

                entity.Property(e => e.IdIndicador9).HasColumnName("id_indicador_9");

                entity.Property(e => e.IdPrestador).HasColumnName("id_prestador");

                entity.Property(e => e.Indicador1)
                    .IsRequired()
                    .HasColumnName("indicador_1")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Indicador2)
                    .IsRequired()
                    .HasColumnName("indicador_2")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Indicador3)
                    .IsRequired()
                    .HasColumnName("indicador_3")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Indicador4)
                    .IsRequired()
                    .HasColumnName("indicador_4")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Indicador5)
                    .IsRequired()
                    .HasColumnName("indicador_5")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Indicador6)
                    .IsRequired()
                    .HasColumnName("indicador_6")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Indicador7)
                    .IsRequired()
                    .HasColumnName("indicador_7")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Indicador8)
                    .IsRequired()
                    .HasColumnName("indicador_8")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Indicador9)
                    .IsRequired()
                    .HasColumnName("indicador_9")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Mes).HasColumnName("mes");

                entity.Property(e => e.NombreAgencia)
                    .IsRequired()
                    .HasColumnName("nombre_agencia")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NombrePrestador)
                    .IsRequired()
                    .HasColumnName("nombre_prestador")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Total1).HasColumnName("total_1");

                entity.Property(e => e.Total2).HasColumnName("total_2");

                entity.Property(e => e.Total3).HasColumnName("total_3");

                entity.Property(e => e.Total4).HasColumnName("total_4");

                entity.Property(e => e.Total5).HasColumnName("total_5");

                entity.Property(e => e.Total6).HasColumnName("total_6");

                entity.Property(e => e.Total7).HasColumnName("total_7");

                entity.Property(e => e.Total8).HasColumnName("total_8");

                entity.Property(e => e.Total9).HasColumnName("total_9");

                entity.Property(e => e.Valor1).HasColumnName("valor_1");

                entity.Property(e => e.Valor2).HasColumnName("valor_2");

                entity.Property(e => e.Valor3).HasColumnName("valor_3");

                entity.Property(e => e.Valor4).HasColumnName("valor_4");

                entity.Property(e => e.Valor5).HasColumnName("valor_5");

                entity.Property(e => e.Valor6).HasColumnName("valor_6");

                entity.Property(e => e.Valor7).HasColumnName("valor_7");

                entity.Property(e => e.Valor8).HasColumnName("valor_8");

                entity.Property(e => e.Valor9).HasColumnName("valor_9");
            });

            modelBuilder.Entity<IndicadoresTotalesPorGrupo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdGrupo).HasColumnName("idGrupo");

                entity.Property(e => e.Indicador)
                    .IsRequired()
                    .HasColumnName("indicador")
                    .HasMaxLength(200);

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.IndicadoresTotalesPorGrupo)
                    .HasForeignKey(d => d.IdGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_IndicadoresTotalesPorGrupo_GrupoReportes");
            });

            modelBuilder.Entity<InfoAdicionalProceso>(entity =>
            {
                entity.ToTable("info_adicional_proceso");

                entity.Property(e => e.InfoAdiEmpleos).HasMaxLength(25);

                entity.Property(e => e.ProcesoId).HasColumnName("Proceso_id");

                entity.Property(e => e.SedeId).HasColumnName("Sede_id");
            });

            modelBuilder.Entity<InsInscripciones>(entity =>
            {
                entity.HasKey(e => e.InsId);

                entity.ToTable("INS_INSCRIPCIONES");

                entity.HasIndex(e => e.CnvId);

                entity.HasIndex(e => e.PicId);

                entity.HasIndex(e => new { e.PersoIdOferente, e.CnvId });

                entity.HasIndex(e => new { e.PersoIdOferente, e.CnvId, e.InsFecha })
                    .HasName("IXX_INS_INSCRIPCIONES_INS_FECHA");

                entity.HasIndex(e => new { e.InsId, e.InsFecha, e.VlcEstadoInscrip, e.CnvId, e.PicId, e.CtaId })
                    .HasName("IX_INS_INSCRIPCIONES_PIC_ID_CTA_ID");

                entity.Property(e => e.InsId).HasColumnName("INS_ID");

                entity.Property(e => e.CnvId).HasColumnName("CNV_ID");

                entity.Property(e => e.CtaId).HasColumnName("CTA_ID");

                entity.Property(e => e.InsDetalleFinal)
                    .HasColumnName("INS_DETALLE_FINAL")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InsFecha)
                    .HasColumnName("INS_FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsFechaAccion)
                    .HasColumnName("INS_FECHA_ACCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.InsLugarAccion)
                    .IsRequired()
                    .HasColumnName("INS_LUGAR_ACCION")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PersoIdAgencia).HasColumnName("PERSO_ID_AGENCIA");

                entity.Property(e => e.PersoIdOferente).HasColumnName("PERSO_ID_OFERENTE");

                entity.Property(e => e.PicId).HasColumnName("PIC_ID");

                entity.Property(e => e.VlcEstadoInscrip).HasColumnName("VLC_ESTADO_INSCRIP");

                entity.HasOne(d => d.Cnv)
                    .WithMany(p => p.InsInscripciones)
                    .HasForeignKey(d => d.CnvId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INS_INSCRIPCIONES_CNV_CONVOCATORIA");

                entity.HasOne(d => d.Cta)
                    .WithMany(p => p.InsInscripciones)
                    .HasForeignKey(d => d.CtaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INS_INSCRIPCIONES_CTA_CURSOS_TALLERES");

                entity.HasOne(d => d.PersoIdAgenciaNavigation)
                    .WithMany(p => p.InsInscripciones)
                    .HasForeignKey(d => d.PersoIdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INS_INSCRIPCIONES_Personas_agencia");

                entity.HasOne(d => d.PersoIdOferenteNavigation)
                    .WithMany(p => p.InsInscripciones)
                    .HasForeignKey(d => d.PersoIdOferente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INS_INSCRIPCIONES_Personas");

                entity.HasOne(d => d.Pic)
                    .WithMany(p => p.InsInscripciones)
                    .HasForeignKey(d => d.PicId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_INS_INSCRIPCIONES_PIC_PREINSCRIPCIONES_CTA");
            });

            modelBuilder.Entity<InterOrga>(entity =>
            {
                entity.ToTable("Inter_orga");

                entity.HasIndex(e => new { e.TipoDocuId, e.Nit, e.InterOrgaId })
                    .HasName("IXX_Inter_orga_tipo_docu_id_NIT_inter_orga_id");

                entity.Property(e => e.InterOrgaId)
                    .HasColumnName("inter_orga_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActId).HasColumnName("ACT_ID");

                entity.Property(e => e.Autoregistro).HasColumnName("autoregistro");

                entity.Property(e => e.CantEmpleados).HasColumnName("cant_empleados");

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmpreTipoId)
                    .HasColumnName("empre_tipo_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EntId).HasColumnName("ent_id");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("fecha_actualizacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaBloqueo)
                    .HasColumnName("fecha_bloqueo")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdNaturaleza).HasColumnName("id_naturaleza");

                entity.Property(e => e.IndId).HasColumnName("IND_ID");

                entity.Property(e => e.Logo)
                    .HasColumnName("logo")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nit)
                    .HasColumnName("NIT")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PersoIdAgencia).HasColumnName("perso_id_agencia");

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("razon_social")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SecId).HasColumnName("SEC_ID");

                entity.Property(e => e.SitioWeb)
                    .HasColumnName("sitio_web")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TipoDocuId)
                    .HasColumnName("tipo_docu_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.HasOne(d => d.CantEmpleadosNavigation)
                    .WithMany(p => p.InterOrga)
                    .HasForeignKey(d => d.CantEmpleados)
                    .HasConstraintName("FK_Inter_orga_Empre_canti_emple");

                entity.HasOne(d => d.EmpreTipo)
                    .WithMany(p => p.InterOrga)
                    .HasForeignKey(d => d.EmpreTipoId)
                    .HasConstraintName("FK_Inter_orga_Empre_Tipo");

                entity.HasOne(d => d.IdNaturalezaNavigation)
                    .WithMany(p => p.InterOrga)
                    .HasForeignKey(d => d.IdNaturaleza)
                    .HasConstraintName("FK_Inter_orga_Empre_Naturaleza");

                entity.HasOne(d => d.TipoDocu)
                    .WithMany(p => p.InterOrga)
                    .HasForeignKey(d => d.TipoDocuId)
                    .HasConstraintName("FK_Inter_orga_tipo_documento");
            });

            modelBuilder.Entity<Iva>(entity =>
            {
                entity.ToTable("IVA");

                entity.Property(e => e.IvaId).HasColumnName("iva_id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50);

                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fecha_creacion")
                    .HasColumnType("date");

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Localidades>(entity =>
            {
                entity.HasKey(e => e.CodigoLocalidad);

                entity.Property(e => e.CodigoLocalidad)
                    .HasColumnName("codigo_localidad")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.CiudadId)
                    .IsRequired()
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(50);

                entity.Property(e => e.NombreLocalidad)
                    .IsRequired()
                    .HasColumnName("nombreLocalidad")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<LogAuditoria>(entity =>
            {
                entity.HasKey(e => e.IdOperacion);

                entity.Property(e => e.FechaOperacion).HasColumnType("datetime");

                entity.Property(e => e.NombreOpercion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NombreProceso)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NombreTabla).HasMaxLength(50);

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.Property(e => e.Sentencia)
                    .HasColumnName("sentencia")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogAuditoria1>(entity =>
            {
                entity.ToTable("Log_Auditoria", "auditoria");

                entity.Property(e => e.AccionId).HasColumnName("Accion_id");

                entity.Property(e => e.Datos)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FuncionalidadId).HasColumnName("Funcionalidad_id");

                entity.Property(e => e.IdPuntoResponsable).HasColumnName("Id_Punto_Responsable");

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModuloId).HasColumnName("Modulo_id");

                entity.Property(e => e.PersoIdAfectado).HasColumnName("Perso_Id_Afectado");

                entity.Property(e => e.PersoIdResponsable).HasColumnName("Perso_Id_Responsable");

                entity.HasOne(d => d.Accion)
                    .WithMany(p => p.LogAuditoria1)
                    .HasForeignKey(d => d.AccionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Auditoria_Acciones");

                entity.HasOne(d => d.Funcionalidad)
                    .WithMany(p => p.LogAuditoria1)
                    .HasForeignKey(d => d.FuncionalidadId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Auditoria_Funcionalidades");

                entity.HasOne(d => d.Modulo)
                    .WithMany(p => p.LogAuditoria1)
                    .HasForeignKey(d => d.ModuloId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Log_Auditoria_Modulos");
            });

            modelBuilder.Entity<LogCandidatos>(entity =>
            {
                entity.HasKey(e => e.IdCandidatos);

                entity.ToTable("log_candidatos");

                entity.HasIndex(e => new { e.InterOrgaId, e.ProcesoId, e.TipoSeleccion, e.Estado, e.Fecha });

                entity.Property(e => e.IdCandidatos).HasColumnName("id_candidatos");

                entity.Property(e => e.Contador).HasColumnName("contador");

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.TipoSeleccion)
                    .HasColumnName("tipo_seleccion")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LogDemandante>(entity =>
            {
                entity.HasKey(e => e.LogAccionRealizadaId);

                entity.ToTable("LOG_DEMANDANTE", "auditoria");

                entity.Property(e => e.LogAccionRealizadaId).HasColumnName("LOG_ACCION_REALIZADA_ID");

                entity.Property(e => e.AccionControladorId)
                    .IsRequired()
                    .HasColumnName("ACCION_CONTROLADOR_ID")
                    .HasMaxLength(64);

                entity.Property(e => e.Afectado)
                    .HasColumnName("AFECTADO")
                    .HasMaxLength(64);

                entity.Property(e => e.AfectadoId).HasColumnName("AFECTADO_ID");

                entity.Property(e => e.Agencia)
                    .HasColumnName("AGENCIA")
                    .HasMaxLength(64);

                entity.Property(e => e.AgenciaId).HasColumnName("AGENCIA_ID");

                entity.Property(e => e.AuditoriaFechaCreacion)
                    .HasColumnName("AUDITORIA_FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datos)
                    .IsRequired()
                    .HasColumnName("DATOS")
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(64);

                entity.Property(e => e.Prestador)
                    .HasColumnName("PRESTADOR")
                    .HasMaxLength(64);

                entity.Property(e => e.PrestadorId).HasColumnName("PRESTADOR_ID");

                entity.Property(e => e.RegistroAfectado)
                    .HasColumnName("REGISTRO_AFECTADO")
                    .HasMaxLength(64);

                entity.Property(e => e.RegistroAfectadoId)
                    .HasColumnName("REGISTRO_AFECTADO_ID")
                    .HasMaxLength(64);

                entity.Property(e => e.RolId).HasColumnName("ROL_ID");

                entity.Property(e => e.TablaAfectado)
                    .HasColumnName("TABLA_AFECTADO")
                    .HasMaxLength(64);

                entity.Property(e => e.TablaRegistroAfectado)
                    .HasColumnName("TABLA_REGISTRO_AFECTADO")
                    .HasMaxLength(64);

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(64);

                entity.Property(e => e.UsuarioId).HasColumnName("USUARIO_ID");
            });

            modelBuilder.Entity<LogErrores>(entity =>
            {
                entity.HasKey(e => e.IdLog);

                entity.ToTable("log_errores");

                entity.Property(e => e.IdLog).HasColumnName("id_log");

                entity.Property(e => e.Error).HasColumnName("error");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Pagina).HasColumnName("pagina");

                entity.Property(e => e.SessionId).HasColumnName("session_id");
            });

            modelBuilder.Entity<LogOferente>(entity =>
            {
                entity.HasKey(e => e.LogAccionRealizadaId)
                    .HasName("PK_LOG_LOG_OFERENTE");

                entity.ToTable("LOG_OFERENTE", "auditoria");

                entity.Property(e => e.LogAccionRealizadaId).HasColumnName("LOG_ACCION_REALIZADA_ID");

                entity.Property(e => e.AccionControladorId)
                    .IsRequired()
                    .HasColumnName("ACCION_CONTROLADOR_ID")
                    .HasMaxLength(64);

                entity.Property(e => e.Afectado)
                    .HasColumnName("AFECTADO")
                    .HasMaxLength(64);

                entity.Property(e => e.AfectadoId).HasColumnName("AFECTADO_ID");

                entity.Property(e => e.Agencia)
                    .HasColumnName("AGENCIA")
                    .HasMaxLength(64);

                entity.Property(e => e.AgenciaId).HasColumnName("AGENCIA_ID");

                entity.Property(e => e.AuditoriaFechaCreacion)
                    .HasColumnName("AUDITORIA_FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datos)
                    .IsRequired()
                    .HasColumnName("DATOS")
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(64);

                entity.Property(e => e.Prestador)
                    .HasColumnName("PRESTADOR")
                    .HasMaxLength(64);

                entity.Property(e => e.PrestadorId).HasColumnName("PRESTADOR_ID");

                entity.Property(e => e.RegistroAfectado)
                    .HasColumnName("REGISTRO_AFECTADO")
                    .HasMaxLength(64);

                entity.Property(e => e.RegistroAfectadoId)
                    .HasColumnName("REGISTRO_AFECTADO_ID")
                    .HasMaxLength(64);

                entity.Property(e => e.RolId).HasColumnName("ROL_ID");

                entity.Property(e => e.TablaAfectado)
                    .HasColumnName("TABLA_AFECTADO")
                    .HasMaxLength(64);

                entity.Property(e => e.TablaRegistroAfectado)
                    .HasColumnName("TABLA_REGISTRO_AFECTADO")
                    .HasMaxLength(64);

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(64);

                entity.Property(e => e.UsuarioId).HasColumnName("USUARIO_ID");
            });

            modelBuilder.Entity<LogOfertas>(entity =>
            {
                entity.HasKey(e => e.IdLogOfertas);

                entity.ToTable("log_ofertas");

                entity.HasIndex(e => new { e.Fecha, e.ProcesoId, e.InterOrgaId, e.Descripcion })
                    .HasName("IX_Log_ofertas_fecha_proceso_inter_orga_desc");

                entity.HasIndex(e => new { e.Contador, e.Fecha, e.ProcesoId, e.InterOrgaId, e.Descripcion })
                    .HasName("IX_Log_ofertas_fecha_proceso_inter_orga_desc_con");

                entity.Property(e => e.IdLogOfertas).HasColumnName("id_log_ofertas");

                entity.Property(e => e.Contador).HasColumnName("contador");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");
            });

            modelBuilder.Entity<LogPrestador>(entity =>
            {
                entity.HasKey(e => e.LogAccionRealizadaId);

                entity.ToTable("LOG_PRESTADOR", "auditoria");

                entity.Property(e => e.LogAccionRealizadaId).HasColumnName("LOG_ACCION_REALIZADA_ID");

                entity.Property(e => e.AccionControladorId)
                    .IsRequired()
                    .HasColumnName("ACCION_CONTROLADOR_ID")
                    .HasMaxLength(64);

                entity.Property(e => e.Afectado)
                    .HasColumnName("AFECTADO")
                    .HasMaxLength(64);

                entity.Property(e => e.AfectadoId).HasColumnName("AFECTADO_ID");

                entity.Property(e => e.Agencia)
                    .HasColumnName("AGENCIA")
                    .HasMaxLength(64);

                entity.Property(e => e.AgenciaId).HasColumnName("AGENCIA_ID");

                entity.Property(e => e.AuditoriaFechaCreacion)
                    .HasColumnName("AUDITORIA_FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Datos)
                    .IsRequired()
                    .HasColumnName("DATOS")
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(64);

                entity.Property(e => e.Prestador)
                    .HasColumnName("PRESTADOR")
                    .HasMaxLength(64);

                entity.Property(e => e.PrestadorId).HasColumnName("PRESTADOR_ID");

                entity.Property(e => e.RegistroAfectado)
                    .HasColumnName("REGISTRO_AFECTADO")
                    .HasMaxLength(64);

                entity.Property(e => e.RegistroAfectadoId)
                    .HasColumnName("REGISTRO_AFECTADO_ID")
                    .HasMaxLength(64);

                entity.Property(e => e.RolId).HasColumnName("ROL_ID");

                entity.Property(e => e.TablaAfectado)
                    .HasColumnName("TABLA_AFECTADO")
                    .HasMaxLength(64);

                entity.Property(e => e.TablaRegistroAfectado)
                    .HasColumnName("TABLA_REGISTRO_AFECTADO")
                    .HasMaxLength(64);

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(64);

                entity.Property(e => e.UsuarioId).HasColumnName("USUARIO_ID");
            });

            modelBuilder.Entity<MatchingVistos>(entity =>
            {
                entity.HasKey(e => e.IdVisto)
                    .HasName("PK__matching__267A67109E65E776");

                entity.ToTable("matching_vistos");

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId, e.PersoId })
                    .HasName("IX_matching_vistos_Sede_proceso_perso");

                entity.Property(e => e.IdVisto).HasColumnName("id_visto");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.SedeId).HasColumnName("sede_id");
            });

            modelBuilder.Entity<MctMisCta>(entity =>
            {
                entity.HasKey(e => new { e.CtaId, e.PersoId });

                entity.ToTable("MCT_MIS_CTA");

                entity.Property(e => e.CtaId).HasColumnName("CTA_ID");

                entity.Property(e => e.PersoId).HasColumnName("PERSO_ID");

                entity.Property(e => e.MctAutoregistro).HasColumnName("MCT_AUTOREGISTRO");

                entity.Property(e => e.MctFecha)
                    .HasColumnName("MCT_FECHA")
                    .HasColumnType("date");

                entity.Property(e => e.VlcEstadoCta).HasColumnName("VLC_ESTADO_CTA");

                entity.HasOne(d => d.Cta)
                    .WithMany(p => p.MctMisCta)
                    .HasForeignKey(d => d.CtaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MCT_MIS_CTA_CTA_CURSOS_TALLERES");

                entity.HasOne(d => d.VlcEstadoCtaNavigation)
                    .WithMany(p => p.MctMisCta)
                    .HasForeignKey(d => d.VlcEstadoCta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MCT_MIS_CTA_VLC_VALOR_CATALOGO1");
            });

            modelBuilder.Entity<MedioImpreso>(entity =>
            {
                entity.HasKey(e => e.NitImpreso);

                entity.ToTable("medio_impreso");

                entity.Property(e => e.NitImpreso)
                    .HasColumnName("nit_impreso")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Abreviatura)
                    .HasColumnName("abreviatura")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId)
                    .IsRequired()
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContactoNombre)
                    .HasColumnName("contacto_nombre")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .IsRequired()
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Logo)
                    .IsRequired()
                    .HasColumnName("logo")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MailNombre)
                    .HasColumnName("mail_nombre")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId)
                    .IsRequired()
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ciudades)
                    .WithMany(p => p.MedioImpreso)
                    .HasForeignKey(d => new { d.PaisId, d.DepartamentoId, d.CiudadId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_medio_impreso_Ciudades");
            });

            modelBuilder.Entity<Modulos>(entity =>
            {
                entity.HasKey(e => e.ModuloId);

                entity.ToTable("Modulos", "auditoria");

                entity.Property(e => e.ModuloId).HasColumnName("Modulo_Id");

                entity.Property(e => e.NombreModulo)
                    .IsRequired()
                    .HasColumnName("nombreModulo")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MonePaisRela>(entity =>
            {
                entity.HasKey(e => new { e.MoneId, e.PaisId });

                entity.ToTable("Mone_pais_rela");

                entity.Property(e => e.MoneId)
                    .HasColumnName("mone_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Mone)
                    .WithMany(p => p.MonePaisRela)
                    .HasForeignKey(d => d.MoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mone_pais_rela_Monedas");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.MonePaisRela)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mone_pais_rela_Paises_Home");
            });

            modelBuilder.Entity<Monedas>(entity =>
            {
                entity.HasKey(e => e.MoneId);

                entity.Property(e => e.MoneId)
                    .HasColumnName("mone_id")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<MotivoCambioPrestador>(entity =>
            {
                entity.ToTable("motivo_cambio_prestador");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(100);

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MotivoCambioPrestadorSede>(entity =>
            {
                entity.HasKey(e => e.IdMotivo);

                entity.ToTable("motivo_cambio_prestador_sede");

                entity.Property(e => e.IdMotivo).HasColumnName("id_motivo");

                entity.Property(e => e.DescripcionMotivo)
                    .HasColumnName("descripcion_motivo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMotivo)
                    .HasColumnName("tipo_motivo")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MotivoCierreCta>(entity =>
            {
                entity.HasKey(e => e.MotivoCierreId)
                    .HasName("PK_Motiv_Cier_Cta");

                entity.ToTable("Motivo_Cierre_Cta");

                entity.Property(e => e.MotivoCierreId)
                    .HasColumnName("motivo_cierre_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MotivoEliminacionSede>(entity =>
            {
                entity.ToTable("Motivo_Eliminacion_Sede");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasMaxLength(300);
            });

            modelBuilder.Entity<MotivoExcepcional>(entity =>
            {
                entity.ToTable("Motivo_Excepcional");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Motivo)
                    .IsRequired()
                    .HasMaxLength(4000);
            });

            modelBuilder.Entity<MotivoInactivarCuenta>(entity =>
            {
                entity.ToTable("motivo_inactivar_cuenta");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(200);

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MotivoRechazoSede>(entity =>
            {
                entity.HasKey(e => e.IdMotivoRechazo);

                entity.ToTable("motivo_rechazo_sede");

                entity.Property(e => e.IdMotivoRechazo).HasColumnName("Id_motivo_rechazo");

                entity.Property(e => e.DescripcionMotivo)
                    .IsRequired()
                    .HasColumnName("descripcion_motivo")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MotivoRechazoVacante>(entity =>
            {
                entity.HasKey(e => e.IdMotivoRechazo);

                entity.ToTable("motivo_rechazo_vacante");

                entity.Property(e => e.IdMotivoRechazo).HasColumnName("Id_motivo_rechazo");

                entity.Property(e => e.DescripcionMotivo)
                    .IsRequired()
                    .HasColumnName("descripcion_motivo")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MotivosCertificadoHidro>(entity =>
            {
                entity.ToTable("Motivos_Certificado_Hidro");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Visible)
                    .HasColumnName("visible")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<NfoNotificacionesOtros>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.NoaId });

                entity.ToTable("NFO_NOTIFICACIONES_OTROS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.NoaId).HasColumnName("NOA_ID");

                entity.Property(e => e.NfoEstado).HasColumnName("NFO_ESTADO");

                entity.Property(e => e.PersoId).HasColumnName("PERSO_ID");
            });

            modelBuilder.Entity<NfpNotificacionesProcesos>(entity =>
            {
                entity.HasKey(e => new { e.ProId, e.NoaId });

                entity.ToTable("NFP_NOTIFICACIONES_PROCESOS");

                entity.Property(e => e.ProId).HasColumnName("PRO_ID");

                entity.Property(e => e.NoaId).HasColumnName("NOA_ID");

                entity.Property(e => e.InterOrgaId).HasColumnName("INTER_ORGA_ID");

                entity.Property(e => e.NtpEstado).HasColumnName("NTP_ESTADO");

                entity.Property(e => e.PersoId).HasColumnName("PERSO_ID");

                entity.HasOne(d => d.Noa)
                    .WithMany(p => p.NfpNotificacionesProcesos)
                    .HasForeignKey(d => d.NoaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFP_NOTIFICACIONES_PROCESOS_NOA_NOTIFICACIONES_ALARMAS");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.NfpNotificacionesProcesos)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFP_NOTIFICACIONES_PROCESOS_Personas_agencia");

                entity.HasOne(d => d.Procesos)
                    .WithMany(p => p.NfpNotificacionesProcesos)
                    .HasForeignKey(d => new { d.InterOrgaId, d.ProId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFP_NOTIFICACIONES_PROCESOS_Procesos");
            });

            modelBuilder.Entity<NfrNotificacionesRegistro>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.NoaId });

                entity.ToTable("NFR_NOTIFICACIONES_REGISTRO");

                entity.Property(e => e.InterOrgaId).HasColumnName("INTER_ORGA_ID");

                entity.Property(e => e.NoaId).HasColumnName("NOA_ID");

                entity.Property(e => e.NfrEstado).HasColumnName("NFR_ESTADO");

                entity.Property(e => e.PersoId).HasColumnName("PERSO_ID");

                entity.HasOne(d => d.InterOrga)
                    .WithMany(p => p.NfrNotificacionesRegistro)
                    .HasForeignKey(d => d.InterOrgaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFR_NOTIFICACIONES_REGISTRO_Inter_orga");

                entity.HasOne(d => d.Noa)
                    .WithMany(p => p.NfrNotificacionesRegistro)
                    .HasForeignKey(d => d.NoaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFR_NOTIFICACIONES_REGISTRO_NOA_NOTIFICACIONES_ALARMAS");

                entity.HasOne(d => d.NoaNavigation)
                    .WithMany(p => p.NfrNotificacionesRegistro)
                    .HasForeignKey(d => d.NoaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFR_NOTIFICACIONES_REGISTRO_Personas_agencia");
            });

            modelBuilder.Entity<NfvNotificacionesVacantes>(entity =>
            {
                entity.HasKey(e => new { e.VacId, e.NoaId });

                entity.ToTable("NFV_NOTIFICACIONES_VACANTES");

                entity.Property(e => e.VacId).HasColumnName("VAC_ID");

                entity.Property(e => e.NoaId).HasColumnName("NOA_ID");

                entity.Property(e => e.InterOrgaId).HasColumnName("INTER_ORGA_ID");

                entity.Property(e => e.NfvEstado).HasColumnName("NFV_ESTADO");

                entity.Property(e => e.PersoId).HasColumnName("PERSO_ID");

                entity.HasOne(d => d.Noa)
                    .WithMany(p => p.NfvNotificacionesVacantes)
                    .HasForeignKey(d => d.NoaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFV_NOTIFICACIONES_VACANTES_NOA_NOTIFICACIONES_ALARMAS");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.NfvNotificacionesVacantes)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFV_NOTIFICACIONES_VACANTES_Personas_agencia");

                entity.HasOne(d => d.Procesos)
                    .WithMany(p => p.NfvNotificacionesVacantes)
                    .HasForeignKey(d => new { d.InterOrgaId, d.VacId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NFV_NOTIFICACIONES_VACANTES_Procesos");
            });

            modelBuilder.Entity<NivelUniversidad>(entity =>
            {
                entity.HasKey(e => e.Idrelacion);

                entity.ToTable("nivel_universidad");

                entity.Property(e => e.Idrelacion).HasColumnName("idrelacion");

                entity.Property(e => e.EstuNivelId)
                    .HasColumnName("estu_nivel_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.InstiId)
                    .HasColumnName("insti_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Niveles>(entity =>
            {
                entity.HasKey(e => e.NivelValor);

                entity.Property(e => e.NivelValor)
                    .HasColumnName("nivel_valor")
                    .ValueGeneratedNever();

                entity.Property(e => e.NivelDescripcion)
                    .HasColumnName("nivel_descripcion")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NoaNotificacionesAlarmas>(entity =>
            {
                entity.HasKey(e => e.NoaId);

                entity.ToTable("NOA_NOTIFICACIONES_ALARMAS");

                entity.Property(e => e.NoaId).HasColumnName("NOA_ID");

                entity.Property(e => e.NoaEntidadPadre).HasColumnName("NOA_ENTIDAD_PADRE");

                entity.Property(e => e.NoaEsNotificacion).HasColumnName("NOA_ES_NOTIFICACION");

                entity.Property(e => e.NoaEstado).HasColumnName("NOA_ESTADO");

                entity.Property(e => e.NoaNombre)
                    .IsRequired()
                    .HasColumnName("NOA_NOMBRE")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NooNotificacionesOcultar>(entity =>
            {
                entity.HasKey(e => e.NotId)
                    .HasName("PK_NOTIFICACIONES_OCULTAR");

                entity.ToTable("NOO_NOTIFICACIONES_OCULTAR");

                entity.Property(e => e.NotId).HasColumnName("NOT_ID");

                entity.Property(e => e.AprId).HasColumnName("APR_ID");

                entity.Property(e => e.AuiId).HasColumnName("AUI_ID");

                entity.Property(e => e.AupId).HasColumnName("AUP_ID");

                entity.Property(e => e.IdAgencia).HasColumnName("ID_AGENCIA");

                entity.Property(e => e.IdSede).HasColumnName("Id_Sede");

                entity.Property(e => e.InterOrgId).HasColumnName("INTER_ORG_ID");

                entity.Property(e => e.NtiId).HasColumnName("NTI_ID");

                entity.Property(e => e.PersoId).HasColumnName("PERSO_ID");

                entity.Property(e => e.ProcesoId).HasColumnName("PROCESO_ID");

                entity.Property(e => e.RolId).HasColumnName("ROL_ID");
            });

            modelBuilder.Entity<NtiNotificacionTipos>(entity =>
            {
                entity.HasKey(e => e.NtiId);

                entity.ToTable("NTI_NOTIFICACION_TIPOS");

                entity.Property(e => e.NtiId)
                    .HasColumnName("NTI_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.NtiDescripcion)
                    .IsRequired()
                    .HasColumnName("NTI_DESCRIPCION")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NucleoBasicoConocimiento>(entity =>
            {
                entity.HasKey(e => e.IdNucleoConoc);

                entity.Property(e => e.IdNucleoConoc)
                    .HasMaxLength(5)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAreaDesempenoNavigation)
                    .WithMany(p => p.NucleoBasicoConocimiento)
                    .HasForeignKey(d => d.IdAreaDesempeno)
                    .HasConstraintName("FK_NucleoBasicoConocimiento_AreaDesempenio");
            });

            modelBuilder.Entity<ObjObjetos>(entity =>
            {
                entity.HasKey(e => e.ObjId);

                entity.ToTable("OBJ_OBJETOS");

                entity.Property(e => e.ObjId).HasColumnName("OBJ_ID");

                entity.Property(e => e.ObjData)
                    .HasColumnName("OBJ_DATA")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ObjImagePath)
                    .HasColumnName("OBJ_IMAGE_PATH")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ObjLabel)
                    .IsRequired()
                    .HasColumnName("OBJ_LABEL")
                    .IsUnicode(false);

                entity.Property(e => e.ObjNombre)
                    .IsRequired()
                    .HasColumnName("OBJ_NOMBRE")
                    .IsUnicode(false);

                entity.Property(e => e.ObjOrden).HasColumnName("OBJ_ORDEN");

                entity.Property(e => e.ObjOwner).HasColumnName("OBJ_OWNER");

                entity.Property(e => e.ObjTipoId)
                    .IsRequired()
                    .HasColumnName("OBJ_TIPO_ID")
                    .HasMaxLength(6)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OfiTipo>(entity =>
            {
                entity.ToTable("OFI_TIPO");

                entity.Property(e => e.OfiTipoId).HasColumnName("OFI_TIPO_ID");

                entity.Property(e => e.OfiTipoDesc)
                    .IsRequired()
                    .HasColumnName("OFI_TIPO_DESC")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OriDescartes>(entity =>
            {
                entity.HasKey(e => e.DescarteId);

                entity.ToTable("Ori_descartes");

                entity.HasIndex(e => new { e.PersoId, e.CtaId });

                entity.Property(e => e.DescarteId).HasColumnName("descarte_id");

                entity.Property(e => e.CnvId).HasColumnName("cnv_id");

                entity.Property(e => e.CtaId).HasColumnName("cta_id");

                entity.Property(e => e.FechaDescarte)
                    .HasColumnName("fecha_descarte")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.HasKey(e => e.PaisId);

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nacionalidad)
                    .HasColumnName("nacionalidad")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaisesHome>(entity =>
            {
                entity.HasKey(e => e.PaisId);

                entity.ToTable("Paises_Home");

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(32);

                entity.Property(e => e.Idioma)
                    .HasColumnName("idioma")
                    .HasMaxLength(7);
            });

            modelBuilder.Entity<PcdProcesoCausalDescarte>(entity =>
            {
                entity.HasKey(e => e.PosId)
                    .HasName("PK__PCD_PROC__F90EC164B1718382");

                entity.ToTable("PCD_PROCESO_CAUSAL_DESCARTE");

                entity.Property(e => e.PosId)
                    .HasColumnName("POS_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdcId).HasColumnName("CDC_ID");

                entity.Property(e => e.PdcObservacion)
                    .HasColumnName("PDC_OBSERVACION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PdcSalario)
                    .HasColumnName("PDC_SALARIO")
                    .HasColumnType("numeric(18, 2)");

                entity.HasOne(d => d.Cdc)
                    .WithMany(p => p.PcdProcesoCausalDescarte)
                    .HasForeignKey(d => d.CdcId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCD_PROCESO_CAUSAL_DESCARTE_CDC_CAUSALES_DESCARTE");

                entity.HasOne(d => d.Pos)
                    .WithOne(p => p.PcdProcesoCausalDescarte)
                    .HasForeignKey<PcdProcesoCausalDescarte>(d => d.PosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PCD_PROCESO_CAUSAL_DESCARTE_ACP_ADMIN_CAND_POST");
            });

            modelBuilder.Entity<PcdProcesoCausalDescarteEliminados>(entity =>
            {
                entity.HasKey(e => e.PosId)
                    .HasName("PK__PCD_PROC__F90EC164FAA7A027");

                entity.ToTable("PCD_PROCESO_CAUSAL_DESCARTE_eliminados");

                entity.Property(e => e.PosId)
                    .HasColumnName("POS_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CdcId).HasColumnName("CDC_ID");

                entity.Property(e => e.PdcObservacion)
                    .HasColumnName("PDC_OBSERVACION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PdcSalario)
                    .HasColumnName("PDC_SALARIO")
                    .HasColumnType("numeric(18, 2)");
            });

            modelBuilder.Entity<PerPeriodicidad>(entity =>
            {
                entity.HasKey(e => e.PerId)
                    .HasName("PK__PER_PERI__8FE383B3D0223FE3");

                entity.ToTable("PER_PERIODICIDAD");

                entity.Property(e => e.PerId).HasColumnName("PER_ID");

                entity.Property(e => e.PerNombre)
                    .HasColumnName("PER_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PermisosPerfil>(entity =>
            {
                entity.HasKey(e => e.IdPermiso);

                entity.ToTable("Permisos_perfil");

                entity.Property(e => e.IdPermiso).HasColumnName("id_permiso");

                entity.Property(e => e.CodigoModulo)
                    .HasColumnName("codigo_modulo")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IdCodigoModulo).HasColumnName("id_codigo_modulo");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.TipoPerfil).HasColumnName("tipo_perfil");
            });

            modelBuilder.Entity<PersAreaprof>(entity =>
            {
                entity.HasKey(e => new { e.IdPersona, e.IdAreaprof, e.IndStatus, e.DtTmst });

                entity.ToTable("PERS_AREAPROF", "tmp");

                entity.Property(e => e.IdPersona).HasColumnName("ID_PERSONA");

                entity.Property(e => e.IdAreaprof).HasColumnName("ID_AREAPROF");

                entity.Property(e => e.IndStatus)
                    .HasColumnName("IND_STATUS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DtTmst)
                    .HasColumnName("DT_TMST")
                    .HasColumnType("datetime");

                entity.Property(e => e.GradoAreaPers).HasColumnName("GRADO_AREA_PERS");

                entity.Property(e => e.IdFase).HasColumnName("ID_FASE");

                entity.Property(e => e.Incrocio)
                    .IsRequired()
                    .HasColumnName("INCROCIO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Mensaje)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersoTeletrabajo>(entity =>
            {
                entity.HasKey(e => e.PersoId);

                entity.ToTable("perso_teletrabajo", "tmp");

                entity.Property(e => e.PersoId)
                    .HasColumnName("perso_id")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<Persona>(entity =>
            {
                entity.HasKey(e => e.IdPersona)
                    .HasName("PK__PERSONA_ERROR")
                    .ForSqlServerIsClustered(false);

                entity.ToTable("PERSONA", "tmp");

                entity.Property(e => e.IdPersona)
                    .HasColumnName("ID_PERSONA")
                    .ValueGeneratedNever();

                entity.Property(e => e.CapDom)
                    .HasColumnName("CAP_DOM")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CapRes)
                    .HasColumnName("CAP_RES")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.CodFisc)
                    .HasColumnName("COD_FISC")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Cognome)
                    .HasColumnName("COGNOME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ComDom)
                    .HasColumnName("COM_DOM")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ComNasc)
                    .HasColumnName("COM_NASC")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ComRes)
                    .HasColumnName("COM_RES")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepNasc).HasColumnName("DEP_NASC");

                entity.Property(e => e.DepRes).HasColumnName("DEP_RES");

                entity.Property(e => e.DtNasc)
                    .HasColumnName("DT_NASC")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtTmst)
                    .HasColumnName("DT_TMST")
                    .HasColumnType("datetime");

                entity.Property(e => e.DtUltRil)
                    .HasColumnName("DT_ULT_RIL")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .HasColumnName("E_MAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FrazioneDom)
                    .HasColumnName("FRAZIONE_DOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FrazioneRes)
                    .HasColumnName("FRAZIONE_RES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdSede).HasColumnName("ID_SEDE");

                entity.Property(e => e.IndDom)
                    .HasColumnName("IND_DOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IndRes)
                    .HasColumnName("IND_RES")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JefeHogar).HasColumnName("JEFE_HOGAR");

                entity.Property(e => e.LocNasc).HasColumnName("LOC_NASC");

                entity.Property(e => e.LocRes).HasColumnName("LOC_RES");

                entity.Property(e => e.Mensaje)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.NomDom)
                    .HasColumnName("NOM_DOM")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NomRes)
                    .HasColumnName("NOM_RES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .HasColumnName("NOME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumTel)
                    .HasColumnName("NUM_TEL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelDom)
                    .HasColumnName("NUM_TEL_DOM")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NumTelDomObs)
                    .HasColumnName("NUM_TEL_DOM_OBS")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PosMil)
                    .HasColumnName("POS_MIL")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PrvDom)
                    .HasColumnName("PRV_DOM")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PrvNasc)
                    .HasColumnName("PRV_NASC")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.PrvRes)
                    .HasColumnName("PRV_RES")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.SecondoCognome)
                    .HasColumnName("SECONDO_COGNOME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondoNome)
                    .HasColumnName("SECONDO_NOME")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sesso)
                    .HasColumnName("SESSO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.StatCit)
                    .HasColumnName("STAT_CIT")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StatCit2)
                    .HasColumnName("STAT_CIT2")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StatCiv)
                    .HasColumnName("STAT_CIV")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StatNasc)
                    .HasColumnName("STAT_NASC")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.StatRes)
                    .IsRequired()
                    .HasColumnName("STAT_RES")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.StratoPubblico).HasColumnName("STRATO_PUBBLICO");

                entity.Property(e => e.TipoLibretaMilitar).HasColumnName("TIPO_LIBRETA_MILITAR");
            });

            modelBuilder.Entity<PersonaBeneficiarioSubsidio>(entity =>
            {
                entity.HasKey(e => e.IdBeneficiarioSubsidio)
                    .HasName("PK__PERSONA___D21747866698BE3C");

                entity.ToTable("PERSONA_BENEFICIARIO_SUBSIDIO");

                entity.Property(e => e.IdBeneficiarioSubsidio).HasColumnName("ID_BENEFICIARIO_SUBSIDIO");

                entity.Property(e => e.AgenciaId).HasColumnName("AGENCIA_ID");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaAsignacionBeneficio)
                    .HasColumnName("FECHA_ASIGNACION_BENEFICIO")
                    .HasColumnType("date");

                entity.Property(e => e.PersoId).HasColumnName("PERSO_ID");

                entity.Property(e => e.PersoIdAsesor).HasColumnName("PERSO_ID_ASESOR");

                entity.HasOne(d => d.Agencia)
                    .WithMany(p => p.PersonaBeneficiarioSubsidio)
                    .HasForeignKey(d => d.AgenciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSONA_B__AGENC__56C522C0");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.PersonaBeneficiarioSubsidio)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSONA_B__PERSO__55D0FE87");

                entity.HasOne(d => d.PersoIdAsesorNavigation)
                    .WithMany(p => p.PersonaBeneficiarioSubsidio)
                    .HasForeignKey(d => d.PersoIdAsesor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSONA_B__PERSO__57B946F9");
            });

            modelBuilder.Entity<PersonaBeneficiarioSubsidioHist>(entity =>
            {
                entity.HasKey(e => e.IdBeneficiarioSubsidioHist)
                    .HasName("PK__PERSONA___5DDE3019D63A2A9C");

                entity.ToTable("PERSONA_BENEFICIARIO_SUBSIDIO_HIST");

                entity.Property(e => e.IdBeneficiarioSubsidioHist).HasColumnName("ID_BENEFICIARIO_SUBSIDIO_HIST");

                entity.Property(e => e.AgenciaId).HasColumnName("AGENCIA_ID");

                entity.Property(e => e.Fecha)
                    .HasColumnName("FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaAsignacionBeneficio)
                    .HasColumnName("FECHA_ASIGNACION_BENEFICIO")
                    .HasColumnType("date");

                entity.Property(e => e.Marcado).HasColumnName("MARCADO");

                entity.Property(e => e.PersoId).HasColumnName("PERSO_ID");

                entity.Property(e => e.PersoIdAsesor).HasColumnName("PERSO_ID_ASESOR");

                entity.HasOne(d => d.Agencia)
                    .WithMany(p => p.PersonaBeneficiarioSubsidioHist)
                    .HasForeignKey(d => d.AgenciaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSONA_B__AGENC__067DCAF8");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.PersonaBeneficiarioSubsidioHist)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSONA_B__PERSO__2CA373E0");

                entity.HasOne(d => d.PersoIdAsesorNavigation)
                    .WithMany(p => p.PersonaBeneficiarioSubsidioHist)
                    .HasForeignKey(d => d.PersoIdAsesor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PERSONA_B__PERSO__2D979819");
            });

            modelBuilder.Entity<PersonaCambioPrestador1>(entity =>
            {
                entity.ToTable("persona_cambio_prestador");

                entity.HasIndex(e => e.PersonaId);

                entity.HasIndex(e => new { e.AgenciaOldId, e.Fecha });

                entity.HasIndex(e => new { e.PersonaId, e.EntidadOldId, e.AgenciaNewId, e.Fecha })
                    .HasName("IX_persona_cambio_prestador_agencia_new_id_fecha");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgenciaNewId).HasColumnName("agencia_new_id");

                entity.Property(e => e.AgenciaOldId).HasColumnName("agencia_old_id");

                entity.Property(e => e.EntidadNewId).HasColumnName("entidad_new_id");

                entity.Property(e => e.EntidadOldId).HasColumnName("entidad_old_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.MotivoId).HasColumnName("motivo_id");

                entity.Property(e => e.OtroMotivo)
                    .HasColumnName("otro_motivo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PersonaId).HasColumnName("persona_id");

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonaInactivarCuenta>(entity =>
            {
                entity.ToTable("persona_inactivar_cuenta");

                entity.HasIndex(e => new { e.PersoId, e.Fecha })
                    .HasName("IX_PersoInactivarCtaFechaPersoID");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.MotivoId).HasColumnName("motivo_id");

                entity.Property(e => e.OtroMotivo)
                    .HasColumnName("otro_motivo")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PersoId).HasColumnName("perso_id");
            });

            modelBuilder.Entity<Personas>(entity =>
            {
                entity.HasKey(e => e.PersoId);

                entity.HasIndex(e => e.DocuNro);

                entity.HasIndex(e => new { e.DocuNro, e.PersoId });

                entity.HasIndex(e => new { e.DocuTipoId, e.DocuNro });

                entity.HasIndex(e => new { e.IdAgencia, e.HvCompleta })
                    .HasName("IX_PersonasAgenciaHVCompleta");

                entity.HasIndex(e => new { e.IdAgencia, e.PerBolsa2Activo });

                entity.HasIndex(e => new { e.PersoId, e.DepartamentoId })
                    .HasName("IX_Personas_departamento_id");

                entity.HasIndex(e => new { e.DocuTipoId, e.DocuNro, e.PersoId });

                entity.HasIndex(e => new { e.PersoId, e.NaciFecha, e.CiudadId, e.Sexo })
                    .HasName("IXX_Personas_sexo");

                entity.HasIndex(e => new { e.PersoId, e.Ape, e.Nombre, e.DocuNro, e.HvCompleta, e.EsVictimaConfliArmado, e.IdAgencia })
                    .HasName("IX_Personas_id_agencia");

                entity.HasIndex(e => new { e.PersoId, e.DepartamentoId, e.PobladoId, e.Sinlaboexpe, e.Sinestudios, e.Sincursos, e.HvCompleta })
                    .HasName("IX_personas_hv_completa_depto");

                entity.HasIndex(e => new { e.PersoId, e.DepartamentoId, e.Sinlaboexpe, e.Sinestudios, e.Sincursos, e.CiudadId, e.HvCompleta })
                    .HasName("IX_Personas_ciudad_HV_Depto_SinlaboE_SinE");

                entity.HasIndex(e => new { e.DocuTipoId, e.DocuNro, e.EntId, e.PrimerNombre, e.SegundoNombre, e.PrimerApellido, e.SegundoApellido, e.IdAgencia, e.PersoId })
                    .HasName("IX_Personas_id_agencia_perso_id");

                entity.HasIndex(e => new { e.PersoId, e.DocuTipoId, e.DocuNro, e.IdAgencia, e.PrimerNombre, e.SegundoNombre, e.PrimerApellido, e.SegundoApellido, e.EntId })
                    .HasName("IXX_Personas_ENT_ID");

                entity.HasIndex(e => new { e.PersoId, e.Ape, e.Nombre, e.DocuTipoId, e.DocuNro, e.Sexo, e.CeluTele, e.ContacTele, e.DepartamentoId, e.CiudadId })
                    .HasName("IXX_Personas_departamento_id_ciudad_id");

                entity.Property(e => e.PersoId)
                    .HasColumnName("perso_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aglomeraciones).HasColumnType("xml");

                entity.Property(e => e.AnioCesante).HasColumnName("anio_cesante");

                entity.Property(e => e.Ape)
                    .HasColumnName("ape")
                    .HasMaxLength(250);

                entity.Property(e => e.Autoregistro).HasColumnName("autoregistro");

                entity.Property(e => e.Barrio)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CeluTele)
                    .HasColumnName("celu_tele")
                    .HasMaxLength(32);

                entity.Property(e => e.Cesante).HasColumnName("cesante");

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContacTele)
                    .HasColumnName("contac_tele")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DepNaci)
                    .HasColumnName("dep_naci")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(320);

                entity.Property(e => e.DocuNro)
                    .IsRequired()
                    .HasColumnName("docu_nro")
                    .HasMaxLength(32);

                entity.Property(e => e.DocuNroSecundario)
                    .HasColumnName("docu_nro_secundario")
                    .HasMaxLength(20);

                entity.Property(e => e.DocuTipoId)
                    .IsRequired()
                    .HasColumnName("docu_tipo_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DocuTipoIdSecundario)
                    .HasColumnName("docu_tipo_id_secundario")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EmailOpc)
                    .HasColumnName("email_opc")
                    .HasMaxLength(320);

                entity.Property(e => e.EntId).HasColumnName("ENT_ID");

                entity.Property(e => e.EsVictimaConfliArmado)
                    .HasColumnName("es_victima_Confli_Armado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EstadoCivil)
                    .HasColumnName("estado_civil")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Experiencia).HasColumnName("experiencia");

                entity.Property(e => e.FecConsultaVictima)
                    .HasColumnName("fec_consulta_victima")
                    .HasColumnType("date");

                entity.Property(e => e.FecDeclaraVictima)
                    .HasColumnName("fec_declara_victima")
                    .HasColumnType("date");

                entity.Property(e => e.FechaCambioResidencia)
                    .HasColumnName("fecha_cambio_residencia")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCondiciones).HasColumnType("datetime");

                entity.Property(e => e.FechaConsultaSisben)
                    .HasColumnName("fecha_consulta_sisben")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaFinSub)
                    .HasColumnName("fecha_fin_sub")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GruposOcupacionales).HasColumnType("xml");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdEstadoCivil).HasColumnName("id_estado_civil");

                entity.Property(e => e.IpCondiciones)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JefeHogar).HasColumnName("jefe_hogar");

                entity.Property(e => e.LocalidadId)
                    .HasColumnName("localidad_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaxEstuOrden).HasColumnName("Max_estu_orden");

                entity.Property(e => e.MesCesante).HasColumnName("mes_cesante");

                entity.Property(e => e.Migrante).HasColumnName("migrante");

                entity.Property(e => e.MunNaci)
                    .HasColumnName("mun_naci")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NaciFecha)
                    .HasColumnName("naci_fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nacionalidad)
                    .HasColumnName("nacionalidad")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.NumLibreta)
                    .HasColumnName("num_libreta")
                    .HasMaxLength(50);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(1000);

                entity.Property(e => e.PaisId)
                    .IsRequired()
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PaisNaci)
                    .HasColumnName("pais_naci")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PartiTele)
                    .HasColumnName("parti_tele")
                    .HasMaxLength(32);

                entity.Property(e => e.Pase).HasColumnName("pase");

                entity.Property(e => e.PerBolsa2Activo).HasColumnName("per_bolsa2_activo");

                entity.Property(e => e.Persoacargo).HasColumnName("persoacargo");

                entity.Property(e => e.PerteneceA)
                    .HasColumnName("pertenece_a")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PobladoId)
                    .HasColumnName("poblado_id")
                    .HasMaxLength(8);

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("primer_apellido")
                    .HasMaxLength(50);

                entity.Property(e => e.PrimerNombre)
                    .HasColumnName("primer_nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.PuntajeSisben)
                    .HasColumnName("puntaje_sisben")
                    .HasColumnType("decimal(6, 2)");

                entity.Property(e => e.RecibeSub).HasColumnName("recibe_sub");

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("segundo_apellido")
                    .HasMaxLength(50);

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("segundo_nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Servicios)
                    .HasColumnName("servicios")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasColumnName("sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sincursos).HasColumnName("sincursos");

                entity.Property(e => e.Sinestudios).HasColumnName("sinestudios");

                entity.Property(e => e.Sinlaboexpe).HasColumnName("sinlaboexpe");

                entity.Property(e => e.Tecnologia)
                    .HasColumnName("tecnologia")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Teletrabajo).HasColumnName("teletrabajo");

                entity.Property(e => e.TipoContratoId)
                    .HasColumnName("tipo_contrato_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLibreta)
                    .HasColumnName("tipo_libreta")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UltPaisTrab)
                    .HasColumnName("ult_pais_trab")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UltimoCargo)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.VeredaId).HasColumnName("vereda_id");

                entity.HasOne(d => d.DocuTipo)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.DocuTipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personas_tipo_documento");

                entity.HasOne(d => d.IdEstadoCivilNavigation)
                    .WithMany(p => p.Personas)
                    .HasForeignKey(d => d.IdEstadoCivil)
                    .HasConstraintName("FK_Personas_EstadoCivil");
            });

            modelBuilder.Entity<PersonasAdmin>(entity =>
            {
                entity.HasKey(e => e.PersoId);

                entity.ToTable("Personas_admin");

                entity.Property(e => e.PersoId)
                    .HasColumnName("perso_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ape)
                    .IsRequired()
                    .HasColumnName("ape")
                    .HasMaxLength(250);

                entity.Property(e => e.CargoId)
                    .HasColumnName("cargo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId)
                    .IsRequired()
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .IsRequired()
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DocuTipoId)
                    .IsRequired()
                    .HasColumnName("docu_tipo_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EmpreAreaId)
                    .HasColumnName("empre_area_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.PaisId)
                    .IsRequired()
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasColumnName("sexo")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.PersonasAdmin)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personas_admin_Personas_admin");
            });

            modelBuilder.Entity<PersonasAgencia>(entity =>
            {
                entity.HasKey(e => e.PersoId);

                entity.ToTable("Personas_agencia");

                entity.HasIndex(e => new { e.DocuTipoId, e.DocuNro })
                    .HasName("IXX_Personas_agencia_docu_tipo_id_docu_nro");

                entity.Property(e => e.PersoId)
                    .HasColumnName("perso_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ape)
                    .IsRequired()
                    .HasColumnName("ape")
                    .HasMaxLength(250);

                entity.Property(e => e.CargoId)
                    .HasColumnName("cargo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId)
                    .IsRequired()
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .IsRequired()
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DocuNro)
                    .IsRequired()
                    .HasColumnName("docu_nro")
                    .HasMaxLength(32);

                entity.Property(e => e.DocuTipoId)
                    .IsRequired()
                    .HasColumnName("docu_tipo_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EmpreAreaId)
                    .HasColumnName("empre_area_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.PaisId)
                    .IsRequired()
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasColumnName("sexo")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoCelular)
                    .HasColumnName("telefono_celular")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PersonasArchivo>(entity =>
            {
                entity.ToTable("Personas_archivo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Aglomeraciones).HasColumnType("xml");

                entity.Property(e => e.AnioCesante).HasColumnName("anio_cesante");

                entity.Property(e => e.Ape)
                    .HasColumnName("ape")
                    .HasMaxLength(250);

                entity.Property(e => e.Autoregistro).HasColumnName("autoregistro");

                entity.Property(e => e.Barrio)
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.CeluTele)
                    .HasColumnName("celu_tele")
                    .HasMaxLength(32);

                entity.Property(e => e.Cesante).HasColumnName("cesante");

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ContacTele)
                    .HasColumnName("contac_tele")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.DepNaci)
                    .HasColumnName("dep_naci")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(320);

                entity.Property(e => e.DocuNro)
                    .IsRequired()
                    .HasColumnName("docu_nro")
                    .HasMaxLength(32);

                entity.Property(e => e.DocuTipoId)
                    .IsRequired()
                    .HasColumnName("docu_tipo_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EmailOpc)
                    .HasColumnName("email_opc")
                    .HasMaxLength(320);

                entity.Property(e => e.EmailPrestador)
                    .HasColumnName("email_prestador")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EntId).HasColumnName("ENT_ID");

                entity.Property(e => e.EsVictimaConfliArmado).HasColumnName("es_victima_Confli_Armado");

                entity.Property(e => e.EstadoCivil)
                    .HasColumnName("estado_civil")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Experiencia).HasColumnName("experiencia");

                entity.Property(e => e.FecDeclaraVictima)
                    .HasColumnName("fec_declara_victima")
                    .HasColumnType("date");

                entity.Property(e => e.FechaCondiciones).HasColumnType("datetime");

                entity.Property(e => e.FechaFinSub)
                    .HasColumnName("fecha_fin_sub")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.GruposOcupacionales).HasColumnType("xml");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdEstadoCivil).HasColumnName("id_estado_civil");

                entity.Property(e => e.IpCondiciones)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JefeHogar).HasColumnName("jefe_hogar");

                entity.Property(e => e.LocalidadId)
                    .HasColumnName("localidad_id")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaxEstuOrden).HasColumnName("Max_estu_orden");

                entity.Property(e => e.MesCesante).HasColumnName("mes_cesante");

                entity.Property(e => e.Migrante).HasColumnName("migrante");

                entity.Property(e => e.MunNaci)
                    .HasColumnName("mun_naci")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NaciFecha)
                    .HasColumnName("naci_fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nacionalidad)
                    .HasColumnName("nacionalidad")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.NumLibreta)
                    .HasColumnName("num_libreta")
                    .HasMaxLength(50);

                entity.Property(e => e.Observaciones)
                    .HasColumnName("observaciones")
                    .HasMaxLength(1000);

                entity.Property(e => e.PaisId)
                    .IsRequired()
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PaisNaci)
                    .HasColumnName("pais_naci")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PartiTele)
                    .HasColumnName("parti_tele")
                    .HasMaxLength(32);

                entity.Property(e => e.Pase).HasColumnName("pase");

                entity.Property(e => e.PerBolsa2Activo).HasColumnName("per_bolsa2_activo");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.Persoacargo).HasColumnName("persoacargo");

                entity.Property(e => e.PerteneceA)
                    .HasColumnName("pertenece_a")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PobladoId)
                    .HasColumnName("poblado_id")
                    .HasMaxLength(8);

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("primer_apellido")
                    .HasMaxLength(50);

                entity.Property(e => e.PrimerNombre)
                    .HasColumnName("primer_nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.RecibeSub).HasColumnName("recibe_sub");

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("segundo_apellido")
                    .HasMaxLength(50);

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("segundo_nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Servicios)
                    .HasColumnName("servicios")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasColumnName("sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Sincursos).HasColumnName("sincursos");

                entity.Property(e => e.Sinestudios).HasColumnName("sinestudios");

                entity.Property(e => e.Sinlaboexpe).HasColumnName("sinlaboexpe");

                entity.Property(e => e.Tecnologia)
                    .HasColumnName("tecnologia")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Teletrabajo).HasColumnName("teletrabajo");

                entity.Property(e => e.TipoContratoId)
                    .HasColumnName("tipo_contrato_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.TipoLibreta)
                    .HasColumnName("tipo_libreta")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UltPaisTrab)
                    .HasColumnName("ult_pais_trab")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.UltimoCargo)
                    .HasMaxLength(350)
                    .IsUnicode(false);

                entity.Property(e => e.VeredaId).HasColumnName("vereda_id");
            });

            modelBuilder.Entity<PersonasEmpresa>(entity =>
            {
                entity.HasKey(e => e.PersoId);

                entity.ToTable("Personas_Empresa");

                entity.HasIndex(e => new { e.DocuTipoId, e.DocuNro });

                entity.Property(e => e.PersoId)
                    .HasColumnName("perso_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ape)
                    .IsRequired()
                    .HasColumnName("ape")
                    .HasMaxLength(250);

                entity.Property(e => e.CampoId)
                    .HasColumnName("campo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CargoId)
                    .HasColumnName("cargo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DocuNro)
                    .IsRequired()
                    .HasColumnName("docu_nro")
                    .HasMaxLength(32);

                entity.Property(e => e.DocuTipoId)
                    .IsRequired()
                    .HasColumnName("docu_tipo_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EmpreAreaId)
                    .HasColumnName("empre_area_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .HasColumnName("primer_apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerNombre)
                    .HasColumnName("primer_nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .HasColumnName("segundo_apellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoNombre)
                    .HasColumnName("segundo_nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(50);

                entity.Property(e => e.TelefonoCelular)
                    .HasColumnName("telefono_celular")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CargoNavigation)
                    .WithMany(p => p.PersonasEmpresa)
                    .HasForeignKey(d => d.CargoId)
                    .HasConstraintName("FK_Personas_Empresa_Cargos");

                entity.HasOne(d => d.DocuTipo)
                    .WithMany(p => p.PersonasEmpresa)
                    .HasForeignKey(d => d.DocuTipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personas_Empresa_tipo_documento");

                entity.HasOne(d => d.EmpreArea)
                    .WithMany(p => p.PersonasEmpresa)
                    .HasForeignKey(d => d.EmpreAreaId)
                    .HasConstraintName("FK_Personas_Empresa_Empre_area");

                entity.HasOne(d => d.Ciudades)
                    .WithMany(p => p.PersonasEmpresa)
                    .HasForeignKey(d => new { d.PaisId, d.DepartamentoId, d.CiudadId })
                    .HasConstraintName("FK_Personas_Empresa_Ciudades");
            });

            modelBuilder.Entity<PesProcesoEncuestaSatisfaccion>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId, e.EnpId });

                entity.ToTable("PES_PROCESO_ENCUESTA_SATISFACCION");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.EnpId).HasColumnName("ENP_ID");

                entity.HasOne(d => d.Enp)
                    .WithMany(p => p.PesProcesoEncuestaSatisfaccion)
                    .HasForeignKey(d => d.EnpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PES_PROCESO_ENCUESTA_SATISFACCION_ENP_ENCUESTA_PREGUNTAS");

                entity.HasOne(d => d.Procesos)
                    .WithMany(p => p.PesProcesoEncuestaSatisfaccion)
                    .HasForeignKey(d => new { d.InterOrgaId, d.ProcesoId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PES_PROCESO_ENCUESTA_SATISFACCION_Procesos");
            });

            modelBuilder.Entity<PicPreinscripcionesCta>(entity =>
            {
                entity.HasKey(e => e.PicId);

                entity.ToTable("PIC_PREINSCRIPCIONES_CTA");

                entity.HasIndex(e => e.CnvId);

                entity.HasIndex(e => e.PersoIdOferente);

                entity.HasIndex(e => new { e.CtaId, e.PersoIdOferente });

                entity.HasIndex(e => new { e.CtaId, e.PersoIdOferente, e.CnvId });

                entity.Property(e => e.PicId).HasColumnName("PIC_ID");

                entity.Property(e => e.CnvId).HasColumnName("CNV_ID");

                entity.Property(e => e.CtaId).HasColumnName("CTA_ID");

                entity.Property(e => e.PersoIdOferente).HasColumnName("PERSO_ID_OFERENTE");

                entity.Property(e => e.PersoIdReco).HasColumnName("PERSO_ID_RECO");

                entity.Property(e => e.PicAutoregistro).HasColumnName("PIC_AUTOREGISTRO");

                entity.Property(e => e.PicFechaPreinsc)
                    .HasColumnName("PIC_FECHA_PREINSC")
                    .HasColumnType("datetime");

                entity.Property(e => e.PicFechaReco)
                    .HasColumnName("PIC_FECHA_RECO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PicObservaciones)
                    .HasColumnName("PIC_OBSERVACIONES")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.VlcEstadoPreinsc).HasColumnName("VLC_ESTADO_PREINSC");

                entity.HasOne(d => d.Cta)
                    .WithMany(p => p.PicPreinscripcionesCta)
                    .HasForeignKey(d => d.CtaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PIC_PREINSCRIPCIONES_CTA_CTA_CURSOS_TALLERES");

                entity.HasOne(d => d.PersoIdOferenteNavigation)
                    .WithMany(p => p.PicPreinscripcionesCta)
                    .HasForeignKey(d => d.PersoIdOferente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PIC_PREINSCRIPCIONES_CTA_Personas");

                entity.HasOne(d => d.VlcEstadoPreinscNavigation)
                    .WithMany(p => p.PicPreinscripcionesCta)
                    .HasForeignKey(d => d.VlcEstadoPreinsc)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PIC_PREINSCRIPCIONES_CTA_VLC_VALOR_CATALOGO");
            });

            modelBuilder.Entity<PinPeriodoInd>(entity =>
            {
                entity.HasKey(e => e.PinId)
                    .HasName("PK__PIN_PERI__D67CEA82CC79C05A");

                entity.ToTable("PIN_PERIODO_IND");

                entity.Property(e => e.PinId).HasColumnName("PIN_ID");

                entity.Property(e => e.Anio).HasColumnName("ANIO");

                entity.Property(e => e.TpeId).HasColumnName("TPE_ID");

                entity.Property(e => e.Valor).HasColumnName("VALOR");

                entity.HasOne(d => d.Tpe)
                    .WithMany(p => p.PinPeriodoInd)
                    .HasForeignKey(d => d.TpeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PIN_PERIODO_IND_TPE_TIPO_PERIODO_IND");
            });

            modelBuilder.Entity<PostuEstado>(entity =>
            {
                entity.HasKey(e => e.PostuEstaId);

                entity.ToTable("Postu_estado");

                entity.Property(e => e.PostuEstaId)
                    .HasColumnName("postu_esta_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<Postulaciones>(entity =>
            {
                entity.HasKey(e => e.PosId)
                    .HasName("PK_POSTULACIONES");

                entity.HasIndex(e => e.PersoId);

                entity.HasIndex(e => new { e.PosId, e.SedeId, e.ProcesoId })
                    .HasName("IX_Postulaciones_sede_id_proceso_id");

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId, e.Estado });

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId, e.PersoId });

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId, e.PersoId, e.DepartamentoId });

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId, e.PersoId, e.Estado });

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId, e.PersoId, e.Estado, e.DepartamentoId });

                entity.Property(e => e.PosId).HasColumnName("POS_ID");

                entity.Property(e => e.CartaPresen)
                    .HasColumnName("carta_presen")
                    .HasMaxLength(500);

                entity.Property(e => e.DeclinaRol)
                    .HasColumnName("declina_rol")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .IsRequired()
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.MotDeclinaId).HasColumnName("mot_declina_id");

                entity.Property(e => e.MotDeclinaOtro)
                    .HasColumnName("mot_declina_otro")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.PostuFecha)
                    .HasColumnName("postu_fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.PostulacionVoluntaria)
                    .HasColumnName("postulacion_voluntaria")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.SedeId).HasColumnName("sede_id");

                entity.Property(e => e.VoluntariaTercero).HasColumnName("voluntaria_tercero");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.Postulaciones)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Postulaciones_Personas");
            });

            modelBuilder.Entity<PostulacionesMiSpe>(entity =>
            {
                entity.ToTable("Postulaciones_MiSPE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.PostuFecha)
                    .HasColumnName("postu_fecha")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.SedeId).HasColumnName("sede_id");
            });

            modelBuilder.Entity<PostuladoUltimoAcceso>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId, e.PersoId })
                    .HasName("PK_Portulado_Ultimo_Acceso");

                entity.ToTable("Postulado_Ultimo_Acceso");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Postulantes>(entity =>
            {
                entity.HasKey(e => e.PersoId);

                entity.HasIndex(e => new { e.PersoId, e.IniFecha })
                    .HasName("IX_Postulantes_ini_fecha");

                entity.Property(e => e.PersoId)
                    .HasColumnName("perso_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IniFecha)
                    .HasColumnName("ini_fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersoIdAsesor).HasColumnName("perso_id_asesor");

                entity.HasOne(d => d.Perso)
                    .WithOne(p => p.Postulantes)
                    .HasForeignKey<Postulantes>(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Postulantes_Personas");
            });

            modelBuilder.Entity<PprPruebasXProceso>(entity =>
            {
                entity.HasKey(e => e.PprId);

                entity.ToTable("PPR_PRUEBAS_X_PROCESO");

                entity.Property(e => e.PprId).HasColumnName("PPR_ID");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.PrpId).HasColumnName("PRP_ID");

                entity.HasOne(d => d.Prp)
                    .WithMany(p => p.PprPruebasXProceso)
                    .HasForeignKey(d => d.PrpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRP_PRUEBAS_PROCESOS_PPR_PRUEBAS_X_PROCESO");
            });

            modelBuilder.Entity<PrcPreferenciasCargosArchivo>(entity =>
            {
                entity.ToTable("PRC_PREFERENCIAS_CARGOS_ARCHIVO");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CargoId)
                    .HasColumnName("cargo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("fecha_actualizacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersoId).HasColumnName("PERSO_ID");
            });

            modelBuilder.Entity<PreSeleccionBusquedas>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId, e.PersoId, e.IdBusqueda });

                entity.ToTable("PreSeleccion_busquedas");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.IdBusqueda).HasColumnName("id_busqueda");

                entity.Property(e => e.BusquedaActual)
                    .HasColumnName("busqueda_actual")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreSeleccionCandidatos>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId, e.PersoId, e.IdBusqueda });

                entity.ToTable("PreSeleccion_candidatos");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.IdBusqueda).HasColumnName("id_busqueda");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PreSeleccionCriterios>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId, e.PersoId })
                    .HasName("PK__PreSeleccion_Cri__118A8A8C");

                entity.ToTable("PreSeleccion_Criterios");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.CampoOrden)
                    .HasColumnName("campo_orden")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CargoId)
                    .HasColumnName("cargo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Filtro)
                    .HasColumnName("filtro")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.IdBusqueda).HasColumnName("id_busqueda");

                entity.Property(e => e.PaginaDesde)
                    .HasColumnName("pagina_desde")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.SalarioRangoId).HasColumnName("salario_rango_id");
            });

            modelBuilder.Entity<PreSeleccionFiltroAnosDeExperiencia>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId, e.IdBusqueda });

                entity.ToTable("PreSeleccion_filtro_Anos_de_Experiencia");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.IdBusqueda).HasColumnName("id_busqueda");

                entity.Property(e => e.Desde).HasColumnName("desde");

                entity.Property(e => e.Hasta).HasColumnName("hasta");
            });

            modelBuilder.Entity<PreSeleccionFiltroEdad>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId, e.IdBusqueda });

                entity.ToTable("PreSeleccion_filtro_Edad");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.IdBusqueda).HasColumnName("id_busqueda");

                entity.Property(e => e.Desde).HasColumnName("desde");

                entity.Property(e => e.Hasta).HasColumnName("hasta");
            });

            modelBuilder.Entity<PreSeleccionFiltroIdiomas>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId, e.IdBusqueda, e.IdioId });

                entity.ToTable("PreSeleccion_filtro_Idiomas");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.IdBusqueda).HasColumnName("id_busqueda");

                entity.Property(e => e.IdioId)
                    .HasColumnName("idio_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.NivelValor).HasColumnName("nivel_valor");
            });

            modelBuilder.Entity<PreSeleccionFiltroInstituciones>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId, e.IdBusqueda, e.InstiId });

                entity.ToTable("PreSeleccion_filtro_Instituciones");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.IdBusqueda).HasColumnName("id_busqueda");

                entity.Property(e => e.InstiId)
                    .HasColumnName("insti_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreSeleccionFiltroNombre>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId, e.IdBusqueda });

                entity.ToTable("PreSeleccion_filtro_Nombre");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.IdBusqueda).HasColumnName("id_busqueda");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<PreSeleccionFiltroSexo>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId, e.IdBusqueda });

                entity.ToTable("PreSeleccion_filtro_Sexo");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.IdBusqueda).HasColumnName("id_busqueda");

                entity.Property(e => e.Sexo)
                    .HasColumnName("sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PreSeleccionFiltros>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId, e.FiltroOr });

                entity.ToTable("PreSeleccion_filtros");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.FiltroOr).HasColumnName("filtro_or");

                entity.Property(e => e.Campo)
                    .HasColumnName("campo")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Filtro1)
                    .HasColumnName("filtro_1")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Filtro2)
                    .HasColumnName("filtro_2")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Filtro3)
                    .HasColumnName("filtro_3")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Filtro4)
                    .HasColumnName("filtro_4")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Filtro5)
                    .HasColumnName("filtro_5")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Filtro6)
                    .HasColumnName("filtro_6")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FiltroDescrip)
                    .HasColumnName("filtro_descrip")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FormuCodi)
                    .HasColumnName("formu_codi")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Puntaje).HasColumnName("puntaje");

                entity.HasOne(d => d.Procesos)
                    .WithMany(p => p.PreSeleccionFiltros)
                    .HasForeignKey(d => new { d.InterOrgaId, d.ProcesoId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PreSeleccion_filtros_Procesos");
            });

            modelBuilder.Entity<PreguntasSeguridad>(entity =>
            {
                entity.HasKey(e => e.Codpregunta)
                    .HasName("PK_PreguntaSeguridad");

                entity.Property(e => e.Codpregunta).HasColumnName("codpregunta");

                entity.Property(e => e.NombrePregunta)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrfPerfiles>(entity =>
            {
                entity.HasKey(e => e.PrfId);

                entity.ToTable("PRF_PERFILES");

                entity.Property(e => e.PrfId).HasColumnName("PRF_ID");

                entity.Property(e => e.PrfNombre)
                    .IsRequired()
                    .HasColumnName("PRF_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TpmId).HasColumnName("TPM_ID");

                entity.HasOne(d => d.Tpm)
                    .WithMany(p => p.PrfPerfiles)
                    .HasForeignKey(d => d.TpmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRF_PERFILES_TPM_TIPO_MODULO");
            });

            modelBuilder.Entity<PrfPeriodicidadFacturacion>(entity =>
            {
                entity.HasKey(e => e.PrfId)
                    .HasName("PK_PRC_PERIODICIDAD");

                entity.ToTable("PRF_PERIODICIDAD_FACTURACION");

                entity.Property(e => e.PrfId).HasColumnName("PRF_ID");

                entity.Property(e => e.PrfNombre)
                    .IsRequired()
                    .HasColumnName("PRF_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrfPreferenciasUsuario>(entity =>
            {
                entity.HasKey(e => e.PersoId);

                entity.ToTable("PRF_PREFERENCIAS_USUARIO");

                entity.Property(e => e.PersoId)
                    .HasColumnName("PERSO_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CargoId)
                    .HasColumnName("CARGO_ID")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ContraTipoId)
                    .HasColumnName("contra_tipo_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EmpreIndusId).HasColumnName("EMPRE_INDUS_ID");

                entity.Property(e => e.EstuNivelId)
                    .HasColumnName("estu_nivel_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ExrId).HasColumnName("EXR_ID");

                entity.Property(e => e.PerId).HasColumnName("PER_ID");

                entity.Property(e => e.PrfFechaEnvioMail)
                    .HasColumnName("PRF_FECHA_ENVIO_MAIL")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrfOfertasEmail).HasColumnName("PRF_OFERTAS_EMAIL");

                entity.Property(e => e.SalarioRangoId).HasColumnName("salario_rango_id");

                entity.Property(e => e.SectorId).HasColumnName("SECTOR_ID");

                entity.HasOne(d => d.ContraTipo)
                    .WithMany(p => p.PrfPreferenciasUsuario)
                    .HasForeignKey(d => d.ContraTipoId)
                    .HasConstraintName("FK_contra_tipos_PRF_PREFERENCIAS_USUARIO");

                entity.HasOne(d => d.EstuNivel)
                    .WithMany(p => p.PrfPreferenciasUsuario)
                    .HasForeignKey(d => d.EstuNivelId)
                    .HasConstraintName("FK_PRF_PREFERENCIAS_USUARIO_Estu_nivel");

                entity.HasOne(d => d.Exr)
                    .WithMany(p => p.PrfPreferenciasUsuario)
                    .HasForeignKey(d => d.ExrId)
                    .HasConstraintName("FK_EXR_EXPERIENCIA_RANGO_PRF_PREFERENCIAS_USUARIO");

                entity.HasOne(d => d.Per)
                    .WithMany(p => p.PrfPreferenciasUsuario)
                    .HasForeignKey(d => d.PerId)
                    .HasConstraintName("FK_PER_PERIODICIDAD_PRF_PREFERENCIAS_USUARIO");

                entity.HasOne(d => d.Perso)
                    .WithOne(p => p.PrfPreferenciasUsuario)
                    .HasForeignKey<PrfPreferenciasUsuario>(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRF_PREFERENCIAS_USUARIO_Personas");

                entity.HasOne(d => d.SalarioRango)
                    .WithMany(p => p.PrfPreferenciasUsuario)
                    .HasForeignKey(d => d.SalarioRangoId)
                    .HasConstraintName("FK_salario_rangos_PRF_PREFERENCIAS_USUARIO");
            });

            modelBuilder.Entity<ProceEstado>(entity =>
            {
                entity.HasKey(e => e.ProceEstaId);

                entity.ToTable("Proce_estado");

                entity.Property(e => e.ProceEstaId)
                    .HasColumnName("proce_esta_id")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("orden");
            });

            modelBuilder.Entity<ProceTipo>(entity =>
            {
                entity.ToTable("Proce_tipo");

                entity.Property(e => e.ProceTipoId)
                    .HasColumnName("proce_tipo_id")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(32);
            });

            modelBuilder.Entity<ProceUsuario>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId, e.PersoId })
                    .HasName("PK_Proce_Usuario");

                entity.ToTable("Proce_usuario");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.ProceUsuario)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proce_usuario_S_usuarios_Empresa");

                entity.HasOne(d => d.Procesos)
                    .WithMany(p => p.ProceUsuario)
                    .HasForeignKey(d => new { d.InterOrgaId, d.ProcesoId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proce_usuario_Procesos");
            });

            modelBuilder.Entity<Procesos>(entity =>
            {
                entity.HasKey(e => new { e.SedeId, e.ProcesoId });

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId })
                    .HasName("IX_Procesos_proceso_id");

                entity.HasIndex(e => new { e.SedeId, e.SedeProcesoIds })
                    .HasName("IX_Procesos_sede_sede_proceso_ids");

                entity.HasIndex(e => new { e.ProcesoId, e.ProceEstaId, e.PaisId })
                    .HasName("IX_Procesos_proce_esta_id_pais_id");

                entity.HasIndex(e => new { e.Publicada, e.EsvId, e.IdAgencia });

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId, e.ProceEstaId })
                    .HasName("IX_Procesos_proce_esta_id");

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId, e.SedeProcesoIds })
                    .HasName("IX_Procesos_sede_proceso_ids");

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId, e.ProceEstaId, e.FechaEnvio })
                    .HasName("IX_Procesos_proce_esta_id_fecha_envio");

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId, e.FechaCreacionProceso, e.ProceEstaId, e.SedeProcesoIds })
                    .HasName("IX_Procesos_proce_esta_id_sede_proceso_ids");

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId, e.LocalizacionId, e.ProceEstaId, e.TipoLocalizacion })
                    .HasName("IXX_Procesos_proce_esta_id_TipoLocalizacion");

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId, e.Nombre, e.FechaCreacionProceso, e.ProceEstaId })
                    .HasName("IXX_Procesos_proce_esta_id");

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId, e.IdGrupoOcupacional1, e.IdGrupoOcupacional2, e.IdGrupoOcupacional3, e.RequiereExperiencia })
                    .HasName("IX_Procesos_requiere_experiencia");

                entity.HasIndex(e => new { e.SedeId, e.ProcesoId, e.Nombre, e.ProceEstaId, e.FechaEnvio, e.PersoIdCrea, e.PersoidAprobo, e.FechaCreacionProceso })
                    .HasName("IXX_Procesos_fecha_creacion_proceso");

                entity.Property(e => e.SedeId).HasColumnName("sede_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.CargoEqui1)
                    .HasColumnName("cargo_equi_1")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CargoEquiv2)
                    .HasColumnName("cargo_equiv_2")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CargoId)
                    .HasColumnName("cargo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoInternoVacante)
                    .HasColumnName("codigo_interno_vacante")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ConfiChk)
                    .HasColumnName("confi_chk")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ContraTipoId)
                    .HasColumnName("contra_tipo_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.EmpreAreaId)
                    .HasColumnName("empre_area_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpreCampoId)
                    .HasColumnName("empre_campo_id")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EsHidrocarburos).HasColumnName("es_hidrocarburos");

                entity.Property(e => e.EsNacional).HasColumnName("es_nacional");

                entity.Property(e => e.EstuNivelId)
                    .HasColumnName("estu_nivel_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.EsvId).HasColumnName("ESV_ID");

                entity.Property(e => e.Excepcional).HasColumnName("excepcional");

                entity.Property(e => e.FechaActualizacion)
                    .HasColumnName("fecha_actualizacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaBaseAmpliacion)
                    .HasColumnName("fecha_base_ampliacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaCreacionProceso)
                    .HasColumnName("fecha_creacion_proceso")
                    .HasColumnType("date");

                entity.Property(e => e.FechaEnvio)
                    .HasColumnName("fecha_envio")
                    .HasColumnType("date");

                entity.Property(e => e.FechaIncorporacion)
                    .HasColumnName("fecha_incorporacion")
                    .HasColumnType("date");

                entity.Property(e => e.FechaIniCargo)
                    .HasColumnName("fecha_ini_cargo")
                    .HasColumnType("date");

                entity.Property(e => e.FechaRechazo)
                    .HasColumnName("fecha_rechazo")
                    .HasColumnType("date");

                entity.Property(e => e.FechaRespPresta)
                    .HasColumnName("fecha_resp_presta")
                    .HasColumnType("date");

                entity.Property(e => e.Graduado).HasColumnName("graduado");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdGrupoOcupacional1)
                    .HasColumnName("idGrupoOcupacional1")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdGrupoOcupacional2)
                    .HasColumnName("idGrupoOcupacional2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdGrupoOcupacional3)
                    .HasColumnName("idGrupoOcupacional3")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdUnique)
                    .HasColumnName("idUnique")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Idareaocupacional).HasColumnName("idareaocupacional");

                entity.Property(e => e.Idareaocupacional1).HasColumnName("idareaocupacional1");

                entity.Property(e => e.Idareaocupacional2).HasColumnName("idareaocupacional2");

                entity.Property(e => e.Idnucleoconoc)
                    .HasColumnName("idnucleoconoc")
                    .HasMaxLength(5);

                entity.Property(e => e.InfoCapacitacion)
                    .HasColumnName("info_capacitacion")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.IniFecha)
                    .HasColumnName("ini_fecha")
                    .HasColumnType("date");

                entity.Property(e => e.JornadaId).HasColumnName("jornada_id");

                entity.Property(e => e.MailContac)
                    .HasColumnName("mail_contac")
                    .HasMaxLength(250);

                entity.Property(e => e.ManoObraCalificada).HasColumnName("mano_obra_calificada");

                entity.Property(e => e.MesExpeDesde).HasColumnName("mes_expe_desde");

                entity.Property(e => e.MesExpeHasta).HasColumnName("mes_expe_hasta");

                entity.Property(e => e.MotCancelId).HasColumnName("mot_cancel_id");

                entity.Property(e => e.MotRechaId).HasColumnName("mot_recha_id");

                entity.Property(e => e.MotRechaOtro)
                    .HasColumnName("mot_recha_otro")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoCancelacion)
                    .HasColumnName("Motivo_Cancelacion")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.MotivoExcepcional).HasColumnName("motivoExcepcional");

                entity.Property(e => e.NoEstandarizadoCargo1).HasColumnName("no_estandarizado_cargo_1");

                entity.Property(e => e.NoEstandarizadoCargo2).HasColumnName("no_estandarizado_cargo_2");

                entity.Property(e => e.NoEstandarizadoCargo3).HasColumnName("no_estandarizado_cargo_3");

                entity.Property(e => e.NoEstandarizadoDetalle).HasColumnName("no_estandarizado_detalle");

                entity.Property(e => e.NoEstandarizadoEstuNivelId)
                    .HasColumnName("no_estandarizado_estu_nivel_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NoEstandarizadoMesExpeDesde).HasColumnName("no_estandarizado_mes_expe_desde");

                entity.Property(e => e.NoVacantes).HasColumnName("noVacantes");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(320);

                entity.Property(e => e.NumeroRemisiones)
                    .HasColumnName("numero_remisiones")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NumeroRemisionesMaximo).HasColumnName("numero_remisiones_maximo");

                entity.Property(e => e.Observacion).IsUnicode(false);

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PersoIdAgenciaCancela).HasColumnName("perso_id_agencia_cancela");

                entity.Property(e => e.PersoIdAgenciaDevuelve).HasColumnName("perso_id_agencia_devuelve");

                entity.Property(e => e.PersoIdAgente).HasColumnName("perso_id_agente");

                entity.Property(e => e.PersoIdAgenteCrea).HasColumnName("perso_id_agente_crea");

                entity.Property(e => e.PersoIdCrea).HasColumnName("perso_id_crea");

                entity.Property(e => e.PersoIdRechazo).HasColumnName("perso_id_rechazo");

                entity.Property(e => e.PersoidAprobo).HasColumnName("persoid_aprobo");

                entity.Property(e => e.Personasacargo).HasColumnName("personasacargo");

                entity.Property(e => e.PerteneceSectorPetroleo).HasColumnName("pertenece_sector_petroleo");

                entity.Property(e => e.ProceEstaFecha)
                    .HasColumnName("proce_esta_fecha")
                    .HasColumnType("date");

                entity.Property(e => e.ProceEstaId)
                    .HasColumnName("proce_esta_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Publicada).HasColumnName("publicada");

                entity.Property(e => e.RequiereCapacitacion).HasColumnName("requiere_capacitacion");

                entity.Property(e => e.RequiereExperiencia).HasColumnName("requiere_experiencia");

                entity.Property(e => e.RequiereGestion).HasColumnName("requiere_gestion");

                entity.Property(e => e.RequiereViajar).HasColumnName("requiere_viajar");

                entity.Property(e => e.RespoPersoId).HasColumnName("respo_perso_id");

                entity.Property(e => e.SalarioRangoId).HasColumnName("salario_rango_id");

                entity.Property(e => e.SectorHidrocarburos).HasColumnName("sector_hidrocarburos");

                entity.Property(e => e.SedeProcesoIds)
                    .IsRequired()
                    .HasColumnName("sede_proceso_ids")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasComputedColumnSql("(concat(CONVERT([varchar](30),[sede_id]),CONVERT([varchar](30),[proceso_id])))");

                entity.Property(e => e.SolicitaNom)
                    .HasColumnName("solicita_nom")
                    .HasMaxLength(250);

                entity.Property(e => e.SubsectorHidrocarburos).HasColumnName("subsector_hidrocarburos");

                entity.Property(e => e.Suplementario).HasColumnName("suplementario");

                entity.Property(e => e.TeleContac)
                    .HasColumnName("tele_contac")
                    .HasMaxLength(32);

                entity.Property(e => e.Teletrabajo).HasColumnName("teletrabajo");

                entity.Property(e => e.TipoProyectoId).HasColumnName("tipo_proyecto_id");

                entity.Property(e => e.TipoVacante).HasColumnName("tipo_vacante");

                entity.Property(e => e.TituloId)
                    .HasColumnName("titulo_id")
                    .HasMaxLength(300);

                entity.Property(e => e.VacanteCreadaPorPrestador).HasColumnName("vacante_creada_por_prestador");

                entity.Property(e => e.Veredas)
                    .HasColumnName("veredas")
                    .IsUnicode(false);

                entity.HasOne(d => d.MotRecha)
                    .WithMany(p => p.Procesos)
                    .HasForeignKey(d => d.MotRechaId)
                    .HasConstraintName("FK_Procesos_motivo_rechazo_vacante");

                entity.HasOne(d => d.ProceEsta)
                    .WithMany(p => p.Procesos)
                    .HasForeignKey(d => d.ProceEstaId)
                    .HasConstraintName("FK_Procesos_Proce_estado");

                entity.HasOne(d => d.SectorHidrocarburosNavigation)
                    .WithMany(p => p.Procesos)
                    .HasForeignKey(d => d.SectorHidrocarburos)
                    .HasConstraintName("FK__Procesos__sector__2E0F5C77");

                entity.HasOne(d => d.SubsectorHidrocarburosNavigation)
                    .WithMany(p => p.Procesos)
                    .HasForeignKey(d => d.SubsectorHidrocarburos)
                    .HasConstraintName("FK__Procesos__subsec__2F0380B0");

                entity.HasOne(d => d.TipoProyecto)
                    .WithMany(p => p.Procesos)
                    .HasForeignKey(d => d.TipoProyectoId)
                    .HasConstraintName("FK_Tipo_proyectos_hidrocarburos");
            });

            modelBuilder.Entity<ProcesosCertificacionesHidro>(entity =>
            {
                entity.ToTable("Procesos_certificaciones_hidro");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgenteIdCertificadoDeptal).HasColumnName("agente_id_certificado_deptal");

                entity.Property(e => e.AgenteIdCertificadoNal).HasColumnName("agente_id_certificado_nal");

                entity.Property(e => e.CodigoCertificadoDeptal)
                    .HasColumnName("codigo_certificado_deptal")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoCertificadoNal)
                    .HasColumnName("codigo_certificado_nal")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCertificadoDeptal)
                    .HasColumnName("fecha_certificado_deptal")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCertificadoNal)
                    .HasColumnName("fecha_certificado_nal")
                    .HasColumnType("datetime");

                entity.Property(e => e.MotivoIdCertificadoDeptal).HasColumnName("motivo_id_certificado_deptal");

                entity.Property(e => e.MotivoIdCertificadoNal).HasColumnName("motivo_id_certificado_nal");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.ResultadoMatch).HasColumnName("Resultado_Match");

                entity.Property(e => e.SedeId).HasColumnName("sede_id");

                entity.Property(e => e.TotalColocados).HasColumnName("Total_Colocados");

                entity.Property(e => e.TotalRemitidos).HasColumnName("Total_Remitidos");

                entity.HasOne(d => d.AgenteIdCertificadoDeptalNavigation)
                    .WithMany(p => p.ProcesosCertificacionesHidroAgenteIdCertificadoDeptalNavigation)
                    .HasForeignKey(d => d.AgenteIdCertificadoDeptal)
                    .HasConstraintName("FK__Procesos___agent__2F482E06");

                entity.HasOne(d => d.AgenteIdCertificadoNalNavigation)
                    .WithMany(p => p.ProcesosCertificacionesHidroAgenteIdCertificadoNalNavigation)
                    .HasForeignKey(d => d.AgenteIdCertificadoNal)
                    .HasConstraintName("FK__Procesos___agent__303C523F");

                entity.HasOne(d => d.Sede)
                    .WithMany(p => p.ProcesosCertificacionesHidro)
                    .HasForeignKey(d => d.SedeId)
                    .HasConstraintName("FK__Procesos___sede___31307678");
            });

            modelBuilder.Entity<ProcesosInterOrgaSedes>(entity =>
            {
                entity.HasKey(e => e.IdProcesosInterOrgaSedes);

                entity.ToTable("Procesos_InterOrga_Sedes");

                entity.Property(e => e.IdProcesosInterOrgaSedes).HasColumnName("ID_Procesos_InterOrga_Sedes");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdSede).HasColumnName("Id_Sede");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.HasOne(d => d.InterOrga)
                    .WithMany(p => p.ProcesosInterOrgaSedes)
                    .HasForeignKey(d => d.InterOrgaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Procesos_InterOrga_Sedes_Inter_orga");

                entity.HasOne(d => d.Procesos)
                    .WithMany(p => p.ProcesosInterOrgaSedes)
                    .HasForeignKey(d => new { d.InterOrgaId, d.ProcesoId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Procesos_InterOrga_Sedes_Procesos");
            });

            modelBuilder.Entity<ProcesosSectorHidrocarburos>(entity =>
            {
                entity.ToTable("procesos_sector_hidrocarburos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProcesosSubsectorHidrocarburos>(entity =>
            {
                entity.ToTable("procesos_subsector_hidrocarburos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SectorId).HasColumnName("sector_id");

                entity.HasOne(d => d.Sector)
                    .WithMany(p => p.ProcesosSubsectorHidrocarburos)
                    .HasForeignKey(d => d.SectorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__procesos___secto__2B32EFCC");
            });

            modelBuilder.Entity<ProcesosTipoProyectosHidrocarburos>(entity =>
            {
                entity.ToTable("Procesos_Tipo_proyectos_Hidrocarburos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Detalle)
                    .HasColumnName("detalle")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProduInterOrga>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProduId, e.ProduOr });

                entity.ToTable("Produ_Inter_orga");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProduId).HasColumnName("produ_id");

                entity.Property(e => e.ProduOr).HasColumnName("produ_or");

                entity.Property(e => e.CantClasificados).HasColumnName("cant_clasificados");

                entity.Property(e => e.CantHv).HasColumnName("cant_hv");

                entity.Property(e => e.FechaDesde)
                    .HasColumnName("fecha_desde")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaHasta)
                    .HasColumnName("fecha_hasta")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProduEstaId)
                    .HasColumnName("produ_esta_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.InterOrga)
                    .WithMany(p => p.ProduInterOrga)
                    .HasForeignKey(d => d.InterOrgaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produ_Inter_orga_Inter_orga");

                entity.HasOne(d => d.ProduEsta)
                    .WithMany(p => p.ProduInterOrga)
                    .HasForeignKey(d => d.ProduEstaId)
                    .HasConstraintName("FK_Produ_Inter_orga_Producto_estado");

                entity.HasOne(d => d.Produ)
                    .WithMany(p => p.ProduInterOrga)
                    .HasForeignKey(d => d.ProduId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Produ_Inter_orga_Producto");
            });

            modelBuilder.Entity<ProduInterOrgaPublicaciones>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId, e.ProduId, e.ProduOr });

                entity.ToTable("produ_inter_orga_publicaciones");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.ProduId).HasColumnName("produ_id");

                entity.Property(e => e.ProduOr).HasColumnName("produ_or");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.Republicaciones).HasColumnName("republicaciones");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.ProduInterOrgaPublicaciones)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_produ_inter_orga_publicaciones_S_usuarios_Empresa");

                entity.HasOne(d => d.Publicaciones)
                    .WithMany(p => p.ProduInterOrgaPublicaciones)
                    .HasForeignKey(d => new { d.InterOrgaId, d.ProcesoId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_produ_inter_orga_publicaciones_Publicaciones");

                entity.HasOne(d => d.ProduInterOrga)
                    .WithMany(p => p.ProduInterOrgaPublicaciones)
                    .HasForeignKey(d => new { d.InterOrgaId, d.ProduId, d.ProduOr })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_produ_inter_orga_publicaciones_Produ_Inter_orga");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.ProduId);

                entity.Property(e => e.ProduId)
                    .HasColumnName("produ_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CantClasificados).HasColumnName("cant_clasificados");

                entity.Property(e => e.CantHv).HasColumnName("cant_hv");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DiasVencimiento).HasColumnName("dias_vencimiento");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProduTipoId)
                    .HasColumnName("produ_tipo_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Valor)
                    .HasColumnName("valor")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProduTipo)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.ProduTipoId)
                    .HasConstraintName("FK_Producto_Producto_tipo");
            });

            modelBuilder.Entity<ProductoEstado>(entity =>
            {
                entity.HasKey(e => e.ProduEstaId);

                entity.ToTable("Producto_estado");

                entity.Property(e => e.ProduEstaId)
                    .HasColumnName("produ_esta_id")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductoTipo>(entity =>
            {
                entity.HasKey(e => e.ProduTipoId)
                    .HasName("PK_Producto_Tipo");

                entity.ToTable("Producto_tipo");

                entity.Property(e => e.ProduTipoId)
                    .HasColumnName("produ_tipo_id")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProgramaXProcesoYSede>(entity =>
            {
                entity.ToTable("Programa_x_proceso_y_sede");

                entity.HasIndex(e => e.Descripcion);

                entity.HasIndex(e => new { e.ProcesoId, e.SedeId });

                entity.HasIndex(e => new { e.ProcesoId, e.SedeId, e.ProgramaId })
                    .HasName("IX_Programa_x_proceso_y_sede_ProgramaId");

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaMarcado)
                    .HasColumnName("fecha_marcado")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcesoId).HasColumnName("Proceso_id");

                entity.Property(e => e.SedeId).HasColumnName("Sede_id");
            });

            modelBuilder.Entity<ProgramaXgobierno>(entity =>
            {
                entity.HasKey(e => e.ProgramasGobiernoId);

                entity.ToTable("ProgramaXGobierno");

                entity.Property(e => e.ProgramasGobiernoId).HasColumnName("ProgramasGobiernoID");

                entity.Property(e => e.Matching)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NombreProgramas)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Oferentes)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Vacantes)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<PrpPruebasProcesos>(entity =>
            {
                entity.HasKey(e => e.PrpId);

                entity.ToTable("PRP_PRUEBAS_PROCESOS");

                entity.Property(e => e.PrpId).HasColumnName("PRP_ID");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.PersoIdCre).HasColumnName("perso_id_cre");

                entity.Property(e => e.PersoIdMod).HasColumnName("perso_id_mod");

                entity.Property(e => e.PrpComentarios)
                    .HasColumnName("PRP_COMENTARIOS")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PrpDescripcion)
                    .HasColumnName("PRP_DESCRIPCION")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PrpEstado)
                    .HasColumnName("PRP_ESTADO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrpFechaCrea)
                    .HasColumnName("PRP_FECHA_CREA")
                    .HasColumnType("date");

                entity.Property(e => e.PrpFechaMod)
                    .HasColumnName("PRP_FECHA_MOD")
                    .HasColumnType("date");

                entity.Property(e => e.PrpFile)
                    .HasColumnName("PRP_FILE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.PrpNombre)
                    .IsRequired()
                    .HasColumnName("PRP_NOMBRE")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StpId).HasColumnName("STP_ID");

                entity.HasOne(d => d.Stp)
                    .WithMany(p => p.PrpPruebasProcesos)
                    .HasForeignKey(d => d.StpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_STP_SUBTIPO_PRUEBAS_PRP_PRUEBAS_PROCESOS");
            });

            modelBuilder.Entity<PruPerfilesUsuario>(entity =>
            {
                entity.HasKey(e => new { e.PrfId, e.PersoId });

                entity.ToTable("PRU_PERFILES_USUARIO");

                entity.Property(e => e.PrfId).HasColumnName("PRF_ID");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");
            });

            modelBuilder.Entity<PubliEstado>(entity =>
            {
                entity.HasKey(e => e.PubliEstaId);

                entity.ToTable("Publi_estado");

                entity.Property(e => e.PubliEstaId)
                    .HasColumnName("Publi_esta_id")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Publicaciones>(entity =>
            {
                entity.HasKey(e => new { e.InterOrgaId, e.ProcesoId });

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.ProcesoId).HasColumnName("proceso_id");

                entity.Property(e => e.AnioExpeDesde).HasColumnName("anio_expe_desde");

                entity.Property(e => e.AnioExpeHasta).HasColumnName("anio_expe_hasta");

                entity.Property(e => e.CodigoOferta)
                    .HasColumnName("codigo_oferta")
                    .HasMaxLength(50);

                entity.Property(e => e.ConfiCk)
                    .HasColumnName("confi_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ContraTipoId)
                    .HasColumnName("contra_tipo_id")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.DesdeFecha)
                    .HasColumnName("desde_fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.EmpreAreaId2)
                    .HasColumnName("empre_area_id2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpreAreaId3)
                    .HasColumnName("empre_area_id3")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmpreNombre)
                    .HasColumnName("empre_nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.EstuNivelId)
                    .HasColumnName("estu_nivel_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.FechaAprob)
                    .HasColumnName("fecha_aprob")
                    .HasColumnType("datetime");

                entity.Property(e => e.HastaFecha)
                    .HasColumnName("hasta_fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.IndId).HasColumnName("IND_ID");

                entity.Property(e => e.PersoidAprobo).HasColumnName("persoid_aprobo");

                entity.Property(e => e.PosiDescrip).HasColumnName("posi_descrip");

                entity.Property(e => e.PubliEstadoId)
                    .HasColumnName("publi_estado_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PubliSalarioCk)
                    .HasColumnName("publi_salario_ck")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PubliVigenciaId).HasColumnName("publi_vigencia_id");

                entity.Property(e => e.Requisitos).HasColumnName("requisitos");

                entity.Property(e => e.SalarioRangoId).HasColumnName("salario_rango_id");

                entity.Property(e => e.SecId).HasColumnName("SEC_ID");

                entity.Property(e => e.Titulo)
                    .HasColumnName("titulo")
                    .HasMaxLength(250);

                entity.HasOne(d => d.EstuNivel)
                    .WithMany(p => p.Publicaciones)
                    .HasForeignKey(d => d.EstuNivelId)
                    .HasConstraintName("FK_Publicaciones_Estu_nivel");

                entity.HasOne(d => d.PubliEstado)
                    .WithMany(p => p.Publicaciones)
                    .HasForeignKey(d => d.PubliEstadoId)
                    .HasConstraintName("FK_Publicaciones_Publi_estado");

                entity.HasOne(d => d.SalarioRango)
                    .WithMany(p => p.Publicaciones)
                    .HasForeignKey(d => d.SalarioRangoId)
                    .HasConstraintName("FK_Publicaciones_Salario_rango");

                entity.HasOne(d => d.Procesos)
                    .WithOne(p => p.Publicaciones)
                    .HasForeignKey<Publicaciones>(d => new { d.InterOrgaId, d.ProcesoId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Publicaciones_Procesos");
            });

            modelBuilder.Entity<Repositorio>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AgenciaId).HasColumnName("agencia_id");

                entity.Property(e => e.Archivo).HasColumnName("archivo");

                entity.Property(e => e.DetalleErrorProceso).HasColumnName("detalle_error_proceso");

                entity.Property(e => e.DetalleRegistrosRechazadosSise).HasColumnName("detalle_registros_rechazados_sise");

                entity.Property(e => e.ErrorProceso).HasColumnName("error_proceso");

                entity.Property(e => e.FechaProceoSise)
                    .HasColumnName("fecha_proceo_sise")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaTransmisionRepositorio)
                    .HasColumnName("fecha_transmision_repositorio")
                    .HasColumnType("datetime");

                entity.Property(e => e.IpCliente)
                    .HasColumnName("ip_cliente")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('127.0.0.1')");

                entity.Property(e => e.PrestadorId).HasColumnName("prestador_id");

                entity.Property(e => e.ProcesadoSise).HasColumnName("procesado_sise");

                entity.Property(e => e.RegistrosActualizados).HasColumnName("Registros_actualizados");

                entity.Property(e => e.RegistrosProcesadosSise).HasColumnName("registros_procesados_sise");

                entity.Property(e => e.RegistrosRechazadosSise).HasColumnName("registros_rechazados_sise");

                entity.Property(e => e.RegistrosTransmitidosRepositorio).HasColumnName("registros_transmitidos_repositorio");

                entity.Property(e => e.UsuarioClave)
                    .IsRequired()
                    .HasColumnName("usuario_clave")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCorreo)
                    .IsRequired()
                    .HasColumnName("usuario_correo")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioDocumento)
                    .IsRequired()
                    .HasColumnName("usuario_documento")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.VersionCliente)
                    .HasColumnName("version_cliente")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1.4')");
            });

            modelBuilder.Entity<RobRolObjeto>(entity =>
            {
                entity.HasKey(e => new { e.ObjId, e.RolId });

                entity.ToTable("ROB_ROL_OBJETO");

                entity.Property(e => e.ObjId).HasColumnName("OBJ_ID");

                entity.Property(e => e.RolId).HasColumnName("ROL_ID");

                entity.HasOne(d => d.Obj)
                    .WithMany(p => p.RobRolObjeto)
                    .HasForeignKey(d => d.ObjId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ROB_ROL_OBJETO_OBJ_OBJETOS");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.RobRolObjeto)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ROB_ROL_OBJETO_ROL_ROL");
            });

            modelBuilder.Entity<RolRol>(entity =>
            {
                entity.HasKey(e => e.RolId);

                entity.ToTable("ROL_ROL");

                entity.Property(e => e.RolId)
                    .HasColumnName("ROL_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.RolNombre)
                    .IsRequired()
                    .HasColumnName("ROL_NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RolUnidad>(entity =>
            {
                entity.HasKey(e => e.RolUnidad1);

                entity.ToTable("ROL_UNIDAD");

                entity.Property(e => e.RolUnidad1).HasColumnName("ROL_UNIDAD");

                entity.Property(e => e.RolNombre)
                    .IsRequired()
                    .HasColumnName("ROL_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RusRolUsuario>(entity =>
            {
                entity.HasKey(e => new { e.RolId, e.UsrId });

                entity.ToTable("RUS_ROL_USUARIO");

                entity.Property(e => e.RolId).HasColumnName("ROL_ID");

                entity.Property(e => e.UsrId).HasColumnName("USR_ID");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.RusRolUsuario)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RUS_ROL_USUARIO_ROL_ROL");

                entity.HasOne(d => d.Usr)
                    .WithMany(p => p.RusRolUsuario)
                    .HasForeignKey(d => d.UsrId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RUS_ROL_USUARIO_USR_USUARIO");
            });

            modelBuilder.Entity<SObjetos>(entity =>
            {
                entity.HasKey(e => e.ObjetoId);

                entity.ToTable("S_objetos");

                entity.Property(e => e.ObjetoId)
                    .HasColumnName("objeto_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IdCodigoModulo).HasColumnName("id_codigo_modulo");

                entity.Property(e => e.ImagePath)
                    .HasColumnName("image_path")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Label)
                    .IsRequired()
                    .HasColumnName("label")
                    .HasMaxLength(100);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(100);

                entity.Property(e => e.ObjeTipoId)
                    .IsRequired()
                    .HasColumnName("obje_tipo_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Orden).HasColumnName("orden");

                entity.Property(e => e.Owner).HasColumnName("owner");
            });

            modelBuilder.Entity<SRolObje>(entity =>
            {
                entity.HasKey(e => new { e.RolId, e.ObjetoId });

                entity.ToTable("S_rol_obje");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.Property(e => e.ObjetoId).HasColumnName("objeto_id");

                entity.HasOne(d => d.Objeto)
                    .WithMany(p => p.SRolObje)
                    .HasForeignKey(d => d.ObjetoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_rol_obje_S_objetos");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.SRolObje)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_rol_obje_S_roles");
            });

            modelBuilder.Entity<SRolUsua>(entity =>
            {
                entity.HasKey(e => new { e.PersoId, e.RolId });

                entity.ToTable("S_rol_usua");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.SRolUsua)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_rol_usua_S_roles1");
            });

            modelBuilder.Entity<SRolUsuaEliminados>(entity =>
            {
                entity.HasKey(e => new { e.PersoId, e.RolId });

                entity.ToTable("S_rol_usua_eliminados");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.RolId).HasColumnName("rol_id");
            });

            modelBuilder.Entity<SRoles>(entity =>
            {
                entity.HasKey(e => e.RolId);

                entity.ToTable("S_roles");

                entity.Property(e => e.RolId)
                    .HasColumnName("rol_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<SSesiones>(entity =>
            {
                entity.HasKey(e => e.SessionId);

                entity.ToTable("S_sesiones");

                entity.Property(e => e.SessionId)
                    .HasColumnName("session_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Expiration)
                    .HasColumnName("expiration")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.InterOrgaId)
                    .IsRequired()
                    .HasColumnName("inter_orga_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .IsRequired()
                    .HasColumnName("ip")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.PostuPersoId).HasColumnName("postu_perso_id");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.SSesiones)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_sesiones_S_roles");
            });

            modelBuilder.Entity<SUsuarioAdmin>(entity =>
            {
                entity.HasKey(e => e.PersoId);

                entity.ToTable("S_USUARIO_ADMIN");

                entity.Property(e => e.PersoId)
                    .HasColumnName("perso_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ape)
                    .HasColumnName("ape")
                    .HasMaxLength(250);

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Codpregunta).HasColumnName("codpregunta");

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DocNumero)
                    .HasColumnName("DOC_NUMERO")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DocuTipoId)
                    .HasColumnName("docu_tipo_id")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(320);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.Nombres)
                    .HasColumnName("NOMBRES")
                    .HasMaxLength(250);

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(250);

                entity.Property(e => e.Respregunta)
                    .HasColumnName("respregunta")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.Property(e => e.RolUnidad).HasColumnName("rol_unidad");

                entity.Property(e => e.Sesiones).HasColumnName("sesiones");

                entity.Property(e => e.Sexo)
                    .HasColumnName("sexo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.Perso)
                    .WithOne(p => p.SUsuarioAdmin)
                    .HasForeignKey<SUsuarioAdmin>(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_USUARIO_ADMIN_Personas_admin");
            });

            modelBuilder.Entity<SUsuarioAgencia>(entity =>
            {
                entity.HasKey(e => e.PersoId);

                entity.ToTable("s_usuario_agencia");

                entity.HasIndex(e => e.AgenciaId);

                entity.HasIndex(e => e.Email);

                entity.HasIndex(e => new { e.AgenciaId, e.UsaEscoord });

                entity.HasIndex(e => new { e.Email, e.Estado });

                entity.HasIndex(e => new { e.Email, e.UsaNombres, e.UsaApellidos, e.UsaFijo1, e.Estado, e.UsaEntId })
                    .HasName("IXX_s_usuario_agencia_estado_USA_ENT_ID");

                entity.HasIndex(e => new { e.Email, e.UsaNombres, e.UsaApellidos, e.UsaFijo1, e.Estado, e.UsaEscoord, e.UsaEntId })
                    .HasName("IX_s_usuario_agencia_estado_USA_ESCOORD_USA_ENT_ID");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.AgenciaId).HasColumnName("agencia_id");

                entity.Property(e => e.AgenciaRegistro).HasColumnName("agencia_registro");

                entity.Property(e => e.Clave)
                    .HasColumnName("clave")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(320);

                entity.Property(e => e.Esmultiagencia).HasColumnName("esmultiagencia");

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaCambioContasena)
                    .HasColumnName("fecha_cambio_contasena")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUltimoAcceso)
                    .HasColumnName("fecha_ultimo_acceso")
                    .HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(250);

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.Property(e => e.Sesiones).HasColumnName("sesiones");

                entity.Property(e => e.UsaApellidos)
                    .HasColumnName("USA_APELLIDOS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsaCelular)
                    .HasColumnName("USA_CELULAR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsaCodage)
                    .HasColumnName("USA_CODAGE")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsaCodigo)
                    .HasColumnName("USA_CODIGO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsaEntId).HasColumnName("USA_ENT_ID");

                entity.Property(e => e.UsaEscoord).HasColumnName("USA_ESCOORD");

                entity.Property(e => e.UsaFijo1)
                    .HasColumnName("USA_FIJO1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsaFijo2)
                    .HasColumnName("USA_FIJO2")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UsaNombres)
                    .HasColumnName("USA_NOMBRES")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UsaNumRoles).HasColumnName("USA_NUM_ROLES");

                entity.Property(e => e.UsaPreg).HasColumnName("USA_PREG");

                entity.Property(e => e.UsaRespuesta)
                    .HasColumnName("USA_RESPUESTA")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SUsuarios>(entity =>
            {
                entity.HasKey(e => new { e.PersoId, e.Email })
                    .HasName("PK_Usuarios");

                entity.ToTable("S_usuarios");

                entity.HasIndex(e => e.Email);

                entity.HasIndex(e => new { e.PersoId, e.Estado })
                    .HasName("IX_S_usuarios_estado");

                entity.HasIndex(e => new { e.PersoId, e.Estado, e.Password })
                    .HasName("IX_S_usuarios_password");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(320);

                entity.Property(e => e.AceptaTermCond).HasColumnName("acepta_term_cond");

                entity.Property(e => e.AceptaTratDatos).HasColumnName("acepta_trat_datos");

                entity.Property(e => e.Clave)
                    .HasColumnName("clave")
                    .HasMaxLength(250);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaCambioContrasena)
                    .HasColumnName("fecha_cambio_contrasena")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCierre)
                    .HasColumnName("fecha_cierre")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUltimoAcceso)
                    .HasColumnName("fecha_ultimo_acceso")
                    .HasColumnType("datetime");

                entity.Property(e => e.MotivoCierreId).HasColumnName("motivo_cierre_id");

                entity.Property(e => e.OtroMotivo)
                    .HasColumnName("otro_motivo")
                    .HasMaxLength(320);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(250);

                entity.Property(e => e.PersoIdPrestador).HasColumnName("perso_id_prestador");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.Property(e => e.SeguPregId).HasColumnName("segu_preg_id");

                entity.Property(e => e.SeguResp)
                    .HasColumnName("segu_resp")
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.Sesiones).HasColumnName("sesiones");

                entity.Property(e => e.TipoCierre)
                    .HasColumnName("tipo_cierre")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UltimoAcceso)
                    .HasColumnName("ultimo_acceso")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.SUsuarios)
                    .HasForeignKey(d => d.Estado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_usuarios_estado_cuenta");

                entity.HasOne(d => d.MotivoCierre)
                    .WithMany(p => p.SUsuarios)
                    .HasForeignKey(d => d.MotivoCierreId)
                    .HasConstraintName("FK_S_usuarios_Motiv_Cier_Cta");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.SUsuarios)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_Usuarios_Personas");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.SUsuarios)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_usuarios_S_roles");
            });

            modelBuilder.Entity<SUsuariosArchivo>(entity =>
            {
                entity.ToTable("S_usuarios_archivo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AceptaTermCond).HasColumnName("acepta_term_cond");

                entity.Property(e => e.AceptaTratDatos).HasColumnName("acepta_trat_datos");

                entity.Property(e => e.Clave)
                    .HasColumnName("clave")
                    .HasMaxLength(250);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(320);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.FechaCambioContrasena)
                    .HasColumnName("fecha_cambio_contrasena")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCierre)
                    .HasColumnName("fecha_cierre")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUltimoAcceso)
                    .HasColumnName("fecha_ultimo_acceso")
                    .HasColumnType("datetime");

                entity.Property(e => e.MotivoCierreId).HasColumnName("motivo_cierre_id");

                entity.Property(e => e.OtroMotivo)
                    .HasColumnName("otro_motivo")
                    .HasMaxLength(320);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(250);

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.PersoIdPrestador).HasColumnName("perso_id_prestador");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.Property(e => e.SeguPregId).HasColumnName("segu_preg_id");

                entity.Property(e => e.SeguResp)
                    .HasColumnName("segu_resp")
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.Sesiones).HasColumnName("sesiones");

                entity.Property(e => e.TipoCierre)
                    .HasColumnName("tipo_cierre")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UltimoAcceso)
                    .HasColumnName("ultimo_acceso")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<SUsuariosEmpresa1>(entity =>
            {
                entity.HasKey(e => e.PersoId);

                entity.ToTable("S_usuarios_Empresa");

                entity.HasIndex(e => e.Email);

                entity.HasIndex(e => e.IdSede);

                entity.Property(e => e.PersoId)
                    .HasColumnName("perso_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AceptaTermCond).HasColumnName("acepta_term_cond");

                entity.Property(e => e.AceptaTratDatos).HasColumnName("acepta_trat_datos");

                entity.Property(e => e.Clave)
                    .HasColumnName("clave")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(320);

                entity.Property(e => e.Estado).HasColumnName("estado");

                entity.Property(e => e.IdSede).HasColumnName("Id_Sede");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(250);

                entity.Property(e => e.RespoPersoId).HasColumnName("respo_perso_id");

                entity.Property(e => e.RolId).HasColumnName("rol_id");

                entity.Property(e => e.SeguPregId).HasColumnName("segu_preg_id");

                entity.Property(e => e.SeguResp)
                    .IsRequired()
                    .HasColumnName("segu_resp")
                    .HasMaxLength(320);

                entity.Property(e => e.Sesiones).HasColumnName("sesiones");

                entity.HasOne(d => d.IdSedeNavigation)
                    .WithMany(p => p.SUsuariosEmpresa1)
                    .HasForeignKey(d => d.IdSede)
                    .HasConstraintName("FK_S_usuarios_Empresa_Sedes");

                entity.HasOne(d => d.Perso)
                    .WithOne(p => p.SUsuariosEmpresa1)
                    .HasForeignKey<SUsuariosEmpresa1>(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_usuarios_Empresa_Personas_Empresa");

                entity.HasOne(d => d.Rol)
                    .WithMany(p => p.SUsuariosEmpresa1)
                    .HasForeignKey(d => d.RolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_S_usuarios_Empresa_S_roles");
            });

            modelBuilder.Entity<SadSuperAdministrador>(entity =>
            {
                entity.HasKey(e => e.SadId);

                entity.ToTable("SAD_SUPER_ADMINISTRADOR");

                entity.Property(e => e.SadId).HasColumnName("SAD_ID");

                entity.Property(e => e.SadIdentificacion)
                    .IsRequired()
                    .HasColumnName("SAD_IDENTIFICACION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SadNombre)
                    .IsRequired()
                    .HasColumnName("SAD_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SalarioRango>(entity =>
            {
                entity.ToTable("Salario_rango");

                entity.Property(e => e.SalarioRangoId)
                    .HasColumnName("salario_rango_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Fin).HasColumnName("fin");

                entity.Property(e => e.Inicio).HasColumnName("inicio");

                entity.Property(e => e.MoneId)
                    .HasColumnName("mone_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(250);

                entity.Property(e => e.SalarioRango1)
                    .HasColumnName("salario_rango")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Mone)
                    .WithMany(p => p.SalarioRango)
                    .HasForeignKey(d => d.MoneId)
                    .HasConstraintName("FK_Salario_rango_Monedas");
            });

            modelBuilder.Entity<SecSector>(entity =>
            {
                entity.HasKey(e => e.SecId);

                entity.ToTable("SEC_SECTOR");

                entity.Property(e => e.SecId).HasColumnName("SEC_ID");

                entity.Property(e => e.IndId).HasColumnName("IND_ID");

                entity.Property(e => e.SecCodigo).HasColumnName("SEC_CODIGO");

                entity.Property(e => e.SecNombre)
                    .IsRequired()
                    .HasColumnName("SEC_NOMBRE")
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ind)
                    .WithMany(p => p.SecSector)
                    .HasForeignKey(d => d.IndId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SEC_SECTOR_IND_INDUSTRIA");
            });

            modelBuilder.Entity<Sedes>(entity =>
            {
                entity.HasKey(e => e.IdSede);

                entity.HasIndex(e => e.InterOrgaId);

                entity.HasIndex(e => new { e.Estado, e.FechaCambioEstado, e.MotivoCierreId });

                entity.HasIndex(e => new { e.IdSede, e.NombreSede, e.CiudadId, e.InterOrgaId, e.FechaCreacion, e.DepartamentoId, e.Estado, e.FechaCambioEstado, e.MotivoCierreId })
                    .HasName("IX_Sedes_departamento_id_Estado_FechaCambioEstado_motivo_cierre_id");

                entity.HasIndex(e => new { e.IdSede, e.NombreSede, e.DireccionSede, e.PaisId, e.DepartamentoId, e.CiudadId, e.FechaCreacion, e.FechaCambioEstado, e.Estado, e.InterOrgaId })
                    .HasName("IX_Sedes_Estado_inter_orga_id");

                entity.Property(e => e.IdSede).HasColumnName("Id_Sede");

                entity.Property(e => e.Autoregistro).HasColumnName("autoregistro");

                entity.Property(e => e.CiudadId)
                    .IsRequired()
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .IsRequired()
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DireccionSede)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCambioEstado).HasColumnType("datetime");

                entity.Property(e => e.FechaCierre)
                    .HasColumnName("fecha_cierre")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnName("fecha_registro")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaUltimoAcceso)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaValidacion)
                    .HasColumnName("fecha_validacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdPersonaAgenciaCrea).HasColumnName("id_persona_agencia_crea");

                entity.Property(e => e.IdPersonaAgenciaVali).HasColumnName("id_persona_agencia_vali");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.MotivoCierreId).HasColumnName("motivo_cierre_id");

                entity.Property(e => e.NombreSede)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.OtroMotivo)
                    .HasColumnName("otro_motivo")
                    .HasMaxLength(320);

                entity.Property(e => e.PaisId)
                    .IsRequired()
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoSede)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSede)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCierre).HasColumnName("usuario_cierre");

                entity.HasOne(d => d.EstadoNavigation)
                    .WithMany(p => p.Sedes)
                    .HasForeignKey(d => d.Estado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sedes_estados_sede");

                entity.HasOne(d => d.InterOrga)
                    .WithMany(p => p.Sedes)
                    .HasForeignKey(d => d.InterOrgaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sedes_Inter_orga");

                entity.HasOne(d => d.MotivoCierre)
                    .WithMany(p => p.Sedes)
                    .HasForeignKey(d => d.MotivoCierreId)
                    .HasConstraintName("FK_sedes_UserID");
            });

            modelBuilder.Entity<SedesAgencia>(entity =>
            {
                entity.HasKey(e => e.IdSedesAgencia);

                entity.ToTable("Sedes_Agencia");

                entity.HasIndex(e => new { e.IdAgencia, e.IdSede })
                    .HasName("IX_Sedes_Agencia_Id_Sede");

                entity.HasIndex(e => new { e.IdSede, e.EsPrincipal });

                entity.HasIndex(e => new { e.IdSede, e.IdAgencia, e.EsPrincipal })
                    .HasName("IX_Sedes_Agencia_id_agencia_EsPrincipal");

                entity.Property(e => e.IdSedesAgencia).HasColumnName("Id_Sedes_Agencia");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdSede).HasColumnName("Id_Sede");

                entity.HasOne(d => d.IdAgenciaNavigation)
                    .WithMany(p => p.SedesAgencia)
                    .HasForeignKey(d => d.IdAgencia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sedes_Agencia_agencia");

                entity.HasOne(d => d.IdSedeNavigation)
                    .WithMany(p => p.SedesAgencia)
                    .HasForeignKey(d => d.IdSede)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sedes_Agencia_Sedes");
            });

            modelBuilder.Entity<SedesAgenciaHistorico>(entity =>
            {
                entity.HasKey(e => e.IdSedeAgenciaHistorico);

                entity.ToTable("Sedes_Agencia_Historico");

                entity.HasIndex(e => new { e.IdSede, e.IdAgenciaNuevo, e.FechaMotivo })
                    .HasName("IX_Sedes_Agencia_Historico_id_agencia_nuevo_fecha_motivo");

                entity.HasIndex(e => new { e.IdSede, e.IdAgencia, e.IdAgenciaNuevo, e.FechaRegistro })
                    .HasName("IX_Sedes_Agencia_Historico_id_agencia_id_agencia_nuevo_FechaRegistro");

                entity.Property(e => e.IdSedeAgenciaHistorico)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FechaMotivo)
                    .HasColumnName("fecha_motivo")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FechaRegistro)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.IdAgenciaNuevo).HasColumnName("id_agencia_nuevo");

                entity.Property(e => e.IdMotivo).HasColumnName("id_motivo");

                entity.Property(e => e.IdSede).HasColumnName("Id_Sede");

                entity.Property(e => e.OtroMotivo)
                    .HasColumnName("otro_motivo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoMotivo)
                    .HasColumnName("tipo_motivo")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMotivoNavigation)
                    .WithMany(p => p.SedesAgenciaHistorico)
                    .HasForeignKey(d => d.IdMotivo)
                    .HasConstraintName("FK_Sedes_Agencia_Historico_motivo_cambio_prestador_sede");
            });

            modelBuilder.Entity<SedesEliminadas>(entity =>
            {
                entity.ToTable("Sedes_Eliminadas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgenciaId).HasColumnName("agencia_id");

                entity.Property(e => e.AgenteId).HasColumnName("agente_id");

                entity.Property(e => e.Cancelados).HasColumnName("cancelados");

                entity.Property(e => e.Cerrados).HasColumnName("cerrados");

                entity.Property(e => e.Ciudad)
                    .HasColumnName("ciudad")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Departamento)
                    .HasColumnName("departamento")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion).HasColumnName("direccion");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("email")
                    .HasMaxLength(200);

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.InterOrgaId).HasColumnName("inter_orga_id");

                entity.Property(e => e.MotivoId).HasColumnName("motivo_id");

                entity.Property(e => e.Nit)
                    .IsRequired()
                    .HasColumnName("nit")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSede)
                    .IsRequired()
                    .HasColumnName("nombre_sede")
                    .HasMaxLength(100);

                entity.Property(e => e.Pais)
                    .HasColumnName("pais")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RazonSocial)
                    .IsRequired()
                    .HasColumnName("razon_social")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Registrados).HasColumnName("registrados");

                entity.Property(e => e.SedeId).HasColumnName("sede_id");

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoSede)
                    .HasColumnName("tipo_sede")
                    .HasMaxLength(50);

                entity.HasOne(d => d.Motivo)
                    .WithMany(p => p.SedesEliminadas)
                    .HasForeignKey(d => d.MotivoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Sedes_Eliminadas_Motivo_Eliminacion_Sede");
            });

            modelBuilder.Entity<Sedesocultas>(entity =>
            {
                entity.HasKey(e => e.IdSede);

                entity.ToTable("sedesocultas", "tmp");

                entity.Property(e => e.IdSede)
                    .HasColumnName("Id_Sede")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<SeguSocEnti>(entity =>
            {
                entity.HasKey(e => e.EntiId)
                    .HasName("PK_SeguSoc_enti");

                entity.ToTable("Segu_soc_enti");

                entity.Property(e => e.EntiId)
                    .HasColumnName("enti_id")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(320);

                entity.Property(e => e.TipoEntiId)
                    .HasColumnName("tipo_enti_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipoEnti)
                    .WithMany(p => p.SeguSocEnti)
                    .HasForeignKey(d => d.TipoEntiId)
                    .HasConstraintName("FK_SeguSoc_enti_SeguSoc_tipo_enti");
            });

            modelBuilder.Entity<SeguSocTipoEnti>(entity =>
            {
                entity.HasKey(e => e.TipoEntiId)
                    .HasName("PK_SeguSoc_tipo_enti");

                entity.ToTable("Segu_soc_tipo_enti");

                entity.Property(e => e.TipoEntiId)
                    .HasColumnName("tipo_enti_id")
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<SituacionLaboral>(entity =>
            {
                entity.HasKey(e => e.SitLabId);

                entity.ToTable("Situacion_Laboral");

                entity.Property(e => e.SitLabId)
                    .HasColumnName("sit_lab_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StpSubtipoPruebas>(entity =>
            {
                entity.HasKey(e => e.StpId);

                entity.ToTable("STP_SUBTIPO_PRUEBAS");

                entity.Property(e => e.StpId).HasColumnName("STP_ID");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.StpDescripcion)
                    .IsRequired()
                    .HasColumnName("STP_DESCRIPCION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TipId).HasColumnName("TIP_ID");
            });

            modelBuilder.Entity<TarTarifa>(entity =>
            {
                entity.HasKey(e => e.TarId);

                entity.ToTable("TAR_TARIFA");

                entity.Property(e => e.TarId).HasColumnName("TAR_ID");

                entity.Property(e => e.TarActivo).HasColumnName("TAR_ACTIVO");

                entity.Property(e => e.TarRangoFin).HasColumnName("TAR_RANGO_FIN");

                entity.Property(e => e.TarRangoIni).HasColumnName("TAR_RANGO_INI");

                entity.Property(e => e.TarValor)
                    .HasColumnName("TAR_VALOR")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TarVigenciaFin)
                    .HasColumnName("TAR_VIGENCIA_FIN")
                    .HasColumnType("datetime");

                entity.Property(e => e.TarVigenciaIni)
                    .HasColumnName("TAR_VIGENCIA_INI")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TarTarifaInicial>(entity =>
            {
                entity.HasKey(e => e.TarIniId);

                entity.ToTable("TAR_TARIFA_INICIAL");

                entity.Property(e => e.TarIniId).HasColumnName("TAR_INI_ID");

                entity.Property(e => e.TarIniConcepto)
                    .IsRequired()
                    .HasColumnName("TAR_INI_CONCEPTO")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TarIniPrfId).HasColumnName("TAR_INI_PRF_ID");

                entity.Property(e => e.TarIniValor)
                    .HasColumnName("TAR_INI_VALOR")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.ValorCuota)
                    .HasColumnName("VALOR_CUOTA")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<TblIngresoDemandante>(entity =>
            {
                entity.HasKey(e => e.IdIngreso)
                    .HasName("PK__tblIngre__FF8BE996BBA6001B");

                entity.ToTable("tblIngresoDemandante");

                entity.Property(e => e.IdIngreso).HasColumnName("id_Ingreso");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");
            });

            modelBuilder.Entity<TblIngresoOferente>(entity =>
            {
                entity.HasKey(e => e.IdIngreso)
                    .HasName("PK__tblIngre__FF8BE996BB0E7E28");

                entity.ToTable("tblIngresoOferente");

                entity.Property(e => e.IdIngreso).HasColumnName("id_Ingreso");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");
            });

            modelBuilder.Entity<TblIngresoPrestador>(entity =>
            {
                entity.HasKey(e => e.IdIngreso)
                    .HasName("PK__tblIngre__FF8BE996F5BAF539");

                entity.ToTable("tblIngresoPrestador");

                entity.Property(e => e.IdIngreso).HasColumnName("id_Ingreso");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");
            });

            modelBuilder.Entity<TblIngresoUnidad>(entity =>
            {
                entity.HasKey(e => e.IdIngreso)
                    .HasName("PK__tblIngre__FF8BE996CBE66AB5");

                entity.ToTable("tblIngresoUnidad");

                entity.Property(e => e.IdIngreso).HasColumnName("id_Ingreso");

                entity.Property(e => e.FechaIngreso)
                    .HasColumnName("fecha_ingreso")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");
            });

            modelBuilder.Entity<TipTipoPruebas>(entity =>
            {
                entity.HasKey(e => e.TipId);

                entity.ToTable("TIP_TIPO_PRUEBAS");

                entity.Property(e => e.TipId).HasColumnName("TIP_ID");

                entity.Property(e => e.IdAgencia).HasColumnName("id_agencia");

                entity.Property(e => e.TipDescripcion)
                    .IsRequired()
                    .HasColumnName("TIP_DESCRIPCION")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoCertificacion>(entity =>
            {
                entity.HasKey(e => e.IdTipoCertificado);

                entity.Property(e => e.NombreTipoCertificado)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoCorreos>(entity =>
            {
                entity.HasKey(e => e.IdTipocorreo);

                entity.ToTable("tipo_correos");

                entity.Property(e => e.IdTipocorreo)
                    .HasColumnName("id_tipocorreo")
                    .ValueGeneratedNever();

                entity.Property(e => e.Asunto)
                    .HasColumnName("asunto")
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoDocumento>(entity =>
            {
                entity.HasKey(e => e.CodTipoDocumento);

                entity.ToTable("tipo_documento");

                entity.Property(e => e.CodTipoDocumento)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.NombreTipoDocumento).HasMaxLength(50);
            });

            modelBuilder.Entity<TipoExperienciaLaboral>(entity =>
            {
                entity.HasKey(e => e.IdTipoExperienciaLaboral);

                entity.Property(e => e.NombreTipoExperienciaLaboral)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoJornadaLab>(entity =>
            {
                entity.HasKey(e => e.IdJornada);

                entity.ToTable("Tipo_jornada_lab");

                entity.Property(e => e.IdJornada).HasColumnName("id_jornada");

                entity.Property(e => e.Jornada)
                    .IsRequired()
                    .HasColumnName("jornada")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoLocalizacion>(entity =>
            {
                entity.ToTable("Tipo_localizacion");

                entity.Property(e => e.TipoLocalizacion1)
                    .IsRequired()
                    .HasColumnName("TipoLocalizacion")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TipoPermiso>(entity =>
            {
                entity.HasKey(e => e.IdTipoPermiso);

                entity.ToTable("Tipo_permiso");

                entity.Property(e => e.IdTipoPermiso)
                    .HasColumnName("id_tipo_permiso")
                    .ValueGeneratedNever();

                entity.Property(e => e.NombrePermiso)
                    .IsRequired()
                    .HasColumnName("Nombre_permiso")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoPoblacionXProcesoYSede>(entity =>
            {
                entity.ToTable("TipoPoblacion_x_proceso_y_sede");

                entity.HasIndex(e => new { e.ProcesoId, e.SedeId, e.TipoPoblacion })
                    .HasName("IX_TipoPoblacion_x_proceso_y_sede_TipoPoblacion");

                entity.Property(e => e.ProcesoId).HasColumnName("Proceso_id");

                entity.Property(e => e.SedeId).HasColumnName("Sede_id");
            });

            modelBuilder.Entity<TipoPunto>(entity =>
            {
                entity.HasKey(e => e.TipoPunto1);

                entity.ToTable("tipo_punto");

                entity.Property(e => e.TipoPunto1)
                    .HasColumnName("tipo_punto")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.NombreTipo)
                    .IsRequired()
                    .HasColumnName("nombre_tipo")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoRemu>(entity =>
            {
                entity.HasKey(e => e.RemuTipoId);

                entity.ToTable("Tipo_remu");

                entity.Property(e => e.RemuTipoId)
                    .HasColumnName("remu_tipo_id")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Titulos>(entity =>
            {
                entity.HasKey(e => e.TituId);

                entity.HasIndex(e => new { e.TituId, e.Nombre, e.EstuNivelId, e.IdNucleoConoc })
                    .HasName("IX_Titulos_estu_nivel_id_IdNucleoConoc");

                entity.HasIndex(e => new { e.TituId, e.Nombre, e.IdNucleoConoc, e.EstuNivelId })
                    .HasName("IX_Titulos_estu_nivel_id");

                entity.Property(e => e.TituId)
                    .HasColumnName("titu_id")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.EstuNivelId)
                    .HasColumnName("estu_nivel_id")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.IdNucleoConoc).HasMaxLength(5);

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(320);

                entity.HasOne(d => d.EstuNivel)
                    .WithMany(p => p.Titulos)
                    .HasForeignKey(d => d.EstuNivelId)
                    .HasConstraintName("FK_Titulos_Estu_nivel");
            });

            modelBuilder.Entity<TitulosPaisRela>(entity =>
            {
                entity.HasKey(e => new { e.TituId, e.PaisId });

                entity.ToTable("Titulos_pais_rela");

                entity.Property(e => e.TituId)
                    .HasColumnName("titu_id")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.TitulosPaisRela)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Titulos_pais_rela_Paises_Home");
            });

            modelBuilder.Entity<TmpBuscarTrabajo>(entity =>
            {
                entity.HasKey(e => e.BuscarTrabajoId)
                    .HasName("PK_buscar_trabajo_id");

                entity.ToTable("tmp_buscar_trabajo");

                entity.Property(e => e.BuscarTrabajoId).HasColumnName("buscar_trabajo_id");

                entity.Property(e => e.NombreOferta)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TextoOferta)
                    .IsRequired()
                    .HasColumnName("textoOferta")
                    .HasMaxLength(400);
            });

            modelBuilder.Entity<TpdTipoDocumento>(entity =>
            {
                entity.HasKey(e => e.TpdId);

                entity.ToTable("TPD_TIPO_DOCUMENTO");

                entity.Property(e => e.TpdId).HasColumnName("TPD_ID");

                entity.Property(e => e.TpdNombre)
                    .IsRequired()
                    .HasColumnName("TPD_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TpeTipoPeriodoInd>(entity =>
            {
                entity.HasKey(e => e.TpeId)
                    .HasName("PK__TPE_TIPO__8DD42CBDBAEAEB03");

                entity.ToTable("TPE_TIPO_PERIODO_IND");

                entity.Property(e => e.TpeId)
                    .HasColumnName("TPE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.TpeNombre)
                    .IsRequired()
                    .HasColumnName("TPE_NOMBRE")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TpmTipoModulo>(entity =>
            {
                entity.HasKey(e => e.TpmId);

                entity.ToTable("TPM_TIPO_MODULO");

                entity.Property(e => e.TpmId).HasColumnName("TPM_ID");

                entity.Property(e => e.TpmNombre)
                    .IsRequired()
                    .HasColumnName("TPM_NOMBRE")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TpsTipoSolicitud>(entity =>
            {
                entity.HasKey(e => e.TpsId);

                entity.ToTable("TPS_TIPO_SOLICITUD");

                entity.Property(e => e.TpsId).HasColumnName("TPS_ID");

                entity.Property(e => e.TpsCodigo)
                    .IsRequired()
                    .HasColumnName("TPS_CODIGO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TpsNombre)
                    .IsRequired()
                    .HasColumnName("TPS_NOMBRE")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrazaColocados20190312>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__Traza_co__AAAC09D8BBE90A61");

                entity.ToTable("Traza_colocados_20190312", "auditoria");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasColumnName("NTUserName")
                    .HasMaxLength(128);

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<TrazaLog20190312>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__traza_lo__AAAC09D8CA8B0B8C");

                entity.ToTable("traza_log_20190312", "auditoria");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasColumnName("NTUserName")
                    .HasMaxLength(128);

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<TrazaMarchingVacante20190507>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__TrazaMar__AAAC09D8EFEF2BD2");

                entity.ToTable("TrazaMarching_vacante20190507");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasColumnName("NTUserName")
                    .HasMaxLength(128);

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<TrazaMatchingHidro09012019tarde>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__Traza_ma__AAAC09D8502BC999");

                entity.ToTable("Traza_matching_hidro_09012019Tarde");

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<TrazaMatchingHidro28012019>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__TrazaMat__AAAC09D898FA2392");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasColumnName("NTUserName")
                    .HasMaxLength(128);

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<TrazaMatchingHidroCompleta846am>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__TrazaMat__AAAC09D8C3969B2D");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasColumnName("NTUserName")
                    .HasMaxLength(128);

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<TrazaMatchingHidroCompleta903am>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__TrazaMat__AAAC09D87DDDDB1A");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasColumnName("NTUserName")
                    .HasMaxLength(128);

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<TrazaMatchingVacanteHidro20190109>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__Traza_ma__AAAC09D8317958D5");

                entity.ToTable("Traza_matching_vacante_hidro20190109");

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<TrazaObtenerDetalleHis20190312>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__Traza_ob__AAAC09D845BE7E0A");

                entity.ToTable("Traza_obtener_detalleHis_20190312", "auditoria");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasColumnName("NTUserName")
                    .HasMaxLength(128);

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<TrazaPostulacionesInsert20190312>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__Traza_po__AAAC09D8C427EE12");

                entity.ToTable("Traza_postulaciones_insert_20190312", "auditoria");

                entity.Property(e => e.ApplicationName).HasMaxLength(128);

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.ClientProcessId).HasColumnName("ClientProcessID");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.NtuserName)
                    .HasColumnName("NTUserName")
                    .HasMaxLength(128);

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<Trazadeadlocks20190507>(entity =>
            {
                entity.HasKey(e => e.RowNumber)
                    .HasName("PK__Trazadea__AAAC09D83C91378C");

                entity.Property(e => e.BinaryData).HasColumnType("image");

                entity.Property(e => e.LoginName).HasMaxLength(128);

                entity.Property(e => e.Spid).HasColumnName("SPID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TextData).HasColumnType("ntext");
            });

            modelBuilder.Entity<TscTipoServicioContratado>(entity =>
            {
                entity.HasKey(e => e.TscId);

                entity.ToTable("TSC_TIPO_SERVICIO_CONTRATADO");

                entity.Property(e => e.TscId).HasColumnName("TSC_ID");

                entity.Property(e => e.TscNombre)
                    .IsRequired()
                    .HasColumnName("TSC_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UpeUsuarioPruebasEval>(entity =>
            {
                entity.HasKey(e => e.UpeId)
                    .HasName("PK__UPE_USUA__40A486E7E432ADC4");

                entity.ToTable("UPE_USUARIO_PRUEBAS_EVAL");

                entity.Property(e => e.UpeId).HasColumnName("UPE_ID");

                entity.Property(e => e.FechaEval)
                    .HasColumnName("FECHA_EVAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.Observacion)
                    .IsRequired()
                    .HasColumnName("OBSERVACION")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PersoIdAgente).HasColumnName("perso_id_agente");

                entity.Property(e => e.UprId).HasColumnName("UPR_ID");

                entity.HasOne(d => d.PersoIdAgenteNavigation)
                    .WithMany(p => p.UpeUsuarioPruebasEval)
                    .HasForeignKey(d => d.PersoIdAgente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personas_agencia_USUARIO_PRUEBAS_EVAL");

                entity.HasOne(d => d.Upr)
                    .WithMany(p => p.UpeUsuarioPruebasEval)
                    .HasForeignKey(d => d.UprId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USUARIO_PRUEBAS_USUARIO_PRUEBAS_EVAL");
            });

            modelBuilder.Entity<UppUsuarioPruebasProceso>(entity =>
            {
                entity.HasKey(e => e.UppId)
                    .HasName("PK__UPP_USUA__EA446A78B57B8A5E");

                entity.ToTable("UPP_USUARIO_PRUEBAS_PROCESO");

                entity.Property(e => e.UppId).HasColumnName("UPP_ID");

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasColumnName("ESTADO")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PosId).HasColumnName("POS_ID");

                entity.Property(e => e.PprId).HasColumnName("PPR_ID");

                entity.Property(e => e.UpeId).HasColumnName("UPE_ID");

                entity.HasOne(d => d.Pos)
                    .WithMany(p => p.UppUsuarioPruebasProceso)
                    .HasForeignKey(d => d.PosId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ACP_ADMIN_CAND_POST_UPP_USUARIO_PRUEBAS_PROCESO");

                entity.HasOne(d => d.Ppr)
                    .WithMany(p => p.UppUsuarioPruebasProceso)
                    .HasForeignKey(d => d.PprId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ppr_pruebas_x_proceso_UPP_USUARIO_PRUEBAS_PROCESO");

                entity.HasOne(d => d.Upe)
                    .WithMany(p => p.UppUsuarioPruebasProceso)
                    .HasForeignKey(d => d.UpeId)
                    .HasConstraintName("FK_UPP_USUARIO_PRUEBAS_PROCESO_UPE_USUARIO_PRUEBAS_EVAL");
            });

            modelBuilder.Entity<UprUsuarioPruebas>(entity =>
            {
                entity.HasKey(e => e.UprId)
                    .HasName("PK__UPR_USUA__1BC260369EB5B3BD");

                entity.ToTable("UPR_USUARIO_PRUEBAS");

                entity.Property(e => e.UprId).HasColumnName("UPR_ID");

                entity.Property(e => e.PersoId).HasColumnName("perso_id");

                entity.Property(e => e.PrpId).HasColumnName("PRP_ID");

                entity.HasOne(d => d.Perso)
                    .WithMany(p => p.UprUsuarioPruebas)
                    .HasForeignKey(d => d.PersoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Personas_UPR_USUARIO_PRUEBAS");

                entity.HasOne(d => d.Prp)
                    .WithMany(p => p.UprUsuarioPruebas)
                    .HasForeignKey(d => d.PrpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PRP_PRUEBAS_PROCESOS_UPR_USUARIO_PRUEBAS");
            });

            modelBuilder.Entity<UsrUsuario>(entity =>
            {
                entity.HasKey(e => e.UsrId);

                entity.ToTable("USR_USUARIO");

                entity.Property(e => e.UsrId)
                    .HasColumnName("USR_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CiudadId)
                    .IsRequired()
                    .HasColumnName("CIUDAD_ID")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .IsRequired()
                    .HasColumnName("DEPARTAMENTO_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DocuTipoId)
                    .IsRequired()
                    .HasColumnName("DOCU_TIPO_ID")
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.EntId).HasColumnName("ENT_ID");

                entity.Property(e => e.MotivoCierre).HasColumnName("MOTIVO_CIERRE");

                entity.Property(e => e.OtroMotivo)
                    .HasColumnName("OTRO_MOTIVO")
                    .HasMaxLength(320);

                entity.Property(e => e.PaisId)
                    .IsRequired()
                    .HasColumnName("PAIS_ID")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.RolId).HasColumnName("ROL_ID");

                entity.Property(e => e.SeguPreguId).HasColumnName("SEGU_PREGU_ID");

                entity.Property(e => e.TpmId).HasColumnName("TPM_ID");

                entity.Property(e => e.UsrApellido)
                    .IsRequired()
                    .HasColumnName("USR_APELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsrCedula)
                    .IsRequired()
                    .HasColumnName("USR_CEDULA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsrCelular)
                    .HasColumnName("USR_CELULAR")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsrDireccion)
                    .HasColumnName("USR_DIRECCION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsrEmail)
                    .HasColumnName("USR_EMAIL")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsrEstado).HasColumnName("USR_ESTADO");

                entity.Property(e => e.UsrGenero)
                    .HasColumnName("USR_GENERO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UsrIsLogon).HasColumnName("USR_IS_LOGON");

                entity.Property(e => e.UsrNaciFecha)
                    .HasColumnName("USR_NACI_FECHA")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsrNombre)
                    .IsRequired()
                    .HasColumnName("USR_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsrPassword)
                    .IsRequired()
                    .HasColumnName("USR_PASSWORD")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsrSeguResp)
                    .HasColumnName("USR_SEGU_RESP")
                    .HasMaxLength(320);

                entity.Property(e => e.UsrSessiones).HasColumnName("USR_SESSIONES");

                entity.Property(e => e.UsrTelefono)
                    .HasColumnName("USR_TELEFONO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DocuTipo)
                    .WithMany(p => p.UsrUsuario)
                    .HasForeignKey(d => d.DocuTipoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USR_USUARIO_tipo_documento");

                entity.HasOne(d => d.Pais)
                    .WithMany(p => p.UsrUsuario)
                    .HasForeignKey(d => d.PaisId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USR_USUARIO_Paises");

                entity.HasOne(d => d.SeguPregu)
                    .WithMany(p => p.UsrUsuario)
                    .HasForeignKey(d => d.SeguPreguId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USR_USUARIO_PreguntaSeguridad");

                entity.HasOne(d => d.Tpm)
                    .WithMany(p => p.UsrUsuario)
                    .HasForeignKey(d => d.TpmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USR_USUARIO_TPM_TIPO_MODULO");

                entity.HasOne(d => d.Departamentos)
                    .WithMany(p => p.UsrUsuario)
                    .HasForeignKey(d => new { d.PaisId, d.DepartamentoId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USR_USUARIO_Departamentos");

                entity.HasOne(d => d.Ciudades)
                    .WithMany(p => p.UsrUsuario)
                    .HasForeignKey(d => new { d.PaisId, d.DepartamentoId, d.CiudadId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_USR_USUARIO_Ciudades");
            });

            modelBuilder.Entity<UsuarioCierreCuenta>(entity =>
            {
                entity.ToTable("usuario_cierre_cuenta");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FechaCierre)
                    .HasColumnName("fecha_cierre")
                    .HasColumnType("datetime");

                entity.Property(e => e.MotivoCierreId).HasColumnName("motivo_cierre_id");

                entity.Property(e => e.OtroMotivo)
                    .HasColumnName("otro_motivo")
                    .HasMaxLength(320)
                    .IsUnicode(false);

                entity.Property(e => e.PersoId).HasColumnName("perso_id");
            });

            modelBuilder.Entity<UsuariosCall>(entity =>
            {
                entity.HasKey(e => e.Email);

                entity.ToTable("usuarios_call");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Veredas>(entity =>
            {
                entity.HasKey(e => new { e.PaisId, e.DepartamentoId, e.CiudadId, e.VeredaId });

                entity.Property(e => e.PaisId)
                    .HasColumnName("pais_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.DepartamentoId)
                    .HasColumnName("departamento_id")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.CiudadId)
                    .HasColumnName("ciudad_id")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VeredaId)
                    .HasColumnName("vereda_id")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.NombreVereda)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ciudades)
                    .WithMany(p => p.Veredas)
                    .HasForeignKey(d => new { d.PaisId, d.DepartamentoId, d.CiudadId })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Veredas_Ciudades");
            });

            modelBuilder.Entity<VlcValorCatalogo>(entity =>
            {
                entity.HasKey(e => e.VlcId);

                entity.ToTable("VLC_VALOR_CATALOGO");

                entity.Property(e => e.VlcId).HasColumnName("VLC_ID");

                entity.Property(e => e.CtgId).HasColumnName("CTG_ID");

                entity.Property(e => e.VlcNombre)
                    .IsRequired()
                    .HasColumnName("VLC_NOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Ctg)
                    .WithMany(p => p.VlcValorCatalogo)
                    .HasForeignKey(d => d.CtgId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VLC_VALOR_CATALOGO_CTG_CATALOGOS");
            });

            modelBuilder.HasSequence<int>("seq_personas")
                .StartsAt(21063706)
                .HasMin(21063706);

            modelBuilder.HasSequence<int>("perso_id")
                .StartsAt(20000000)
                .HasMin(1)
                .HasMax(40000000)
                .IsCyclic();
        }
    }
}
