using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;

namespace Painter
{
    [Serializable]
    public abstract class Figura
    {
        private int  ancho=0;
        private int  alto=0;
        private int  figuraX = 0;
        private int  figuraY = 0;
        private Color colorLapiz;
        private Color colorRelleno;
        private float anchoLapiz;
        private bool relleno = false;
        private bool borde = false;
        

       // private Graphics g;
        public int Ancho { get => ancho; set => ancho = value; }
        public int Alto { get => alto; set => alto = value; }
        public int FiguraX { get => figuraX; set => figuraX = value; }
        public int FiguraY { get => figuraY; set => figuraY = value; }
        public bool Relleno { get => relleno; set => relleno = value; }
        public float AnchoLapiz { get => anchoLapiz; set => anchoLapiz = value; }
        public Color ColorLapiz { get => colorLapiz; set => colorLapiz = value; }
        public Color ColorRelleno { get => colorRelleno; set => colorRelleno = value; }

        public Figura()
        {

        }
        //figura default
        public Figura(int ancho, int alto, int figuraX, int figuraY,bool relleno)
        {
            this.ancho = ancho;
            this.alto = alto;
            this.figuraX = figuraX;
            this.figuraY = figuraY;
            this.relleno = relleno;
        }
        //figura con contorno
        public Figura(int ancho, int alto, int figuraX, int figuraY,bool relleno, Color colorLapiz, float anchoLapiz)
        {
            this.ancho = ancho;
            this.alto = alto;
            this.figuraX = figuraX;
            this.figuraY = figuraY;
            this.relleno = relleno;
            this.colorLapiz = colorLapiz;
            this.anchoLapiz = anchoLapiz;
        }
        //figura con relleno
        public Figura(int ancho, int alto, int figuraX, int figuraY, bool relleno, Color colorRelleno)
        {
            this.ancho = ancho;
            this.alto = alto;
            this.figuraX = figuraX;
            this.figuraY = figuraY;
            this.relleno = relleno;
            this.colorRelleno = colorRelleno;
        }

        //figura con borde y contorno
        public Figura(int ancho, int alto, int figuraX, int figuraY,bool relleno, Color colorLapiz, float anchoLapiz,Color colorRelleno)
        {
            this.ancho = ancho;
            this.alto = alto;
            this.figuraX = figuraX;
            this.figuraY = figuraY;
            this.relleno = relleno;
            this.colorLapiz = colorLapiz;
            this.anchoLapiz = anchoLapiz;
            this.colorRelleno = colorRelleno;
        }     

        public abstract void dibujarFigura(Graphics g, SolidBrush relleno, Figura f);
        public abstract void dibujarFigura(Graphics g, Pen pincel, Figura f, char i);
        public abstract void dibujarFigura(Graphics g, Pen pincel, int ancho, int alto, int figuraX, int figuraY);
        public abstract void dibujarFigura(Graphics g, SolidBrush relleno, int ancho, int alto, int figuraX, int figuraY);

    }
}
