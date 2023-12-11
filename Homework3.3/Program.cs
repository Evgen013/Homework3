
/*Створити клас Vehicle. У тілі класу створіть поля: координати та параметри суден (ціна, швидкість, рік випуску).
 * Створіть 3 похідні класи Plane, Саг і Ship. Для класу Plane має бути визначена висота та кількість пасажирів. 
 * Для класу Ship – кількість пасажирів та порт приписки. 
 * Написати програму, яка виводить на екран інформацію про кожен засіб пересування. */

using System.Numerics;

namespace Homework3._3
{
    
    internal class Program
    {
       
        static void Main(string[] args)
        {
          
            Plane vehicle1 = new Plane();

                        
            Vehicle vehicle = vehicle1;


            Car vehicle2 = new Car();

            Vehicle vehicle3 = vehicle2;


            Ship vehicle4 = new Ship();

            Vehicle vehicle5 = vehicle4;

            vehicle.coordinates = "45.56.34";
            vehicle.price = 2000;
            vehicle.speed = 13;
            vehicle.releaseDate = 2016;
            vehicle1.hight = 30;
            vehicle2.numberPassengers = 1000;
            vehicle4.homePort = "Kiev";
                
                    
            vehicle.Show();
            vehicle1.Show();
            vehicle2.Show();
            vehicle4.Show();
             
            Console.ReadKey();
        }
    }
}

//зроблено