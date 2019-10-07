namespace DATABASE_MODELS.Models
{
    public partial class UppUsuarioPruebasProceso
    {
        public int UppId { get; set; }
        public int PprId { get; set; }
        public int PosId { get; set; }
        public string Estado { get; set; }
        public int? UpeId { get; set; }

        public virtual AcpAdminCandPost Pos { get; set; }
        public virtual PprPruebasXProceso Ppr { get; set; }
        public virtual UpeUsuarioPruebasEval Upe { get; set; }
    }
}
