using System.Collections.Generic;

namespace DATABASE_MODELS.Models
{
    public partial class FfvFosfecVersiones
    {
        public FfvFosfecVersiones()
        {
            FfdFosfecDetalleVersion = new HashSet<FfdFosfecDetalleVersion>();
        }

        public int FfvId { get; set; }
        public int FfvAnio { get; set; }
        public int FfvMes { get; set; }
        public string FfvVersion { get; set; }
        public bool FfvHistorico { get; set; }

        public virtual ICollection<FfdFosfecDetalleVersion> FfdFosfecDetalleVersion { get; set; }
    }
}
