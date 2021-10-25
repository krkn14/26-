using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace пр26кркн
{
    class Location
    {
        protected int x, y;//
        public int X//
        {
            get { return x; }
        }
        public int Y//
        {
            get { return y; }
        }

        //
        public Location() { x = 0; y = 0; }
        //
        public Location(int initx, int inity) { x = initx; y = inity; }

        //
        public void MoveXY(int newx, int newy)
        {
            x = newx;
            y = newy;
        }
    }
    class point : Location
    {
        protected Brush fill;//
        Rectangle rect;//
        public Brush Fill
        {
            get { return fill; }
            set { fill = value; rect.Fill = fill; rect.Stroke = fill; }
        }
        public Rectangle Figure//
        { get { return rect; } }

        //
        public point()
        {
            //x=0;y=0;//
            fill = Brushes.Black;//
            rect = new Rectangle();
            rect.Height = 3;
            rect.Width = 3;
            rect.Margin = new Thickness(x, y, 0, 0);
        }

        //
        public point(int initX, int initY) : base(initX, initY)
        {
            //x=initX;y=initY;//
            fill = Brushes.Black;//
            rect = new Rectangle();
            rect.Fill = fill;
            rect.Stroke = fill;
            rect.Height = 3;
            rect.Width = 3;
            rect.Margin = new Thickness(x, y, 0, 0);
        }
        public point(int initX, int initY, Brush initFill) : base(initX, initY)
        {
            //x=initX;y=initY;//
            fill = initFill;//
            rect = new Rectangle();
            rect.Fill = fill;
            rect.Stroke = fill;
            rect.Height = 3;
            rect.Width = 3;
            rect.Margin = new Thickness(x, y, 0, 0);
            //Canvas.SetLeft(rect,x);
            //Canvas.SetTop(rect,y);
        }

        //
        public void Show()
        {
            rect.Visibility = Visibility.Visible;
        }
        //
        public void Hide()
        {
            rect.Visibility = Visibility.Hidden;
        }

        //
        public new void MoveXY(int newx, int newy)
        {
            x = newx; y = newy;//
            //base.MoveXY(newx,newy);
            rect.Margin = new Thickness(x, y, 0, 0);
            //Canvas.SetLeft(rect, x);
        }   //Canvas.SetTop(rect, y);
    }

    class circle : point
    {
        protected int radius;
        Brush stroke;//
        Ellipse elips;//
        public new Brush Fill//
        {
            get { return fill; }
            set { fill = value; elips.Fill = fill; elips.Stroke = fill; }
        }
        public new Ellipse Figure//
        { get { return elips; } }

        //
        public circle()
        {
            //x=0; y=0;//
            radius = 0;
            //fill=Brushes.Black;//
            elips = new Ellipse();
            elips.Height = radius * 2;
            elips.Width = radius * 2;
            elips.Margin = new Thickness(x - radius, y - radius, 0, 0);
        }
        public circle(int initX, int initY) : base(initX, initY)
        {

        }

        //
        public circle(int initX, int initY, int initR) : base(initX, initY)
        {
            //x=initX; y=initY;//
            radius = initR;
            //fill=Brushes.Black;//
            elips = new Ellipse();
            elips.Fill = fill;
            elips.Stroke = stroke = Brushes.Black;
            elips.Height = radius * 2;
            elips.Width = radius * 2;
            elips.Margin = new Thickness(x - radius, y - radius, 0, 0);
        }

        public circle(int initX, int initY, int initR, Brush initFill, Brush initStroke) :base(initX, initY, initFill)
        {
            //x=initX; y=initY;//
            radius = initR;
            //fill=initFill;//
            elips = new Ellipse();
            elips.Fill = fill;
            elips.Stroke = stroke = initStroke;
            elips.Height = radius * 2;
            elips.Width = radius * 2;
            elips.Margin = new Thickness(x - radius, y - radius, 0, 0);
            //Canvas.SetLeft(rect, x);
        }   //Canvas.SetTop(rect, y);

        //
        public new void Show()
        {
            elips.Visibility = Visibility.Visible;
        }

        //
        public new void Hide()
        {
            elips.Visibility = Visibility.Hidden;
        }

        //
        public new void MoveXY(int newx, int newy)
        {
            x = newx; y = newy;//
            elips.Margin = new Thickness(x - radius, y - radius, 0, 0);
            //Canvas.SetLeft(recr,x);
            //Canvas.SetTop(rect, y);
        }
    }

    class ellipse : circle
    {
        int radius;
        Brush stroke;//
        Ellipse elipse;//
        public new Brush Fill//
        {
            get { return fill; }
            set { fill = value; elipse.Fill = fill; elipse.Stroke = fill; }
        }
        public new Ellipse Figure//
        { get { return elipse; } }
        //
        public ellipse()
        {
            //x=0;y=0;//
            radius = 0;
            //fill=Brushes.Black;//
            elipse = new Ellipse();
            elipse.Height = radius * 2;
            elipse.Width = radius * 4;
            elipse.Margin = new Thickness(x - radius, y - radius, 0, 0);
        }
        //
        public ellipse(int initX,int initY,int initR) : base(initX, initY)
        {
            //x=initX;y=initY;//
            radius = initR;
            //fill=Brushes.Black;//
            elipse = new Ellipse();
            elipse.Fill = fill;
            elipse.Stroke = stroke = Brushes.Black;
        }
        public ellipse(int initX,int initY,int initR,Brush initFill,Brush initStroke) : base(initX, initY)
        {
            radius = initR;
            elipse = new Ellipse();
            elipse.Fill = fill;
            elipse.Stroke = stroke = initStroke;
            elipse.Height = radius * 2;
            elipse.Width = radius * 4;
            elipse.Margin = new Thickness(x - radius, y - radius, 0, 0);
        }
        //
        public new void Show()
        {
            elipse.Visibility = Visibility.Visible;
        }
        //
        public new void MoveXY(int newx, int newy)
        {
            x = newx;y = newy;//
            elipse.Margin = new Thickness(x - radius, y - radius, 0, 0);
        }
        //
        public new void Hide()
        {
            elipse.Visibility = Visibility.Hidden;
        }
    }

}
