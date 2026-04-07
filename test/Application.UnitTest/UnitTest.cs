public class UnitTestApplication
{
// PRUEBA 1: PERÍMETRO
[Theory]
[InlineData(5, 10, 30)]
[InlineData(2, 4, 12)]
[InlineData(6, 6, 24)]
[InlineData(3, 7, 20)]
[InlineData(10, 20, 60)]
[InlineData(1, 2, 6)]
[InlineData(8, 12, 40)]
[InlineData(15, 5, 40)]
[InlineData(50, 50, 200)]
[InlineData(2.5, 2.5, 10)]
[InlineData(0.5, 1.5, 4)]
[InlineData(4, 9, 26)]
[InlineData(11, 11, 44)]
[InlineData(20, 5, 50)]
[InlineData(100, 10, 220)]
[InlineData(3.5, 6.5, 20)]
[InlineData(12, 3, 30)]
[InlineData(9, 9, 36)]
[InlineData(7, 14, 42)]
[InlineData(1, 99, 200)]
public void CalcularPerimetroParalelogramo_ab_Correcto(double a, double b, double expected)
{
// Arrange
// (No necesitamos Arrange para inicializar objetos porque el método es estático)
// Act
// Llamamos al método directamente usando el nombre de la clase (Figura)
double actual = Figura2XXE00.CalcularPerimetroParalelogramo(a, b);
// Assert
Assert.Equal(expected, actual);
}

// PRUEBA 2: ÁREA
[Theory]
[InlineData(10, 5, 50)]
[InlineData(4, 2, 8)]
[InlineData(6, 6, 36)]
[InlineData(7, 3, 21)]
[InlineData(20, 10, 200)]
[InlineData(2, 1, 2)]
[InlineData(12, 8, 96)]
[InlineData(5, 15, 75)]
[InlineData(50, 10, 500)]
[InlineData(2.5, 4, 10)]
[InlineData(1.5, 2, 3)]
[InlineData(9, 4, 36)]
[InlineData(11, 5, 55)]
[InlineData(5, 20, 100)]
[InlineData(10, 100, 1000)]
[InlineData(6.5, 2, 13)]
[InlineData(3, 12, 36)]
[InlineData(9, 9, 81)]
[InlineData(14, 5, 70)]
[InlineData(99, 1, 99)]
public void CalcularAreaParalelogramo_ac_Correcto(double b, double c, double expected)
{
// Arrange
// Act
double actual = Figura2XXE00.CalcularAreaParalelogramo(b, c);
// Assert
Assert.Equal(expected, actual);
}

// PRUEBA 3: VOLUMEN
[Theory]
[InlineData(50, 10, 500)]
[InlineData(8, 5, 40)]
[InlineData(36, 4, 144)]
[InlineData(21, 3, 63)]
[InlineData(200, 2, 400)]
[InlineData(2, 10, 20)]
[InlineData(96, 1, 96)]
[InlineData(75, 2, 150)]
[InlineData(500, 2, 1000)]
[InlineData(10, 5, 50)]
[InlineData(3, 10, 30)]
[InlineData(36, 2, 72)]
[InlineData(55, 4, 220)]
[InlineData(100, 5, 500)]
[InlineData(1000, 0.5, 500)]
[InlineData(13, 10, 130)]
[InlineData(36, 3, 108)]
[InlineData(81, 2, 162)]
[InlineData(70, 1, 70)]
[InlineData(99, 10, 990)]
public void CalcularVolumenParalelogramo_areah_Correcto(double area, double h, double expected)
{
// Arrange
// Act
double actual = Figura2XXE00.CalcularVolumenParalelogramo(area , h);
// Assert
Assert.Equal(expected, actual);
}
}