using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Painter
{
    class DibujarFiguras
    {
        private Pen pen = new Pen(Color.Black, 1);
        private SolidBrush solido;

        public void dibujarRectangulo(Graphics g, Color colorRelleno, int ancho, int alto, int figuraX, int figuraY)
        {
            solido.Color = Color.Green;
            g.FillRectangle(solido, ancho, alto, figuraX, figuraY);
            System.Windows.Forms.MessageBox.Show("Rectangulo");
        }

        public void dibujarRectangulo(Graphics g, int ancho, int alto, int figuraX, int figuraY)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.DrawRectangle(pen, ancho, alto, figuraX, figuraY);
        }

        public void dibujarElipse(Graphics g,Color colorRelleno,int ancho,int alto,int figuraX,int figuraY)
        {
            this.solido.Color = colorRelleno;
            g.FillEllipse(solido, ancho,alto, figuraX, figuraY);
        }

        public void dibujarElipse(Graphics g, float anchoPincel, Color lapiz, int ancho, int alto, int figuraX, int figuraY)
        {
            this.pen.Width = anchoPincel;
            g.DrawEllipse(pen, ancho, alto, figuraX, figuraY);
        }


        //sin relleno con borde      =>  g.DrawEllipse(pen, cx, cy, sx, sy
        //con relleno sin borde      =>  g.FillRectangle(colorRelleno, cx, cy, sx, sy)
        //Con borde y con relleno    =>    g.DrawEllipse(pen, cx, cy, sx, sy)    =>   g.FillEllipse(colorRelleno, cx, cy, sx, sy);


    }
}
