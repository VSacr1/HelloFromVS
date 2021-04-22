namespace Shapy
{
    class Rectangle : Shapes
    {
        private double length { get; set; }
        private double breadth { get; set; }
        public Rectangle(double L, double B)
        {
            length = L;
            breadth = B;
        }
        public override double Area()
        {
            var area = length * breadth;
            return area;
        }
    }
    class RandomClass
    {
        private int length;

        public int Length
        {
            get { return length; }
            set { length = value + 500; }
        }

    }
    class SomeShape
    {
        protected int width;
        protected int height;

        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }

    }
    class SomeRectange : SomeShape
    {
        public int getArea()
        {
            return (width * height);
        }
    }

}
