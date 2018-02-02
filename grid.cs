using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grid
{
    class Program
    {
        static void Main(string[] args)
        {
            //Build base array to act as grid
            string[] sArry ={
                "..........",
                "..........",
                "..........",
                "..........",
                "..........",
                "..........",
            };
            sArry = plot(3, 3, sArry, "X");
            foreach (string s in sArry) {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }

        static string grid(int x,int y, string[] grid) {
            //Get the y axis of the grid
            int gy = (grid.Length - y) - 1;
            //Return the substring
            return grid[gy].Substring(x, 1);
        }
        static string[] plot(int x, int y, string[] grid,string rep) {
            //Get y axis of grid
            int gy = (grid.Length - y) - 1;
            //Store array index value
            string gridPos = grid[gy];
            //Remove string at the x position and replace it with rep
            gridPos = gridPos.Remove(x,1).Insert(x, rep);
            //Update the array
            grid[gy] = gridPos;
            //send it.
            return grid;
        }
    }
}
