using System;
using System.Collections.Generic;
using System.Text;

namespace TAIO
{
    public abstract class Element
    {
        public int Size { get; private set; }

        public int Id { get; private set; }

        public string Type { get; private set; }

        public List<Rotation> Rotations { get; private set; }

        public List<(Element a, Element b)> Cuts { get; private set; }

        public override string ToString()
        {
            return $"Rozmiar: {Size}\n" +
            $"Ułożenie: {Type}\n" +
            $"Id: {Id}";
        }

        public Element(int size, int id, string type)
        {
            Size = size;
            Id = id;
            Rotations = new List<Rotation>();
            Cuts = new List<(Element a, Element b)>();
            Type = type;
        }
    }

    public class OnePiece : Element
    {
        public OnePiece(int Id) : base(1, Id, "Kwadrat")
        {
            Rotations.Add(new Rotation((0, 0)));
        }
    }

    public class TwoPiece : Element
    {
        public TwoPiece(int id) : base(2, id, "|")
        {
            Rotations.Add(new Rotation((0, 0), (0, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0)));
            Cuts.Add((new OnePiece(id), new OnePiece(id)));
        }
    }

    public class ThreePieceStraight : Element
    {
        public ThreePieceStraight(int id) : base(3, id, "|")
        {
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0)));
            Cuts.Add((new OnePiece(id), new TwoPiece(id)));
        }
    }

    public class ThreePieceL : Element
    {
        public ThreePieceL(int id) : base(3, id, "L")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (1, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (0,-1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (-1, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0)));
            Cuts.Add((new OnePiece(id), new TwoPiece(id)));
        }
    }

    public class FourPieceSquare : Element
    {
        public FourPieceSquare(int id) : base(4, id, "Kwadrat")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (1, 1), (0, 1)));
            Cuts.Add((new TwoPiece(id), new TwoPiece(id)));
        }
    }

    public class FourPieceStraight : Element
    {
        public FourPieceStraight(int id) : base(4, id, "|")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3)));
            Cuts.Add((new TwoPiece(id), new TwoPiece(id)));
            Cuts.Add((new ThreePieceStraight(id), new OnePiece(id)));
        }
    }

    public class FourPieceRightZ : Element
    {
        public FourPieceRightZ(int id) : base(4, id, "Z")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (1, -1), (2, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 1), (1, 2)));
            Cuts.Add((new TwoPiece(id), new TwoPiece(id)));
            Cuts.Add((new OnePiece(id), new ThreePieceL(id)));
        }
    }

    public class FourPieceLeftZ : Element
    {
        public FourPieceLeftZ(int id) : base(4, id, "odwrócone Z")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (1, 1), (2, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (-1, 1), (-1, -2)));
            Cuts.Add((new TwoPiece(id), new TwoPiece(id)));
            Cuts.Add((new OnePiece(id), new ThreePieceL(id)));
        }
    }

    public class FourPieceRightL : Element
    {
        public FourPieceRightL(int id) : base(4, id, "odwrocone L")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (0, 1), (0, 2)));
            Rotations.Add(new Rotation((0, 0), (-1, 2), (0, 1), (0, 2)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, -1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, 1)));
            Cuts.Add((new TwoPiece(id), new TwoPiece(id)));
            Cuts.Add((new ThreePieceL(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceStraight(id), new OnePiece(id)));
        }
    }

    public class FourPieceLeftL : Element
    {
        public FourPieceLeftL(int id) : base(4, id, "L")
        {
            Rotations.Add(new Rotation((0, 0), (-1, 0), (0, 1), (0, 2)));
            Rotations.Add(new Rotation((0, 0), (2, 1), (0, 1), (0, 2)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, -1)));
            Cuts.Add((new TwoPiece(id), new TwoPiece(id)));
            Cuts.Add((new ThreePieceL(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceStraight(id), new OnePiece(id)));
        }
    }

    public class FourPieceT : Element
    {
        public FourPieceT(int id) : base(4, id, "T")
        {
            Rotations.Add(new Rotation((0, 0), (-1, 0), (1, 0), (0, -1)));
            Rotations.Add(new Rotation((0, 0), (-1, 0), (1, 0), (0, 1)));
            Rotations.Add(new Rotation((0, 0), (-1, 0), (0, -1), (0, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (0, -1), (0, 1)));
            Cuts.Add((new ThreePieceL(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceStraight(id), new OnePiece(id)));
        }
    }
}
