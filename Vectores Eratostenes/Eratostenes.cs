using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores_Eratostenes
{
    class Eratostenes
    {
        private bool[] _vec;//vector booleano
        public Eratostenes(int num)
        {
            _vec = new bool[num];
        }
        public string returnEratostenes()
        {
            string cad = "";//sirve para guardar la cadena
            for(int i=0; i < _vec.Length; i++)
            {
                _vec[i] = true;//llenamos el vector de bool con verdaderos
            }
            for(int i = 2; i < _vec.Length; i++)//para i
            {//con el for de j quitamos el verdadero de los multiplos de la posicion de i
                for(int j = 2; i * j < _vec.Length; j++)
                {
                    _vec[i * j] = false;
                }
            }
            for(int i=2; i < _vec.Length; i++)
            {
                if (_vec[i])//si en el bool[i] es un verdadero
                    cad += i.ToString() +", ";//pone el valor de i en el string
            }
            return cad;//regresa el string
        }
    }
}
