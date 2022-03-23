using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace TAIO
{
    public static class Functions
    {
        public static (int, int) Calculate_rectangle(List<Element> elements)
        {
            int sum = 0;
            foreach (var elem in elements)
            {
                sum += elem.Size;
            }
            for (int i = (int)Math.Floor(Math.Sqrt(sum)); i > 0; i--)
            {
                if (sum % i == 0)
                {
                    return (i, sum / i);
                }
            }
            throw new NotSupportedException();
        }

        public static List<Solution> Backtrack(List<Element> elements, int index, Solution solution)
        {
            List<Solution> solutions = new List<Solution>();
            if (index < elements.Count)
            {
                for (int i = 0; i < solution.Height; i++)
                    for (int j = 0; j < solution.Width; j++)
                        if (solution.Board[i, j] == -1)
                            foreach (var rotation in elements[index].Rotations)
                                foreach (var newSolution in solution.Fit(rotation, i, j, elements[index].Id))
                                    foreach (var tmp in Backtrack(elements, index + 1, newSolution))
                                        if (!solutions.Contains(tmp))
                                            solutions.Add(tmp);
            }
            else
            {
                for (int i = 0; i < solution.Height; i++)
                    for (int j = 0; j < solution.Width; j++)
                        if (solution.Board[i, j] == -1)
                            return solutions;
                solutions.Add(solution);
            }
            return solutions;
        }

        public static Solution HeuristicAlgorithm(List<Element> elements)
        {
            (int wysokosc, int szerokosc) = Calculate_rectangle(elements);
            Solution solution = new Solution(wysokosc, szerokosc);
            while (elements.Count > 0)
            {
                Element elem = elements[0];
                elements.RemoveAt(0);
                bool trzeba_ciac = true;
                bool dodano = false;
                for (int i = 0; i < wysokosc; i++)
                {
                    for (int j = 0; j < szerokosc; j++)
                    {
                        if(solution.Board[i,j] ==-1)
                        {
                            foreach(var ulozenie in elem.Rotations)
                            {
                                (solution, dodano) = solution.Fit_heuristic(ulozenie, i, j, elem.Id);
                                if (dodano)
                                {
                                    trzeba_ciac = false;
                                    break;
                                }
                            }
                            if (dodano)
                                break;
                        }
                    }
                    if (dodano)
                        break;
                }
                if(trzeba_ciac)
                {
                    Element a = null;
                    Element b = null;
                    foreach(var (elem1,elem2) in elem.Cuts)
                    {
                        a = elem1;
                        b = elem2;
                        if (elem1.Size == 1 || elem2.Size == 1)
                            break;
                    }
                    elements.Add(a);
                    elements.Add(b);
                    solution.Steps += 1;
                }
            }
            return solution;
        }

        public static List<Solution> PreciseAlgorithm(List<Element> elements)
        {
            List<Solution> solutions = new List<Solution>();
            List<List<Element>> rozpatrzone = new List<List<Element>>();
            int min = int.MaxValue;
            (int wysokosc, int szerokosc) = Calculate_rectangle(elements);
            List<(List<Element> lista, int min)> l = new List<(List<Element>, int)>
            {
                (elements, 0)
            };
            int cmin = -1;
            while (l.Count > 0)
            {
                List<Element> elementy = l[0].lista;
                int elementy_min = l[0].min;
                l.RemoveAt(0);
                if (cmin < elementy_min)
                {
                    cmin++;
                    Console.WriteLine($"Rozpatrywnie zbiorów po zastosowaniu {cmin} operacji");
                }
                if (elementy_min <= min && !rozpatrzone.Contains(elementy))
                {
                    Solution new_solution = new Solution(wysokosc, szerokosc);
                    List<Solution> rozwiazania = Backtrack(elementy, 0, new_solution);
                    if( rozwiazania.Count >0)
                    {
                        foreach (var sol in rozwiazania)
                        {
                            sol.Steps = elementy_min;
                            if(!solutions.Contains(sol))
                                solutions.Add(sol);
                        }
                        min = elementy_min;
                    }
                    else
                    {
                        foreach(var element in elementy)
                        {
                            List<Element> tmp = new List<Element>(elementy);
                            tmp.Remove(element);
                            foreach(var (a,b) in element.Cuts)
                            {
                                List<Element> pom = new List<Element>(tmp)
                                {
                                    a,
                                    b
                                };
                                l.Add((pom, elementy_min + 1));
                            }
                        }
                    }
                }
                rozpatrzone.Add(elementy);
            }
            return solutions;
        }

        public static List<Element> Element5Factory(int[] elements)
        {
            int id = 0;
            List<Element> list = new List<Element>();
            for(int i=0;i<elements.Length;i++)
            {
                for(int j = 0;j<elements[i];j++)
                {
                    switch (i)
                    {
                        case 0:
                            list.Add(new FivePieceStraight(id));
                            break;
                        case 1:
                            list.Add(new FivePieceRightF(id));
                            break;
                        case 2:
                            list.Add(new FivePieceLeftF(id));
                            break;
                        case 3:
                            list.Add(new FivePieceRightL(id));
                            break;
                        case 4:
                            list.Add(new FivePieceLeftL(id));
                            break;
                        case 5:
                            list.Add(new FivePieceLeftP(id));
                            break;
                        case 6:
                            list.Add(new FivePieceRightP(id));
                            break;
                        case 7:
                            list.Add(new FivePieceRightN(id));
                            break;
                        case 8:
                            list.Add(new FivePieceLeftN(id));
                            break;
                        case 9:
                            list.Add(new FivePieceT(id));
                            break;
                        case 10:
                            list.Add(new FivePieceU(id));
                            break;
                        case 11:
                            list.Add(new FivePieceV(id));
                            break;
                        case 12:
                            list.Add(new FivePieceW(id));
                            break;
                        case 13:
                            list.Add(new FivePieceCross(id));
                            break;
                        case 14:
                            list.Add(new FivePieceLeftY(id));
                            break;
                        case 15:
                            list.Add(new FivePieceRightY(id));
                            break;
                        case 16:
                            list.Add(new FivePieceRightZ(id));
                            break;
                        case 17:
                            list.Add(new FivePieceLeftZ(id));
                            break;
                        default:
                            break;
                    }
                    id++;
                }
            }
            return list;
        }

        public static List<Element> Element6Factory(int[] elements)
        {
            int id = 0;
            List<Element> list = new List<Element>();
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements[i]; j++)
                {
                    switch (i)
                    {
                        case 0:
                            list.Add(new SixPieceStraight(id));
                            break;
                        case 1:
                            list.Add(new SixPieceL(id));
                            break;
                        case 2:
                            list.Add(new SixPieceY(id));
                            break;
                        case 3:
                            list.Add(new SixPieceWideT(id));
                            break;
                        case 4:
                            list.Add(new SixPieceN(id));
                            break;
                        case 5:
                            list.Add(new SixPieceP(id));
                            break;
                        case 6:
                            list.Add(new SixPieceBigF(id));
                            break;
                        case 7:
                            list.Add(new SixPieceU(id));
                            break;
                        case 8:
                            list.Add(new SixPieceFatT(id));
                            break;
                        case 9:
                            list.Add(new SixPieceV(id));
                            break;
                        case 10:
                            list.Add(new SixPieceWideY(id));
                            break;
                        case 11:
                            list.Add(new SixPieceTallT(id));
                            break;
                        case 12:
                            list.Add(new SixPieceF(id));
                            break;
                        case 13:
                            list.Add(new SixPieceZY(id));
                            break;
                        case 14:
                            list.Add(new SixPieceTallZ(id));
                            break;
                        case 15:
                            list.Add(new SixPieceYY(id));
                            break;
                        case 16:
                            list.Add(new SixPieceCross(id));
                            break;
                        case 17: 
                            list.Add(new SixPieceVF(id));
                            break;
                        case 18:
                            list.Add(new SixPieceUN(id));
                            break;
                        case 19:
                            list.Add(new SixPieceWideZ(id));
                            break;
                        case 20:
                            list.Add(new SixPieceFatZ(id));
                            break;
                        case 21: 
                            list.Add(new SixPieceRectangle(id));
                            break;
                        case 22:
                            list.Add(new SixPieceTF(id));
                            break;
                        case 23:
                            list.Add(new SixPiecePP(id));
                            break;
                        case 24:
                            list.Add(new SixPieceWF(id));
                            break;
                        case 25:
                            list.Add(new SixPieceVZ(id));
                            break;
                        case 26:
                            list.Add(new SixPieceVN(id));
                            break;
                        case 27:
                            list.Add(new SixPieceJ(id));
                            break;
                        case 28://
                            list.Add(new SixPieceMi(id));
                            break;
                        case 29:
                            list.Add(new SixPieceTank(id));
                            break;
                        case 30:
                            list.Add(new SixPieceCamel(id));
                            break;
                        case 31:
                            list.Add(new SixPieceSmallStairs(id));
                            break;
                        case 32:
                            list.Add(new SixPieceArrow(id));
                            break;
                        case 33:
                            list.Add(new SixPieceQ(id));
                            break;
                        case 34:
                            list.Add(new SixPieceBigStairs(id));
                            break;
                        default:
                            break;
                    }
                    id++;
                }
            }
            return list;
        }

        public static void CalculateOP(List<Element> list)
        {
            List<Element> list2 = new List<Element>(list);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Obliczenie rozwizania dla elementów:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}. ");
                Console.WriteLine($"{list[i]}");
            }
            Console.WriteLine("----------");
            Console.WriteLine("Obliczenie dla alogotymu dokładnego:");
            Stopwatch sw2 = new Stopwatch();
            sw2.Start();
            List<Solution> solutions = PreciseAlgorithm(list);
            sw2.Stop();
            Console.WriteLine("----------");
            Console.WriteLine("Rozwiązanie dokładne:");
            Console.WriteLine($"Czas rozwiązania: {sw2.Elapsed}");
            int nr = 1;
            Console.WriteLine($"Rozwiązanie numer: {nr}");
            solutions[0].Print();
            solutions.RemoveAt(0);
            Console.WriteLine($"Czy wydrukować pozostałe wyniki? Jest ich {solutions.Count} (y/n)");
            ConsoleKeyInfo c = Console.ReadKey();
            if(c.KeyChar == 'y')
                foreach (var sol in solutions)
                {
                    Console.WriteLine($"Rozwiązanie numer: {nr}");
                    sol.Print();
                    nr++;
                }
        }
        
        public static void CalculateHP(List<Element> list)
        {
            List<Element> list2 = new List<Element>(list);
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Obliczenie rozwizania dla elementów:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"{i + 1}. ");
                Console.WriteLine($"{list[i]}");
            }
            Console.WriteLine("----------");
            Console.WriteLine("Obliczenie dla alogotymu heurystycznego:");
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Solution solution = HeuristicAlgorithm(list2);
            sw.Stop();
            Console.WriteLine("Rozwiązanie heurystyczne:");
            Console.WriteLine($"Czas rozwiązania: {sw.Elapsed}");
            solution.Print();
        }
    }
}
