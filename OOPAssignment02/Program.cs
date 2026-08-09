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
        }
    }
}
