using System;

namespace MusicStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Store
    {
        public event EventHandler TruckArrived;

        protected virtual void OnTruckArrived(EventArgs e)
        {
            if (TruckArrived != null)
                TruckArrived.Invoke(this, e);
        }
        public void RaiseTheEvent()
        {
            OnTruckArrived(null);
        }
        private void Store_TruckArrived(object sender, EventArgs e)
        {

        }
    }
    class Employee
    {
        public ToDo TodoList {get;set;}
        public List<string> Completed { get; set; }
        public Employee (Store store)
        {
            Store = store;
        }
    }
}
