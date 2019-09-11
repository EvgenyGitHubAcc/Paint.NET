using System;
using System.Drawing;

namespace CustomPaint
{
    [Serializable]
    class Text: Step
    {
        Font font;
        string str;

        public Text(string str)
        {
            this.str = str;
        }

        public Font Font
        {
            set
            {
                font = value;
            }
        }
        public override void draw(Graphics g)
        {
            g.DrawString(str, font, new SolidBrush(this.Colorelem), Start1);
        }
    }
}
