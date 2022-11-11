using System;
namespace ejercicio;
class ejercicio{
    public static void Main(String[] args){
        Suma(2, 5, 8);
        Coche a = new Coche();
        
        
        System.Console.WriteLine(a.numero_puertas);
        a.numero_puertas = 4;
        System.Console.WriteLine(a.numero_puertas);

    }

    /*funcion suma 3 valores*/
    public static int Suma(int a, int b, int c){
        int result = a + b+ c;
        return result;
    }
}

public class Coche{

    /*parametros*/
    private int _numero_puertas;

    /*constructor para asigar valor a _numero_puertas */
    public Coche(){
        this._numero_puertas = 0;
    }

    /* geter y seter para poder ver y modificar el valor de _numero_puertas*/
    public int numero_puertas {get => _numero_puertas; set => _numero_puertas = value;}


}