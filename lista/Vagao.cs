using System;
using System.Collections.Generic;

namespace aula.lista
{
    public class Vagao
    {
        public int Id { get; set; }
        public string Carga { get; set; }
        public int Peso { get; set; } //toneladas
        public Vagao VagaoAnterior { get; set; }
    }
}