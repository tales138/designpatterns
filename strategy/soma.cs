using system;
namespace strategy
{
  public class Soma : ICalculadora
  {
      public int Calcular(int a, int b)
      {
          return a + b;
      }
  }
}