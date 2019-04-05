using System;

public class Queen
{
    public Queen(int row, int column)
    {
        Row = row;
        Column = column;
    }

    public int Row { get; }
    public int Column { get; }
}

public static class QueenAttack
{
    public static bool CanAttack(Queen white, Queen black)
    {
        if (white.Row == black.Row || white.Column == black.Column)
            return true;
        int diffRow = Math.Abs(white.Row - black.Row);
        int diffCol = Math.Abs(white.Column - black.Column);
        if (diffRow == diffCol)
            return true;
        return false;
    }

    public static Queen Create(int row, int column)
    {
        if (row < 0 || column < 0 || row >= 8 || column >= 8)
            throw new ArgumentOutOfRangeException();
        return new Queen(row, column);
    }
}