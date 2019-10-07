namespace DATABASE_MODELS.Models
{
    public partial class MedioImpreso
    {
        public string NitImpreso { get; set; }
        public string Nombre { get; set; }
        public string Logo { get; set; }
        public string ContactoNombre { get; set; }
        public string MailNombre { get; set; }
        public string Abreviatura { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public string PaisId { get; set; }

        public virtual Ciudades Ciudades { get; set; }
    }
}
