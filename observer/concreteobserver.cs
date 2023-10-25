namespace observer{
  public class ConcreteObserver : IObserver
  {
      private string name;
  
      public ConcreteObserver(string name)
      {
          this.name = name;
      }
  
      public void Update(string message)
      {
          Console.WriteLine($"{name} recebeu a mensagem: {message}");
      }
  }
}