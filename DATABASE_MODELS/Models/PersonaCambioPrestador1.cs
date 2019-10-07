using System;

namespace DATABASE_MODELS.Models
{
    public partial class PersonaCambioPrestador1
    {
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public int EntidadOldId { get; set; }
        public int EntidadNewId { get; set; }
        public int AgenciaOldId { get; set; }
        public int AgenciaNewId { get; set; }
        public int MotivoId { get; set; }
        public string Tipo { get; set; }
        public DateTime Fecha { get; set; }
        public string OtroMotivo { get; set; }
    }
}
