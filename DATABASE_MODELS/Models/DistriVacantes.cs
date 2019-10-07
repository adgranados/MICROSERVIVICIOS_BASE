namespace DATABASE_MODELS.Models
{
    public partial class DistriVacantes
    {
        public int DistribucionId { get; set; }
        public int ProcesoId { get; set; }
        public int SedeId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public int? PuestoDept { get; set; }
        public int? PuestoCiu { get; set; }
        public int? AgenciaIdVal { get; set; }
        public int? AgenciaIdAlt { get; set; }
        public string PublicacionCodigo { get; set; }
        public bool? Flag { get; set; }
        public bool EsDepartamental { get; set; }
        public bool? Todos { get; set; }

        public virtual Agencia AgenciaIdValNavigation { get; set; }
        public virtual Procesos Procesos { get; set; }
        public virtual Sedes Sede { get; set; }
    }
}
