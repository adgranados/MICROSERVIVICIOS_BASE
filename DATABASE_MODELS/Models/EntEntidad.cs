using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class EntEntidad
    {
        public EntEntidad()
        {
            Agencia = new HashSet<Agencia>();
            CnvConvenio = new HashSet<CnvConvenio>();
            HistIndicaTotales = new HashSet<HistIndicaTotales>();
            HistIndicaTotalesOferentes = new HashSet<HistIndicaTotalesOferentes>();
            HistIndicaTotalesRemitidos = new HashSet<HistIndicaTotalesRemitidos>();
            HistIndicador40Mil = new HashSet<HistIndicador40Mil>();
            HistIndicadorDiscap = new HashSet<HistIndicadorDiscap>();
            HistIndicadorVictima = new HashSet<HistIndicadorVictima>();
        }

        public int EntId { get; set; }
        public string EntNombre { get; set; }
        public string EntNit { get; set; }
        public string EntSigla { get; set; }
        public string EntNombreContacto { get; set; }
        public string EntApellidoContacto { get; set; }
        public string TipoDocuId { get; set; }
        public string EntNumDocu { get; set; }
        public string EntTelContacto { get; set; }
        public string EntCorreoContacto { get; set; }
        public string CargoContactoId { get; set; }
        public string EntFax { get; set; }
        public string EntLogo { get; set; }
        public string EntBanner { get; set; }
        public string EntPaisId { get; set; }
        public string EntDepId { get; set; }
        public string EntCiuId { get; set; }
        public int EntIndId { get; set; }
        public int EntSectorId { get; set; }
        public string EntUrlweb { get; set; }
        public string EntDirContacto { get; set; }
        public string EntRazonSocial { get; set; }
        public bool? EntActivo { get; set; }
        public string EmpreCampoId { get; set; }
        public int? EntActId { get; set; }
        public string EntEmailEnvi { get; set; }
        public string EntClaveMail { get; set; }
        public string EntServidorDominio { get; set; }
        public string EntPuerto { get; set; }
        public string EntResolucion { get; set; }
        public string EntCodigo { get; set; }
        public bool? EntPub { get; set; }
        public DateTime? EntFechaReg { get; set; }
        public string EntTipo { get; set; }
        public int? EntClase { get; set; }
        public string EntCodigoAlterno { get; set; }
        public string EntModalidad { get; set; }
        public string InstiNombre { get; set; }
        public string Imagenbase64 { get; set; }

        public virtual ClasePrestador EntClaseNavigation { get; set; }
        public virtual ICollection<Agencia> Agencia { get; set; }
        public virtual ICollection<CnvConvenio> CnvConvenio { get; set; }
        public virtual ICollection<HistIndicaTotales> HistIndicaTotales { get; set; }
        public virtual ICollection<HistIndicaTotalesOferentes> HistIndicaTotalesOferentes { get; set; }
        public virtual ICollection<HistIndicaTotalesRemitidos> HistIndicaTotalesRemitidos { get; set; }
        public virtual ICollection<HistIndicador40Mil> HistIndicador40Mil { get; set; }
        public virtual ICollection<HistIndicadorDiscap> HistIndicadorDiscap { get; set; }
        public virtual ICollection<HistIndicadorVictima> HistIndicadorVictima { get; set; }
    }
}
