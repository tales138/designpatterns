namespace observer{
  public class Subject
  {
      private List<IObserver> observers = new List<IObserver>();
      private string message;
  
      public void RegisterObserver(IObserver observer)
      {
          observers.Add(observer);
      }
  
      public void UnregisterObserver(IObserver observer)
      {
          observers.Remove(observer);
      }
  
      public void NotifyObservers()
      {
          foreach (var observer in observers)
          {
              observer.Update(message);
          }
      }
  
      public void SetMessage(string message)
      {
          this.message = message;
          NotifyObservers();
      }
  }
}