namespace Triangulo_Orientado_a_Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double ladoA = 3;
            double ladoB = 2;
            double ladoC = 1;
            Triangulo calculadora = new Triangulo(ladoA, ladoB, ladoC);
            if(calculadora.validaDados()){
                System.Console.WriteLine("Os dados são validos, o triangulo é " + calculadora.retornarTipoTriangulo());
            }else{
                System.Console.WriteLine("Os dados são invalidos, e o triangulo não pode ser formado.");
            }
        }
    }
}