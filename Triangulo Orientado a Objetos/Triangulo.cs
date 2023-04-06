using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangulo_Orientado_a_Objetos
{
    public class Triangulo
    {
        private double _ladoA;
        private double _ladoB;
        private double _ladoC;

        public Triangulo(double ladoA, double ladoB, double ladoC)
        {
            _ladoA = ladoA;
            _ladoB = ladoB;
            _ladoC = ladoC;
        }
        public bool validaDados(){
            if (_ladoA + _ladoB > _ladoC && _ladoA + _ladoC > _ladoB && _ladoB + _ladoC > _ladoA)
            {
                return true;
            }
            return false;
        }
        public String retornarTipoTriangulo()
        {
            if (_ladoA == _ladoB && _ladoB == _ladoC)
            {
                return "Equilatero";
            }
            else if (_ladoA == _ladoB || _ladoB == _ladoC || _ladoA == _ladoC)
            {
                return "Isosceles";
            }
            else
            {
                return "Escaleno";
            }
        }
    }
}