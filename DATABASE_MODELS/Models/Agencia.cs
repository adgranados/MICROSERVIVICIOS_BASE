using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class Agencia
    {
        public Agencia()
        {
            AgenciaInterOrga = new HashSet<AgenciaInterOrga>();
            CtaCursosTalleres = new HashSet<CtaCursosTalleres>();
            DireccionParametrizada = new HashSet<DireccionParametrizada>();
            DistriVacantes = new HashSet<DistriVacantes>();
            HistIndicaTotales = new HashSet<HistIndicaTotales>();
            HistIndicaTotalesOferentes = new HashSet<HistIndicaTotalesOferentes>();
            HistIndicaTotalesRemitidos = new HashSet<HistIndicaTotalesRemitidos>();
            HistIndicador40Mil = new HashSet<HistIndicador40Mil>();
            HistIndicadorDiscap = new HashSet<HistIndicadorDiscap>();
            HistIndicadorVictima = new HashSet<HistIndicadorVictima>();
            PersonaBeneficiarioSubsidio = new HashSet<PersonaBeneficiarioSubsidio>();
            PersonaBeneficiarioSubsidioHist = new HashSet<PersonaBeneficiarioSubsidioHist>();
            SedesAgencia = new HashSet<SedesAgencia>();
        }

        public int IdAgencia { get; set; }
        public string NombreAgencia { get; set; }
        public string CodigoAgencia { get; set; }
        public string AgeDireccion { get; set; }
        public string AgeTel { get; set; }
        public string AgeTel2 { get; set; }
        public string AgeFax { get; set; }
        public bool? AgeActivo { get; set; }
        public string AgePaisId { get; set; }
        public string AgeDepId { get; set; }
        public string AgeCiuId { get; set; }
        public int AgeEntId { get; set; }
        public bool? AgenPublica { get; set; }
        public string AgenTipo { get; set; }
        public DateTime? AgeFechaReg { get; set; }
        public DateTime? AgeFechaAct { get; set; }

        public virtual Departamentos Age { get; set; }
        public virtual EntEntidad AgeEnt { get; set; }
        public virtual Ciudades AgeNavigation { get; set; }
        public virtual Paises AgePais { get; set; }
        public virtual ICollection<AgenciaInterOrga> AgenciaInterOrga { get; set; }
        public virtual ICollection<CtaCursosTalleres> CtaCursosTalleres { get; set; }
        public virtual ICollection<DireccionParametrizada> DireccionParametrizada { get; set; }
        public virtual ICollection<DistriVacantes> DistriVacantes { get; set; }
        public virtual ICollection<HistIndicaTotales> HistIndicaTotales { get; set; }
        public virtual ICollection<HistIndicaTotalesOferentes> HistIndicaTotalesOferentes { get; set; }
        public virtual ICollection<HistIndicaTotalesRemitidos> HistIndicaTotalesRemitidos { get; set; }
        public virtual ICollection<HistIndicador40Mil> HistIndicador40Mil { get; set; }
        public virtual ICollection<HistIndicadorDiscap> HistIndicadorDiscap { get; set; }
        public virtual ICollection<HistIndicadorVictima> HistIndicadorVictima { get; set; }
        public virtual ICollection<PersonaBeneficiarioSubsidio> PersonaBeneficiarioSubsidio { get; set; }
        public virtual ICollection<PersonaBeneficiarioSubsidioHist> PersonaBeneficiarioSubsidioHist { get; set; }
        public virtual ICollection<SedesAgencia> SedesAgencia { get; set; }
    }
}
