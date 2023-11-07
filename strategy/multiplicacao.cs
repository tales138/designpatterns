using system;

namespace strategy
{
  public class Multiplicacao : ICalculadora
  {
      public int Calcular(int a, int b)
      {
          return a * b;
      }
  }
}