using System;

namespace DATABASE_MODELS.Models
{
    public partial class HvInfoBasicaArchivo
    {
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
        public int Id { get; set; }
    }
}
