using System;
using System.Collections.Generic;

namespace AppKinalAlumnos.Models
{
    public class  Horario
    {
        
        public int HorarioId {get;set;}
        public DateTime HorarioInicio {get;set;}
        public DateTime HorarioFinal {get;set;}
        public virtual List<Clase> Clases {get;set;}        
    }
    
}