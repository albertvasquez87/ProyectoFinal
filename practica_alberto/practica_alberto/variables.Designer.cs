namespace practica_alberto
{
    partial class variables
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "                                                                    Tipos, variab" +
                "les y valores",
            "C# es un lenguaje fuertemente tipado. Todas las variables y constantes tienen un " +
                "tipo, al igual que todas las expresiones que se evalúan ",
            "como un valor. ",
            "Cada una de las firmas de método especifica un tipo para cada parámetro de entrad" +
                "a y para el valor devuelto. ",
            "La biblioteca de clases .NET define un conjunto de tipos numéricos integrados, as" +
                "í como tipos más complejos ",
            "que representan una amplia variedad ",
            "de construcciones lógicas, como el sistema de archivos, conexiones de red, colecc" +
                "iones y matrices de objetos, y fechas.",
            "Los programas de C# típicos usan tipos de la biblioteca de clases, así como tipos" +
                " definidos por el usuario que modelan ",
            "los conceptos que son específicos del dominio del problema del programa.",
            "",
            "Entre la información almacenada en un tipo se puede incluir lo siguiente:",
            "",
            "El espacio de almacenamiento que requiere una variable del tipo.",
            "",
            "Los valores máximo y mínimo que puede representar.",
            "",
            "Los miembros (métodos, campos, eventos, etc.) que contiene.",
            "",
            "El tipo base del que hereda.",
            "",
            "La ubicación donde se asignará la memoria para variables en tiempo de ejecución.",
            "",
            "Los tipos de operaciones permitidas.",
            "",
            "El compilador usa información de tipo para garantizar que todas las operaciones q" +
                "ue se realizan en el código cuentan con seguridad de tipos",
            ". Por ejemplo, si declara una variable de tipo int, el compilador le permite usar" +
                " la variable en operaciones de suma y resta."});
            this.listBox1.Location = new System.Drawing.Point(3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(904, 132);
            this.listBox1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::practica_alberto.Properties.Resources.ScreenShot_20180413224350;
            this.pictureBox2.Location = new System.Drawing.Point(236, 140);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(388, 430);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // variables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 575);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "variables";
            this.Text = "variables";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}