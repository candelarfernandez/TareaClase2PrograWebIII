using Clase2.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Clase.Logica
{
    public interface IEquipoServicio
    {
        void Agregar(Equipo equipo);

        void Eliminar(int idEquipo);
        List<Equipo> GetEquipos();
         Equipo traerEquipoPorId(int idEquipo);
    }



    public class EquipoServicio : IEquipoServicio
    {
        private static List<Equipo> Equipos { get; set; } = new List<Equipo>();
        public void Agregar(Equipo equipo)
        {
            Equipos.Add(equipo);
        }

        public void Eliminar(int idEquipo)
        {
            var equipoExistente = traerEquipoPorId(idEquipo);
            Equipos.Remove(equipoExistente);
        }

        public Equipo traerEquipoPorId(int idEquipo)
        {
            foreach (var equipo in Equipos) { 
                if(equipo.Id == idEquipo) {  
                    return equipo; 
                }
            } throw new Exception("No se encontro el equipo");
        }

        public List<Equipo> GetEquipos()
        {
            return Equipos;
        }
    }
}
