using System;
using System.Drawing;

namespace CustomPaint
{
    [Serializable]
    class RectangleB:Step
    {
        public override void draw(Graphics g)
        {
            Pen mypen = new Pen(this.Colorelem, this.Widthelem);
            Rectangle myrect = new Rectangle();

            if (Start1.Y < Finish1.Y && Start1.X < Finish1.X)
            {
                myrect = new Rectangle(Start1, new Size(Finish1.X - Start1.X, Finish1.Y - Start1.Y));
                g.DrawRectangle(mypen, myrect);
            }
            else if (Start1.Y > Finish1.Y && Start1.X < Finish1.X)
            {
                myrect = new Rectangle(new Point(Start1.X, Finish1.Y), new Size(Finish1.X - Start1.X, Start1.Y - Finish1.Y));
                g.DrawRectangle(mypen, myrect);
            }
            else if (Start1.Y > Finish1.Y && Start1.X > Finish1.X)
            {
                myrect = new Rectangle(Finish1, new Size(Start1.X - Finish1.X, Start1.Y - Finish1.Y));
                g.DrawRectangle(mypen, myrect);
            }
            else if (Start1.Y < Finish1.Y && Start1.X > Finish1.X)
            {
                myrect = new Rectangle(new Point(Finish1.X, Start1.Y), new Size(Start1.X - Finish1.X, Finish1.Y - Start1.Y));
                g.DrawRectangle(mypen, myrect);
            }
            if (this.backgroundcolorelem != Color.White)
            {
                SolidBrush br = new SolidBrush(backgroundcolorelem);
                g.FillRectangle(br, myrect);
                g.DrawRectangle(mypen, myrect);
            }
        }
    }
}
