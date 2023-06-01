// See https://aka.ms/new-console-template for more information
using System;
using EspacioCalculadora;

namespace CalculadoraA{
    class Program{
        static void Main(string[] args){

            Calculadora calculadora = new Calculadora();
            Console.WriteLine("Escriba la operacion a realizar:\nSumar\nRestar\nMultiplicar\nDividir\nSalir");

            while(true){
                Console.WriteLine("Comando:");
                string comando = Console.ReadLine();

                if(comando == "salir"){
                    break;
                }

                string[] partes = comando.Split(' ');
                string operacion = partes[0];

                if(double.TryParse(partes[1], out double termino)){
                    switch(operacion){
                        case "sumar":
                            calculadora.Sumar(termino);
                            break;
                        case "restar":
                            calculadora.Restar(termino);
                            break;
                        case "multiplicar":
                            calculadora.Multiplicar(termino);
                            break;
                        case "dividir":
                            calculadora.Dividir(termino);
                            break;
                        default:
                            Console.WriteLine("Comando incorrecto\n");
                            break;
                    }
                    Console.WriteLine("Resultado: "+ calculadora.resultado);
                }else{
                    Console.WriteLine("Comando invalido.\n");
                }

            }
            Console.WriteLine("Fin\n") ;

        }
    }
}