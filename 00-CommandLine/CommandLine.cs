[assembly: CLSCompliant(true)]
namespace WP01;

public static class CommandLine
{
    public static void Calculator(double a, double b, char op)
    {        
        double result =0;
        switch(op)
        {
        case '+':
            result = a+b;
            break;
        case '-':
            result = a-b;
            break;
        case '*':
            result = a*b;
            break;
        case '/':
            result = a/b;
            break;
        default:
            Console.WriteLine("not supported operation");
            return;

        }
        
        Console.WriteLine("result: " + result);
    }

    public static void InputStringPrint()
    {        
        string? input = Console.ReadLine();
        if( input == null)
            throw new Exception("Command line input is null!");
        Console.WriteLine("input: " + input);
    }

    public static void InputDoublePrint()
    {        
        double input = System.Convert.ToDouble(Console.ReadLine());
        Console.Write(input);
    }


    static void Main(string[] args)
    {
        Calculator(5.0,6.0,'+');
    }
}

