using System;

// Interface que define a estratégia. Nesse caso, a estratégia define o metódo de calcular a ser implementad por uma calculador nas operações fundamentais.
namespace strategy
{
  public interface ICalculadora
  {
      int Calcular(int a, int b);
  }
}