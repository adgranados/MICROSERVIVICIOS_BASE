using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class InterOrga
    {
        public InterOrga()
        {
            AgenciaInterOrga = new HashSet<AgenciaInterOrga>();
            ConsulPerso = new HashSet<ConsulPerso>();
            NfrNotificacionesRegistro = new HashSet<NfrNotificacionesRegistro>();
            ProcesosInterOrgaSedes = new HashSet<ProcesosInterOrgaSedes>();
            ProduInterOrga = new HashSet<ProduInterOrga>();
            Sedes = new HashSet<Sedes>();
        }

        public int InterOrgaId { get; set; }
        public string Logo { get; set; }
        public string Nombre { get; set; }
        public string RazonSocial { get; set; }
        public string Descripcion { get; set; }
        public string TipoDocuId { get; set; }
        public string Nit { get; set; }
        public string SitioWeb { get; set; }
        public string Fax { get; set; }
        public int? CantEmpleados { get; set; }
        public string EmpreTipoId { get; set; }
        public int? IndId { get; set; }
        public int? SecId { get; set; }
        public int? ActId { get; set; }
        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? EntId { get; set; }
        public int? PersoIdAgencia { get; set; }
        public int? IdAgencia { get; set; }
        public bool? Bloqueada { get; set; }
        public bool? Autoregistro { get; set; }
        public DateTime? FechaActualizacion { get; set; }
        public DateTime? FechaBloqueo { get; set; }
        public int? IdNaturaleza { get; set; }

        public virtual EmpreCantiEmple CantEmpleadosNavigation { get; set; }
        public virtual EmpreTipo EmpreTipo { get; set; }
        public virtual EmpreNaturaleza IdNaturalezaNavigation { get; set; }
        public virtual TipoDocumento TipoDocu { get; set; }
        public virtual ICollection<AgenciaInterOrga> AgenciaInterOrga { get; set; }
        public virtual ICollection<ConsulPerso> ConsulPerso { get; set; }
        public virtual ICollection<NfrNotificacionesRegistro> NfrNotificacionesRegistro { get; set; }
        public virtual ICollection<ProcesosInterOrgaSedes> ProcesosInterOrgaSedes { get; set; }
        public virtual ICollection<ProduInterOrga> ProduInterOrga { get; set; }
        public virtual ICollection<Sedes> Sedes { get; set; }
    }
}
