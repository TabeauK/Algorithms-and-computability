using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using TAIO;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThreeFivePieceCrossesH()
        {
            Stopwatch sw = new Stopwatch();
            List<Element> l = new List<Element>
            {
                new FivePieceCross(1),
                new FivePieceCross(2),
                new FivePieceCross(3)
            };
            sw.Start();
            Solution hSolution = Functions.HeuristicAlgorithm(l);
            sw.Stop();
            Console.WriteLine("Rozwi¹zanie heurystyczne");
            Console.WriteLine($"Czas rozwi¹zania: {sw.Elapsed}");
            hSolution.Print();
        }
        
        [TestMethod]
        public void ThreeFivePieceCrosses()
        {
            Stopwatch sw = new Stopwatch();
            List<Element> l = new List<Element>
            {
                new FivePieceCross(1),
                new FivePieceCross(2),
                new FivePieceCross(3)
            };
            sw.Start();
            List<Solution> solutions = Functions.PreciseAlgorithm(l);
            sw.Stop();
            Console.WriteLine("Rozwi¹zanie dok³adne:");
            Console.WriteLine($"Czas rozwi¹zania: {sw.Elapsed}");
            int nr = 1;
            foreach (var sol in solutions)
            {
                Console.WriteLine("Rozwi¹zanie numer: {0}", nr);
                sol.Print();
                nr++;
            }
        }

        [TestMethod]
        public void H1()
        {
            Stopwatch sw = new Stopwatch();
            List<Element> l = new List<Element>
            {
                new FivePieceCross(1),
                new FivePieceU(2),
                new TwoPiece(3)
            };
            sw.Start();
            Solution hSolution = Functions.HeuristicAlgorithm(l);
            sw.Stop();
            Console.WriteLine("Rozwi¹zanie heurystyczne");
            Console.WriteLine($"Czas rozwi¹zania: {sw.Elapsed}");
            hSolution.Print();
        }

        [TestMethod]
           public void P1()
        {
            Stopwatch sw = new Stopwatch();
            List<Element> l = new List<Element>
            {
                new FivePieceCross(1),
                new FivePieceU(2),
                new TwoPiece(3)
            };
            sw.Start();
            List<Solution> solutions = Functions.PreciseAlgorithm(l);
            sw.Stop();
            Console.WriteLine("Rozwi¹zanie dok³adne:");
            Console.WriteLine($"Czas rozwi¹zania: {sw.Elapsed}");
            int nr = 1;
            foreach (var sol in solutions)
            {
                Console.WriteLine("Rozwi¹zanie numer: {0}", nr);
                sol.Print();
                nr++;
            }
        }
    }
}
