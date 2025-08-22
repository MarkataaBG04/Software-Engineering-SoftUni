namespace _07.House_Painting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double heightHouse = double.Parse(Console.ReadLine());
            double lenghtSideWall = double.Parse(Console.ReadLine());
            double heightOfTriangleRoof = double.Parse(Console.ReadLine());

            double sideWall = heightHouse * lenghtSideWall;
            double windowsArea = 1.5 * 1.5;
            double sideWallArea = sideWall * 2 - windowsArea * 2;

            double backWall = heightHouse * heightHouse;
            double doorArea = 1.2 * 2;
            double frontBackWallArea = backWall * 2 - doorArea;

            double allWalls = sideWallArea + frontBackWallArea;
            double greenPaint = allWalls / 3.4;


            double roofRectangulars = (heightHouse * lenghtSideWall) * 2;
            double roofTriangle = 2 * (heightHouse * heightOfTriangleRoof / 2);
            double totalRoofArea = roofRectangulars + roofTriangle;

            double redPaint = totalRoofArea / 4.3;

            Console.WriteLine($"{greenPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");
            
        }
    }
}