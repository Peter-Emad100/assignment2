using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Vehicle_Control
    {
        public void run(IStartable st)
        {
            st.start();
            st.pause();
        }
    }
    public interface IStartable:IPauseable
    {
        public void start();
    }
    public interface IPauseable
    {
       public void pause();
    }
    public class Car :IStartable
    {
        public void start()
        {
            Console.WriteLine("Car");
        }
        public void pause()
        {
            Console.WriteLine("Car");
        }
    }
    public class Truck : IStartable
    {
        public void start()
        {
            Console.WriteLine("Truck");
        }
        public void pause()
        {
            Console.WriteLine("Truck");
        }
    }
    public class Motorcycle : IStartable
    {
        public void start()
        {
            Console.WriteLine("Motorcycle");
        }
        public void pause()
        {
            Console.WriteLine("Motorcycle");
        }
    }
}
