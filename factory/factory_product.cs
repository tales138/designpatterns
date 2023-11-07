// Factories concretas que herdam de Factory

namespace factory
{
  public class FabricaProductA : Factory
  {
      public override Produto CriarProduto()
      {
          return new ProductA();
      }
  }
}