using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painter
{
    [Serializable]
    public class Linea : Figura
    {
        // private Pen pen = new Pen(Color.Green,50);

        public Linea(int ancho, int alto, int figuraX, int figuraY,bool relleno, Color colorLapiz, float anchoLapiz)
                : base(ancho, alto, figuraX, figuraY, relleno,colorLapiz, anchoLapiz)
        {
            // this.pen.Color = colorLapiz;
           // this.pen.Width = anchoLapiz;*/
        }
        public Linea()
        {

        }

        public override void dibujarFigura(Graphics g, SolidBrush relleno, Figura f)
        {
        
        }

        public override void dibujarFigura(Graphics g, Pen pincel, Figura f, char i)
        {
             // g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
             // g.DrawLine(this.pen, Ancho, Alto, FiguraX, FiguraY);
        }

        public override void dibujarFigura(Graphics g, Pen pincel, int ancho, int alto, int figuraX, int figuraY)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawLine(pincel, ancho, alto, figuraX, figuraY);
        }
        public override void dibujarFigura(Graphics g, SolidBrush relleno, int ancho, int alto, int figuraX, int figuraY){}
    }
}
