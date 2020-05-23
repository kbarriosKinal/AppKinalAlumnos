using System.Collections.Generic;

namespace AppKinalAlumnos.Models
{
    public class Salon
    {
        
        public int SalonId {get;set;}
        public string NombreSalon {get;set;}
        public string Descripcion {get;set;}
        public int Capacidad {get;set;}
        public virtual List<Clase> Clases {get;set;}  
        
    }
}