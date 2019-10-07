using System;

namespace DATABASE_MODELS.Models
{
    public partial class IndicadorDemandanteTotalesHistorico
    {
        public Guid Id { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public int IdPrestador { get; set; }
        public string NombrePrestador { get; set; }
        public int IdAgencia { get; set; }
        public string NombreAgencia { get; set; }
        public int IdIndicador1 { get; set; }
        public string Indicador1 { get; set; }
        public int Valor1 { get; set; }
        public int Total1 { get; set; }
        public int IdIndicador2 { get; set; }
        public string Indicador2 { get; set; }
        public int Valor2 { get; set; }
        public int Total2 { get; set; }
        public int IdIndicador3 { get; set; }
        public string Indicador3 { get; set; }
        public int Valor3 { get; set; }
        public int Total3 { get; set; }
        public int IdIndicador4 { get; set; }
        public string Indicador4 { get; set; }
        public int Valor4 { get; set; }
        public int Total4 { get; set; }
        public int IdIndicador5 { get; set; }
        public string Indicador5 { get; set; }
        public int Valor5 { get; set; }
        public int Total5 { get; set; }
        public int IdIndicador6 { get; set; }
        public string Indicador6 { get; set; }
        public int Valor6 { get; set; }
        public int Total6 { get; set; }
        public int IdIndicador7 { get; set; }
        public string Indicador7 { get; set; }
        public int Valor7 { get; set; }
        public int Total7 { get; set; }
        public int IdIndicador8 { get; set; }
        public string Indicador8 { get; set; }
        public int Valor8 { get; set; }
        public int Total8 { get; set; }
        public int IdIndicador9 { get; set; }
        public string Indicador9 { get; set; }
        public int Valor9 { get; set; }
        public int Total9 { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
