namespace DATABASE_MODELS.Models
{
    public partial class PersonasEmpresa
    {
        public int PersoId { get; set; }
        public string Ape { get; set; }
        public string Nombre { get; set; }
        public string DocuTipoId { get; set; }
        public string DocuNro { get; set; }
        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public string EmpreAreaId { get; set; }
        public string CargoId { get; set; }
        public string Telefono { get; set; }
        public string TelefonoCelular { get; set; }
        public string CampoId { get; set; }
        public string Cargo { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }

        public virtual Cargos CargoNavigation { get; set; }
        public virtual Ciudades Ciudades { get; set; }
        public virtual TipoDocumento DocuTipo { get; set; }
        public virtual EmpreArea EmpreArea { get; set; }
        public virtual SUsuariosEmpresa1 SUsuariosEmpresa1 { get; set; }
    }
}
