using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Enemigo
    {
        public int Posicionx { get; set; }
        public int Posiciony { get; set; }

        private int _puntos;
        public int Puntos
        {
            get
            {
                return _puntos;
            }
            set
            {
                if (value >= 100)
                {
                    _puntos = value;
                }
                else
                {
                    throw new Exception("El valor debe ser mayor a 100");
                }

            }
        }
            
        public void moverse()

        {

        }

        public void disparar()

        {

        }

        public void explotar()

        {

        }

    }

    }

