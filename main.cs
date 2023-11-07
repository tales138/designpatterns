using System;
using System.Collections.Generic;
using observer;
using factory;
using prototype;
using strategy;
namespace main
{
  class Program
  {
      static void Main()
      {

          //instanciando o padrão observer
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

          //instanciando o padrão factory
          // Cria uma instância da factory de produtos A
          Factory factoryA = new FabricaProductA();
          Product produtoA = factoryA.CriarProduto();
          produtoA.Criar();

         //instanciando o padrão prototype
        
          // Crie um objeto protótipo
          var prototype = new ObjetoConcreto { Propriedade = 42 };
  
          // Clone o protótipo para criar um novo objeto
          var novoObjeto = prototype.Clone();
          novoObjeto.Propriedade = 10;

          //instanciando o padrão strategy
          // Criar instâncias das estratégias
          ICalculadora soma = new Soma();
          ICalculadora subtracao = new Subtracao();
          ICalculadora multiplicacao = new Multiplicacao();

          // Criar instância da calculadora com a estratégia de soma
          Calculadora calculadoraSoma = new Calculadora(soma);
          int resultadoSoma = calculadoraSoma.ExecutarOperacao(5, 3);
          Console.WriteLine("Soma: " + resultadoSoma);

          // Criar instância da calculadora com a estratégia de subtração
          Calculadora calculadoraSubtracao = new Calculadora(subtracao);
          int resultadoSubtracao = calculadoraSubtracao.ExecutarOperacao(5, 3);
          Console.WriteLine("Subtração: " + resultadoSubtracao);

          // Criar instância da calculadora com a estratégia de multiplicação
          Calculadora calculadoraMultiplicacao = new Calculadora(multiplicacao);
          int resultadoMultiplicacao = calculadoraMultiplicacao.ExecutarOperacao(5, 3);
          Console.WriteLine("Multiplicação: " + resultadoMultiplicacao);
      }
  }
}
