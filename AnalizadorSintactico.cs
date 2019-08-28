using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1LF_AnalizadorLexico
{
    class AnalizadorSintactico
    {
        //PARA ANALISIS SINTACTICO
        int MainPointer;
        Boolean Errores; 
        String[] TempVector = new String[5]; //Guardara Temporalmente la informacion del Pais
        String TempCont; //Guarda Temporalmente el nombre del Continente 

        //PARA EXTRAS
        public static String[] Pais; //Guardara al Pais Seleccionado
        public static String RutaImg; //Guarda Imagen de Grafica

        public AnalizadorSintactico()
        {

        }

        public void Parsing()
        {
            MainPointer = 0;
            Errores = false;
            TempVector = new String[6];
            Program.TablaS.Add(new String[] {null,null,"Final","Ultima","Ultima"});
            BloqueGrafica();
            if (!Errores)
            {
                MessageBox.Show("Ok", "Syntax Analysis", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            //String[] aux2i = (String[])Program.TablaI[0];
            //Console.WriteLine(" ");
            //Console.WriteLine(aux2i[0]);
            //for (int i=1;i<Program.TablaI.Count;i++)
            //{
            //    String[] auxi = (String[])Program.TablaI[i];
            //    Console.Write(auxi[0] + " ");
            //    Console.Write(auxi[1] + " ");
            //    Console.Write(auxi[2] + " ");
            //    Console.Write(auxi[3] + " ");
            //    Console.Write(auxi[4] + " ");
            //    Console.WriteLine(" ");
            //}

        }

        private void ErrorProvider(String linea,String columna)
        {
            MessageBox.Show("Error en linea "+linea+" y columna "+columna, "Syntax Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void NextToken(String Token1, int Pointer)
        {
            String[] Token2=(String[])Program.TablaS[Pointer];
            if (!Errores) {
                if (Token1.Equals(Token2[2]))
                {
                    MainPointer++;
                }
                else
                {
                    Errores = true;
                    ErrorProvider(Token2[3], Token2[4]);
                }
            }
        }

        private Boolean CompareToken(String Token1, int Pointer)
        {
            String[] Token2 = (String[])Program.TablaS[Pointer];
            if (!Token2[2].Equals("Final"))
            {
                if (Token1.Equals(Token2[2]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else { return false; }
            
        }

        private String ReturnLexeme(int Pointer)
        {
            String[] aux = (String[])Program.TablaS[Pointer];
            return aux[1];
        }

        private void BloqueGrafica()
        {

            NextToken("Reservada Grafica", MainPointer);
            NextToken("Dos Puntos", MainPointer);
            NextToken("Abre Llave", MainPointer);
            NextToken("Reservada Nombre", MainPointer);
            NextToken("Dos Puntos", MainPointer);
            NextToken("Comillas Dobles", MainPointer);
            NextToken("Cadena", MainPointer);
            NextToken("Comillas Dobles", MainPointer);
            NextToken("Punto y Coma", MainPointer);
            if (!Errores) {
                TempVector[0] = ReturnLexeme(MainPointer-3);
                Program.TablaI.Add(TempVector);
                TempVector = new String[5];
            }
            if (!Errores) { BloqueContinente(); }
            NextToken("Cierra Llave", MainPointer);

        }

        private void BloqueContinente()
        {
            NextToken("Reservada Continente", MainPointer);
            NextToken("Dos Puntos", MainPointer);
            NextToken("Abre Llave", MainPointer);
            NextToken("Reservada Nombre", MainPointer);
            NextToken("Dos Puntos", MainPointer);
            NextToken("Comillas Dobles", MainPointer);
            NextToken("Cadena", MainPointer);
            NextToken("Comillas Dobles", MainPointer);
            NextToken("Punto y Coma", MainPointer);
            if (!Errores) {
                TempVector = new String[5];
                TempVector[0] = ReturnLexeme(MainPointer - 3);
                TempCont = TempVector[0];
            }
            if (!Errores) { BloquePais(); }
            NextToken("Cierra Llave", MainPointer);
            if(CompareToken("Reservada Continente", MainPointer) && !Errores) { BloqueContinente(); }
        }

        private void BloquePais()
        {
            NextToken("Reservada Pais", MainPointer);
            NextToken("Dos Puntos", MainPointer);
            NextToken("Abre Llave", MainPointer);
            PropiedadesPais();
            PropiedadesPais();
            PropiedadesPais();
            PropiedadesPais();
            NextToken("Cierra Llave", MainPointer);
            if (!Errores) {
                Program.TablaI.Add(TempVector);
                TempVector = new String[5];
                TempVector[0] = TempCont;
            }
            if (CompareToken("Reservada Pais", MainPointer)&&!Errores) { BloquePais(); }

        }

        private void PropiedadesPais()
        {
            String[] aux = (String[])Program.TablaS[MainPointer];
            if (!Errores)
            {
                switch (aux[2])
                {
                    case "Reservada Nombre":
                        NextToken("Reservada Nombre", MainPointer);
                        NextToken("Dos Puntos", MainPointer);
                        NextToken("Comillas Dobles", MainPointer);
                        NextToken("Cadena", MainPointer);
                        NextToken("Comillas Dobles", MainPointer);
                        NextToken("Punto y Coma", MainPointer);
                        if (!Errores) { TempVector[1] = ReturnLexeme(MainPointer - 3); }
                        break;
                    case "Reservada Poblacion":
                        NextToken("Reservada Poblacion", MainPointer);
                        NextToken("Dos Puntos", MainPointer);
                        NextToken("Numero", MainPointer);
                        NextToken("Punto y Coma", MainPointer);
                        if (!Errores) { TempVector[2] = ReturnLexeme(MainPointer - 2); }
                        break;
                    case "Reservada Saturacion":
                        NextToken("Reservada Saturacion", MainPointer);
                        NextToken("Dos Puntos", MainPointer);
                        NextToken("Numero", MainPointer);
                        NextToken("Porcentaje", MainPointer);
                        NextToken("Punto y Coma", MainPointer);
                        if (Int32.Parse(ReturnLexeme(MainPointer - 3))<=100 && Int32.Parse(ReturnLexeme(MainPointer - 3))>=0)
                        {
                            //NOTHING
                        }
                        else
                        {
                            NextToken("NumeroMal", MainPointer-4);
                        }
                        if (!Errores) { TempVector[3] = ReturnLexeme(MainPointer - 3); }
                        break;
                    case "Reservada Bandera":
                        NextToken("Reservada Bandera", MainPointer);
                        NextToken("Dos Puntos", MainPointer);
                        NextToken("Comillas Dobles", MainPointer);
                        NextToken("Cadena", MainPointer);
                        NextToken("Comillas Dobles", MainPointer);
                        NextToken("Punto y Coma", MainPointer);
                        if (!Errores) { TempVector[4] = ReturnLexeme(MainPointer - 3); }
                        break;
                }
            }
        }

        public void GenerateGraph()
        {
            int Continentes=0;
            int Paises = 1;
            int SatCont = 0;
            if (!Errores)
            {
                String[] aux;
                String[] auxCont = new String[100];

                aux = (String[])Program.TablaI[0];
                String GraphName = aux[0];

                aux = (String[])Program.TablaI[1];
                auxCont[0] = aux[0];
                SatCont = Int32.Parse(aux[3]);
                Program.TablaI.Add(new String[] { "Final", null });

                //Se identifican los continentes con su saturacion
                for (int i = 2; i < Program.TablaI.Count; i++)
                {
                    aux = (String[])Program.TablaI[i];

                    //Si es diferente continente se agrega
                    if (aux[0] == "Final")
                    {
                        //Se establece Saturacion del Continente anterior
                        SatCont = (SatCont / Paises);
                        auxCont[Continentes + 1] = SatCont.ToString();
                    }
                    else if (aux[0] != auxCont[Continentes])
                    {
                        //Se establece Saturacion del Continente anterior
                        SatCont = (SatCont / Paises);
                        auxCont[Continentes + 1] = SatCont.ToString();
                        //Se establece el siguiente continente
                        Continentes += 2;
                        auxCont[Continentes] = aux[0];
                        SatCont = Int32.Parse(aux[3]);
                        Paises = 1;
                    }
                    else
                    {
                        SatCont = SatCont + Int32.Parse(aux[3]);
                        Paises++;
                    }

                }
                Program.TablaI.RemoveAt(Program.TablaI.Count - 1);

                int menor = 100; //SAT MAXIMA
                Pais = new String[5];

                //Se identifica el mejor pais
                for (int j = 1; j < Program.TablaI.Count; j++)
                {
                    aux = (String[])Program.TablaI[j];
                    if (Int32.Parse(aux[3]) < menor)
                    {
                        menor = Int32.Parse(aux[3]);
                        Pais = aux;
                    }
                    if (Int32.Parse(aux[3]) == menor)
                    {
                        //Si la saturacion del continente es menor 
                        if (Int32.Parse(SearchSat(auxCont, aux[0])) < Int32.Parse(SearchSat(auxCont, Pais[0])))
                        {
                            Pais = aux;
                        }

                    }
                }

                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Archivo DOT (*.dot)|*.dot";
                saveFile.DefaultExt = "dot";
                saveFile.AddExtension = true;

                saveFile.Title = "Guardar Grafico";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    FileStream MyStream = new FileStream(saveFile.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                    StreamWriter MyWriter = new StreamWriter(MyStream);
                    MyWriter.WriteLine("digraph G {");
                    //Se llena Segundo Nivel
                    for (int p = 0; p <= Continentes; p += 2)
                    {
                        MyWriter.WriteLine(GraphName + "->" + auxCont[p] + ";");
                    }
                    //Se llena tercer nivel
                    for (int n = 1; n < Program.TablaI.Count; n++)
                    {
                        aux = (String[])Program.TablaI[n];
                        MyWriter.WriteLine(aux[0] + "->" + aux[1] + ";");
                    }
                    MyWriter.WriteLine(GraphName + "[shape = Mdiamond label = \"" + GraphName + "\"];");
                    //Se da formato a cada nodo
                    for (int p = 0; p <= Continentes; p += 2)
                    {
                        MyWriter.WriteLine(FormatNode(auxCont[p], Int32.Parse(auxCont[p + 1])));
                    }
                    for (int n = 1; n < Program.TablaI.Count; n++)
                    {
                        aux = (String[])Program.TablaI[n];
                        MyWriter.WriteLine(FormatNode(aux[1], Int32.Parse(aux[3])));
                    }
                    MyWriter.WriteLine("}");
                    MyWriter.Close();
                    MyStream.Close();
                    MessageBox.Show("Guardado Correctamente", "Grafico", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //SE MANDO COMANDO AL SHELL DEL SISTEMA 
                    RutaImg = Path.GetDirectoryName(saveFile.FileName) + "\\" + Path.GetFileNameWithoutExtension(saveFile.FileName) + ".png";
                    String Command = "dot.exe -Tpng "+saveFile.FileName+" -o "+RutaImg;
                    Process cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = false;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.Start();
                    cmd.StandardInput.WriteLine(Command);
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.Close();
                    cmd.WaitForExit();
                    Console.WriteLine(cmd.StandardOutput.ReadToEnd());
                    Console.Read();
                }
            }

        }

        //Me devuleve la saturacion del continente indicado
        private String SearchSat(String[]Vector,String Cont)
        {
            String Sat="";
            for (int i=0;i<Vector.Length;i++)
            {
                if (Vector[i].Equals(Cont))
                {
                    Sat= Vector[i + 1];
                    break;
                }

            }
            return Sat;
        }

        //Me devuelve un string para dar formato en grafica
        private String FormatNode(String Name,int Sat)
        {
            String color="";
            if (Sat<=15)
            {
                color = "white";
            }
            else if (Sat <= 30)
            {
                color = "dodgerblue";
            }
            else if (Sat <= 45)
            {
                color = "limegreen";
            }
            else if (Sat <= 60)
            {
                color = "gold";
            }
            else if (Sat <= 75)
            {
                color = "darkorange";
            }
            else if (Sat <= 100)
            {
                color = "red";
            }
            return Name + "[shape = record label = \"{" + Name + "|" + Sat + "}\"style = filled fillcolor =" + color + "];";
            
        }
    }
}
