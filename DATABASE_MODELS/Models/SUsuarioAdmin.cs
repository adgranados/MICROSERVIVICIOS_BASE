namespace DATABASE_MODELS.Models
{
    public partial class SUsuarioAdmin
    {
        public int PersoId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int? Estado { get; set; }
        public int? RolId { get; set; }
        public int? Sesiones { get; set; }
        public string Ape { get; set; }
        public string Nombres { get; set; }
        public string DocuTipoId { get; set; }
        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public string Sexo { get; set; }
        public string DocNumero { get; set; }
        public int? RolUnidad { get; set; }
        public int? Codpregunta { get; set; }
        public string Respregunta { get; set; }

        public virtual PersonasAdmin Perso { get; set; }
    }
}
