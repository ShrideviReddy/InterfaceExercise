using System;

namespace InterfaceExercise
{
    interface IVehicle
    {
        void tires();
        void color();
        void milage();
        void speed();
    }
    interface ICompany
    {
        void logo();
        void name();
    }
    class Car: IVehicle, ICompany
    {
       public void tires()
        {
            Console.WriteLine("Car has 2 tires");
        }
        public void color()
        {
            Console.WriteLine("It is mostly red, black, white and blue in color");
        }
        public void milage()
        {
            Console.WriteLine("Milage is in the range 15-20cc");
        }
        public void speed()
        {
            Console.WriteLine("Speed range is 100m/hr");
        }
        public void height()
        {
            Console.WriteLine("Height is 150-180m");
        }
        public void capacity()
        {
            Console.WriteLine("Capacity is 2-5");
        }
        public void name()
        {
            Console.WriteLine("Famous company is Toyoto");
        }
        public void logo()
        {
            Console.WriteLine("T");
        }
    }
    class truck: IVehicle, ICompany
    {
        public void tires()
        {
            Console.WriteLine("Truck  has 4 tires");
        }
        public void color()
        {
            Console.WriteLine("It is mostly red, black, white and blue in color");
        }
        public void milage()
        {
            Console.WriteLine("Milage is in the range 20-30cc");
        }
        public void speed()
        {
            Console.WriteLine("Speed range is 200m/hr");
        }
        public void wt_capacity()
        {
            Console.WriteLine("Capacity is 50-200 pounds");
        }
        public void name()
        {
            Console.WriteLine("Famous truck company is Ford ");
        }
        public void logo()
        {
            Console.WriteLine("F");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces
            Car c = new Car();
            c.tires();
            c.color();
            c.name();
            c.capacity();
            truck t = new truck();
            t.tires();
            t.color();
            t.name();
            t.wt_capacity();

            //Create 2 Interfaces called IVehicle & ICompany
     
      

            //Create 3 classes called Car , Truck , & SUV
       
        

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        }
    }
}
