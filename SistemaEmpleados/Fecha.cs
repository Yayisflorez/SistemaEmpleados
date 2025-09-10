using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpleados
{
    internal class Fecha
    {
        //Atributos
        private int dia;
        private int mes;
        private int anio;

        //constructor
        public Fecha(int dia, int mes, int anio)
        {
            this.dia = dia;
            this.mes = mes;
            this.anio = anio;
        }

        public Fecha()
        {
            DateTime hoy = DateTime.Now;
            this.dia = hoy.Day;
            this.mes = hoy.Month;
            this.anio = hoy.Year;


        }
        //Metodos
        public int getDia()
        {
            return this.dia;
        }
        public void setDia(int dia)
        {
            this.dia = dia;
        }
        public int getMes()
        {
            return this.mes;
        }
        public void setMes(int mes)
        {
            this.mes = mes;
        }
        public int getAnio()
        {
            return this.anio;
        }
        public void setAnio(int anio)
        {
            this.anio = anio;
        }

        public int diferenciaFechaMeses(Fecha pFecha)
        {
            return 0;
        }

        public string toString()
        {
            return this.dia + "/" + this.mes + "/" + this.anio;
        }
    }
}
