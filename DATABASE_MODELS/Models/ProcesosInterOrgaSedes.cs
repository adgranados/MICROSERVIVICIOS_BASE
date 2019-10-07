namespace DATABASE_MODELS.Models
{
    public partial class ProcesosInterOrgaSedes
    {
        public int IdProcesosInterOrgaSedes { get; set; }
        public int InterOrgaId { get; set; }
        public int ProcesoId { get; set; }
        public int IdSede { get; set; }
        public int? IdAgencia { get; set; }

        public virtual InterOrga InterOrga { get; set; }
        public virtual Procesos Procesos { get; set; }
    }
}
