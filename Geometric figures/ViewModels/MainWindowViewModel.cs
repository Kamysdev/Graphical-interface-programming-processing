using System;
using System.Collections.ObjectModel;
using Avalonia.Controls.Shapes;
using Geometric_figures.Entity;

namespace Geometric_figures.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<PolyLineObserver> Points { get; set; } = [];

        public Entity.Rectangle Square { get; set; }
        public Entity.Rectangle Rectangle { get; set; }
        public Entity.Triangle Triangle { get; set; }

        public double ShiftingX
        {
            get => _shiftingX;
            set 
            { 
                _shiftingX = value; 
                OnPropertyChanged(nameof(ShiftingX));
                if (DrawTriangle() == true) { }
            }
        }
        private double _shiftingX = 5;

        public double ShiftingY
        {
            get => _shiftingY;
            set { _shiftingY = value; OnPropertyChanged(nameof(ShiftingY)); DrawTriangle(); }
        }
        private double _shiftingY = 5;

        public MainWindowViewModel()
        {

        }

        public void Button_DrawTriangle()
        {
            FigureLib figureLib = new FigureLib();
            Triangle = figureLib.GenerateTriangle();

            DrawTriangle();
        }

        public bool DrawTriangle()
        {
            try
            {
                Triangle.ShiftX(ShiftingX - 5);
                Triangle.ShiftY(ShiftingY - 5);
                Points.Clear();
                Points.Add(new PolyLineObserver(Triangle.GetPoint1(), Triangle.GetPoint2()));
                Points.Add(new PolyLineObserver(Triangle.GetPoint2(), Triangle.GetPoint3()));
                Points.Add(new PolyLineObserver(Triangle.GetPoint3(), Triangle.GetPoint1()));
            }
            catch
            {
                return false;
            }

            return true;
        }

        public void Button_DrawRectangle()
        {
            FigureLib figLib = new FigureLib();
            Rectangle = figLib.GenerateRectangle();
            Points.Clear();

            DrawRectangle(Rectangle);
        }


        public void Button_DrawSquare()
        {
            FigureLib figLib = new FigureLib();
            Square = figLib.GenerateSquare();
            Points.Clear();

            DrawRectangle(Square);
        }


        void DrawRectangle(Entity.Rectangle _rectangle)
        {
            _rectangle.ShiftX(ShiftingX - 5);
            Points.Add(new PolyLineObserver(_rectangle.GetPoint1(), _rectangle.GetPoint2()));
            Points.Add(new PolyLineObserver(_rectangle.GetPoint1(), _rectangle.GetPoint3()));
            Points.Add(new PolyLineObserver(_rectangle.GetPoint3(), _rectangle.GetPoint4()));
            Points.Add(new PolyLineObserver(_rectangle.GetPoint4(), _rectangle.GetPoint2()));
        }
    }

    public class PolyLineObserver
    {
        public Avalonia.Point StartPoint { get; set; }
        public Avalonia.Point EndPoint { get; set; }

        public PolyLineObserver(double startX, double startY, double endX, double endY)
        {
            StartPoint = new Avalonia.Point(startX, startY);
            EndPoint = new Avalonia.Point(endX, endY);
        }

        public PolyLineObserver(Point2D startPoint, Point2D endPoint)
        {
            StartPoint = new Avalonia.Point(startPoint.GetX(), startPoint.GetY());
            EndPoint = new Avalonia.Point(endPoint.GetX(), endPoint.GetY());
        }
    }

    public class FigureLib
    {
        public FigureLib()
        {
        }

        public Point2D GeneratePoint() { return new Point2D(new Random().NextDouble() * 400, new Random().NextDouble() * 300); }

        public Triangle GenerateTriangle() { return new Triangle(GeneratePoint(), GeneratePoint(), GeneratePoint()); }

        public Entity.Rectangle GenerateRectangle()
        {
            Point2D p1 = GeneratePoint();
            Point2D p2 = new Point2D(p1);
            Point2D p3 = new Point2D(p1);

            p2.ShiftY(new Random().NextDouble() * 150);
            p3.ShiftX(new Random().NextDouble() * 150);

            Point2D p4 = new Point2D(p3.GetX(), p2.GetY());

            return new Entity.Rectangle(p1, p2, p3, p4);
        }

        public Entity.Rectangle GenerateSquare()
        {
            Point2D p1 = GeneratePoint();

            Point2D p2 = new Point2D(p1);
            var side = new Random().NextDouble() * 150;
            p2.ShiftY(side);

            Point2D p3 = new Point2D(p1);
            p3.ShiftX(side);

            Point2D p4 = new Point2D(p3.GetX(), p2.GetY());

            return new Entity.Rectangle(p1, p2, p3, p4);
        }
    }
}
