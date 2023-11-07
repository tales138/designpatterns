using system;
namespace prototype
{
  //interface para implementação genérica do padrão prototype
  public interface IPrototype
  {
    IPrototype Clone();
  }
}