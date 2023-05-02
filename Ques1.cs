using System;
using System.Collections.Generic;


namespace sitecore
{
    public static class Ques1
    {
        public class Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public void Move(double deltaX, double deltaY)
            {
                X += deltaX;
                Y += deltaY;
            }

            public void Rotate(double angleInDegrees)
            {
                double angleInRadians = angleInDegrees * Math.PI / 180;
                double cosAngle = Math.Cos(angleInRadians);
                double sinAngle = Math.Sin(angleInRadians);

                double newX = X * cosAngle - Y * sinAngle;
                double newY = X * sinAngle + Y * cosAngle;

                X = newX;
                Y = newY;
            }
        }

        public class Line
        {
            public Point StartPoint { get; set; }
            public Point EndPoint { get; set; }

            public Line(Point startPoint, Point endPoint)
            {
                StartPoint = startPoint;
                EndPoint = endPoint;
            }

            public void Move(double deltaX, double deltaY)
            {
                StartPoint.Move(deltaX, deltaY);
                EndPoint.Move(deltaX, deltaY);
            }

            public void Rotate(double angleInDegrees)
            {
                StartPoint.Rotate(angleInDegrees);
                EndPoint.Rotate(angleInDegrees);
            }
        }

        public class Circle
        {
            public Point Center { get; set; }
            public double Radius { get; set; }

            public Circle(Point center, double radius)
            {
                Center = center;
                Radius = radius;
            }

            public void Move(double deltaX, double deltaY)
            {
                Center.Move(deltaX, deltaY);
            }

            public void Rotate(double angleInDegrees)
            {
                Center.Rotate(angleInDegrees);
            }
        }

        public class Aggregation
        {
            private List<object> figures;

            public Aggregation()
            {
                figures = new List<object>();
            }

            public void AddFigure(object figure)
            {
                figures.Add(figure);
            }

            public void RemoveFigure(object figure)
            {
                figures.Remove(figure);
            }

            public void Move(double deltaX, double deltaY)
            {
                foreach (object figure in figures)
                {
                    if (figure is Point point)
                    {
                        point.Move(deltaX, deltaY);
                    }
                    else if (figure is Line line)
                    {
                        line.Move(deltaX, deltaY);
                    }
                    else if (figure is Circle circle)
                    {
                        circle.Move(deltaX, deltaY);
                    }
                }
            }

            public void Rotate(double angleInDegrees)
            {
                foreach (object figure in figures)
                {
                    if (figure is Point point)
                    {
                        point.Rotate(angleInDegrees);
                    }
                    else if (figure is Line line)
                    {
                        line.Rotate(angleInDegrees);
                    }
                    else if (figure is Circle circle)
                    {
                        circle.Rotate(angleInDegrees);
                    }
                }
            }
        }
    }

}
