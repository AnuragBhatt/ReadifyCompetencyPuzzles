using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadifyCompetencyPuzzles
{
    class TypeOfTriangle
    {
        private const string INVALID = "Invalid Triangle";
        private const string SCALENE = "Scalene Triangle";
        private const string ISOSCELES = "Isosceles Triangle";
        private const string EQUILATERAL = "Equilateral Triangle";

        public static void Run()
        {
            string triangleType = new TypeOfTriangle().DetermineTriangleType(0, 5, 5);
            Console.WriteLine(triangleType);
        }
        string DetermineTriangleType(int x, int y, int z)//where x, y, z are the length of each side, respectively.
        {
            if (x <= 0 || y <= 0 || z <= 0)
                return INVALID;//invalid triangle.
            if (x == y && y == z)//equilateral triangle
                return EQUILATERAL;
            else
            { 
                if (IsValidTriangle(x, y, z))//check for 
                {
                    //check for isosceles condition.
                    if (IsIsosceles(x, y, z))
                        return ISOSCELES;
                    return SCALENE;
                }
                else
                    return INVALID;
            }
        }
        bool IsValidTriangle(int x, int y, int z)
        {
            //find the greatest side.
            int greatestSide = x < y ? (y < z ? z : y) : (x < z ? z : x);
            if (greatestSide == x)
            {
                return x < y + z;
            }
            else if (greatestSide == y)
            {
                return y < x + z;
            }
            else
            {
                return z < x + y;
            }
        }
        bool IsIsosceles(int x, int y, int z)
        {
            if (x == y || y == z || x == z) return true;
            return false;
        }
    }
}
