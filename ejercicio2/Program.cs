using System;
namespace ejercicio2;
class ejercicio2{
    public static void Main(String[] args){
        EsPositivo();
        BucleWhile();
        BucleDoWhile();
        BucleFor();
        Switch();

    }
    public static void EsPositivo(){
        int numeroif = int.Parse(Console.ReadLine());
        if(numeroif < 0){
            System.Console.WriteLine($"El numero {numeroif} es positivo");
        }else if(numeroif == 0){
            System.Console.WriteLine($"El numero {numeroif} es cero");
        }else{
            System.Console.WriteLine($"El numero {numeroif} es negtivo");
        }
    }
    public static void BucleWhile(){
        int numerowhile = 0;
        while(numerowhile < 3){
            numerowhile++;
            System.Console.WriteLine(numerowhile);
        }

    }
        public static void BucleDoWhile(){
            int numerowhile = 2;
            do{
                numerowhile++;
                System.Console.WriteLine(numerowhile);
            }while(numerowhile<3);
  
        }
        public static void BucleFor(){
            
            for(int numeroFor = 0; numeroFor <= 3; numeroFor++){
                System.Console.WriteLine(numeroFor);
            }
        }
        public static void Switch(){
            System.Console.WriteLine("indica la estacion:");
            string estacion = Console.ReadLine();
            switch(estacion){
                case "verano":
                System.Console.WriteLine("verano");
                break;
                case "otono":
                System.Console.WriteLine("otono");
                break;

                case "invierno":
                System.Console.WriteLine("invierno");
                break;

                case "primavera":
                System.Console.WriteLine("primavera");
                break;

                default:
                System.Console.WriteLine("no es una estacion");
                break;
                

            }
            
          
        }
}