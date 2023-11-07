using system;
namespace prototype
{
  public abstract class Prototype:IPrototype
  {
      public abstract Prototype Clone();
  }
}