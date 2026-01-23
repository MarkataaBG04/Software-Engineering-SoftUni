namespace _03.Longer_Line
{
    internal class Program
    {
        static void Main()
        {
            // ====== ЧЕТЕМ ВХОДА ======
            // Координати на първата линия (точка 1 и точка 2)
            double x1 = double.Parse(Console.ReadLine()); // x на първа точка от линия 1
            double y1 = double.Parse(Console.ReadLine()); // y на първа точка от линия 1
            double x2 = double.Parse(Console.ReadLine()); // x на втора точка от линия 1
            double y2 = double.Parse(Console.ReadLine()); // y на втора точка от линия 1

            // Координати на втората линия (точка 3 и точка 4)
            double x3 = double.Parse(Console.ReadLine()); // x на първа точка от линия 2
            double y3 = double.Parse(Console.ReadLine()); // y на първа точка от линия 2
            double x4 = double.Parse(Console.ReadLine()); // x на втора точка от линия 2
            double y4 = double.Parse(Console.ReadLine()); // y на втора точка от линия 2

            // ====== СМЯТАМЕ ДЪЛЖИНАТА НА ЛИНИИТЕ ======
            // line1LengthSq = "число", което показва колко е дълга линия 1
            double line1LengthSq = GetLineLengthSq(x1, y1, x2, y2);

            // line2LengthSq = "число", което показва колко е дълга линия 2
            double line2LengthSq = GetLineLengthSq(x3, y3, x4, y4);

            // ====== СРАВНЯВАМЕ ДВЕТЕ ЛИНИИ ======
            // Ако първата линия е по-дълга ИЛИ равна → взимаме нея
            if (line1LengthSq >= line2LengthSq)
            {
                PrintLineClosestFirst(x1, y1, x2, y2);
            }
            else
            {
                PrintLineClosestFirst(x3, y3, x4, y4);
            }
        }

        // ====== МЕТОД ЗА ДЪЛЖИНА НА ЛИНИЯ ======
        static double GetLineLengthSq(double x1, double y1, double x2, double y2)
        {
            // dx = разлика по X между двете точки
            double dx = x2 - x1;

            // dy = разлика по Y между двете точки
            double dy = y2 - y1;

            // Връщаме число, което показва дължината (без корен)
            return dx * dx + dy * dy;
        }

        // ====== МЕТОД ЗА ПЕЧАТ ======
        static void PrintLineClosestFirst(double x1, double y1, double x2, double y2)
        {
            // dist1Sq = колко е далеч първата точка от (0,0)
            double dist1Sq = x1 * x1 + y1 * y1;

            // dist2Sq = колко е далеч втората точка от (0,0)
            double dist2Sq = x2 * x2 + y2 * y2;

            // Ако първата точка е по-близо (или равна)
            if (dist1Sq <= dist2Sq)
            {
                Console.WriteLine($"({x1}, {y1})({x2}, {y2})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})({x1}, {y1})");
            }
        }
    }
}