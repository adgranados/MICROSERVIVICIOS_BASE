using System;

namespace DATABASE_MODELS.Models
{
    public partial class DireccionParametrizadaArchivo
    {
        public int? PersoId { get; set; }
        public int? IdSede { get; set; }
        public int? IdAgencia { get; set; }
        public int Id { get; set; }
        public string ViaPrincipalNombre { get; set; }
        public string ViaPrincipalAbreviatura { get; set; }
        public string ViaPrincipalValor { get; set; }
        public string ViaPrincipalPrimeraLetra { get; set; }
        public string ViaPrincipalBis { get; set; }
        public string ViaPrincipalSegundaLetra { get; set; }
        public string ViaPrincipalCuadrante { get; set; }
        public string ViaGeneradoraValor { get; set; }
        public string ViaGeneradoraLetra { get; set; }
        public string ViaGeneradoraPlaca { get; set; }
        public string ViaGeneradoraCuadrante { get; set; }
        public string ComplementoDireccion { get; set; }
        public int? CodigoPostal { get; set; }
        public DateTime? FechaUltimaActualizacion { get; set; }
    }
}
