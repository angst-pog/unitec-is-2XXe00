public class IntegrationTestApplication
{
[Theory]
[InlineData(10, 5, 10, 500)]
[InlineData(4, 2, 5, 40)]
[InlineData(6, 6, 2, 72)]
[InlineData(7, 3, 3, 63)]
[InlineData(20, 10, 2, 400)]
[InlineData(2, 1, 10, 20)]
[InlineData(12, 8, 1, 96)]
[InlineData(5, 15, 2, 150)]
[InlineData(50, 10, 2, 1000)]
[InlineData(2.5, 4, 5, 50)]
[InlineData(1.5, 2, 10, 30)]
[InlineData(9, 4, 2, 72)]
[InlineData(11, 5, 4, 220)]
[InlineData(5, 20, 5, 500)]
[InlineData(10, 100, 0.5, 500)]
[InlineData(6.5, 2, 10, 130)]
[InlineData(3, 12, 3, 108)]
[InlineData(9, 9, 2, 162)]
[InlineData(14, 5, 1, 70)]
[InlineData(99, 1, 10, 990)]
public void CalcularVolumen_IntegrandoAreaParalelogramo_bch_Correcto(double b, double c, double h, double expected)
{
// Arrange - Setup
// Obtenemos un dato real del Componente A.
double area = Figura2XXE00.CalcularAreaParalelogramo(b,c);
// Act - Perform
// Le pasamos ese dato real al Componente B.
double actual = Figura2XXE00.CalcularVolumenParalelogramo(area , h);
// Assert - Verify
// Verificamos si el flujo completo produjo el resultado correcto.
Assert.Equal(expected, actual);
}
}