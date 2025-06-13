using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IMC
{
    internal class ClsPersona
    {
        //Atributos
        protected float Estatura;
        protected float Peso;
        protected float Sancada;
        protected int Pasos;
        protected float Distancia;
        protected float IMC;
        protected float DistanciaFaltante;

        //Propiedades
        public float estatura
        {
            get { return Estatura; }
            set { Estatura = value; }
        }
        public float peso
        {
            get { return Peso; }
            set { Peso = value; }
        }
        public float sancada
        {
            get { return Sancada; }
            set { Sancada = value; }
        }
        public int pasos
        {
            get { return Pasos; }
            set { Pasos = value; }
        }
        public float distanciapendiente
        {
            get { return DistanciaFaltante; }
            set { DistanciaFaltante = value; }
        }

        //Constructor
        public ClsPersona()
        {
            Estatura = 0;
            Peso = 0;
            Sancada = 0;
            Pasos = 0;
            IMC = 0;
            Distancia = 0;
            DistanciaFaltante = 0;
        }

        //Metodos
        public float CalcularIMC()
        {
            return IMC = Peso/(Estatura*Estatura);
        }
        public float DistanciaDiaria()
        {
            if (IMC >= 18.50 && IMC <= 24.99)
            {
                Distancia = 3000;
            }
            if (IMC>=25 && IMC <= 34.99)
            {
                Distancia = 5000;
            }
            if (IMC>=35)
            {
                Distancia = 10000;
            }
            DistanciaFaltante = Distancia - (Sancada * Pasos);
            return Distancia;
        }
        public string TipoCuerpo()
        {
            if (IMC >= 18.50 && IMC <= 24.99)
            {
                return "ideal";
            }
            if (IMC >= 25 && IMC <= 34.99)
            {
                return "sobrepeso";
            }
            if (IMC >= 35)
            {
                return "obesidad";
            }
            return "Bajo";
        }
        public string Datos()
        {
            string Mensaje="";
            if (DistanciaFaltante < 0)
            {
                Mensaje = "Tu IMC es de: " + CalcularIMC() + "\nTu tipo de cuerpo es: " + TipoCuerpo() + "\nLa distancia que debe recorrer es de: " + DistanciaDiaria() + " Km\nDistancia pendiente: " + DistanciaFaltante + " Km";
            }
            else
            {
                Mensaje = "Tu IMC es de: " + CalcularIMC() + "\nTu tipo de cuerpo es: " + TipoCuerpo() + "\nLa distancia que debe recorrer es de: " + DistanciaDiaria() + " Km\nDistancia pendiente: Usted ha realizado la mínima diaria";
            }
            return Mensaje;
        }
    }
}
