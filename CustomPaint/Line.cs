using System;
using System.Drawing;

namespace CustomPaint
{
    [Serializable]
    class Line: Step
    {
        public override void draw(Graphics g) {
            Pen mypen = new Pen(this.Colorelem, this.Widthelem);
            g.DrawLine(mypen, this.Start1, this.Finish1);
        }
    }
}
