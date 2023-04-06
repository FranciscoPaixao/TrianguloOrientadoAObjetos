using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Triangulo_Orientado_a_Objetos
{
    public class Calculadora
    {
        private double _ladoA;
        private double _ladoB;
        private double _ladoC;

        public Calculadora(double ladoA, double ladoB, double ladoC)
        {
            _ladoA = ladoA;
            _ladoB = ladoB;
            _ladoC = ladoC;
        }
        public bool validaDados(){
            if(_ladoA <= 0 || _ladoB <= 0 || _ladoC <= 0){
                return true;
            }
            if(_ladoA + _ladoB <= _ladoC || _ladoA + _ladoC <= _ladoB || _ladoB + _ladoC <= _ladoA){
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