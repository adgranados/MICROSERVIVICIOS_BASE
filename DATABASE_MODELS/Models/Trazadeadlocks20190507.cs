using System;

namespace DATABASE_MODELS.Models
{
    public partial class Trazadeadlocks20190507
    {
        public int RowNumber { get; set; }
        public int? EventClass { get; set; }
        public string TextData { get; set; }
        public string LoginName { get; set; }
        public int? Spid { get; set; }
        public DateTime? StartTime { get; set; }
        public byte[] BinaryData { get; set; }
    }
}
