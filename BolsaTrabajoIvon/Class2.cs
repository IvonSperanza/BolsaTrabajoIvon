using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BolsaTrabajoIvon
{
    internal class BolsaTrabajo
    {
        private string _sector;
        private string _nombre;
        private int _experiencia;
        private int _sueldo;

        public int Experiencia
        {
            get { return _experiencia; }
            set { _experiencia = value; }
        }

        public int Sueldo
        {
            get { return _sueldo; }
            set { _sueldo = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Sector
        {
            get { return _sector; }
            set { _sector = value; }
        }

        public string Incremento(int monto)
        {
            if (_sueldo <= monto)
            {
                _sueldo += monto;
                //Console.WriteLine("Su monto final es {_saldo}");

            }
            Console.WriteLine(_sueldo);
            return ".";
        }


        public string Decremento(int monto)
        {
            if (_sueldo >= monto)
            {
                _sueldo -= monto;


            }
            //Console.WriteLine("Su monto final es {_saldo}");
            Console.WriteLine(_sueldo);
            return ".";
        }
        }
}
