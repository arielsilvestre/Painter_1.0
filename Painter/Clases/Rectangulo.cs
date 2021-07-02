using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Painter
{
    [Serializable]
    public class Rectangulo : Figura
    {
        // private SolidBrush colorDeRelleno;
        // Pen pen = new Pen(Color.Red,15);
        
        public Rectangulo()
        {

        }

        //sin relleno con borde =>  g.DrawRectangle(pen, cx, cy, sx, sy);
        public Rectangulo(int ancho, int alto, int figuraX, int figuraY, bool relleno, Color colorLapiz, float anchoLapiz)
              : base(ancho, alto, figuraX, figuraY, relleno,colorLapiz, anchoLapiz)
        {
            // this.pen.Color = colorLapiz;
            // this.pen.Width = anchoLapiz;*/
        }
        //con relleno sin borde =>  g.FillRectangle(colorRelleno, cx, cy, sx, sy);

        public Rectangulo(int ancho, int alto, int figuraX, int figuraY, bool relleno)
               : base(ancho, alto, figuraX, figuraY, relleno)
        {

        }

        //Con borde y con relleno => g.DrawRectangle(pen, cx, cy, sx, sy);   g.FillRectangle(colorRelleno, cx, cy, sx, sy);
        /*
       public Rectangulo(int ancho, int alto, int figuraX, int figuraY, bool relleno, Color colorLapiz, float anchoLapiz)
              : base(ancho, alto, figuraX, figuraY, relleno)
        {
            this.pen.Color = colorLapiz;
            this.pen.Width = anchoLapiz;
            this.colorDeRelleno = colorRelleno;
            this.colorDeRelleno.Color = colorRelleno.Color;
        }
        */

        public override void dibujarFigura(Graphics g, SolidBrush relleno, Figura f)
        {
            //g.FillRectangle(colorDeRelleno, f.Ancho, f.Alto, f.FiguraX, f.FiguraY);
        }
        public override void dibujarFigura(Graphics g, Pen pincel, int ancho, int alto, int figuraX, int figuraY)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawRectangle(pincel, ancho, alto, figuraX, figuraY);
        }
        public override void dibujarFigura(Graphics g, SolidBrush relleno, int ancho, int alto, int figuraX, int figuraY)
        {
            g.FillRectangle(relleno, ancho, alto, figuraX, figuraY);
        }


        public override void dibujarFigura(Graphics g, Pen pincel, Figura f, char i)
        {
            // g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
           // g.DrawRectangle(this.pen, f.Ancho, f.Alto, f.FiguraX, f.FiguraY);
        }
    }
}
