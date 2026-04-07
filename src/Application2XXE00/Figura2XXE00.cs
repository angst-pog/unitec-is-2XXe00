// Archivo: ./src/Application2XXE00/Figura2XXE00.cs
public class Figura2XXE00 
{
    // Método estático para calcular el Perímetro
    public static double Perimetro(double ladoA , double ladoB) 
    {
         return 2*(ladoA+ladoB);
    }

    // Método estático para calcular el Área
    public static double Area(double ladoB , double ladoC) 
    {
         return ladoB*ladoC;
    }

    //Metodo estatico para calcular el volumen

    public static double Volumen(double ladoA, double ladoB, double ladoC)
     {
          return ladoA*ladoB*ladoC;
     }
}