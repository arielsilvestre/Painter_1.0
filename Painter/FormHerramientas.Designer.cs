
namespace Painter
{
    partial class FormHerramientas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkRelleno = new System.Windows.Forms.CheckBox();
            this.chkBorde = new System.Windows.Forms.CheckBox();
            this.btnRectangulo = new System.Windows.Forms.Button();
            this.btnRelleno = new System.Windows.Forms.Button();
            this.btnLinea = new System.Windows.Forms.Button();
            this.btnElipse = new System.Windows.Forms.Button();
            this.btnGoma = new System.Windows.Forms.Button();
            this.btnLapiz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.boxTextoADibujar = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.BtnInsertarTexto = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkRelleno
            // 
            this.chkRelleno.AutoSize = true;
            this.chkRelleno.ForeColor = System.Drawing.Color.White;
            this.chkRelleno.Location = new System.Drawing.Point(15, 23);
            this.chkRelleno.Name = "chkRelleno";
            this.chkRelleno.Size = new System.Drawing.Size(65, 19);
            this.chkRelleno.TabIndex = 0;
            this.chkRelleno.Text = "Relleno";
            this.chkRelleno.UseVisualStyleBackColor = true;
            this.chkRelleno.CheckedChanged += new System.EventHandler(this.chkRelleno_CheckedChanged);
            // 
            // chkBorde
            // 
            this.chkBorde.AutoSize = true;
            this.chkBorde.ForeColor = System.Drawing.Color.White;
            this.chkBorde.Location = new System.Drawing.Point(15, 48);
            this.chkBorde.Name = "chkBorde";
            this.chkBorde.Size = new System.Drawing.Size(70, 19);
            this.chkBorde.TabIndex = 1;
            this.chkBorde.Text = "Reborde";
            this.chkBorde.UseVisualStyleBackColor = true;
            this.chkBorde.Visible = false;
            this.chkBorde.CheckedChanged += new System.EventHandler(this.chkBorde_CheckedChanged);
            // 
            // btnRectangulo
            // 
            this.btnRectangulo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRectangulo.BackgroundImage = global::Painter.Properties.Resources.FilledRectangle_16x;
            this.btnRectangulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRectangulo.Location = new System.Drawing.Point(346, 37);
            this.btnRectangulo.Name = "btnRectangulo";
            this.btnRectangulo.Size = new System.Drawing.Size(83, 62);
            this.btnRectangulo.TabIndex = 8;
            this.btnRectangulo.Text = "Rectangulo";
            this.btnRectangulo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangulo.UseVisualStyleBackColor = false;
            this.btnRectangulo.Click += new System.EventHandler(this.btnRectangulo_Click);
            // 
            // btnRelleno
            // 
            this.btnRelleno.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRelleno.BackgroundImage = global::Painter.Properties.Resources.Fill_solid_16x;
            this.btnRelleno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnRelleno.ForeColor = System.Drawing.Color.Black;
            this.btnRelleno.Location = new System.Drawing.Point(15, 19);
            this.btnRelleno.Name = "btnRelleno";
            this.btnRelleno.Size = new System.Drawing.Size(75, 62);
            this.btnRelleno.TabIndex = 3;
            this.btnRelleno.Text = "Relleno";
            this.btnRelleno.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRelleno.UseVisualStyleBackColor = false;
            this.btnRelleno.Click += new System.EventHandler(this.btnRelleno_Click);
            // 
            // btnLinea
            // 
            this.btnLinea.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLinea.BackgroundImage = global::Painter.Properties.Resources.AssociationRelationship_16x;
            this.btnLinea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLinea.Location = new System.Drawing.Point(265, 37);
            this.btnLinea.Name = "btnLinea";
            this.btnLinea.Size = new System.Drawing.Size(75, 62);
            this.btnLinea.TabIndex = 4;
            this.btnLinea.Text = "Linea";
            this.btnLinea.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLinea.UseVisualStyleBackColor = false;
            this.btnLinea.Click += new System.EventHandler(this.btnLinea_Click);
            // 
            // btnElipse
            // 
            this.btnElipse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnElipse.BackgroundImage = global::Painter.Properties.Resources.FilledEllipse_16x;
            this.btnElipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnElipse.Location = new System.Drawing.Point(185, 37);
            this.btnElipse.Name = "btnElipse";
            this.btnElipse.Size = new System.Drawing.Size(75, 62);
            this.btnElipse.TabIndex = 5;
            this.btnElipse.Text = "Elipse";
            this.btnElipse.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnElipse.UseVisualStyleBackColor = false;
            this.btnElipse.Click += new System.EventHandler(this.btnElipse_Click);
            // 
            // btnGoma
            // 
            this.btnGoma.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGoma.BackgroundImage = global::Painter.Properties.Resources.Eraser_16x;
            this.btnGoma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGoma.Location = new System.Drawing.Point(103, 37);
            this.btnGoma.Name = "btnGoma";
            this.btnGoma.Size = new System.Drawing.Size(75, 62);
            this.btnGoma.TabIndex = 6;
            this.btnGoma.Text = "Goma";
            this.btnGoma.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGoma.UseVisualStyleBackColor = false;
            this.btnGoma.Click += new System.EventHandler(this.btnGoma_Click);
            // 
            // btnLapiz
            // 
            this.btnLapiz.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLapiz.BackgroundImage = global::Painter.Properties.Resources.ASX_Edit_grey_16x;
            this.btnLapiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLapiz.Location = new System.Drawing.Point(18, 37);
            this.btnLapiz.Name = "btnLapiz";
            this.btnLapiz.Size = new System.Drawing.Size(79, 62);
            this.btnLapiz.TabIndex = 7;
            this.btnLapiz.Text = "Trazo";
            this.btnLapiz.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLapiz.UseVisualStyleBackColor = false;
            this.btnLapiz.Click += new System.EventHandler(this.btnLapiz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Formas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRelleno);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(11, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 90);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Relleno";
            // 
            // boxTextoADibujar
            // 
            this.boxTextoADibujar.Location = new System.Drawing.Point(166, 138);
            this.boxTextoADibujar.Name = "boxTextoADibujar";
            this.boxTextoADibujar.Size = new System.Drawing.Size(259, 71);
            this.boxTextoADibujar.TabIndex = 11;
            this.boxTextoADibujar.Text = "";
            this.boxTextoADibujar.TextChanged += new System.EventHandler(this.boxTextoADibujar_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.BtnInsertarTexto);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(144, 118);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 138);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Texto a dibujar";
            // 
            // BtnInsertarTexto
            // 
            this.BtnInsertarTexto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnInsertarTexto.Location = new System.Drawing.Point(186, 96);
            this.BtnInsertarTexto.Name = "BtnInsertarTexto";
            this.BtnInsertarTexto.Size = new System.Drawing.Size(94, 27);
            this.BtnInsertarTexto.TabIndex = 13;
            this.BtnInsertarTexto.Text = "Insertar texto";
            this.BtnInsertarTexto.UseVisualStyleBackColor = true;
            this.BtnInsertarTexto.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkRelleno);
            this.groupBox4.Controls.Add(this.chkBorde);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(11, 214);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(112, 72);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Relleno figuras";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // FormHerramientas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(447, 298);
            this.Controls.Add(this.boxTextoADibujar);
            this.Controls.Add(this.btnRectangulo);
            this.Controls.Add(this.btnLinea);
            this.Controls.Add(this.btnElipse);
            this.Controls.Add(this.btnGoma);
            this.Controls.Add(this.btnLapiz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHerramientas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHerramientas";
            this.Load += new System.EventHandler(this.FormHerramientas_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkRelleno;
        private System.Windows.Forms.CheckBox chkBorde;
        private System.Windows.Forms.Button btnRectangulo;
        private System.Windows.Forms.Button btnRelleno;
        private System.Windows.Forms.Button btnLinea;
        private System.Windows.Forms.Button btnElipse;
        private System.Windows.Forms.Button btnGoma;
        private System.Windows.Forms.Button btnLapiz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox boxTextoADibujar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button BtnInsertarTexto;
    }
}