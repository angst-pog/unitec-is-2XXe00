// 1. Declaración de variables
double ladoA = 5;
double ladoB = 10;
double ladoC = 15;

// 2. Consumo de la Librería de Clases (Invocación de métodos estáticos)
double perimetro = Figura2XXE00.Perimetro(ladoA,ladoB);
double area = Figura2XXE00.Area(ladoB,ladoC);
double volumen = Figura2XXE00.Volumen(ladoA,ladoB,ladoC);

// 3. Salida en Consola
Console.WriteLine($"El perímetro de un Paralelogramo de {ladoA} y de {ladoB}cm es {perimetro}cm");
Console.WriteLine($"El área de un Paralelogramo con una base de {ladoB}cm y una altura de{ladoC} es {area}cm2");
Console.WriteLine($"El volumen de un Paralelogramo con dimenciones de {ladoA},{ladoB},{ladoC}cm2 es de {volumen}cm3");