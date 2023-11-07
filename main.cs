using System;
using System.Collections.Generic;
using observer;
using factory;
namespace main
{
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

          // Cria uma instância da factory de produtos A
          Factory factoryA = new FabricaProductA();
          Product produtoA = factoryA.CriarProduto();
          produtoA.Criar();
      }
  }
}
