// 1. Declaración de variables
double a = 5;
double b = 10;
double c = 15;
double h = 20;

// 2. Consumo de la Librería de Clases (Invocación de métodos estáticos)
double perimetro = Figura2XXE00.CalcularPerimetroParalelogramo(a,b);
double area = Figura2XXE00.CalcularAreaParalelogramo(b,c);
double volumen = Figura2XXE00.CalcularVolumenParalelogramo(area,h);

// 3. Salida en Consola
Console.WriteLine($"El perímetro de un Paralelogramo de {a} y de {b}cm es {perimetro}cm");
Console.WriteLine($"El área de un Paralelogramo de {b} y {c} es {area}cm2");
Console.WriteLine($"El volumen de un Paralelogramo con un area de {area}cm y una altura de {h} es igual a {volumen}cm3");