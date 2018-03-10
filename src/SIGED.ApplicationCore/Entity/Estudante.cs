using System;
using System.Collections.Generic;
using System.Text;

namespace SIGED.ApplicationCore.Entity
{
    public class Estudante
    {
        public int EstudanteId { get; set; }
        public string EstudanteNome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public decimal Altura { get; set; }
        public decimal Peso { get; set; }
        public int NivelEnsinoId { get; set; }
        public NivelEnsino NivelEnsino { get; set; }
        public string Foto { get; set; }
    }
}
