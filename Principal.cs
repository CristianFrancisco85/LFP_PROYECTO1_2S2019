using Practica1LF_AnalizadorLexico;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1LF_AnalizadorLexico
{
    public partial class Principal : Form
    {

        String RutaA, RutaG; //RUTAS DE APERTURA Y ESCRITURA
        Boolean Guardar;  // INDICA SI ABRIO DESDE UN ARCHIVO
        AnalizadorLexico Scanner = new AnalizadorLexico();

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            timer1.Interval = 10;
            timer1.Start();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            numLineas.Refresh();
        }

        private void NumLineas_Paint(object sender, PaintEventArgs e)
        {
            int Altura = TxtCodigo.GetPositionFromCharIndex(0).Y;

            if (TxtCodigo.Lines.Length > 0)
            {
                for (int i = 0; i <= TxtCodigo.Lines.Length - 1; i++)
                {
                    int aux = i + 1;
                    e.Graphics.DrawString(aux.ToString(), TxtCodigo.Font, Brushes.DimGray, numLineas.Width - (e.Graphics.MeasureString(aux.ToString(), TxtCodigo.Font).Width + 10), Altura);
                    Altura += 15;
                }
            }
            else
            {
                e.Graphics.DrawString("1", TxtCodigo.Font, Brushes.DimGray, numLineas.Width - (e.Graphics.MeasureString("1", TxtCodigo.Font).Width + 10), Altura);
            }
        }

        private void NuevaPestañaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage NewTab = new TabPage();
            TextEditorTabPage TETP = new TextEditorTabPage();
            NewTab.Controls.Add(TETP);
            NewTab.Text = "Pestaña " + (TabControl.TabCount + 1);
            TabControl.TabPages.Add(NewTab);
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RutaA = openFileDialog1.FileName;
                TabControl.SelectedTab.Text = openFileDialog1.SafeFileName;
                ActualTxtCodigo.Text = File.ReadAllText(RutaA);
            }
        }

        private void GuardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //FALTA
        }

        private void GuardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                RutaG = saveFileDialog1.FileName;
                FileStream MyStream = new FileStream(RutaG, FileMode.Create, FileAccess.Write, FileShare.None);
                StreamWriter MyWriter = new StreamWriter(MyStream);
                MyWriter.Write(ActualTxtCodigo.Text);
                MyWriter.Close();
                MyStream.Close();
                MessageBox.Show("Guardado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cristian Francisco Meoño Canel - 201801397", "Acerca de", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnAnalizar_Click(object sender, EventArgs e)
        {
            Scanner = new AnalizadorLexico();
            Scanner.Analysis(ActualTxtCodigo);
            Scanner.PaintText(ActualTxtCodigo);
            Scanner.GenerateHTML();
            Program.TablaS = new ArrayList();
            Program.TablaE = new ArrayList();
        }

        //AUX METHODS
        private RichTextBox ActualTxtCodigo
        {
            get
            {
                RichTextBox aux = new RichTextBox();

                if (TabControl.SelectedIndex == 0)
                {
                    aux = TxtCodigo;
                }
                else
                {
                    foreach (TextEditorTabPage C in TabControl.SelectedTab.Controls)
                    {
                        aux = C.TextCodigo;
                    }
                }
                return aux;
            }
        }

    }

}