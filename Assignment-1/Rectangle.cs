using System;

namespace RecatangleClass
{
    //define rectangle class
    class Rectangle
    {
        //attributes
        double width;
        double height;

        //constructor
        public Rectangle(double rectangleWidth, double rectangleHeight)
        {
            width = rectangleWidth;
            height = rectangleHeight;
        }

        //Method to return perimeter of the rectangle
        public double GetPerimeter()
        {
            return 2 * (width + height);
        }

        //Method to return area of the rectangle
        public double GetArea()
        {
            return width * height;
        }
    }

}