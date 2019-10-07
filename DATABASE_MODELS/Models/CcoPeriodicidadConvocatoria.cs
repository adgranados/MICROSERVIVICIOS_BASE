namespace DATABASE_MODELS.Models
{
    public partial class CcoPeriodicidadConvocatoria
    {
        public int CnvId { get; set; }
        public int VlcRepetirCada { get; set; }

        public virtual CnvConvocatoria Cnv { get; set; }
        public virtual VlcValorCatalogo VlcRepetirCadaNavigation { get; set; }
    }
}
