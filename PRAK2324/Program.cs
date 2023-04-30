namespace PRAK2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();
            string Temp;
            string MainFigure = "";
            for (int i = 0; ;)
            {
                Console.WriteLine("\nВведіть доступну команду:\n(new - ініціалізувати фігуру)\n(end - завершити виконання програми)");
                if (i > 0) Console.WriteLine("(area - площа фігури)\n(perimetr - периметр фігури)");
                Temp = Console.ReadLine().ToLower();

                if (Temp == "new")
                {
                    Console.WriteLine("\n(rectangle - прямокутник)\n(circle - коло)");
                    string FigureTemp = Console.ReadLine().ToLower();
                    if (FigureTemp == "rectangle")
                    {
                        try
                        {
                            rectangle = GetInitRectangle();
                            MainFigure = "rectangle";
                            i++;
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }
                    }
                    else if (FigureTemp == "circle")
                    {
                        for (; ; )
                        {
                            try
                            {
                                InitCircle(ref circle);
                                i++;
                                MainFigure = "circle";
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                    }
                }
                else if (Temp == "area" && i > 0)
                {
                    if (MainFigure == "rectangle")
                    {
                        Console.WriteLine($"\nПлоща прямокутника = {rectangle.Area()}");
                    }
                    else if (MainFigure == "circle")
                    {
                        Console.WriteLine($"\nПлоща кола = {circle.Area()}");
                    }
                }
                else if (Temp == "perimetr" && i > 0)
                {
                    if (MainFigure == "rectangle")
                    {
                        Console.WriteLine($"\nПериметр прямокутника = {rectangle.Perimeter()}");
                    }
                    else if (MainFigure == "circle")
                    {
                        Console.WriteLine($"\nДовжина кола = {circle.Perimeter()}");
                    }
                }
                else if (Temp == "clear")
                {
                    Console.Clear();
                }
                else if(Temp == "end")
                {
                    break;
                }
            }//end for
        }
        static private Rectangle GetInitRectangle()
        {
            try
            {
                float TopLeftX, TopLeftY, BottomLeftX, BottomLeftY, TopRightX, TopRightY, BottomRightX, BottomRightY;

                Console.Write("\nВведіть координату X для лівої нижньої координати прямокутника = ");
                BottomLeftX = Single.Parse(Console.ReadLine());
                Console.Write("\nВведіть координату Y для лівої нижньої координати прямокутника = ");
                BottomLeftY = Single.Parse(Console.ReadLine());

                Console.Write("\nВведіть координату X для лівої верхньої координати прямокутника = ");
                TopLeftX = Single.Parse(Console.ReadLine());
                Console.Write("\nВведіть координату Y для лівої верхньої координати прямокутника = ");
                TopLeftY = Single.Parse(Console.ReadLine());

                Console.Write("\nВведіть координату X для правої нижньої координати прямокутника = ");
                BottomRightX = Single.Parse(Console.ReadLine());
                Console.Write("\nВведіть координату Y для правої нижньої координати прямокутника = ");
                BottomRightY = Single.Parse(Console.ReadLine());

                Console.Write("\nВведіть координату X для правої верхньої координати прямокутника = ");
                TopRightX = Single.Parse(Console.ReadLine());
                Console.Write("\nВведіть координату Y  для правої верхньої координати прямокутника = ");
                TopRightY = Single.Parse(Console.ReadLine());

                return new Rectangle(TopLeftX, TopLeftY, BottomLeftX, BottomLeftY, TopRightX, TopRightY, BottomRightX, BottomRightY);
            }
            catch (Exception)
            {
                throw new Exception("\nНекоректні дані!");
            }
        }
        static void InitCircle(ref Circle circle)
        {
            try
            {
                Console.Write("\nВведіть радіус кола: ");
                float Radius = Single.Parse(Console.ReadLine());
                circle = new Circle(Radius);
            }
            catch (Exception)
            {
                throw new Exception("\nНекоректні дані!");
            }
        }
    }
}