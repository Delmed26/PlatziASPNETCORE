using System;
using System.Collections.Generic;

namespace PlatziASPNETCORE.Models
{
    public class Alumno: ObjetoEscuelaBase
    {
        public List<Evaluación> Evaluaciones { get; set; } = new List<Evaluación>();
    }
}