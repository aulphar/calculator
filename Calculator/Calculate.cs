namespace Calculator;

public static class Calculate
{
       public static int Add(int x, int y)
       {
           int result = x + y;
           return result;
       }

       public static int Subtract(int x, int y)
       {
           int result = x - y;
           return result;
       }
       public static int Multiply(int x, int y)
       {
           int result = x * y;
           return result;
       }
       public static int Divide(int x, int y)
       {
           int result = x / y;
           return result;
       }
       public static int PowerOf(int baseNumber, int exponent)
       {
           int result = 1;
           for (int i = 0; i < exponent; i++)
           {
               result *= baseNumber;
           }

           return result;
       }
}