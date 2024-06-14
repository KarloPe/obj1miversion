using System.Drawing;

namespace libreriaClases {

    class Persona {

        //atributos
        public string nombre;
        public string fecNac;
        public int dni;
        public bool vivo;

        //constructor 
        public Persona(int rDni, string rNombre, string rFechanac) {
            dni=rDni;
            nombre=rNombre;
            fecNac=rFechanac;
            vivo=true;
        }

        //otros metodos
        public string Respirar(){

            return "Hola... respirando...";
        }

        public void Morir(){

            Console.WriteLine ("{0} murio...",nombre);
            vivo=false;
        }

        public void Revivir(){
            Console.WriteLine ("{0} reivió...",nombre);
            vivo=true;
        }

    }
}           //cm