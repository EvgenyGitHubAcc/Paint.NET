using System;
using System.Collections.Generic;
using System.Drawing;

namespace CustomPaint
{
    [Serializable]
    public abstract class Step
    {
        private Color colorelem = Color.Black;
        private int widthelem = 2;
        private Point Start;
        private Point Finish;
        public Color backgroundcolorelem = Color.White;
        public List<Point> path = new List<Point>();

        public Color Colorelem
        {
            get
            {
                return colorelem;
            }

            set
            {
                colorelem = value;
            }
        }

        public int Widthelem
        {
            get
            {
                return widthelem;
            }

            set
            {
                widthelem = value;
            }
        }

        public Point Start1
        {
            get
            {
                return Start;
            }

            set
            {
                Start = value;
            }
        }

        public Point Finish1
        {
            get
            {
                return Finish;
            }

            set
            {
                Finish = value;
            }
        }

        public abstract void draw(Graphics g);
        //public abstract bool selFig();


        
    }
}
