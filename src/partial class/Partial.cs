using System;


namespace Learn
{
    // Separar a implementação de uma interface
   public interface IMyInterface
   {
        void Method1();
   }

   public partial class MyClass : IMyInterface
   {
        public void Method1()
        {
            Console.WriteLine("Method1");
        }
   }

   public partial class MyClass
   {
        public void Method2()
        {
            Console.WriteLine("Method2");
        }
   }

   // Separar a definição de propriedades
   public partial class MyClass
   {
        private int _idade;
        public int Idade
        {
            get {return _idade;}
            set { _idade = value;}
        }
   }

   public partial class MyClass
   {
        private string nome;
        public string Nome 
        {
            get {return nome;}
            set {nome = value;}
        }
   }

   // Separar a definição de eventos
   public partial class MyClass
   {
        public event EventHandler myEvent;
        private void RaiseMyEvent()
        {
            myEvent?.Invoke(this, EventArgs.Empty);
        }
   }
}