using System;
namespace ejercicio4{
    class program{
        public static void Main(String[] args){
            Cliente uno = new Cliente(18, "Juan", 609123098, 1500);
            Trabajador dos = new Trabajador(32, "Pedro", 609503098, 1090);

            System.Console.WriteLine(uno.ToString());
            System.Console.WriteLine(dos.ToString());   
        }
        class Persona{
            protected int _edad;
            protected string _nombre;
            protected int _telefono;
            public Persona(int edad, string nombre, int telefono){
                this._edad = edad;
                this._nombre = nombre;
                this._telefono = telefono;
            }
            public int edad{get => _edad;}
            public string nombre{get => _nombre;}
            public int telefono{get => _telefono;}
        }
        class Cliente : Persona{
            private int _credito;

            public Cliente(int edad, string nombre, int telefono, int credito):base(edad, nombre, telefono){
                this._credito=credito;
            }
            public int credito{get => _credito;}

            public override string ToString(){
                return $"{_edad}, {_nombre}, {_telefono}, {_credito}";
            }
        }
        class Trabajador : Persona{
            private int _salario;

            public Trabajador(int edad, string nombre, int telefono, int salario):base(edad, nombre, telefono){
                this._salario=salario;
            }
            public int salario{get => _salario;}

            public override string ToString(){
                return $"{_edad}, {_nombre}, {_telefono}, {_salario}";
            }

        }
    }
}