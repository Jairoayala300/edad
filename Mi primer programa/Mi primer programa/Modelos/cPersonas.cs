using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mi_primer_programa.Modelos
{
    class cPersonas
    {
        private string Nombre;
        private int añoNac;
        //Costructor
        public cPersonas()
        { 
        }
        public cPersonas (string Nombre, int AñoNac)
        {
            this.Nombre = Nombre;
            this.añoNac = AñoNac;
        }
        // setter
        public void setNombre(string Nombre)
        {
            this.Nombre = Nombre;
        } 
        public void setAñoNac(int añoNac)
        {
            this.añoNac = añoNac;
        }
        public string getNombre()
            {
                return this.Nombre;
            }
        public int getAñoNac()
        {
            return this.añoNac;
        }
        // Metodos
        public int CalcularEdad()
        {
            int añoAct = DateTime.Now.Year;
            int Edad = añoAct - this.añoNac;
            return Edad;
        }
    }
}

