using System;
namespace Example
{
    class Box
    {
        private int length;
        private int width;
        private int height;

        public Box(int length, int width, int height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public int GetLength() { return length; }
        public int GetWidth() { return width; }
        public int GetHeight() { return height; }

        public static Box operator +(Box box1, Box box2)
        {
            return new Box(box1.GetLength() + box2.GetLength(),
                box1.GetWidth() + box2.GetWidth(),
                box1.GetHeight() + box2.GetHeight());
        }

    }

    class Program
    {
        static void Main(String[] args)
        {
            Box box1 = new Box(2, 3, 4);
            Box box2 = new Box(2, 3, 4);
            Box box3 = box1 + box2;

            System.Diagnostics.Debug.WriteLine("Lenght: " + box3.GetLength());
            System.Diagnostics.Debug.WriteLine("Width: " + box3.GetWidth());
            System.Diagnostics.Debug.WriteLine("Height: " + box3.GetHeight());

        }
    }
}