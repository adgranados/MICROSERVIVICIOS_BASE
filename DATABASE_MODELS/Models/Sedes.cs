using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Sedes
    {
        public Sedes()
        {
            DireccionParametrizada = new HashSet<DireccionParametrizada>();
            DistriVacantes = new HashSet<DistriVacantes>();
            ProcesosCertificacionesHidro = new HashSet<ProcesosCertificacionesHidro>();
            SUsuariosEmpresa1 = new HashSet<SUsuariosEmpresa1>();
            SedesAgencia = new HashSet<SedesAgencia>();
        }

        public int IdSede { get; set; }
        public string NombreSede { get; set; }
        public string DireccionSede { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public int Estado { get; set; }
        public int InterOrgaId { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaCambioEstado { get; set; }
        public string TelefonoSede { get; set; }
        public string TipoSede { get; set; }
        public int? MotivoCierreId { get; set; }
        public string OtroMotivo { get; set; }
        public DateTime? FechaCierre { get; set; }
        public int? UsuarioCierre { get; set; }
        public DateTime? FechaUltimoAcceso { get; set; }
        public int? IdPersonaAgenciaCrea { get; set; }
        public int? IdPersonaAgenciaVali { get; set; }
        public DateTime? FechaValidacion { get; set; }
        public bool? Autoregistro { get; set; }

        public virtual EstadosSede EstadoNavigation { get; set; }
        public virtual InterOrga InterOrga { get; set; }
        public virtual MotivoCierreCta MotivoCierre { get; set; }
        public virtual ICollection<DireccionParametrizada> DireccionParametrizada { get; set; }
        public virtual ICollection<DistriVacantes> DistriVacantes { get; set; }
        public virtual ICollection<ProcesosCertificacionesHidro> ProcesosCertificacionesHidro { get; set; }
        public virtual ICollection<SUsuariosEmpresa1> SUsuariosEmpresa1 { get; set; }
        public virtual ICollection<SedesAgencia> SedesAgencia { get; set; }
    }
}
