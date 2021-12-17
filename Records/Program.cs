using System;

namespace Records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RecPos rec = new(5, 5, new[] {"Hej", "Hopp"});
            rec.values[0] = "Nisse";
           // rec.values = new[] {"Nisse"};

            var recCopy = rec with { X = 56};
           

           // Position position = new(6) { X = 67 };
            // position.X = 69;
           // var (X,Y)= rec;
            //Console.WriteLine((X,Y));
            //Console.WriteLine(X);
            Console.WriteLine(rec);
            
        }
    }

    internal record class RecPos(int X, int Y, string[] values = default)
    {
        public static RecPos operator +(RecPos p1, RecPos p2) =>
            new RecPos(p1.Y + p2.Y, p1.X + p2.X);
    }
    internal record struct StructPos(int X, int Y);
    internal readonly record struct  ReadOnlyStructPos(int X, int Y);

    internal record Position
    {
        public int X { get; init; } 
        public int Y { get; init; }

        public Position(int y, int x) => (Y,X) = (y,x);
        //{
        //    Y = y;
        //   // X = x;
        //}

        //public static Position operator +(Position p1, Position p2) =>
        //    new Position(p1.Y + p2.Y, p1.X + p2.X);
    }
}
