using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            






            Santa santa = Santa.Instance;
            santa.DoSomething();
        }
    }
    internal interface Interface1
    {
    }
}
public class Santa
{
    private static Santa instance = new Santa();
    private Santa() { }

    public static Santa Instance
    {
        get { return instance; }
    }

    public void DoSomething()
    {
        SantasBoard santasBoard = new SantasBoard();

        Ssanta santa = new Ssanta("Santa Claus");
        santasBoard.Attach(santa);

      

        santasBoard.Toy = "5";
        
       

        Console.ReadLine();
       
    }

    interface ISubject
    {
        void Attach(IObserver observer);
        void Notify();
    }

    class SantasBoard : ISubject
    {
        private List<IObserver> _observers;

        public String Toy
        {
            get { return _toy; }
            set
            {
                _toy = value;
                Notify();
            }



        }
        private String _toy;

        public SantasBoard()
        {
            _observers = new List<IObserver>();
        }

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notify()
        {
            _observers.ForEach(o =>
            {
                o.Update(this);
            });
        }
    }

    interface IObserver
    {
        void Update(ISubject subject);
    }

    class Ssanta : IObserver
    {
        public String SantaClaus { get; set; }
        public Ssanta(String name)
        {
            SantaClaus = name;
        }

        public void Update(ISubject subject)
        {
            if (subject is SantasBoard santasBoard)
            {
                Console.WriteLine(String.Format("{0} wants {1} dolls", SantaClaus, santasBoard.Toy));
                Console.WriteLine(String.Format("{0} wants {1} bikes", SantaClaus, santasBoard.Toy));
                Console.WriteLine();

            }
        }
    }



}
