using System;
using System.Collections.Generic;
using System.Text;

namespace TAIO
{
    public class FivePieceStraight : Element
    {
        public FivePieceStraight(int id) : base(5, id, "|")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (4, 0)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (0, 4)));
            Cuts.Add((new FourPieceStraight(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new ThreePieceStraight(id)));
        }
    }

    public class FivePieceRightN : Element
    {
        public FivePieceRightN(int id) : base(5, id, "N")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, -1), (3, -1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, 1), (-1, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 2), (1, 3)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (-1, 0), (-1, -1)));
            Cuts.Add((new FourPieceRightL(id), new OnePiece(id)));
            Cuts.Add((new FourPieceRightZ(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new ThreePieceStraight(id)));
            Cuts.Add((new TwoPiece(id), new ThreePieceL(id)));
        }
    }

    public class FivePieceLeftN : Element
    {
        public FivePieceLeftN(int id) : base(5, id, "odwrócone N")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, 1), (3, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, -1), (-1, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (-1, 2), (-1, 3)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 0), (1, -1)));
            Cuts.Add((new FourPieceLeftL(id), new OnePiece(id)));
            Cuts.Add((new FourPieceLeftZ(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new ThreePieceStraight(id)));
            Cuts.Add((new TwoPiece(id), new ThreePieceL(id)));
        }
    }

    public class FivePieceV : Element
    {
        public FivePieceV(int id) : base(5, id, "V")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, 1), (0, 2)));
            Rotations.Add(new Rotation((0, 0), (-1, 0), (-2, 0), (0, 1), (0, 2)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, -1), (0, -2)));
            Rotations.Add(new Rotation((0, 0), (-1, 0), (-2, 0), (0, -1), (0, -2)));
            Cuts.Add((new FourPieceLeftL(id), new OnePiece(id)));
            Cuts.Add((new FourPieceRightL(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new ThreePieceStraight(id)));
        }
    }

    public class FivePieceT : Element
    {
        public FivePieceT(int id) : base(5, id, "T")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, 1), (0, -1)));
            Rotations.Add(new Rotation((0, 0), (-1, 0), (-2, 0), (0, 1), (0, -1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, -1), (2, 1)));
            Rotations.Add(new Rotation((0, 0), (-1, 0), (-2, 0), (-2, -1), (-2, 1)));
            Cuts.Add((new FourPieceT(id), new OnePiece(id)));
            Cuts.Add((new FourPieceRightL(id), new OnePiece(id)));
            Cuts.Add((new FourPieceLeftL(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new ThreePieceStraight(id)));
        }
    }

    public class FivePieceU : Element
    {
        public FivePieceU(int id) : base(5, id, "U")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, 1), (2, 1)));
            Rotations.Add(new Rotation((0, 0), (-1, 0), (-2, 0), (0, 1), (-2, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, -1), (2, -1)));
            Rotations.Add(new Rotation((0, 0), (-1, 0), (-2, 0), (-2, -1), (0, -1)));
            Cuts.Add((new FourPieceRightL(id), new OnePiece(id)));
            Cuts.Add((new FourPieceLeftL(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new ThreePieceL(id)));
        }
    }

    public class FivePieceLeftL : Element
    {
        public FivePieceLeftL(int id) : base(5, id, "L")
        {
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 3)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (1, 0)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (3, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (0, -1)));
            Cuts.Add((new FourPieceStraight(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new TwoPiece(id)));
            Cuts.Add((new ThreePieceStraight(id), new TwoPiece(id)));
            Cuts.Add((new FourPieceLeftL(id), new OnePiece(id)));
        }
    }

    public class FivePieceRightL : Element
    {
        public FivePieceRightL(int id) : base(5, id, "odwrócone L")
        {
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (1, 3)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 0)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (3, -1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (0, 1)));
            Cuts.Add((new FourPieceStraight(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new TwoPiece(id)));
            Cuts.Add((new ThreePieceStraight(id), new TwoPiece(id)));
            Cuts.Add((new FourPieceRightL(id), new OnePiece(id)));
        }
    }

    public class FivePieceLeftY : Element
    {
        public FivePieceLeftY(int id) : base(5, id, "odwrócone Y")
        {
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (1, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (2, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (1, -1)));
            Cuts.Add((new FourPieceStraight(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new TwoPiece(id)));
            Cuts.Add((new FourPieceT(id), new OnePiece(id)));
            Cuts.Add((new FourPieceLeftL(id), new OnePiece(id)));
        }
    }

    public class FivePieceRightY : Element
    {
        public FivePieceRightY(int id) : base(5, id, "Y")
        {
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (1, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (2, -1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (1, 1)));
            Cuts.Add((new FourPieceStraight(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new TwoPiece(id)));
            Cuts.Add((new FourPieceT(id), new OnePiece(id)));
            Cuts.Add((new FourPieceRightL(id), new OnePiece(id)));
        }
    }

    public class FivePieceLeftZ : Element
    {
        public FivePieceLeftZ(int id) : base(5, id, "Z")
        {
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 0), (-1, 2)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, -1), (2, 1)));
            Cuts.Add((new ThreePieceL(id), new TwoPiece(id)));
            Cuts.Add((new FourPieceLeftL(id), new OnePiece(id)));
        }
    }

    public class FivePieceRightZ : Element
    {
        public FivePieceRightZ(int id) : base(5, id, "odwrócone Z")
        {
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (-1, 0), (1, 2)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, 1), (2, -1)));
            Cuts.Add((new ThreePieceL(id), new TwoPiece(id)));
            Cuts.Add((new FourPieceRightL(id), new OnePiece(id)));
        }
    }

    public class FivePieceW : Element
    {
        public FivePieceW(int id) : base(5, id, "W")
        {
            Rotations.Add(new Rotation((0, 0), (0, 1), (-1, 1), (1, 0), (1, -1)));
            Rotations.Add(new Rotation((0, 0), (0, -1), (-1, 1), (-1, 0), (1, -1)));
            Rotations.Add(new Rotation((0, 0), (-1, -1), (1, 1), (1, 0), (0, 1)));
            Rotations.Add(new Rotation((0, 0), (-1, -1), (1, 1), (-1, 0), (0, -1)));
            Cuts.Add((new ThreePieceL(id), new TwoPiece(id)));
            Cuts.Add((new FourPieceRightZ(id), new OnePiece(id)));
            Cuts.Add((new FourPieceLeftZ(id), new OnePiece(id)));
        }
    }

    public class FivePieceLeftP : Element
    {
        public FivePieceLeftP(int id) : base(5, id, "odwrocone P")
        {
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0), (1, 1), (0, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0), (1, 1), (2, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0), (1, 1), (1, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0), (1, 1), (-1, 0)));
            Cuts.Add((new ThreePieceL(id), new TwoPiece(id)));
            Cuts.Add((new ThreePieceStraight(id), new TwoPiece(id)));
            Cuts.Add((new FourPieceSquare(id), new OnePiece(id)));
        }
    }

    public class FivePieceRightP : Element
    {
        public FivePieceRightP(int id) : base(5, id, "P")
        {
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0), (1, 1), (1, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0), (1, 1), (2, 0)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0), (1, 1), (0, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0), (1, 1), (-1, 1)));
            Cuts.Add((new ThreePieceL(id), new TwoPiece(id)));
            Cuts.Add((new ThreePieceStraight(id), new TwoPiece(id)));
            Cuts.Add((new FourPieceSquare(id), new OnePiece(id)));
        }
    }

    public class FivePieceCross : Element
    {
        public FivePieceCross(int id) : base(5, id, "X")
        {
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0), (0, -1), (-1, 0)));
            Cuts.Add((new FourPieceT(id), new OnePiece(id)));
        }
    }

    public class FivePieceLeftF : Element
    {
        public FivePieceLeftF(int id) : base(5, id, "odwrocone F")
        {
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (-1, 2), (1, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 1), (-1, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, 1), (1, -1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, -1), (1, 1)));
            Cuts.Add((new ThreePieceL(id), new TwoPiece(id)));
            Cuts.Add((new FourPieceT(id), new OnePiece(id)));
            Cuts.Add((new FourPieceLeftL(id), new OnePiece(id)));
            Cuts.Add((new FourPieceLeftZ(id), new OnePiece(id)));
        }
    }

    public class FivePieceRightF : Element
    {
        public FivePieceRightF(int id) : base(5, id, "F")
        {
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 2), (-1, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, -1), (1, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, -1), (1, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, 1), (1, -1)));
            Cuts.Add((new ThreePieceL(id), new TwoPiece(id)));
            Cuts.Add((new FourPieceT(id), new OnePiece(id)));
            Cuts.Add((new FourPieceRightL(id), new OnePiece(id)));
            Cuts.Add((new FourPieceRightZ(id), new OnePiece(id)));
        }
    }
}
