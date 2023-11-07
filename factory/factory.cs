using system;
// Factory abstrata para criar produtos
namespace factory
{
  public abstract class Factory
  {
      public abstract Produto CriarProduto();
  }
}