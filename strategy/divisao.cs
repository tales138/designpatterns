using system;

namespace strategy
{
  public class Divisao : ICalculadora
  {
      public int Calcular(int a, int b)
      {
          return a / b;
      }
  }
}