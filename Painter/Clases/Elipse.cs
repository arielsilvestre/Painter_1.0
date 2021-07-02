using System;
using System.Drawing;

namespace Painter
{
    [Serializable]
    class Elipse : Figura
    {

        // private Pen pen = new Pen(Color.Black,1);
        // SolidBrush colorRelleno;*/

        //sin relleno con borde =>  g.DrawEllipse(pen, cx, cy, sx, sy);
        public Elipse(int ancho, int alto, int figuraX,int figuraY, bool relleno, Color colorLapiz, float anchoLapiz)
              : base(ancho, alto, figuraX,figuraY, relleno,colorLapiz,anchoLapiz)
        {
            // this.pen.Color = colorLapiz;
            // this.pen.Width = anchoLapiz;
        }


        //con relleno sin borde =>  g.FillRectangle(colorRelleno, cx, cy, sx, sy);
        public Elipse(int ancho, int alto, int figuraX, int figuraY, bool relleno,Color colorRelleno)
               : base(ancho, alto, figuraX, figuraY, relleno, colorRelleno)
        {
            this.ColorRelleno = colorRelleno;
        }

        // Con borde y con relleno   =>    g.DrawEllipse(pen, cx, cy, sx, sy)    =>   g.FillEllipse(colorRelleno, cx, cy, sx, sy);
        
        public override void dibujarFigura(Graphics g, SolidBrush relleno, Figura f)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // g.FillEllipse(ColorRelleno, f.Ancho,f.Alto, f.FiguraX, f.FiguraY);
        }

        public override void dibujarFigura(Graphics g, Pen pincel, Figura f, char i)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // g.DrawRectangle(this.pen, f.Ancho, f.Alto, f.FiguraX, f.FiguraY);
        }

        public override void dibujarFigura(Graphics g, Pen pincel, int ancho, int alto,int figuraX,int figuraY) //solo borde
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawEllipse(pincel, ancho, alto, figuraX, figuraY);
        }
        public override void dibujarFigura(Graphics g, SolidBrush relleno, int ancho, int alto, int figuraX, int figuraY) // solo relleno
        {
            g.FillEllipse(relleno, ancho, alto, figuraX, figuraY);
        }

    }
}
