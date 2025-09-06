using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpleados
{
    internal class Empleado
    {
        //Atributos
        private string  Nombre;
        private string Apellido;
        private string Genero;
        private DateTime FechaNacimiento;
        private int Salario;
        private DateTime FechaIngreso;
        private string Placeholder;

        //Constructor
        public Empleado(string pNombre, string pApellido, string pGenero, DateTime pFechaNacimiento, DateTime pFechaIngreso, int NuevoSalario)
        { 
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Genero = pGenero;
            this.FechaNacimiento = pFechaNacimiento;
            this.FechaIngreso = pFechaIngreso;
            this.Salario = NuevoSalario;

        }
        //Metodos
        public string getNombre()
        {
            return this.Nombre;
        }
        public void setNombre(string pNombre)
        {
            this.Nombre = pNombre;
        }
        public string getApellido()
        {
            return this.Apellido;
        }
        public void setApellido(string pApellido)
        {
            this.Apellido = pApellido;
        }
        public string getGenero()
        {
            return this.Genero;
        }
        public void setGenero(string pGenero)
        {
            this.Genero = pGenero;
        }
        public DateTime getFechaNacimiento()
        {
            return this. FechaNacimiento;
        }
        public void setFechaNacimiento(DateTime pFechaNacimiento)
        {
            this.FechaNacimiento = pFechaNacimiento;
        }
        public DateTime getFechaIngreso()
        {
            return this. FechaIngreso;
        }
        public void setFechaIngreso(DateTime pFechaIngreso)
        {
             this.FechaIngreso = pFechaIngreso;
        }

        public int getSalario()
        {
            return this.Salario;
        }
        public void ModificarSalario(int NuevoSalario)
        {
            this.Salario = NuevoSalario;
        }
        public string getPlaceholder()
        {
            return this.Placeholder;
        }
        public void setPlaceholder(string pPlaceholder)
        {
            this.Placeholder = pPlaceholder;
        }
    }
}
