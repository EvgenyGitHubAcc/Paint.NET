using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Windows.Forms;

namespace CustomPaint
{
    [Serializable]
    public class Buffer
    {
        string filepath;
        Stack<Step> done = new Stack<Step>();
        Stack<Step> copy = new Stack<Step>();
        Color drawColor = Color.Black;
        Color fillColor = Color.White;
        Font font = new Font ("Arial", 8);
        int lineWidth = 2;
        Step selStep;

        public Buffer()
        {
            selStep = new Line();
            selStep.Colorelem = DrawColor;
            selStep.Widthelem = LineWidth;
        }

        public Step SelStep
        {
            get
            {
                return selStep;
            }
            set
            {
                selStep = value;
            }
        }

        public Stack<Step> Done
        {
            get
            {
                return done;
            }

            set
            {
                done = value;
            }
        }

        public Color DrawColor
        {
            get
            {
                return drawColor;
            }

            set
            {
                drawColor = value;
            }
        }

        public Color FillColor
        {
            get
            {
                return fillColor;
            }

            set
            {
                fillColor = value;
            }
        }

        public Font Font
        {
            get
            {
                return font;
            }

            set
            {
                font = value;
            }
        }

        public int LineWidth
        {
            get
            {
                return lineWidth;
            }

            set
            {
                lineWidth = value;
            }
        }

        public void drawStep()
        {
            if(copy.Count() > 0)
            {
                done.Push(copy.Pop());
            }
        }

        public void unDrawStep()
        {
            if(done.Count() > 0)
            {
                copy.Push(done.Pop());
            }  
        }

        public void Add(Step obj)
        {
            done.Push(obj);
            copy.Clear();
        }

        public void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                {
                    Done = (Stack<Step>)formatter.Deserialize(fs);
                }
            }
        }

        public void Save()
        {
            if(filepath.Count() != 0)
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(filepath, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, Done);
                }
            }
        }

        public void SaveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = saveFileDialog.FileName;

                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(filepath, FileMode.Create))
                {
                    formatter.Serialize(fs, Done);
                }
            }
        }

        public void ExportImage(Panel obj)
        {
            Bitmap img = new Bitmap(obj.Width, obj.Height);
            obj.DrawToBitmap(img, new Rectangle(0, 0, obj.Width, obj.Height));
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Image (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            if (sf.ShowDialog() == DialogResult.OK)
            {
                img.Save(sf.FileName);
            }
        }
    }
}
