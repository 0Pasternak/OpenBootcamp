using System;
namespace ejercicio3{
    class ejercicio3{
        public static void Main(String [] arg){
            Persona persona = new Persona();
            persona.nombre = "Gabriel";
            persona.edad = 24;
            persona.telefono = 640274931;

            System.Console.WriteLine($"{persona.nombre} {persona.edad} {persona.telefono}");
        }
    }
    class Persona{
        private int _edad;
        private string _nombre;
        private int _telefono;

        public Persona(){
            _nombre = "";
            _edad = 0;
            _telefono = 0;
        }
        public Persona(string nombre, int edad, int telefono){
            this._nombre = nombre;
            this._edad = edad;
            this._telefono = telefono;
        }

        public int edad {get  => _edad; set => _edad = value;}
        public string nombre {get  => _nombre; set => _nombre = value;}
        public int telefono {get  => _telefono; set => _telefono = value;}

    }
}