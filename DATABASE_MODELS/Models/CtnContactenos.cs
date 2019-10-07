namespace DATABASE_MODELS.Models
{
    public partial class CtnContactenos
    {
        public int CtnId { get; set; }
        public string CtnNombre { get; set; }
        public string CtnEmail { get; set; }
        public string CtnTelefono { get; set; }
        public string CtnNIdentificacion { get; set; }
        public string CtnMensaje { get; set; }
        public int TpsId { get; set; }

        public virtual TpsTipoSolicitud Tps { get; set; }
    }
}
