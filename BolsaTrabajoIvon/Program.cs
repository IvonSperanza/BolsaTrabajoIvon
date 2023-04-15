using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoIvon
{
    internal class Program
    {
        static void Main(string[] args)
        {
      
                BolsaTrabajo mitrabajo = new BolsaTrabajo();

                Console.WriteLine("Ingrese su nombre:");
                string _nombre = Console.ReadLine();
                mitrabajo.Nombre = _nombre;


                Console.WriteLine("Ingrese el sector donde desea trabajar: ");
                string _sector = Console.ReadLine();
                mitrabajo.Sector = _sector;

                Console.WriteLine("Ingrese sus años de experiencia:");
                string respuestaE = Console.ReadLine();
                int _experiencia = int.Parse(respuestaE);
                mitrabajo.Experiencia = _experiencia;


                Console.WriteLine("Ingrese su remuneración esperada:");
                string respuestaS = Console.ReadLine();
                int _sueldo = int.Parse(respuestaS);
                mitrabajo.Sueldo = _sueldo;

                Console.WriteLine("Desea Incrementar o Decrementar su remuneracion, seleccione I o D");
                string opcion = Console.ReadLine();

                if (opcion == "D")
                {
                    Console.WriteLine("Ingrese el monto: ");
                    string respuestaEX = Console.ReadLine();
                    int monto = int.Parse(respuestaEX);

                    string sueldo = mitrabajo.Decremento(monto);
                    Console.WriteLine(sueldo);
                }
                
               else if (opcion == "I") 
                    {
                    Console.WriteLine("Ingrese el monto: ");
                    string respuestaIncr = Console.ReadLine();
                    int monto = int.Parse(respuestaIncr);

                string sueldo = mitrabajo.Incremento(monto);
                Console.WriteLine(sueldo);
            }

            }

        }
    }
  