Console.WriteLine("SAMETGCN Calculation Machine.");
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("0-Exit");
Console.WriteLine("1- Addition");
Console.WriteLine("2- Subtraction");
Console.WriteLine("3- Multiplication");
Console.WriteLine("4- Partition");
Console.WriteLine("5- Cos");
Console.WriteLine("6- Sin");
Console.WriteLine("7- SinCos");
Console.WriteLine("8-Tan");
Console.WriteLine("9- Abs");
Console.WriteLine("10- Square Root");
Console.WriteLine("11- Cube Root");
Console.WriteLine("12-Base/Pow");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Plese enter a value:");
int value = Convert.ToInt32(Console.ReadLine());


switch(value)
{
    case 0:
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Thank You For Using My Program:).");
        break;

     case 1:
        
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Enter First Number:");
            int advalue1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int advalue2 = Convert.ToInt32(Console.ReadLine());
            int ad3 = advalue1 + advalue2;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Result: " + ad3);
            break;
        
    case 2:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Enter First Number:");
        int advalue3 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number:");
        int advalue4 = Convert.ToInt32(Console.ReadLine());
        int ad4 = advalue3 - advalue4;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Result: " + ad4);
        break;

    case 3:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Enter First Number:");
        int advalue7 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number:");
        int advalue8 = Convert.ToInt32(Console.ReadLine());
        int ad9 = advalue7 * advalue8;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Result: " + ad9);
        break;
    case 4:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Enter First Number:");
        int advalue9 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number:");
        int advalue10 = Convert.ToInt32(Console.ReadLine());
        int ad11 = advalue9 / advalue10;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Result: " + ad11);
        break;
    case 5:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Enter  Number:");
        int cos = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Result: " + Math.Cos(cos));
        break;
    case 6:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Enter  Number:");
        int sin = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Result: " + Math.Sin(sin));
        break;
    case 7:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Enter  Number:");
        int sincos = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Result: " + Math.SinCos(sincos));
        break;
    case 8:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Enter  Number:");
        int tan = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Result" + Math.Cos(tan));
        break;
    case 9:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Enter  Number:");
        int abs = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Resul: " + Math.Abs(abs));
        break;
    
    case 10:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Enter  Number:");
        int sqrt = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Result: " + Math.Sqrt(sqrt));
        break;
    case 11:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Enter  Number:");
        int cbrt = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Result: " + Math.Cbrt(cbrt));
        break;
    case 12:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Enter   First Number:");
        int base1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter   Second Number:");
        int base2 = Convert.ToInt32(Console.ReadLine());
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Result: " + Math.Pow(base1,base2));
        break;

}
          
        
        


