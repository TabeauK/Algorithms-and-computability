using System;
using System.Collections.Generic;
using System.Text;

namespace TAIO
{
    public class SixPieceStraight : Element
    {
        public SixPieceStraight(int id) : base(6, id, "|")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (4, 0), (5,0)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (0, 4), (0,5)));
            Cuts.Add((new FivePieceStraight(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceStraight(id), new ThreePieceStraight(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceStraight(id)));
        }
    }

    public class SixPieceL : Element
    {
        public SixPieceL(int id) : base(6, id, "L")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (4, 0), (4, -1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (4, 0), (0, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (0, 4), (1, 4)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (0, 4), (-1, 0)));
            Cuts.Add((new FivePieceStraight(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightL(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceStraight(id), new ThreePieceL(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceStraight(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightL(id)));
        }
    }

    public class SixPieceY : Element
    {
        public SixPieceY(int id) : base(6, id, "Y")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (4, 0), (3, -1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (4, 0), (1, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (0, 4), (1, 3)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (0, 4), (-1, 1)));
            Cuts.Add((new FivePieceStraight(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightL(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightY(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceStraight(id), new ThreePieceL(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceT(id)));
        }
    }

    public class SixPieceWideT : Element
    {
        public SixPieceWideT(int id) : base(6, id, "szerokie T")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (4, 0), (2, -1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (4, 0), (2, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (0, 4), (1, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (0, 4), (-1, 2)));
            Cuts.Add((new FivePieceStraight(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightY(id), new OnePiece(id)));
            Cuts.Add((new FivePieceLeftY(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceLeftL(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightL(id)));
        }
    }

    public class SixPieceN : Element
    {
        public SixPieceN(int id) : base(6, id, "N")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (4, -1), (3, -1)));
            Rotations.Add(new Rotation((0, 1), (1, 0), (2, 0), (3, 0), (4, 0), (1, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (1, 4), (1, 3)));
            Rotations.Add(new Rotation((-1, 0), (0, 1), (0, 2), (0, 3), (0, 4), (-1, 1)));
            Cuts.Add((new FivePieceRightN(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightL(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceStraight(id), new ThreePieceL(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceStraight(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightZ(id)));
        }
    }

    public class SixPieceP : Element
    {
        public SixPieceP(int id) : base(6, id, "P")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (4, -1), (3, -1)));
            Rotations.Add(new Rotation((0, 1), (1, 0), (2, 0), (3, 0), (4, 0), (1, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (1, 4), (1, 3)));
            Rotations.Add(new Rotation((-1, 0), (0, 1), (0, 2), (0, 3), (0, 4), (-1, 1)));
            Cuts.Add((new FivePieceRightP(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceStraight(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceSquare(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightL(id)));
        }
    }

    public class SixPieceBigF : Element
    {
        public SixPieceBigF(int id) : base(6, id, "Wielki F")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (1, -1), (3, -1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (0, 1), (2, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (1, 1), (1, 3)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 2), (-1, 0)));
            Cuts.Add((new FivePieceLeftY(id), new OnePiece(id)));
            Cuts.Add((new FivePieceU(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightL(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceL(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceT(id)));
        }
    }

    public class SixPieceU : Element
    {
        public SixPieceU(int id) : base(6, id, "U")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (0, 1), (3, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (0, -1), (3, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (1, 0), (1, 3)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 0), (-1, 3)));
            Cuts.Add((new FivePieceRightL(id), new OnePiece(id)));
            Cuts.Add((new FivePieceLeftL(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceL(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceLeftL(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightL(id)));
        }
    }

    public class SixPieceFatT : Element
    {
        public SixPieceFatT(int id) : base(6, id, "grube T")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (1, 1), (2, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (1, -1), (2, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (1, 1), (1, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 1), (-1, 2)));
            Cuts.Add((new FivePieceRightP(id), new OnePiece(id)));
            Cuts.Add((new FivePieceLeftP(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceL(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceStraight(id)));
        }
    }

    public class SixPieceV : Element
    {
        public SixPieceV(int id) : base(6, id, "V")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (3, -1), (3, -2)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (0, 1), (0, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (1, 3), (2, 3)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 0), (-2, 0)));
            Cuts.Add((new FivePieceRightL(id), new OnePiece(id)));
            Cuts.Add((new FivePieceV(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceStraight(id), new ThreePieceStraight(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceStraight(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceLeftL(id)));
        }
    }

    public class SixPieceWideY : Element
    {
        public SixPieceWideY(int id) : base(6, id, "szerokie Y")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (2, -1), (2, -2)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (1, 1), (1, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (1, 2), (2, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 1), (-2, 1)));
            Cuts.Add((new FivePieceRightY(id), new OnePiece(id)));
            Cuts.Add((new FivePieceV(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceStraight(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightL(id)));
            Cuts.Add((new FivePieceT(id), new OnePiece(id)));
        }
    }

    public class SixPieceTallT : Element
    {
        public SixPieceTallT(int id) : base(6, id, "wysokie T")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (3, -1), (3, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (0, 1), (0, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (1, 3), (-1, 3)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 0), (1, 0)));
            Cuts.Add((new FivePieceRightL(id), new OnePiece(id)));
            Cuts.Add((new FivePieceLeftL(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceStraight(id), new ThreePieceStraight(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceT(id)));
            Cuts.Add((new FivePieceT(id), new OnePiece(id)));
        }
    }

    public class SixPieceF : Element
    {
        public SixPieceF(int id) : base(6, id, "zY")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (2, 1), (3, -1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (0, 1), (1, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 2), (1, 3)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (1, 1), (-1, 0)));
            Cuts.Add((new FivePieceLeftY(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightL(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightF(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceLeftZ(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceLeftL(id)));
        }
    }
    
    public class SixPieceZY : Element
    {
        public SixPieceZY(int id) : base(6, id, "ZY")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (1, 1), (3, -1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (0, 1), (2, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 1), (1, 3)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (1, 2), (-1, 0)));
            Cuts.Add((new FivePieceRightY(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightL(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightZ(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceT(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceL(id)));
        }
    }

    public class SixPieceTallZ : Element
    {
        public SixPieceTallZ(int id) : base(6, id, "wysokie Z")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (0, 1), (3, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 0), (1, 3)));
            Cuts.Add((new FivePieceRightL(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightL(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceL(id)));
        }
    }

    public class SixPieceYY : Element
    {
        public SixPieceYY(int id) : base(6, id, "YY")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (1, 1), (2, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 1), (1, 2)));
            Cuts.Add((new FivePieceRightY(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightF(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceL(id)));
        }
    }

    public class SixPieceCross : Element
    {
        public SixPieceCross(int id) : base(6, id, "Krzyż")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (2, 1), (2, -1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, 0), (1, 1), (1, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 1), (1, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (0, 3), (-1, 2), (1, 2)));
            Cuts.Add((new FivePieceRightY(id), new OnePiece(id)));
            Cuts.Add((new FivePieceLeftY(id), new OnePiece(id)));
            Cuts.Add((new FivePieceT(id), new OnePiece(id)));
            Cuts.Add((new FivePieceCross(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceT(id)));
        }
    }

    public class SixPieceVF : Element
    {
        public SixPieceVF(int id) : base(6, id, "VF")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (3, -1), (2, -1), (2, -2)));
            Rotations.Add(new Rotation((0, 1), (1, 0), (2, 0), (3, 0), (1, 1), (1, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 3), (1, 2), (2, 2)));
            Rotations.Add(new Rotation((-1, 0), (0, 1), (0, 2), (0, 3), (-1, 1), (-2, 1)));
            Cuts.Add((new FivePieceLeftF(id), new OnePiece(id)));
            Cuts.Add((new FivePieceV(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightN(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceT(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceStraight(id)));
        }
    }

    public class SixPieceUN : Element
    {
        public SixPieceUN(int id) : base(6, id, "UN")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, -1), (2, -1), (3, -1)));
            Rotations.Add(new Rotation((0, 1), (1, 0), (2, 0), (3, 0), (1, 1), (3, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 3), (1, 2), (1, 0)));
            Rotations.Add(new Rotation((-1, 0), (0, 1), (0, 2), (0, 3), (-1, 1), (-1, 3)));
            Cuts.Add((new FivePieceU(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightN(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceLeftL(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightZ(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceL(id)));
        }
    }

    public class SixPieceWideZ : Element
    {
        public SixPieceWideZ(int id) : base(6, id, "szerokie Z")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, -1), (3, -1), (4, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 2), (1, 3), (1, 4)));
            Cuts.Add((new FivePieceRightN(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightL(id)));
            Cuts.Add((new ThreePieceStraight(id), new ThreePieceStraight(id)));
        }
    }

    public class SixPieceFatZ : Element
    {
        public SixPieceFatZ(int id) : base(6, id, "grube Z")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (1, -1), (2, -1), (3, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 1), (1, 2), (1, 3)));
            Cuts.Add((new FivePieceRightP(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceL(id)));
            Cuts.Add((new ThreePieceStraight(id), new ThreePieceStraight(id)));
        }
    }

    public class SixPieceRectangle : Element
    {
        public SixPieceRectangle(int id) : base(6, id, "prostokąt")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, 1), (1, 1), (2, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 0), (1, 1), (1, 2)));
            Cuts.Add((new TwoPiece(id), new FourPieceSquare(id)));
            Cuts.Add((new ThreePieceStraight(id), new ThreePieceStraight(id)));
        }
    }
    
    public class SixPieceTF : Element
    {
        public SixPieceTF(int id) : base(6, id, "TF")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, -1), (3, -1), (2, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, -1), (1, -1), (0, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 2), (-1, 2), (1, 3)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 0), (-1, 0), (-1, -1)));
            Cuts.Add((new TwoPiece(id), new FourPieceLeftL(id)));
            Cuts.Add((new FivePieceRightN(id), new OnePiece(id)));
            Cuts.Add((new FivePieceT(id), new OnePiece(id)));
            Cuts.Add((new FivePieceLeftF(id), new OnePiece(id)));
        }
    }
    
    public class SixPiecePP : Element
    {
        public SixPiecePP(int id) : base(6, id, "PP")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (0, 1), (1, 1), (0, -1), (-1, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (0, 1), (1, 1), (-1, 1), (1, 2)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (0, 1), (1, 1), (1, 2), (2, 0)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (0, 1), (1, 1), (2, 0), (0, -1)));
            Cuts.Add((new TwoPiece(id), new FourPieceLeftL(id)));
            Cuts.Add((new FivePieceRightP(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceStraight(id), new ThreePieceL(id)));
        }
    }

    public class SixPieceWF : Element
    {
        public SixPieceWF(int id) : base(6, id, "WF")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (1, 1), (2, -1), (3, -1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (1, -1), (0, 1), (-1, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (-1, 1), (1, 2), (1, 3)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 1), (-1, 0), (-1, -1)));
            Cuts.Add((new TwoPiece(id), new FourPieceT(id)));
            Cuts.Add((new FivePieceRightF(id), new OnePiece(id)));
            Cuts.Add((new FivePieceW(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightN(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceL(id)));
        }
    }

    public class SixPieceVZ : Element
    {
        public SixPieceVZ(int id) : base(6, id, "VZ")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, -1), (2, -2), (3, -2)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, 1), (0, 2), (-1, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 2), (2, 2), (2, 3)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (-1, 0), (-2, 0), (-2, -1)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightL(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceLeftL(id)));
            Cuts.Add((new FivePieceV(id), new OnePiece(id)));
            Cuts.Add((new FivePieceLeftZ(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceStraight(id)));
        }
    }

    public class SixPieceVN : Element
    {
        public SixPieceVN(int id) : base(6, id, "VN")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, -1), (3, -1), (3, -2)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, 1), (-1, -1), (-1, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 2), (1, 3), (2, 3)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (-1, 0), (-1, -1), (-2, -1)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightL(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceLeftZ(id)));
            Cuts.Add((new FivePieceW(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightN(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceStraight(id)));
        }
    }

    public class SixPieceJ : Element
    {
        public SixPieceJ(int id) : base(6, id, "J")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, -1), (0, -1), (0, -2)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, 1), (2, 1), (2, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 0), (2, 0), (1, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (-1, 0), (-1, 2), (-2, -2)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightL(id)));
            Cuts.Add((new FivePieceV(id), new OnePiece(id)));
            Cuts.Add((new FivePieceU(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceStraight(id)));
        }
    }
    public class SixPieceMi : Element
    {
        public SixPieceMi(int id) : base(6, id, "Mi")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, -1), (0, -1), (2, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, 1), (2, 1), (0, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 0), (1, 2), (-1, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (-1, 0), (1, 0), (-1, 2)));
            Cuts.Add((new TwoPiece(id), new FourPieceT(id)));
            Cuts.Add((new FivePieceT(id), new OnePiece(id)));
            Cuts.Add((new FivePieceU(id), new OnePiece(id)));
            Cuts.Add((new FivePieceLeftZ(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceStraight(id)));
        }
    }

    public class SixPieceTank : Element
    {
        public SixPieceTank(int id) : base(6, id, "Czołg")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, -1), (0, -1), (1, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (0, 1), (2, 1), (1, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 0), (1, 2), (-1, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (-1, 0), (1, 1), (-1, 2)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightZ(id)));
            Cuts.Add((new FivePieceRightF(id), new OnePiece(id)));
            Cuts.Add((new FivePieceU(id), new OnePiece(id)));
            Cuts.Add((new FivePieceLeftF(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceLeftZ(id)));
        }
    }

    public class SixPieceCamel : Element
    {
        public SixPieceCamel(int id) : base(6, id, "Wielbłąd")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, -1), (0, 1), (-1, 1)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (2, 0), (2, -1), (3, -1), (0, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 2), (-1, 0), (-1, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (0, 2), (1, 2), (-1, 0), (1, 3)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightZ(id)));
            Cuts.Add((new FivePieceRightZ(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceL(id)));
            Cuts.Add((new FivePieceRightN(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightL(id)));
        }
    }

    public class SixPieceSmallStairs : Element
    {
        public SixPieceSmallStairs(int id) : base(6, id, "Małe schodki")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (0, 1), (1, 1), (0, 2), (2, 0)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (0, 1), (1, 1), (2, 1), (0, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0), (1, 1), (1, -1), (-1, 1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0), (1, 1), (-1, 0), (1, 2)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightZ(id)));
            Cuts.Add((new FivePieceRightZ(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceL(id)));
            Cuts.Add((new FivePieceRightN(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceRightL(id)));
        }
    }

    public class SixPieceArrow : Element
    {
        public SixPieceArrow(int id) : base(6, id, "Strzałka")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (0, 1), (1, 1), (2, 1), (1, 2)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (0, 1), (1, 1), (2, 0), (1, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0), (1, 1), (0, -1), (-1, 0)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0), (1, 1), (-1, 1), (0, 2)));
            Cuts.Add((new FivePieceLeftP(id), new OnePiece(id)));
            Cuts.Add((new FivePieceRightP(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceT(id)));
        }
    }

    public class SixPieceQ : Element
    {
        public SixPieceQ(int id) : base(6, id, "Q")
        {
            Rotations.Add(new Rotation((0, 0), (1, 0), (0, 1), (1, 1), (2, 1), (2, 2)));
            Rotations.Add(new Rotation((0, 0), (1, 0), (0, 1), (1, 1), (1, -1), (2, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0), (1, 1), (-1, 0), (-1, -1)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 0), (1, 1), (0, 2), (-1, 2)));
            Cuts.Add((new FivePieceLeftP(id), new OnePiece(id)));
            Cuts.Add((new TwoPiece(id), new FourPieceSquare(id)));
            Cuts.Add((new FourPieceLeftL(id), new TwoPiece(id)));
            Cuts.Add((new FourPieceRightZ(id), new TwoPiece(id)));
        }
    }

    public class SixPieceBigStairs : Element
    {
        public SixPieceBigStairs(int id) : base(6, id, "Duże schodki")
        {
            Rotations.Add(new Rotation((0, 0), (-1, 0), (-1, 1), (-2, 1), (-2, 2), (-3, 2)));
            Rotations.Add(new Rotation((0, 0), (0, 1), (1, 1), (1, 2), (2, 2), (2, 3)));
            Cuts.Add((new FivePieceW(id), new OnePiece(id)));
            Cuts.Add((new ThreePieceL(id), new ThreePieceL(id)));
            Cuts.Add((new FourPieceRightZ(id), new TwoPiece(id)));
        }
    }

}
