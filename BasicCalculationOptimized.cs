using System;
public class BasicCalcOptimized
{
    public static void Main()
    {
        float x, y;
        char operation;
         
        Console.Write("Input first number: ");
        x = float.Parse(Console.ReadLine());
        Console.Write("Input operation: ");
        operation = Convert.ToChar(Console.Read());
        Console.Write("Input second number: ");
        y = float.Parse(Console.ReadLine());
         
        switch{
        case '+' :{
            Console.WriteLine("{0} + {1} = {2}", x, y, x+y);
            } break;
        case '-' :{
            Console.WriteLine("{0} + {1} = {2}", x, y, x-y);
            } break;
        case '*' :{
            Console.WriteLine("{0} + {1} = {2}", x, y, x*y);
            } break;
        case '/' :{
            if(y==0){
              Console.WriteLine("Cannot procede with '0' as Divisor");
            break;
            }
            else{ Console.WriteLine("{0} + {1} = {2}", x, y, x+y);
            } break;
       defalut: Console.WriteLine("Opps! something went wrong");
            break;
    }
}
