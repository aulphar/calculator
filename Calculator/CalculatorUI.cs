using System.Xml;

namespace Calculator;

public static class CalculatorUI
{
    public static bool DisplayAnswer { get; set; }

    private static int _firstNumber;
    public static string FirstNumber
    {

        get { return _firstNumber.ToString(); }
        set
        {
            bool isANumber = int.TryParse(value, out int output);
            if (isANumber)
            {
                _firstNumber = output;
            }
            else
            {
                Console.WriteLine("Invalid input for First Number");
                NotAccurateInput = true;


            }
            
        }
    }

    private static string _operation;
    public static string Operation
    {
        get { return _operation; }
        set
        {
            if (value == "+" || value == "-" || value == "*" || value == "/" || value == "^" )
            {
                _operation = value;
            }
            else
            {
                Console.WriteLine("Invalid Operator!");
                NotAccurateInput = true;
            }
        }
      
    }




    private static int _secondNumber;
    public static string SecondNumber
    {

        get { return _secondNumber.ToString();; }
        set
        {
            bool isANumber = int.TryParse(value, out int output);
            if (isANumber)
            {
                _secondNumber = output;
            }
            else
            {
                Console.WriteLine("Invalid input for Second number");
                NotAccurateInput = true;


            }
        }
    }


    private static int _result;

    public static int Result
    {
        get
        {
            int x = _firstNumber;
            int y = _secondNumber;
            

            switch (Operation.ToLower())
            {
                case "+":
                case "add":
                    _result = x + y;
                    break;
                case "-":
                case "subtract":
                    _result = x - y;
                    break;
                case "*":
                case "multiply":
                    _result = x * y;
                    break;
                case "/":
                case "divide":
                    if (y != 0)
                    {
                        _result = x / y; 
                    }
                    else
                    {
                        Console.WriteLine("Division By 0 is undefined");
                        

                    }
                    
                    break;
                case "^":
                case "powerof":
                    _result = Calculate.PowerOf(x, y);
                    break;
                
            }

            
            return _result;
        }
       
    }

    public static string Exit { get; set; }

    public static bool NotAccurateInput { get; set; }


    

   








}



          