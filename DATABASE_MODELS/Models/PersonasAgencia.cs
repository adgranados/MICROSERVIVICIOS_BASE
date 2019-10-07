using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class PersonasAgencia
    {
        public PersonasAgencia()
        {
            EvaEvaluacion = new HashSet<EvaEvaluacion>();
            FfaFosfecCriteriosAudit = new HashSet<FfaFosfecCriteriosAudit>();
            InsInscripciones = new HashSet<InsInscripciones>();
            NfpNotificacionesProcesos = new HashSet<NfpNotificacionesProcesos>();
            NfrNotificacionesRegistro = new HashSet<NfrNotificacionesRegistro>();
            NfvNotificacionesVacantes = new HashSet<NfvNotificacionesVacantes>();
            PersonaBeneficiarioSubsidio = new HashSet<PersonaBeneficiarioSubsidio>();
            PersonaBeneficiarioSubsidioHist = new HashSet<PersonaBeneficiarioSubsidioHist>();
            ProcesosCertificacionesHidroAgenteIdCertificadoDeptalNavigation = new HashSet<ProcesosCertificacionesHidro>();
            ProcesosCertificacionesHidroAgenteIdCertificadoNalNavigation = new HashSet<ProcesosCertificacionesHidro>();
            UpeUsuarioPruebasEval = new HashSet<UpeUsuarioPruebasEval>();
        }

        public int PersoId { get; set; }
        public string Ape { get; set; }
        public string Nombre { get; set; }
        public string DocuTipoId { get; set; }
        public string DocuNro { get; set; }
        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public string EmpreAreaId { get; set; }
        public string CargoId { get; set; }
        public string Telefono { get; set; }
        public string TelefonoCelular { get; set; }
        public string Sexo { get; set; }

        public virtual ICollection<EvaEvaluacion> EvaEvaluacion { get; set; }
        public virtual ICollection<FfaFosfecCriteriosAudit> FfaFosfecCriteriosAudit { get; set; }
        public virtual ICollection<InsInscripciones> InsInscripciones { get; set; }
        public virtual ICollection<NfpNotificacionesProcesos> NfpNotificacionesProcesos { get; set; }
        public virtual ICollection<NfrNotificacionesRegistro> NfrNotificacionesRegistro { get; set; }
        public virtual ICollection<NfvNotificacionesVacantes> NfvNotificacionesVacantes { get; set; }
        public virtual ICollection<PersonaBeneficiarioSubsidio> PersonaBeneficiarioSubsidio { get; set; }
        public virtual ICollection<PersonaBeneficiarioSubsidioHist> PersonaBeneficiarioSubsidioHist { get; set; }
        public virtual ICollection<ProcesosCertificacionesHidro> ProcesosCertificacionesHidroAgenteIdCertificadoDeptalNavigation { get; set; }
        public virtual ICollection<ProcesosCertificacionesHidro> ProcesosCertificacionesHidroAgenteIdCertificadoNalNavigation { get; set; }
        public virtual ICollection<UpeUsuarioPruebasEval> UpeUsuarioPruebasEval { get; set; }
    }
}
