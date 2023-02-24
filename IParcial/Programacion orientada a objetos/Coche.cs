using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programacion_orientada_a_objetos
{
    public class Coche
    {
        //atributos
        private string marca;
        private string modelo;
        private decimal precio;


        //Propiedades

        //1 forma (más larga)

        public string Marca { get { return marca; } set { marca = value; } }

        //2 forma más elegante 
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Kilometros { get; set; }

        //Constructor

        public Coche() { }

        public Coche(string _marca, string _modelo)
        {
            Marca = _marca; Modelo=_modelo;
        }


        //Se utiliza la opcion de generar constructor,, icono de desarmador
        public Coche(string marca, string modelo, decimal precio, int kilometros) : this(marca, modelo)
        {
            Precio = precio;
            Kilometros = kilometros;
        }

        //Metodos

        public string DevolverDatosBasicos()
        {
            return "Marca: " + Marca + " Modelo: " + Modelo + " Precio: " + Precio;

        }


    }
}
