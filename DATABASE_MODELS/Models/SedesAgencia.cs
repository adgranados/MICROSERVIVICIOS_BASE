namespace DATABASE_MODELS.Models
{
    public partial class SedesAgencia
    {
        public int IdSedesAgencia { get; set; }
        public int IdSede { get; set; }
        public int IdAgencia { get; set; }
        public bool? EsPrincipal { get; set; }

        public virtual Agencia IdAgenciaNavigation { get; set; }
        public virtual Sedes IdSedeNavigation { get; set; }
    }
}
