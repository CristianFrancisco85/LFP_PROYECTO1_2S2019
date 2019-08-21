using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practica1LF_AnalizadorLexico;

namespace Proyecto1LF_AnalizadorLexico
{
    class AnalizadorLexico
    {
        String[] Reservadas = new String[7] { "Grafica","Continente","Pais","Nombre","Poblacion","Saturacion","Bandera"};
        String[] Otros = new String[3] { ":" ,"%",";"};
        String[] auxVectorS = new String[5]; //Para Tokens
        String[] auxVectorE = new String[5]; //Para Errores Lexicos
        Boolean Errores,Cadena;

        public AnalizadorLexico()
        {

        }
        
        public void Analysis(RichTextBox Code)
        {
            int MyByte=0;                       //Guarda valor ASCII
            int Correlativo = 1;                //Para Simbolos
            int CorrelativoE = 1;               //Para Errores
            int NCaracteres = Code.Text.Length; //Cantidad de Caracteres
            Cadena = false;                     //Indica si se leyendo una cadena
            Errores = false;                    //Indica si hay errores lexicos

            // INICIA ANALISIS LEXICO
            for (int i = 0; i < NCaracteres; i++)
            {
                MyByte = (int)Code.Text[i];
                // SE VERIFICA SI ES UN CARACTER "OTROS"
                if (MyByte == 123 || MyByte == 125 || MyByte == 58 || MyByte == 34 || MyByte == 37 || MyByte == 59)
                {
                    auxVectorS[0] = Correlativo.ToString();
                    Correlativo++;
                    auxVectorS[1] = Char.ToString((char)MyByte);
                    switch (MyByte)
                    {
                        case 123: auxVectorS[2] = "Abre Llave"; break;
                        case 125: auxVectorS[2] = "Cierra Llave"; break;
                        case 58: auxVectorS[2] = "Dos Puntos"; break;
                        case 34: auxVectorS[2] = "Comillas Dobles"; Cadena = !Cadena; break;
                        case 37: auxVectorS[2] = "Porcentaje"; break;
                        case 59: auxVectorS[2] = "Punto y Coma"; break;
                    }
                    int fila = Code.GetLineFromCharIndex(i) + 1;
                    auxVectorS[3] = fila.ToString();
                    int columna = i - Code.GetFirstCharIndexFromLine(fila - 1);
                    auxVectorS[4] = columna.ToString();
                    Program.TablaS.Add(auxVectorS);
                }

                //SE VERIFICA SI ES UNA LETRA
                else if ((MyByte >= 65 && MyByte <= 90) || (MyByte >= 97 && MyByte <= 122) || (MyByte == 241 || MyByte == 209) || (Cadena))
                {
                    auxVectorS[0] = Correlativo.ToString();
                    Correlativo++;
                    auxVectorS[1] = Char.ToString((char)MyByte);
                    int fila = Code.GetLineFromCharIndex(i) + 1;
                    auxVectorS[3] = fila.ToString();
                    int columna = i - Code.GetFirstCharIndexFromLine(fila - 1);
                    auxVectorS[4] = columna.ToString(); ;
                    //SE LEEN LOS CARACTERES SIGUIENTES
                    for (int j = i + 1; j < NCaracteres; j++)
                    {
                        MyByte = (int)Code.Text[j];
                        if (MyByte == 34)
                        {
                            Cadena = false;
                        }
                        //SE VERIFICA SI ES UNA LETRA O UN NUMERO 
                        if ((MyByte >= 65 && MyByte <= 90) || (MyByte >= 97 && MyByte <= 122) || (MyByte >= 48 && MyByte <= 57) || (MyByte == 241 || MyByte == 209 ) || (Cadena))
                        {
                            //SE CONCATENAN LO CARACTERES
                            auxVectorS[1] = auxVectorS[1] + Char.ToString((char)MyByte);
                        }
                        //SE TERMINO DE LEER UN ID O UNA RESERVADA
                        else
                        {
                            i = j - 1;
                            if (MyByte == 34) { Cadena = true; }
                            //SE ESTABLECE EL TIPO DE TOKEN
                            switch (Verificador(Reservadas, auxVectorS[1]))
                            {
                                case -1:auxVectorS[2]="Cadena"; break;
                                case 0: auxVectorS[2] = "Reservada Grafica"; break;
                                case 1: auxVectorS[2] = "Reservada Continente"; break;
                                case 2: auxVectorS[2] = "Reservada Pais"; break;
                                case 3: auxVectorS[2] = "Reservada Nombre"; break;
                                case 4: auxVectorS[2] = "Reservada Poblacion"; break;
                                case 5: auxVectorS[2] = "Reservada Saturacion"; break;
                                case 6: auxVectorS[2] = "Reservada Bandera"; break;
                            }

                            //SE DEJA DE LEER EL SIGUIENTE CARACTER
                            break;
                        }

                    }
                    Program.TablaS.Add(auxVectorS);
                }

                //SE VERFICA SI ES UN NUMERO
                else if (MyByte >= 48 && MyByte <= 57)
                {
                    auxVectorS[0] = Correlativo.ToString();
                    Correlativo++;
                    auxVectorS[1] = Char.ToString((char)MyByte);
                    auxVectorS[2] = "Numero";
                    int fila = Code.GetLineFromCharIndex(i) + 1;
                    auxVectorS[3] = fila.ToString();
                    int columna = i - Code.GetFirstCharIndexFromLine(fila - 1);
                    auxVectorS[4] = columna.ToString();
                    //SE LEEN LOS CARACTERES SIGUIENTES
                    for (int j = i + 1; j < NCaracteres; j++)
                    {
                        MyByte = (int)Code.Text[j];
                        //SE VERIFICA SI ES UN NUMERO 
                        if (MyByte >= 48 && MyByte <= 57)
                        {
                            //SE CONCATENAN LO CARACTERES
                            auxVectorS[1] = auxVectorS[1] + Char.ToString((char)MyByte);
                        }
                        //SE TERMINO DE LEER UN NUMERO
                        else
                        {
                            i = j - 1;
                            Program.TablaS.Add(auxVectorS);
                            //SE DEJA DE LEER EL SIGUIENTE CARACTER
                            break;
                        }

                    }

                }

                //SINO SE ESTABLECE COMO UN CARACTER DESCONOCIDO
                else if (MyByte <= 127 && MyByte > 35)
                {
                    Errores = true;
                    auxVectorE[0] = CorrelativoE.ToString();
                    CorrelativoE++;
                    auxVectorE[1] = Char.ToString((char)MyByte);
                    auxVectorE[2] = "Desconocido";
                    int fila = Code.GetLineFromCharIndex(i) + 1;
                    auxVectorE[3] = fila.ToString();
                    int columna = i - Code.GetFirstCharIndexFromLine(fila - 1);
                    auxVectorE[4] = columna.ToString();
                    Program.TablaE.Add(auxVectorE);
                }

                //SE RESTABLECEN LOS VECTORES
                auxVectorE = new String[5];
                auxVectorS = new String[5];
            }
            // TERMINA EL ANALISIS LEXICO
        }

        public void GenerateHTML()
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            if (!Errores)
            {
                saveFile.Title = "Guardar Tabla de Simbolos";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    FileStream MyStream = new FileStream(saveFile.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                    StreamWriter MyWriter = new StreamWriter(MyStream);
                    MyWriter.WriteLine("<font size=\"2\" face=\"Segoe UI Emoji\" >");
                    MyWriter.WriteLine("<h2 style=\"text - align: center; \"><strong>TABLA DE SIMBOLOS</strong></h2>");
                    MyWriter.WriteLine("<table align=\"center\" border=\"1\" cellpadding=\"1\" cellspacing=\"1\" style=\"width: 500px;\">");
                    MyWriter.WriteLine("<thead>");
                    MyWriter.WriteLine("<tr>");
                    MyWriter.WriteLine("<th scope=\"col\">#</th>");
                    MyWriter.WriteLine("<th scope=\"col\">LEXEMA</th>");
                    MyWriter.WriteLine("<th scope=\"col\">TIPO</th>");
                    MyWriter.WriteLine("<th scope=\"col\">FILA</th>");
                    MyWriter.WriteLine("<th scope=\"col\">COLUMNA</th>");
                    MyWriter.WriteLine("</tr>");
                    MyWriter.WriteLine("</thead>");
                    MyWriter.WriteLine("<tbody>");
                    for (int p = 0; p < Program.TablaS.Count; p++)
                    {
                        String[] auxVector3 = (String[])Program.TablaS[p];
                        MyWriter.WriteLine("<tr>");
                        MyWriter.WriteLine("<th scope=\"col\">" + auxVector3[0] + "</th>");
                        MyWriter.WriteLine("<th scope=\"col\">" + auxVector3[1] + "</th>");
                        MyWriter.WriteLine("<th scope=\"col\">" + auxVector3[2] + "</th>");
                        MyWriter.WriteLine("<th scope=\"col\">" + auxVector3[3] + "</th>");
                        MyWriter.WriteLine("<th scope=\"col\">" + auxVector3[4] + "</th>");
                        MyWriter.WriteLine("</tr>");
                    }
                    MyWriter.WriteLine("</tbody>");
                    MyWriter.WriteLine("</font>");
                    MyWriter.Close();
                    MyStream.Close();
                    MessageBox.Show("Guardado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start("chrome.exe", saveFile.FileName);
                }
            }

            if (Errores)
            {
                saveFile.Title = "Guardar Tabla de Errores";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    FileStream MyStream = new FileStream(saveFile.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                    StreamWriter MyWriter = new StreamWriter(MyStream);
                    MyWriter.WriteLine("<font size=\"2\" face=\"Segoe UI Emoji\" >");
                    MyWriter.WriteLine("<h2 style=\"text - align: center; \"><strong>TABLA DE ERRORES</strong></h2>");
                    MyWriter.WriteLine("<table align=\"center\" border=\"1\" cellpadding=\"1\" cellspacing=\"1\" style=\"width: 500px;\">");
                    MyWriter.WriteLine("<thead>");
                    MyWriter.WriteLine("<tr>");
                    MyWriter.WriteLine("<th scope=\"col\">#</th>");
                    MyWriter.WriteLine("<th scope=\"col\">ERROR</th>");
                    MyWriter.WriteLine("<th scope=\"col\">DESCRIPCION</th>");
                    MyWriter.WriteLine("<th scope=\"col\">FILA</th>");
                    MyWriter.WriteLine("<th scope=\"col\">COLUMNA</th>");
                    MyWriter.WriteLine("</tr>");
                    MyWriter.WriteLine("</thead>");
                    MyWriter.WriteLine("<tbody>");
                    for (int p = 0; p < Program.TablaE.Count; p++)
                    {
                        String[] auxVector3 = (String[])Program.TablaE[p];
                        MyWriter.WriteLine("<tr>");
                        MyWriter.WriteLine("<th scope=\"col\">" + auxVector3[0] + "</th>");
                        MyWriter.WriteLine("<th scope=\"col\">" + auxVector3[1] + "</th>");
                        MyWriter.WriteLine("<th scope=\"col\">" + auxVector3[2] + "</th>");
                        MyWriter.WriteLine("<th scope=\"col\">" + auxVector3[3] + "</th>");
                        MyWriter.WriteLine("<th scope=\"col\">" + auxVector3[4] + "</th>");
                        MyWriter.WriteLine("</tr>");
                    }
                    MyWriter.WriteLine("</tbody>");
                    MyWriter.WriteLine("</font>");
                    MyWriter.Close();
                    MyStream.Close();
                    MessageBox.Show("Guardado Correctamente", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Process.Start("chrome.exe", saveFile.FileName);
                }
            }

        }

        public void PaintText(RichTextBox Code)
        {
            int tabs = 0;
            Code.Clear();
            foreach (String[] Vector in Program.TablaS)
            {
                if (Vector[2].Contains("Reservada"))
                {
                    Code.AppendText(Tabulador(tabs)+Vector[1],Color.RoyalBlue);
                }
                else if(Vector[2].Contains("Numero"))
                {
                    Code.AppendText(Vector[1], Color.Green);
                }
                else if (Vector[2].Contains("Cadena"))
                {
                    Code.AppendText(Vector[1], Color.Goldenrod);
                }
                else if (Vector[2].Contains("Abre Llave"))
                {
                    Code.AppendText(Vector[1] + "\n", Color.Red);
                    tabs++;
                }
                else if (Vector[2].Contains("Cierra Llave"))
                {
                    Code.AppendText(Tabulador(tabs) + Vector[1] + "\n", Color.Red);
                    tabs--;
                }
                else if (Vector[2].Contains("Punto y Coma"))
                {
                    Code.AppendText(Vector[1]+"\n", Color.DarkOrange);
                }
                else
                {
                    Code.AppendText(Vector[1], Color.Black);
                }
            }
        }

        //Verfica si MyString existe en MyArray y regresara el indice si no regresara -1
        public int Verificador(String[] MyArray, String MyString )
        {
            int contador = 0;
            foreach (String Cadena in MyArray)
            {
                if (MyString.Equals(Cadena, StringComparison.OrdinalIgnoreCase))
                {
                    return contador;
                }
                contador++;
            }
            return -1;
        }

        //Me regresa una string con n tabulaciones
        public String Tabulador(int n)
        {
            String aux="";
            for (int i=0;i<n;i++)
            {
                aux = aux + "\t";
            }
            return aux;
        }
    }

    public static class RichTextBoxExtensions
    {
        //SE SOBRECARGAR EL METODO APPENDTEXT PARA PODER PINTAR EL TEXTO
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }

}
