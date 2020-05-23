using System.Collections.Generic;

namespace AppKinalAlumnos.Models
{
    public class CarreraTecnica
    {
        
        public int CarreraTecnicaId {get;set;}
        public string NombreCarrera {get;set;}
        public virtual List<Clase> Clases {get;set;}   
    }
}