﻿using System;

namespace DATABASE_MODELS.Models
{
    public partial class HvEstuArchivo
    {
        public int PersoId { get; set; }
        public int EstuOrdi { get; set; }
        public string EstuNivelId { get; set; }
        public string TituNombre { get; set; }
        public string TituId { get; set; }
        public string TituEquiv { get; set; }
        public string InstiNombre { get; set; }
        public string InstiId { get; set; }
        public string PaisId { get; set; }
        public string DepartamentoId { get; set; }
        public string CiudadId { get; set; }
        public DateTime? FechaIni { get; set; }
        public DateTime? FechaFin { get; set; }
        public string PractiCk { get; set; }
        public bool? Desertado { get; set; }
        public string IdNucleoConoc { get; set; }
        public int? IdEstado { get; set; }
        public bool? TarjetaProf { get; set; }
        public string NumTarjetaProf { get; set; }
        public DateTime? FechaExpTarjProf { get; set; }
        public string Observaciones { get; set; }
        public int? IdAreaDesempeno { get; set; }
        public int Iduk { get; set; }
    }
}