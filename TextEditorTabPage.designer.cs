﻿namespace Practica1LF_AnalizadorLexico
{
    partial class TextEditorTabPage
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.numLineas = new System.Windows.Forms.PictureBox();
            this.TxtCodigo = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numLineas)).BeginInit();
            this.SuspendLayout();
            // 
            // numLineas
            // 
            this.numLineas.Location = new System.Drawing.Point(3, 3);
            this.numLineas.Margin = new System.Windows.Forms.Padding(1);
            this.numLineas.Name = "numLineas";
            this.numLineas.Size = new System.Drawing.Size(27, 485);
            this.numLineas.TabIndex = 3;
            this.numLineas.TabStop = false;
            this.numLineas.Paint += new System.Windows.Forms.PaintEventHandler(this.NumLineas_Paint);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(30, 3);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(10);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtCodigo.Size = new System.Drawing.Size(420, 485);
            this.TxtCodigo.TabIndex = 2;
            this.TxtCodigo.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // TextEditorTabPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.numLineas);
            this.Controls.Add(this.TxtCodigo);
            this.Name = "TextEditorTabPage";
            this.Size = new System.Drawing.Size(462, 572);
            this.Load += new System.EventHandler(this.TextEditorTabPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLineas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox numLineas;
        private System.Windows.Forms.RichTextBox TxtCodigo;
        private System.Windows.Forms.Timer timer1;

        public System.Windows.Forms.RichTextBox TextCodigo
        {
            get{ return TxtCodigo; }
        }
    }
}
