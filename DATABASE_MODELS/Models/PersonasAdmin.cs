namespace DATABASE_MODELS.Models
{
    public partial class PersonasAdmin
    {
        public int PersoId { get; set; }
        public string Ape { get; set; }
        public string Nombre { get; set; }
        public string DocuTipoId { get; set; }
        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public string EmpreAreaId { get; set; }
        public string CargoId { get; set; }
        public string Telefono { get; set; }
        public string Sexo { get; set; }

        public virtual Paises Pais { get; set; }
        public virtual SUsuarioAdmin SUsuarioAdmin { get; set; }
    }
}
