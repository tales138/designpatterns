using system;

namespace strategy
{
  // Classe que utiliza a estratégia
  public class Calculadora
  {
      private ICalculadora estrategia;

      public Calculadora(ICalculadora estrategia)
      {
          this.estrategia = estrategia;
      }

      public int ExecutarOperacao(int a, int b)
      {
          return estrategia.Calcular(a, b);
      }
  }

}