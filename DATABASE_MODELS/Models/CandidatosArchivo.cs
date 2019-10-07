using System;

namespace DATABASE_MODELS.Models
{
    public partial class CandidatosArchivo
    {
        public int ArchiId { get; set; }
        public int InterOrgaId { get; set; }
        public int ProcesoId { get; set; }
        public int PersoId { get; set; }
        public int PersoEmpresaId { get; set; }
        public int IdEtapaProceso { get; set; }
        public string TituloArchivo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? Fecha { get; set; }
        public string Archivo { get; set; }

        public virtual EtapaProceso IdEtapaProcesoNavigation { get; set; }
        public virtual Personas Perso { get; set; }
        public virtual Procesos Procesos { get; set; }
    }
}
