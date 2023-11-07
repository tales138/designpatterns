using System;

// classe base para criação dos objetos que serão criados com padrão factory
// nesse exemplo está sendo criado um produto genérico
namespace factory
{
  public abstract class Product
  {
      public abstract void Criar();
  }
}