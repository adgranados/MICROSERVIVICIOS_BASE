using System;
using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class UsrUsuario
    {
        public UsrUsuario()
        {
            RusRolUsuario = new HashSet<RusRolUsuario>();
        }

        public int UsrId { get; set; }
        public string UsrCedula { get; set; }
        public string UsrNombre { get; set; }
        public string UsrApellido { get; set; }
        public string UsrEmail { get; set; }
        public string DocuTipoId { get; set; }
        public string UsrCelular { get; set; }
        public string UsrDireccion { get; set; }
        public string UsrTelefono { get; set; }
        public string UsrGenero { get; set; }
        public DateTime? UsrNaciFecha { get; set; }
        public string UsrPassword { get; set; }
        public bool? UsrEstado { get; set; }
        public int? UsrSessiones { get; set; }
        public int RolId { get; set; }
        public int SeguPreguId { get; set; }
        public int? MotivoCierre { get; set; }
        public string OtroMotivo { get; set; }
        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public int EntId { get; set; }
        public bool UsrIsLogon { get; set; }
        public int TpmId { get; set; }
        public string UsrSeguResp { get; set; }

        public virtual Ciudades Ciudades { get; set; }
        public virtual Departamentos Departamentos { get; set; }
        public virtual TipoDocumento DocuTipo { get; set; }
        public virtual Paises Pais { get; set; }
        public virtual PreguntasSeguridad SeguPregu { get; set; }
        public virtual TpmTipoModulo Tpm { get; set; }
        public virtual ICollection<RusRolUsuario> RusRolUsuario { get; set; }
    }
}
