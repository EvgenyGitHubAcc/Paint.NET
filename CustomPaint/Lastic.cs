using System.Drawing;

namespace CustomPaint
{
    class Lastic: Step
    {
        public override void draw(Graphics g)
        {         
            SolidBrush mybrush = new SolidBrush(Color.White);
           
            foreach (Point el in this.path)
            {
                g.FillEllipse(mybrush, el.X,el.Y, 20, 20);
            }           
        }
    }
}
