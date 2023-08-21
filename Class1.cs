namespace floralplayingcards
{
    internal class Blocker
    {
        public int Size { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }
        public Blocker(int size, int row, int column)
        {
            Size = size;
            Row = row;
            Column = column;
        }
    }
}
