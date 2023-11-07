using system;
namespace prototype
{
  //objeto genérico para implementação do padrão prototype
  public class ObjetoConcreto : Prototype
  {
      public int Propriedade { get; set; }
  
      public override Prototype Clone()
      {
          // Crie uma nova instância do objeto e copie os valores
          return new ObjetoConcreto { Propriedade = this.Propriedade };
      }
  }
}