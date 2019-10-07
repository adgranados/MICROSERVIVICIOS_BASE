namespace DATABASE_MODELS.Models
{
    public partial class AgenciaInterOrga
    {
        public int IdAgenciaInteroga { get; set; }
        public int IdAgencia { get; set; }
        public int InterOrgaId { get; set; }
        public bool? EsPrincipal { get; set; }

        public virtual Agencia IdAgenciaNavigation { get; set; }
        public virtual InterOrga InterOrga { get; set; }
    }
}
