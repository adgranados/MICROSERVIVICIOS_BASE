using System;

namespace DATABASE_MODELS.Models
{
    public partial class PersonasArchivo
    {
        public int PersoId { get; set; }
        public string Ape { get; set; }
        public string Nombre { get; set; }
        public string DocuTipoId { get; set; }
        public string DocuNro { get; set; }
        public string Sexo { get; set; }
        public DateTime NaciFecha { get; set; }
        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public int? VeredaId { get; set; }
        public string PobladoId { get; set; }
        public string Direccion { get; set; }
        public string PartiTele { get; set; }
        public string CeluTele { get; set; }
        public string EmailOpc { get; set; }
        public int? EntId { get; set; }
        public bool? Cesante { get; set; }
        public string TipoContratoId { get; set; }
        public int? MesCesante { get; set; }
        public int? AnioCesante { get; set; }
        public int? IdAgencia { get; set; }
        public bool? Autoregistro { get; set; }
        public bool? RecibeSub { get; set; }
        public DateTime? FechaFinSub { get; set; }
        public string EstadoCivil { get; set; }
        public string Servicios { get; set; }
        public bool? Sinlaboexpe { get; set; }
        public string Tecnologia { get; set; }
        public bool? Sinestudios { get; set; }
        public bool? Sincursos { get; set; }
        public int? Experiencia { get; set; }
        public string UltimoCargo { get; set; }
        public string Barrio { get; set; }
        public bool? Teletrabajo { get; set; }
        public bool? Pase { get; set; }
        public int? Persoacargo { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string ContacTele { get; set; }
        public string TipoLibreta { get; set; }
        public string PaisNaci { get; set; }
        public string DepNaci { get; set; }
        public string MunNaci { get; set; }
        public string Nacionalidad { get; set; }
        public string NumLibreta { get; set; }
        public bool? JefeHogar { get; set; }
        public bool? Migrante { get; set; }
        public string UltPaisTrab { get; set; }
        public int? IdEstadoCivil { get; set; }
        public string Observaciones { get; set; }
        public int? MaxEstuOrden { get; set; }
        public string Aglomeraciones { get; set; }
        public string GruposOcupacionales { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string LocalidadId { get; set; }
        public bool? Flag { get; set; }
        public bool? HvCompleta { get; set; }
        public string IpCondiciones { get; set; }
        public DateTime? FechaCondiciones { get; set; }
        public bool? PerBolsa2Activo { get; set; }
        public bool? EsVictimaConfliArmado { get; set; }
        public DateTime? FecDeclaraVictima { get; set; }
        public int Id { get; set; }
        public string EmailPrestador { get; set; }
        public string PerteneceA { get; set; }
    }
}
