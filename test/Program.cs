
namespace Program
{
    class Rectangle
    {
        //поле
        private int width;

        private int height;

        public Rectangle(int width, int height)
        {
            this.height = height;
            this.width = width;
        }

        //свойство
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                //строим логику в сеттере
                if (value <= 0)
                    width = 1;
                else
                    width = value;
            }
        }

        public int calcArea()
        {
            return this.height * this.width;
        }

    }

    class Osnova
    {
        public static void Main()
        {
            //экземпляры
            var obj = new Rectangle(2, 5);
            var obj2 = new Rectangle(4, 10);
            var obj3 = new Rectangle(8, 20);

            //обращаемся к полю через свойство
            obj.Width = -20;
            Console.WriteLine(obj.Width);

            Console.WriteLine(obj.calcArea());
            Console.WriteLine(obj2.calcArea());
            Console.WriteLine(obj3.calcArea());

        }
    }
}