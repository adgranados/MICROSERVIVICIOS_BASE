namespace DATABASE_MODELS.Models
{
    public partial class ProceUsuario
    {
        public int InterOrgaId { get; set; }
        public int ProcesoId { get; set; }
        public int PersoId { get; set; }

        public virtual SUsuariosEmpresa1 Perso { get; set; }
        public virtual Procesos Procesos { get; set; }
    }
}
