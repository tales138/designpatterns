using system;

namespace strategy
{
  public class Subtracao : ICalculadora
  {
      public int Calcular(int a, int b)
      {
          return a - b;
      }
  }
}