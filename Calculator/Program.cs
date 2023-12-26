using Calculator;

class Program
{
   static void Main(string[] args)
   {

     Console.WriteLine("This is a Simple Calculator!");
     Console.WriteLine("You can only Add, Subtract, Multiply, Divide and find the Power Of a number with this calculator.");
     Console.WriteLine("You can only calculate maximum of two number");
     bool startAfresh;
     do
     {
          startAfresh = false;
          CalculatorUI.NotAccurateInput = false;

         Console.Write("Input your first number: ");
         CalculatorUI.FirstNumber = Console.ReadLine();
         if (CalculatorUI.NotAccurateInput)
         {
             startAfresh = true;
              continue;
         }
        
         

         Console.Write("Input your Operator symbol: ");
         CalculatorUI.Operation = Console.ReadLine();
         if (CalculatorUI.NotAccurateInput)
         {
             startAfresh = true;
             continue;
         }


         Console.Write("Input your second number: ");
         CalculatorUI.SecondNumber = Console.ReadLine();
         if (CalculatorUI.NotAccurateInput)
         {
             startAfresh = true;
             continue;
         }

         
         Console.Write("The Answer is " + CalculatorUI.Result); 
         
         
         
        
         Console.WriteLine();

        

         Console.Write("Input n to End Program or any other key to continue...: ");
         CalculatorUI.Exit = Console.ReadLine();
         if (CalculatorUI.Exit.ToLower() == "n")
         {
             break;
         }


     } while (true || startAfresh);






  
   }
}