namespace DATABASE_MODELS.Models
{
    public partial class ConsulPerso
    {
        public int PersoId { get; set; }
        public int InterOrgaId { get; set; }

        public virtual InterOrga InterOrga { get; set; }
        public virtual SUsuariosEmpresa1 Perso { get; set; }
    }
}
