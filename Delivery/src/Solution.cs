using System;
using System.Collections.Generic;
using System.Text;

namespace TAIO
{
    public class Solution
    {
        public int Steps { get;  set; }
        public int[,] Board { get; private set; }

        public int Height { get; private set; }
        public int Width { get; private set; }
        public Solution(int height, int width)
        {
            Steps = 0;
            Height = height;
            Width = width;
            Board = new int[height, width];
            for (int i = height - 1; i >= 0; i--)
                for (int j = width - 1; j >= 0; j--)
                    Board[i, j] = -1;
        }

        private Solution Copy()
        {
            Solution solution = new Solution(Height, Width);
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    solution.Board[i, j] = Board[i, j];
            solution.Steps = Steps;
            return solution;
        }

        public void Print()
        {
            Console.WriteLine($"Liczba potrzebnych operacji: {Steps}");
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < Height; j++)
                {
                    Console.Write($"|{Board[j, i]:D2}");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine("");
        }

        public List<Solution> Fit(Rotation rotation, int height, int width, int id)
        {
            List<Solution> solutions = new List<Solution>();
            foreach(var (x, y) in rotation.Fields)
            {
                bool is_ok = true;
                Solution newSolution = Copy();
                foreach(var neighbor in rotation.Fields)
                {
                    int newHeight = height + neighbor.y - y;
                    int newWidth = width + neighbor.x - x;
                    if (newWidth >= 0 && newHeight >= 0 && newHeight < Height && newWidth < Width && Board[newHeight, newWidth] == -1)
                        newSolution.Board[newHeight, newWidth] = id;
                    else
                        is_ok = false;
                }
                if (is_ok)
                    solutions.Add(newSolution);
            }
            return solutions;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Solution solution)) return false;
            for (int i = 0; i < Height; i++)
                for (int j = 0; j < Width; j++)
                    if (Board[i, j] != solution.Board[i, j])
                        return false;
            return true;
        }
        public (Solution, bool) Fit_heuristic(Rotation rotation, int height, int width, int id)
        {
            Solution oldSolution = Copy();
            foreach (var (x, y) in rotation.Fields)
            {
                bool is_ok = true;
                Solution newSolution = Copy();
                foreach (var neighbor in rotation.Fields)
                {
                    int newHeight = height + neighbor.y - y;
                    int newWidth = width + neighbor.x - x;
                    if (newWidth >= 0 && newHeight >= 0 && newHeight < Height && newWidth < Width && Board[newHeight, newWidth] == -1)
                        newSolution.Board[newHeight, newWidth] = id;
                    else
                        is_ok = false;
                }
                if (is_ok)
                    return (newSolution, true);
            }
            return (oldSolution,false);
        }
    }
}
