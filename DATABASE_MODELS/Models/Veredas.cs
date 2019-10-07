namespace DATABASE_MODELS.Models
{
    public partial class Veredas
    {
        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public string VeredaId { get; set; }
        public string NombreVereda { get; set; }

        public virtual Ciudades Ciudades { get; set; }
    }
}
