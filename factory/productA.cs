// Classes concretas que herdam de Product
namespace factory
{
  public class ProductA : Product
  {
      public override void Criar()
      {
          Console.WriteLine("Produto A criado.");
      }
  }
}