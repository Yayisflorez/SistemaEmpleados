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
        private string  nombre;
        private string apellido;
        private char genero;
        private Fecha fechaNacimiento;
        private double salario;
        private Fecha fechaIngreso;
        private string Placeholder;

        //Constructor
        public Empleado(string pNombre, string pApellido, char pGenero) 
        { 
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.genero = pGenero;
            this.fechaNacimiento = new Fecha();
            this.fechaIngreso = new Fecha();
            this.salario = 0;
        }

        public Empleado(string pNombre, string pApellido, char pGenero, double pSalario)
        {
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.genero = pGenero;
            this.salario = pSalario;
        }

        public Empleado(string pNombre, string pApellido, char pGenero, Fecha pFechaNacimiento, Fecha pFechaIngreso, double pSalario)
        { 
            this.nombre = pNombre;
            this.apellido = pApellido;
            this.genero = pGenero;
            this.fechaNacimiento = pFechaNacimiento;
            this.fechaIngreso = pFechaIngreso;
            this.salario = pSalario;

        }
        //Metodos
        public string getNombre()
        {
            return this.nombre;
        }
        public void setNombre(string pNombre)
        {
            this.nombre = pNombre;
        }
        public string getApellido()
        {
            return this.apellido;
        }
        public void setApellido(string pApellido)
        {
            this.apellido = pApellido;
        }
        public char getGenero()
        {
            return this.genero;
        }
        public void setGenero(char pGenero)
        {
            this.genero = pGenero;
        }
        public Fecha getFechaNacimiento()
        {
            return this. fechaNacimiento;
        }
        public void setFechaNacimiento(Fecha pFechaNacimiento)
        {
            this.fechaNacimiento = pFechaNacimiento;
        }
        public Fecha getFechaIngreso()
        {
            return this.fechaIngreso;
        }
        public void setFechaIngreso(Fecha pFechaIngreso)
        {
             this.fechaIngreso = pFechaIngreso;
        }

        public double getSalario()
        {
            return this.salario;
        }
        public void ModificarSalario(double pSalario)
        {
            this.salario = pSalario;
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
