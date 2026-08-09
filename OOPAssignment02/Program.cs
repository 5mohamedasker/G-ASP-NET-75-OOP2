using System.Drawing;
using System.Security.Cryptography.X509Certificates;

namespace OOPAssignment02
{
    internal class Program
    {
        static void Main()
        {
            #region Question01
            /*a) What is the difference between a class and a struct?
             =========================================================
                       Class             |           Struct
             ============================|============================
                                         |             
            *Refernce Type               |  *Value Type  
                                         |            
            *Heap                        |  *Stack
                                         |                
            *The object has a longer     |  *Less than class lifespane.
             lifespan.                   |                    
                                         |                                         
            *We use it to simulate       |  *We use it for simple data.
             huge systems with behavior. |   
                                         |                          
            *It supports the main        |  *just Encapsulation.There is
             pillars of the OOP          |   an exception with Polymorphism 
                                         |
             =========================================================                               

            */
            /*b) Why are classes more suitable than structs for large applications?
              Because the class is stored in heap memory
              and heap memory has more space than stack memory
              it also supports the four pillars of OOP.
              This makes it easier to reuse code
              and provides features not available elsewhere.

            */
            #endregion
            #region Question02
            //  public class Shibment
            //  {
            //         public string TrackingCode { get; set; }
            //  }
            //
            //  public class ExpressShibment : Shibment 
            //  {
            //         public decimal ExtraFe {  get; set; }
            //  }
            //
            // a) Which class is the parent class? Shibment
            //
            // b) Which class is the child class?  ExpressShibment 
            //
            // c) What members are inherited by ExpressShipment?  public string TrackingCode { get; set; }
            //
            /* d) Why is inheritance better than duplicating the same code in multiple classes?
                    - Organize the code better, especially when there is a logical relationship between the classes.
                    - Easy to modify and maintain
                    - Make the code Reusable.
                    - Avoid repeating the code as much as possible.
             
             */
            #endregion

            Console.WriteLine("Enter Delivery Center Name: ");
            DeliveryCenter Center = new (20, Console.ReadLine());



            DeliveryAddress deliveryAddress1 = new("Naser","Abas",12);
            StandardShipment standardShipment = new("aa_11", "Phon", 0.250, 60, deliveryAddress1);

            DeliveryAddress deliveryAddress2 = new("Alex","halawlaw", 15);
            ExpressShipment expressShipment = new("bb_22", "laptop",4, 80, deliveryAddress2,30);

            DeliveryAddress deliveryAddress3 = new("Geza", "Haram", 9);
            InternationalShipment internationalShipment = new("cc_33", "Screen", 9, 110, deliveryAddress3,"Germany",100);



            if (Center.AddShipment(standardShipment))
                Console.WriteLine("\nShipment added successfullu.");

            if (Center.AddShipment(expressShipment))
                Console.WriteLine("Shipment added successfullu.");

            if (Center.AddShipment(internationalShipment))
                Console.WriteLine("Shipment added successfullu.\n");



            Console.WriteLine("=========================================");
            Console.WriteLine($"Delivery Center : {Center.CenterName}");
            Console.WriteLine("=========================================");

            Center.PrintAllShipments();

            Console.WriteLine("\nEnter Tracking Code to Remove: ");


            if (Center.RemoveShipment(Console.ReadLine()))
                Console.WriteLine("\nShipment Removed Successfully\n");

            Console.WriteLine("=========================================");
            Console.WriteLine("Remaining Shipments");
            Console.WriteLine("=========================================");

            Center.PrintAllShipments();


        }
    }
}
