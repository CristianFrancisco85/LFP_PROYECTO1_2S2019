namespace Proyecto1LF_AnalizadorLexico
{
    partial class Principal
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.MenuTop = new System.Windows.Forms.MenuStrip();
            this.Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaPestañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AbrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeAplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numLineas = new System.Windows.Forms.PictureBox();
            this.TxtCodigo = new System.Windows.Forms.RichTextBox();
            this.diagramaBox = new System.Windows.Forms.GroupBox();
            this.paisLbl = new System.Windows.Forms.Label();
            this.banderaImage = new System.Windows.Forms.PictureBox();
            this.poblacionLbl = new System.Windows.Forms.Label();
            this.BtnAnalizar = new System.Windows.Forms.Button();
            this.BtnPdf = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.MenuTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.TabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLineas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.banderaImage)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuTop
            // 
            this.MenuTop.AutoSize = false;
            this.MenuTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(121)))), ((int)(((byte)(204)))));
            this.MenuTop.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuTop.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Archivo,
            this.ayudaToolStripMenuItem});
            this.MenuTop.Location = new System.Drawing.Point(0, 0);
            this.MenuTop.Name = "MenuTop";
            this.MenuTop.Size = new System.Drawing.Size(500, 30);
            this.MenuTop.TabIndex = 3;
            this.MenuTop.Text = "menuStrip1";
            // 
            // Archivo
            // 
            this.Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaPestañaToolStripMenuItem,
            this.AbrirToolStripMenuItem,
            this.GuardarToolStripMenuItem,
            this.GuardarComoToolStripMenuItem});
            this.Archivo.Name = "Archivo";
            this.Archivo.Size = new System.Drawing.Size(63, 26);
            this.Archivo.Text = "Archivo";
            // 
            // nuevaPestañaToolStripMenuItem
            // 
            this.nuevaPestañaToolStripMenuItem.Name = "nuevaPestañaToolStripMenuItem";
            this.nuevaPestañaToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.nuevaPestañaToolStripMenuItem.Text = "Nueva Pestaña";
            this.nuevaPestañaToolStripMenuItem.Click += new System.EventHandler(this.NuevaPestañaToolStripMenuItem_Click);
            // 
            // AbrirToolStripMenuItem
            // 
            this.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem";
            this.AbrirToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.AbrirToolStripMenuItem.Text = "Abrir Archivo";
            this.AbrirToolStripMenuItem.Click += new System.EventHandler(this.AbrirToolStripMenuItem_Click);
            // 
            // GuardarToolStripMenuItem
            // 
            this.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem";
            this.GuardarToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.GuardarToolStripMenuItem.Text = "Guardar Archivo";
            this.GuardarToolStripMenuItem.Click += new System.EventHandler(this.GuardarToolStripMenuItem_Click);
            // 
            // GuardarComoToolStripMenuItem
            // 
            this.GuardarComoToolStripMenuItem.Name = "GuardarComoToolStripMenuItem";
            this.GuardarComoToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.GuardarComoToolStripMenuItem.Text = "Guardar Archivo Como...";
            this.GuardarComoToolStripMenuItem.Click += new System.EventHandler(this.GuardarComoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeAplicacionToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(56, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeAplicacionToolStripMenuItem
            // 
            this.manualDeAplicacionToolStripMenuItem.Name = "manualDeAplicacionToolStripMenuItem";
            this.manualDeAplicacionToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.manualDeAplicacionToolStripMenuItem.Text = "Manual de Aplicacion";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de ...";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.AcercaDeToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(121)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.CloseBtn);
            this.panel2.Location = new System.Drawing.Point(500, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 30);
            this.panel2.TabIndex = 4;
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = ((System.Drawing.Image)(resources.GetObject("CloseBtn.Image")));
            this.CloseBtn.Location = new System.Drawing.Point(665, 3);
            this.CloseBtn.Margin = new System.Windows.Forms.Padding(0, 0, 30, 0);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(24, 24);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(30, 60);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(470, 600);
            this.TabControl.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numLineas);
            this.tabPage2.Controls.Add(this.TxtCodigo);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(462, 572);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pestaña 1";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numLineas
            // 
            this.numLineas.Dock = System.Windows.Forms.DockStyle.Left;
            this.numLineas.Location = new System.Drawing.Point(3, 3);
            this.numLineas.Margin = new System.Windows.Forms.Padding(1);
            this.numLineas.Name = "numLineas";
            this.numLineas.Size = new System.Drawing.Size(27, 566);
            this.numLineas.TabIndex = 1;
            this.numLineas.TabStop = false;
            this.numLineas.Paint += new System.Windows.Forms.PaintEventHandler(this.NumLineas_Paint);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(30, 3);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.TxtCodigo.Size = new System.Drawing.Size(420, 565);
            this.TxtCodigo.TabIndex = 0;
            this.TxtCodigo.Text = "";
            // 
            // diagramaBox
            // 
            this.diagramaBox.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diagramaBox.Location = new System.Drawing.Point(540, 60);
            this.diagramaBox.Name = "diagramaBox";
            this.diagramaBox.Size = new System.Drawing.Size(625, 300);
            this.diagramaBox.TabIndex = 6;
            this.diagramaBox.TabStop = false;
            this.diagramaBox.Text = "Diagrama";
            // 
            // paisLbl
            // 
            this.paisLbl.AutoSize = true;
            this.paisLbl.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paisLbl.Location = new System.Drawing.Point(830, 400);
            this.paisLbl.Name = "paisLbl";
            this.paisLbl.Size = new System.Drawing.Size(167, 26);
            this.paisLbl.TabIndex = 7;
            this.paisLbl.Text = "Pais Seleccionado:";
            // 
            // banderaImage
            // 
            this.banderaImage.Location = new System.Drawing.Point(830, 440);
            this.banderaImage.Name = "banderaImage";
            this.banderaImage.Size = new System.Drawing.Size(250, 125);
            this.banderaImage.TabIndex = 8;
            this.banderaImage.TabStop = false;
            // 
            // poblacionLbl
            // 
            this.poblacionLbl.AutoSize = true;
            this.poblacionLbl.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poblacionLbl.Location = new System.Drawing.Point(830, 600);
            this.poblacionLbl.Name = "poblacionLbl";
            this.poblacionLbl.Size = new System.Drawing.Size(100, 26);
            this.poblacionLbl.TabIndex = 9;
            this.poblacionLbl.Text = "Poblacion:";
            // 
            // BtnAnalizar
            // 
            this.BtnAnalizar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnAnalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnAnalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnAnalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAnalizar.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnalizar.Location = new System.Drawing.Point(540, 440);
            this.BtnAnalizar.Name = "BtnAnalizar";
            this.BtnAnalizar.Size = new System.Drawing.Size(143, 39);
            this.BtnAnalizar.TabIndex = 10;
            this.BtnAnalizar.Text = "ANALIZAR";
            this.BtnAnalizar.UseVisualStyleBackColor = true;
            this.BtnAnalizar.Click += new System.EventHandler(this.BtnAnalizar_Click);
            // 
            // BtnPdf
            // 
            this.BtnPdf.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.BtnPdf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.BtnPdf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.BtnPdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPdf.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPdf.Location = new System.Drawing.Point(540, 526);
            this.BtnPdf.Name = "BtnPdf";
            this.BtnPdf.Size = new System.Drawing.Size(143, 39);
            this.BtnPdf.TabIndex = 11;
            this.BtnPdf.Text = "GENERAR PDF";
            this.BtnPdf.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog2
            // 
            this.saveFileDialog2.Filter = "Archivo HTML|*.html";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.BtnPdf);
            this.Controls.Add(this.BtnAnalizar);
            this.Controls.Add(this.poblacionLbl);
            this.Controls.Add(this.banderaImage);
            this.Controls.Add(this.paisLbl);
            this.Controls.Add(this.diagramaBox);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.MenuTop);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proyecto1";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.MenuTop.ResumeLayout(false);
            this.MenuTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numLineas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.banderaImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuTop;
        private System.Windows.Forms.ToolStripMenuItem Archivo;
        private System.Windows.Forms.ToolStripMenuItem nuevaPestañaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AbrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeAplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox CloseBtn;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.GroupBox diagramaBox;
        private System.Windows.Forms.Label paisLbl;
        private System.Windows.Forms.PictureBox banderaImage;
        private System.Windows.Forms.Label poblacionLbl;
        private System.Windows.Forms.Button BtnAnalizar;
        private System.Windows.Forms.Button BtnPdf;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox numLineas;
        private System.Windows.Forms.RichTextBox TxtCodigo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}

