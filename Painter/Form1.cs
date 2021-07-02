using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Painter
{
    [Serializable]
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Width = 900;
            Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            goma.StartCap = goma.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            g.Clear(Color.White);
            pic.Image = bm;
            
        }
        FormHerramientas FormHerramientas = new FormHerramientas();
        public Bitmap bm;
        Graphics g;
        bool dibujando = false;
        bool panelVisible = true;
        bool formHerramientasAbierto = false;
        bool formCapasAbierto = false;

        // bool abierto = false;
        // bool simetria = false; //2DO
        public static bool borde = false;
        public static bool relleno = false;


        
        Point px, py, mouseMov;
        Pen pen = new Pen(Color.Black, 1);
        Pen goma = new Pen(Color.White, 10);
        SolidBrush colorRelleno = new SolidBrush(Color.Gray);

        // PictureBox dibujo = new PictureBox(); //prueba
        int x, y, sx, sy, cx, cy;
        public static int index = 1;
        public static String texto = "no se ha insertado ningún texto...";
        ColorDialog colorPicker = new ColorDialog();
        public Color nuevoColor;
        public Color colorBorde;
        List<Figura> figuras = new List<Figura>();
        internal List<Figura> Figuras { get => figuras; set => figuras = value; }
        capas capas = new capas();

        private void btnColor_Click(object sender, EventArgs e)
        {
            nuevoColor = elegirColor();
            pen.Color = nuevoColor;
            pbColorMain.BackColor = nuevoColor;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            colorBorde = elegirColor();
            colorRelleno.Color = colorBorde;
            pbColorBorde.BackColor = colorBorde;
        }

        public Color elegirColor()
        {
            colorPicker.ShowDialog();

            return colorPicker.Color;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            dibujando = true;
            py = e.Location;

            //pic.Location = e.Location;
            cx = e.X;
            cy = e.Y;
            mouseMov = e.Location;

        }
        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (dibujando)
            {
                if (index == 0)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        this.Left += e.X - mouseMov.X;
                        this.Top += e.Y - mouseMov.Y;
                    }
                }
                if (index == 1) //Mano alzada
                {
                    px = e.Location;
                    g.DrawLine(pen, px, py);
                    py = px;
                }
                if (index == 2) //Goma
                {
                    px = e.Location;
                    g.DrawLine(goma, px, py);
                    py = px;
                }
            pic.Refresh();
            }

            x = e.X;
            y = e.Y;
            sx = e.X - cx;
            sy = e.Y - cy;
        }
        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            dibujando = false;
            sx = x - cx;
            sy = y - cy;

            if (index == 3) //Dibujar Circulo
            {

                if (relleno && !borde)
                {
                    g.FillEllipse(colorRelleno, cx, cy, sx, sy);
                    Elipse nuevaElipseConRelleno = new Elipse(cx, cy, sx, sy, true,colorRelleno.Color);
                    figuras.Add(nuevaElipseConRelleno);

                }
                else if (relleno && borde)
                {
                    g.DrawEllipse(pen,cx, cy, sx, sy);
                    Elipse nuevaElipseConBorde = new Elipse(cx, cx, sx, sy, false,pen.Color,pen.Width);
                    figuras.Add(nuevaElipseConBorde);
                    g.FillEllipse(colorRelleno, cx, cy, sx, sy);
                    Elipse nuevaElipseConRelleno = new Elipse(cx, cy, sx, sy, true, colorRelleno.Color);
                    figuras.Add(nuevaElipseConRelleno);

                }
                else
                {   //solo Borde
                    g.DrawEllipse(pen, cx, cy, sx, sy);
                    Elipse nuevaElipseConBorde = new Elipse(cx, cy, sx, sy, false,pen.Color,pen.Width);
                    figuras.Add(nuevaElipseConBorde);
                }
                /*dataGridView1.DataSource = null;
                dataGridView1.DataSource = figuras;*/
            }

            if (index == 4) //Dibujar Rectangulo
            {
                if (relleno == true && borde == false)
                {
                    g.FillRectangle(colorRelleno, cx, cy, sx, sy);
                    Rectangulo nuevoRectanguloConRelleno = new Rectangulo(cx, cy, sx, sy, true);
                    figuras.Add(nuevoRectanguloConRelleno);
                }
                else if (relleno && borde == true)
                {
                    g.DrawRectangle(pen, cx, cy, sx, sy);
                    g.FillRectangle(colorRelleno, cx, cy, sx, sy);
                    Rectangulo nuevoRectanguloConRelleno = new Rectangulo(cx, cy, sx, sy, true);
                    Rectangulo nuevoRectanguloSinRelleno = new Rectangulo(cx, cy, sx, sy, false,pen.Color,pen.Width);
                    figuras.Add(nuevoRectanguloSinRelleno);
                    figuras.Add(nuevoRectanguloConRelleno);
                }
                else
                {   //solo Borde
                    g.DrawRectangle(pen, cx, cy, sx, sy);
                    Rectangulo nuevoRectanguloSinRelleno = new Rectangulo(cx, cy, sx, sy, false,pen.Color,pen.Width);
                    figuras.Add(nuevoRectanguloSinRelleno);
                }
            }

            if (index == 5)      //Dibujar Linea
            {
                g.DrawLine(pen, cx, cy, x, y);
                Linea nuevaLinea = new Linea(cx, cy, x, y, false,pen.Color,pen.Width);
                figuras.Add(nuevaLinea);
            }

            if (index == 99)    // Dibujar Texto
            {
                FontDialog fd = new FontDialog();
                Font fuente = new Font("Arial", 16.0f, FontStyle.Regular);

                if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    fuente = fd.Font;
                    g.DrawString(texto, fuente, colorRelleno, cx, cy);
                }
            }
            cargarLista();
          /*  dataGridView1.DataSource = null;
            dataGridView1.DataSource = figuras;*/
            capas.dgvCapas.DataSource = null;
            capas.dgvCapas.DataSource = figuras;
            pic.Refresh();
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (dibujando)
            {
                if (index == 3) //muestra elipse
                {
                    if (relleno && !borde)
                    {
                        g.FillEllipse(colorRelleno, cx, cy, sx, sy);
                    }
                    else if (relleno && borde)
                    {
                        g.DrawEllipse(pen, cx, cy, sx, sy);
                        g.FillEllipse(colorRelleno, cx, cy, sx, sy);

                    }
                    else
                    {
                        g.DrawEllipse(pen, cx, cy, sx, sy);
                    }
                }
                if (index == 4) //muestra rectangulo
                {
                    if (relleno == true && borde == false)
                    {
                        g.FillRectangle(colorRelleno, cx, cy, sx, sy);
                    }
                    else if (relleno == true && borde == true)
                    {
                        g.DrawRectangle(pen, cx, cy, sx, sy);
                        g.FillRectangle(colorRelleno, cx, cy, sx, sy);
                    }
                    else
                    {
                        g.DrawRectangle(pen, cx, cy, sx, sy);
                    }
                }
                if (index == 5) //muestra linea
                {
                    g.DrawLine(pen, cx, cy, x, y);
                }
            }
        }
        private void btnLapiz_Click(object sender, EventArgs e)
        {
            foreach (Figura f in figuras)
            {
                if (f.Relleno)
                {
                    f.dibujarFigura(g, colorRelleno, f);
                    pic.Refresh();
                }
                else
                {
                    f.dibujarFigura(g, pen, f, 'i');
                    pic.Refresh();
                }
            }
        }
        /*
                private void btnRelleno_Click(object sender, MouseEventArgs e)
                {
                    index = 7;
                }*/

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point punto = set_point(pic, e.Location);
                rellenar(bm, punto.X, punto.Y, nuevoColor);
                pic.Refresh();
            }

        }
        /*
                private void btnRelleno_Click(object sender, EventArgs e)   // OP 7 Figura
                {
                    index = 7;
                }*/


        private void trackBar1_Scroll(object sender, EventArgs e)   //ANCHO DE TRAZO
        {
            int x = trackBar1.Value;
            pen.Width = x;
            goma.Width = x;
            tamañoTrazo.Text = x.ToString();
        }

        public void exportarComoJPG()
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "dibujo(*.jpg) | *.jpg | (*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }

        private void button1_Click(object sender, EventArgs e)  // Exportar imagen a PNG
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "dibujo(*.jpg) | *.jpg | (*.*|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0, 0, pic.Width, pic.Height), bm.PixelFormat);
                btm.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }
        private void abrirMenuHerramientas()
        {
            
            if (formHerramientasAbierto)
            {
                formHerramientasAbierto = false;
                FormHerramientas.Hide();
            }
            else
            {
                formHerramientasAbierto = true;
                FormHerramientas.Owner = this;
                FormHerramientas.Show();
                FormHerramientas.Location = new Point(this.Location.X + this.ClientSize.Width+15, this.Location.Y);

            }
        }
        private void abrirMenuCapas()
        {

            if (formCapasAbierto)
            {
                formCapasAbierto = false;
                capas.Hide();
            }
            else
            {
                formCapasAbierto = true;
                capas.Owner = this;
                capas.Show();
                capas.Location = new Point(this.Location.X + this.ClientSize.Width + 15, this.Location.Y + 15 + (this.ClientSize.Height) / 2);

            }
        }

        private void abrirHerramientas_Click(object sender, EventArgs e)
        {
            abrirMenuHerramientas();
        }

        private void btnGoma_Click(object sender, EventArgs e)  //Borrar todo
        {
            g.Clear(Color.White);
            pic.Refresh();
            figuras.Clear();
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            FormHerramientas.Location = new Point(this.Location.X + this.ClientSize.Width + 15, this.Location.Y);
            capas.Location = new Point(this.Location.X + this.ClientSize.Width + 15, this.Location.Y + 15 + (this.ClientSize.Height) / 2);
        }

        private void s(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        public void guardarArchivoBinario()
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("figuras.bin", FileMode.Create, FileAccess.Write);
            formatter.Serialize(stream, figuras);
            stream.Close();
            toolStripProgressBar1.Value = 100;
            toolStripStatusLabel1.Text = "El archivo se guardó correctamente";
        }

        private void button3_Click(object sender, EventArgs e)      //Guardar archivo Binario
        {
            guardarArchivoBinario();
        } 

        public void abrirArchivoBinario()           //Abrir archivo Binario
        {
            DibujarFiguras dibujarfiguras = new DibujarFiguras();
            toolStripProgressBar1.Value = 0;
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream("figuras.bin", FileMode.Open, FileAccess.Read);
            figuras = (List<Figura>)formatter.Deserialize(stream);
            stream.Close();

     /*       dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = figuras;*/

            bm.Dispose();
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;

            toolStripProgressBar1.Value = 100;
            toolStripStatusLabel1.Text = "El archivo se abrió correctamente";

            foreach (Figura f in figuras)
            {
                if (f.GetType() == typeof(Rectangulo))
                {
                    if (f.Relleno)
                    {
                        //Pen pen = new Pen(f.ColorLapiz, f.AnchoLapiz);
                        f.dibujarFigura(g,colorRelleno,f.Ancho,f.Alto,f.FiguraX,f.FiguraY);
                        pic.Refresh();
                    }
                    else
                    {

                        Pen pen = new Pen(f.ColorLapiz, f.AnchoLapiz);
                        f.dibujarFigura(g, pen, f.Ancho, f.Alto, f.FiguraX, f.FiguraY);
                        pic.Refresh();
                    }
                }
                if (f.GetType() == typeof(Elipse)) //g.FillEllipse(colorRelleno, cx, cy, sx, sy);
                {
                    //dibujarfiguras.dibujarElipse(g, f.AnchoLapiz, f.ColorLapiz, f.Ancho, f.Alto, f.FiguraX, f.FiguraY);
                    if (f.Relleno)
                    {
                        f.dibujarFigura(g, colorRelleno, f.Ancho, f.Alto, f.FiguraX, f.FiguraY);
                        pic.Refresh();
                    }
                    else
                    {
                        Pen pen = new Pen(f.ColorLapiz, f.AnchoLapiz);
                        f.dibujarFigura(g, pen, f.Ancho, f.Alto, f.FiguraX, f.FiguraY);
                        pic.Refresh();
                    }
                }
                if (f.GetType() == typeof(Linea))
                {
                    if (f.Relleno)
                    {
                        f.dibujarFigura(g, colorRelleno, f.Ancho, f.Alto, f.FiguraX, f.FiguraY);
                        pic.Refresh();
                    }
                    else
                    {
                        Pen pen = new Pen(f.ColorLapiz, f.AnchoLapiz);
                        f.dibujarFigura(g, pen, f.Ancho, f.Alto, f.FiguraX, f.FiguraY);
                        pic.Refresh();
                    }
                }
            }
        }


        private void button2_Click_1(object sender, EventArgs e)    //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>       Abrir archivo Binario
        {
            abrirArchivoBinario();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            index = 0;
        }

        private void button6_Click(object sender, EventArgs e)      /** Esto todavía no esta hay que ver el PB*/
        {
           /* capas.Show();
            capas.dgvCapas.DataSource = null;
            capas.dgvCapas.DataSource = figuras;*/
        }

        private void button5_Click(object sender, EventArgs e) // Dibujar Texto!
        {
            MessageBox.Show("Clickea donde quieras insertar tu texto, y a continuación elegí la tipografía. (recordá escribirlo en el form de <Herramientas>");
            index = 99;
        }

        public void cargarLista()
        {   
/*            dataGridView1.ColumnCount = 10;
            foreach (Figura f in figuras)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                dataGridView1.Rows[row.Index].Cells[0].Value = f.Alto;
                dataGridView1.Rows[row.Index].Cells[1].Value = f.Ancho;
                dataGridView1.Rows[row.Index].Cells[2].Value = f.FiguraX;
                dataGridView1.Rows[row.Index].Cells[3].Value = f.FiguraY;
                dataGridView1.Rows.Add(row);
            }
*/
        }


        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirArchivoBinario();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            guardarArchivoBinario();
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportarComoJPG();
        }

        private void borrarTodo()
        {
            bm.Dispose();
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pic.Image = bm;
            index = 0;
            pen.Width = 1;
            goma.Width = 1;
            trackBar1.Value = 1;
            figuras.Clear();
/*            dataGridView1.Columns.Clear();
*/        }
        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            borrarTodo();
        }

        private void verLayers_Click(object sender, EventArgs e)
        {
            abrirMenuCapas();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void herramientasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            abrirMenuHerramientas();

            /*            FormHerramientas.Owner = this;
                        FormHerramientas.Show();
                        FormHerramientas.Location = new Point(this.Location.X + this.ClientSize.Width, this.Location.Y);*/
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            if (panelVisible)
            {
                panel1.Show();
                panelVisible = false ;
            }
            else
            {
                panel1.Hide();
                panelVisible = true;
            }
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }


        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }


        private void capasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            capas.Owner = this;
            capas.Show();
        }

        private void insertarImagenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para insertar una imagen arrastrala hasta el lienzo");
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            borrarTodo();
        }

        private void pic_DragEnter(object sender, DragEventArgs e)
        {
            var data = e.Data.GetData(DataFormats.FileDrop);
            if(data != null)
            {
                var fileNames = data as string[];
                if (fileNames.Length > 0)
                {
                    pic.Image = Image.FromFile(fileNames[0]);
                }
            }
        }
        private void pic_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void Form1_Load(object sender, EventArgs e)         //>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>LOAD FORM
        {
            pic.AllowDrop = true;
        }

        private static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void validar(Bitmap bmp, Stack<Point> sp, int x, int y, Color colorViejo, Color colorNuevo)
        {
            Color cx = bmp.GetPixel(x, y);
            if (cx == colorViejo)
            {
                sp.Push(new Point(x, y));
                bmp.SetPixel(x, y, colorNuevo);
            }
        }

        public void rellenar(Bitmap bmp, int x, int y, Color colorNuevo)
        {
            Color colorViejo = bmp.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bmp.SetPixel(x, y, colorNuevo);
            if (colorViejo == colorNuevo)
            {
                return;
            }

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bmp.Width - 1 && pt.Y < bmp.Height - 1)
                {
                    validar(bmp, pixel, pt.X - 1, pt.Y, colorViejo, colorNuevo);
                    validar(bmp, pixel, pt.X, pt.Y - 1, colorViejo, colorNuevo);
                    validar(bmp, pixel, pt.X + 1, pt.Y, colorViejo, colorNuevo);
                    validar(bmp, pixel, pt.X, pt.Y + 1, colorViejo, colorNuevo);
                }
            }
        }
    }
}
