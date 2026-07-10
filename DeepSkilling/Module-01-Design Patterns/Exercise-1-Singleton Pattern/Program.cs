Logger logger1 = Logger.GetInstance();
Logger logger2 = Logger.GetInstance();

logger1.Display();

if (logger1 == logger2)
{
    Console.WriteLine("Same Object");
}