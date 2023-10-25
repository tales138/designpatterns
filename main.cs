using System;
using System.Collections.Generic;

// Interface do Observador
public interface IObserver
{
    void Update(string message);
}

// Classe Concreta do Observador
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

// Classe Sujeito (ou Observável)
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

class Program
{
    static void Main()
    {
        // Criando observadores
        IObserver observer1 = new ConcreteObserver("Observador 1");
        IObserver observer2 = new ConcreteObserver("Observador 2");

        // Criando o sujeito
        Subject subject = new Subject();

        // Registrando observadores
        subject.RegisterObserver(observer1);
        subject.RegisterObserver(observer2);

        // Notificando observadores
        subject.SetMessage("Evento importante ocorreu!");

        // Removendo um observador
        subject.UnregisterObserver(observer1);

        // Notificando observadores novamente
        subject.SetMessage("Outro evento ocorreu!");
    }
}
