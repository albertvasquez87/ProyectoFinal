using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;


namespace practica_alberto
{
    public partial class programa2 : Form
    {
        public programa2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mnuSwitch_Click(object sender, EventArgs e)
        {/*Leopoldo Evangelista   10-EISN-1-183 en esta parte lo que se hace una instancia de el 
          formulario seleccion y se invoca con .show y se usa MdiParent para hacer que el formulario
          llamado sea tipo mdi al igual que este . igual en los demas casos*/
            fmSeleccion fs = new fmSeleccion();
            fs.Show();
            fs.MdiParent = this;
           
        }

        private void mnuForDoWhile_Click(object sender, EventArgs e)
        {
            fmRepeticion fr = new fmRepeticion();
            fr.Show();
            fr.MdiParent = this;


        }

        private void mnvolver_Click(object sender, EventArgs e)
        {
            MsgBoxUtil.HackMessageBox("volver al menu", "salir","Cancelar");
            DialogResult respuesta = MessageBox.Show("¿Que deseas hacer volver al menu o cerrar el programa ? ", "Alerta", MessageBoxButtons.AbortRetryIgnore);
            if (respuesta == DialogResult.Abort)
            {
                Form1 fm = new Form1();
                fm.Show();
                this.Close();
            }
                if (respuesta == DialogResult.Retry)
                {
                    Application.Exit();
                }
            else
            {
                
            }
        }
        public class MsgBoxUtil
        {//en esta seccion completa me ayudo un amigo
            #region Interoperabilidad
            /// <summary>Delegado para pasar funciones coom parametro a llmados de la api</summary>
            private delegate bool EnumWindowDelegate(IntPtr handler, IntPtr longPointer);

            /// <summary>Establece el texto de una ventana</summary>
            [DllImport("user32.dll")]
            private static extern bool SetWindowText(IntPtr handler, string texto);

            /// <summary>Obtiene el nombre de la clase de una ventana</summary>
            [DllImport("user32.dll")]
            private static extern int GetClassName(IntPtr handler, StringBuilder nombre, int tamañoMaximo);

            /// <summary>Realiza un listado de las ventanas hijas y por cada una ejecuta un callback asociado</summary>
            [DllImport("user32.dll")]
            private static extern bool EnumChildWindows(IntPtr handler, EnumWindowDelegate callback, IntPtr longPointer);

            /// <summary>Realiza un listado de las ventanas del hilo actual por cada una ejecuta un callback asociado</summary>
            [DllImport("user32.dll")]
            private static extern bool EnumThreadWindows(int threadID, EnumWindowDelegate callback, IntPtr longPointer);

            /// <summary>Obtiene el ID del hilo actual</summary>
            [DllImport("kernel32.dll")]
            private static extern int GetCurrentThreadId();

            /// <summary>Obtiene el handler de una ventana</summary>
            [DllImport("user32.dll")]
            static extern IntPtr FindWindow(string ClassName, string WindowName);

            /// <summary>Obtiene el thread id del  hilo donde se ejecuta una ventana</summary>
            [DllImport("user32.dll", SetLastError = true)]
            static extern int GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

            /// <summary>Realiza un listado de las ventanas y por cada una ejecuta un callback asociado</summary>
            [DllImport("user32.dll")]
            static extern bool EnumWindows(EnumWindowDelegate lpEnumFunc, IntPtr lParam);

            /// <summary>Destruye la referencia a una ventana</summary>
            [DllImport("user32.dll")]
            static extern bool DestroyWindow(IntPtr hwnd);
            #endregion Interoperabilidad

            #region Objetos locales
            /// <summary>Array que almacena los textosque se colocaran a cada uno de los botones del msgbox</summary>
            private static string[] textoBotones;
            /// <summary>Indica cual de los botones se esta actualizando</summary>
            private static int indiceTexto;
            /// <summary>Delegado para llamar el proceso de cambio de texto de manera asincrona, se usa en aplicaciones no forms</summary>
            private static WaitCallback EsperarYCambiarMsgBoxWC = new WaitCallback(EsperarYCambiarMsgBox);
            /// <summary>Delegado para buscar e iniciar el proceso de cambio de textos en aplicaciones forms</summary>
            private delegate void BuscarMsgBoxDelegate();
            /// <summary>Handler del ultimo message box modificado</summary>
            private static IntPtr globalHandler;
            #endregion Objetos locales

            #region Constantes
            /// <summary>Nombre de la clase de la ventana de un messagebox</summary>
            private const string MBOX_CLASSNAME = "#32770";
            /// <summary>Nombre de la clase de la ventana de un boton</summary>
            private const string BUTTON_CLASSNAME = "Button";
            /// <summary>Número de reintentos de hallar un messagebox en el listado de ventanas
            /// , se usa en aplicaciones no forms</summary>
            private const int CICLOS_REINTENTO = 2;
            /// <summary>Tiempo de espera entre reintentos de hallar un messagebox en el listadod de ventanas
            /// , se usa en aplicaciones no forms</summary>
            private const int TIEMPO_REINTENTO = 50;
            /// <summary>Capacidad máxima para StringBuilders</summary>
            private const int STRING_BUILDER_CAPACITY = 256;
            #endregion Constantes

            #region Métodos Públicos

            /// <summary>
            /// Modifica el texto de los botones de un messagebox
            /// </summary>
            /// <param name="textoBotones">lista de labels para los botones</param>
            /// <remarks>Internamente se llama a EsperarYCambiarMsgBoxWC
            /// que es un WaitCallBack que llama a EsperarYCambiarMsgBox</remarks>
            public static void HackMessageBox(params string[] textoBotones)
            {
                //guardar referencia global a la lista
                MsgBoxUtil.textoBotones = textoBotones;
                //Si hay al menos una forma... se debe trabajar como aplicación forms
                if (Application.OpenForms.Count > 0)
                    //Se llama el delegado desde el hilo actual de forms
                    Application.OpenForms[0].BeginInvoke(new BuscarMsgBoxDelegate(BuscaMessageBox));
                else/*sino, se debe presuponer que la instancia del msgbox no ha sido creada
             * y hay que esperar a que se cree*/
                    //Llamado asincrono
                    ThreadPool.QueueUserWorkItem(EsperarYCambiarMsgBoxWC);
            }

            /// <summary>Destruye el hack aplicado</summary>
            public static void UnHackMessageBox()
            {
                //destruye la ventahna de msgbox a la qu se le aplico el hack
                //windows se encarga de revivir la instancia
                DestroyWindow(MsgBoxUtil.globalHandler);
            }

            #endregion #region Métodos Públicos

            #region Métodos Privados

            /// <summary>Wrapper para simplificar el llamado a EnumThreadWindows desde HackMessageBox</summary>
            private static void BuscaMessageBox()
            {
                EnumThreadWindows(GetCurrentThreadId(), ProcesaMessageBoxEnForms, IntPtr.Zero);
            }

            /// <summary>
            /// Busca las ventanas que sean messagebox y que pertenezcan al proceso actual
            /// sino encuentra ninguna realiza algunos reintentos cada cierto tiempo
            /// </summary>
            /// <param name="stateInfo">no se usa, neceario para crear un waitcallback y asi realizar ejecución desde el threadpool</param>
            /// <remarks>Esta funcion es util cuando no se busca el messagebox desde forms, 
            /// ya que se debe esperar a que la instancia estatica del messagebox sea creada
            /// por lo cual se prevee hacer algunos intentos de busqueda</remarks>
            private static void EsperarYCambiarMsgBox(Object stateInfo)
            {
                int contador = CICLOS_REINTENTO;
                do
                {
                    //sino encontro, espera un poco y busca de nuevo
                    //EnumWindows retorna true si enumero las ventanas hasta el final
                    if (EnumWindows(ProcesaMessageBoxEnOtros, IntPtr.Zero))
                        Thread.Sleep(TIEMPO_REINTENTO);
                    else//si encontro se sale del ciclo
                        break;

                } while (--contador > 0);
            }

            /// <summary>
            /// Determina si el handler pasado es un messagebox, 
            /// si es así inicia el proceso de modificacion de texto de los botones
            /// </summary>
            /// <param name="handler">manejador de la ventana</param>
            /// <param name="longPointer">no se usa, pero se requiere como signature de delegado</param>
            /// <returns>Si el handle pasado no es un MessageBox devuelve true, false de lo contrario</returns>
            private static bool ProcesaMessageBoxEnForms(IntPtr handler, IntPtr longPointer)
            {
                //almacenar nombre de la clase
                StringBuilder nombreClase = new StringBuilder(STRING_BUILDER_CAPACITY);
                GetClassName(handler, nombreClase, nombreClase.Capacity);

                //Si no es un MessageBox...
                if (nombreClase.ToString() != MBOX_CLASSNAME)
                    return true;
                else
                {
                    //Inicializar indice del arreglo
                    indiceTexto = 0;
                    //Buscar y cambiar Botones del MessageBox
                    EnumChildWindows(handler, CambiaTextoBotonMessageBox, IntPtr.Zero);
                    //guardar handler del MessageBox
                    MsgBoxUtil.globalHandler = handler;
                    return false;
                }
            }

            /// <summary>
            /// Determina si el handler pasado es un messagebox, 
            /// si es así inicia el proceso de modificacion de texto de los botones
            /// </summary>
            /// <param name="handler">manejador de la ventana</param>
            /// <param name="longPointer">no se usa, pero se requiere como signature de delegado</param>
            /// <returns>Si el handle pasado no es un MessageBox devuelve true, false de lo contrario</returns>
            /// <remarks>Util para llamar cuando el proceso que hace el llamado no es forms</remarks>
            private static bool ProcesaMessageBoxEnOtros(IntPtr handler, IntPtr longPointer)
            {
                //almacenar nombre de la clase
                StringBuilder nombreClase = new StringBuilder(STRING_BUILDER_CAPACITY);
                GetClassName(handler, nombreClase, nombreClase.Capacity);

                //Si no es un MessageBox...
                if (nombreClase.ToString() != MBOX_CLASSNAME)
                    return true;
                else
                {   //Determinar el id de proceso actual
                    int pid = Process.GetCurrentProcess().Id;
                    /*Id del proceso de la ventana donde se ejecuta el 
                     * MesasgeBox al cual pertenece el handler*/
                    int wpid;
                    GetWindowThreadProcessId(handler, out wpid);

                    //Si son del mismo proceso se procede
                    //a realizar la modificacion de textos
                    if (wpid == pid)
                    {
                        //Inicializar indice del arreglo
                        indiceTexto = 0;
                        //Buscar y cambiar Botones del MessageBox
                        EnumChildWindows(handler, CambiaTextoBotonMessageBox, IntPtr.Zero);
                        //guardar handler del MessageBox
                        MsgBoxUtil.globalHandler = handler;
                        return false;
                    }
                    else
                        return true;
                }
            }

            /// <summary>
            /// Cambia el texto del boton recibido como parámetro de acuerdo al listado
            /// de valores iniciales al llamr a HackMessageBox
            /// </summary>
            /// <param name="handler">Manejador del boton</param>
            /// <param name="longPointer">no se usa, pero se requiere como signature de los delegados</param>
            /// <returns>siempre true</returns>
            private static bool CambiaTextoBotonMessageBox(IntPtr handler, IntPtr longPointer)
            {
                //almacenar nombre de la clase
                StringBuilder nombreClase = new StringBuilder(STRING_BUILDER_CAPACITY);
                GetClassName(handler, nombreClase, nombreClase.Capacity);

                //Si el handler es de un boton se modifica el texto
                if (nombreClase.ToString() == BUTTON_CLASSNAME && indiceTexto < textoBotones.Length)
                {
                    SetWindowText(handler, textoBotones[indiceTexto]);
                    indiceTexto++;
                }
                return true;
            }
            #endregion Métodos Privados

        }

        private void programa2_Load(object sender, EventArgs e)
        {
         
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            fmRacionales fr = new fmRacionales();
            fr.Show();
            fr.MdiParent = this;
            if (fr.IsDisposed == true)
            {
                label1.Show();
            }
            if (this.Visible == true)
            {
                label1.Hide();
            }
        }

        private void mnulf_Click(object sender, EventArgs e)
        {
            fmCondicion fc = new fmCondicion();
            fc.MdiParent = this;
            fc.Show();
        }

        private void mnuClases_Click(object sender, EventArgs e)
        {
            proximamente pr = new proximamente();
            pr.MdiParent = this; pr.Show();
        }

        private void matematicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            variables vr = new variables();
            vr.Show();

            vr.MdiParent = this;
            
            if (vr.IsDisposed==true)
            {
                label1.Show();   
            }
            if (this.Visible==true)
            {
                label1.Hide(); 
            }
        }
    }
}
