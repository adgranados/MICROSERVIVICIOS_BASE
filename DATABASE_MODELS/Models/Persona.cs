using System;

namespace DATABASE_MODELS.Models
{
    public partial class Persona
    {
        public int IdPersona { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public DateTime? DtNasc { get; set; }
        public string ComNasc { get; set; }
        public string PrvNasc { get; set; }
        public string StatNasc { get; set; }
        public string Sesso { get; set; }
        public string PosMil { get; set; }
        public string CodFisc { get; set; }
        public string StatCiv { get; set; }
        public string StatCit { get; set; }
        public string StatCit2 { get; set; }
        public string NomRes { get; set; }
        public string IndRes { get; set; }
        public string FrazioneRes { get; set; }
        public string ComRes { get; set; }
        public string PrvRes { get; set; }
        public string CapRes { get; set; }
        public string NumTel { get; set; }
        public string EMail { get; set; }
        public string NomDom { get; set; }
        public string IndDom { get; set; }
        public string FrazioneDom { get; set; }
        public string ComDom { get; set; }
        public string PrvDom { get; set; }
        public string CapDom { get; set; }
        public string NumTelDom { get; set; }
        public DateTime? DtUltRil { get; set; }
        public DateTime? DtTmst { get; set; }
        public int? IdSede { get; set; }
        public int? DepNasc { get; set; }
        public int? LocNasc { get; set; }
        public int? DepRes { get; set; }
        public int? LocRes { get; set; }
        public string NumTelDomObs { get; set; }
        public string SecondoNome { get; set; }
        public string SecondoCognome { get; set; }
        public int? StratoPubblico { get; set; }
        public int? TipoLibretaMilitar { get; set; }
        public byte? JefeHogar { get; set; }
        public string StatRes { get; set; }
        public string Mensaje { get; set; }
    }
}
