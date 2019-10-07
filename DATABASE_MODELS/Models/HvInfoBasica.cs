using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class HvInfoBasica
    {
        public HvInfoBasica()
        {
            Adjuntos = new HashSet<Adjuntos>();
            HvEstu = new HashSet<HvEstu>();
            HvHabi = new HashSet<HvHabi>();
        }

        public int PersoId { get; set; }
        public string PerfilProf { get; set; }
        public string ViajeDispoCk { get; set; }
        public string TraslaDispoCk { get; set; }
        public string InfoProdCk { get; set; }
        public string InfoComCk { get; set; }
        public string InfoElespecCk { get; set; }
        public string InfoCaracolCk { get; set; }
        public string InfoShockCk { get; set; }
        public string InfoCromosCk { get; set; }
        public int? SalarioRangoId { get; set; }
        public string DistiPremios { get; set; }
        public string InterHobbies { get; set; }
        public DateTime? VersionActuFecha { get; set; }
        public string FotoVisiCk { get; set; }
        public int? PersoIdAsesorModif { get; set; }
        public DateTime? VersionModifFechaAsesor { get; set; }
        public string TipoPoblacion { get; set; }
        public int? SitLabId { get; set; }
        public bool? PropMedioTrans { get; set; }
        public string LicenciaMoto { get; set; }
        public string CatLicenciaMoto { get; set; }
        public DateTime? VigLicenciaMoto { get; set; }
        public string LicenciaCarro { get; set; }
        public string CatLicenciaCarroPart { get; set; }
        public DateTime? VigLicenciaCarroPart { get; set; }
        public string CatLicenciaCarroPub { get; set; }
        public DateTime? VigLicenciaCarroPub { get; set; }

        public virtual SalarioRango SalarioRango { get; set; }
        public virtual SituacionLaboral SitLab { get; set; }
        public virtual HvSeguSoc HvSeguSoc { get; set; }
        public virtual ICollection<Adjuntos> Adjuntos { get; set; }
        public virtual ICollection<HvEstu> HvEstu { get; set; }
        public virtual ICollection<HvHabi> HvHabi { get; set; }
    }
}
