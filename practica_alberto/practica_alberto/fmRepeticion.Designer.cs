namespace practica_alberto
{
    partial class fmRepeticion
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbDoWhile = new System.Windows.Forms.RadioButton();
            this.rbWhile = new System.Windows.Forms.RadioButton();
            this.rbFor = new System.Windows.Forms.RadioButton();
            this.nudTablaNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.nudBreak = new System.Windows.Forms.NumericUpDown();
            this.nudContinue = new System.Windows.Forms.NumericUpDown();
            this.ckbBreak = new System.Windows.Forms.CheckBox();
            this.ckbContinue = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listTabla = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtCodigo = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTablaNum)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContinue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbDoWhile);
            this.panel1.Controls.Add(this.rbWhile);
            this.panel1.Controls.Add(this.rbFor);
            this.panel1.Controls.Add(this.nudTablaNum);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 100);
            this.panel1.TabIndex = 1;
            // 
            // rbDoWhile
            // 
            this.rbDoWhile.AutoSize = true;
            this.rbDoWhile.Location = new System.Drawing.Point(276, 74);
            this.rbDoWhile.Name = "rbDoWhile";
            this.rbDoWhile.Size = new System.Drawing.Size(84, 17);
            this.rbDoWhile.TabIndex = 6;
            this.rbDoWhile.Text = "Do...While...";
            this.rbDoWhile.UseVisualStyleBackColor = true;
            // 
            // rbWhile
            // 
            this.rbWhile.AutoSize = true;
            this.rbWhile.Location = new System.Drawing.Point(156, 74);
            this.rbWhile.Name = "rbWhile";
            this.rbWhile.Size = new System.Drawing.Size(61, 17);
            this.rbWhile.TabIndex = 5;
            this.rbWhile.Text = "While...";
            this.rbWhile.UseVisualStyleBackColor = true;
            // 
            // rbFor
            // 
            this.rbFor.AutoSize = true;
            this.rbFor.Checked = true;
            this.rbFor.Location = new System.Drawing.Point(36, 74);
            this.rbFor.Name = "rbFor";
            this.rbFor.Size = new System.Drawing.Size(49, 17);
            this.rbFor.TabIndex = 4;
            this.rbFor.TabStop = true;
            this.rbFor.Text = "For...";
            this.rbFor.UseVisualStyleBackColor = true;
            // 
            // nudTablaNum
            // 
            this.nudTablaNum.Location = new System.Drawing.Point(140, 23);
            this.nudTablaNum.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudTablaNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTablaNum.Name = "nudTablaNum";
            this.nudTablaNum.Size = new System.Drawing.Size(40, 20);
            this.nudTablaNum.TabIndex = 3;
            this.nudTablaNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTablaNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seleccionar la Estructura de Control Repetitiva:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mostrar Tabla del:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tabla de Multiplicar";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnCerrar);
            this.panel3.Controls.Add(this.btnCalcular);
            this.panel3.Controls.Add(this.nudBreak);
            this.panel3.Controls.Add(this.nudContinue);
            this.panel3.Controls.Add(this.ckbBreak);
            this.panel3.Controls.Add(this.ckbContinue);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 303);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(451, 97);
            this.panel3.TabIndex = 3;
            // 
            // btnCerrar
            // 
            this.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCerrar.Location = new System.Drawing.Point(331, 51);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "&Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.AutoSize = true;
            this.btnCalcular.Location = new System.Drawing.Point(331, 18);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 27);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // nudBreak
            // 
            this.nudBreak.Location = new System.Drawing.Point(145, 47);
            this.nudBreak.Name = "nudBreak";
            this.nudBreak.Size = new System.Drawing.Size(120, 20);
            this.nudBreak.TabIndex = 4;
            // 
            // nudContinue
            // 
            this.nudContinue.Location = new System.Drawing.Point(145, 21);
            this.nudContinue.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nudContinue.Name = "nudContinue";
            this.nudContinue.Size = new System.Drawing.Size(40, 20);
            this.nudContinue.TabIndex = 3;
            this.nudContinue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ckbBreak
            // 
            this.ckbBreak.AutoSize = true;
            this.ckbBreak.Location = new System.Drawing.Point(43, 48);
            this.ckbBreak.Name = "ckbBreak";
            this.ckbBreak.Size = new System.Drawing.Size(82, 17);
            this.ckbBreak.TabIndex = 2;
            this.ckbBreak.Text = "Detener en:";
            this.ckbBreak.UseVisualStyleBackColor = true;
            // 
            // ckbContinue
            // 
            this.ckbContinue.AutoSize = true;
            this.ckbContinue.Location = new System.Drawing.Point(43, 22);
            this.ckbContinue.Name = "ckbContinue";
            this.ckbContinue.Size = new System.Drawing.Size(66, 17);
            this.ckbContinue.TabIndex = 1;
            this.ckbContinue.Text = "Omitir el:";
            this.ckbContinue.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Restricciones:";
            // 
            // listTabla
            // 
            this.listTabla.Dock = System.Windows.Forms.DockStyle.Left;
            this.listTabla.FormattingEnabled = true;
            this.listTabla.Location = new System.Drawing.Point(0, 100);
            this.listTabla.Name = "listTabla";
            this.listTabla.Size = new System.Drawing.Size(148, 203);
            this.listTabla.TabIndex = 4;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(148, 100);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(148, 203);
            this.listBox1.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCodigo.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtCodigo.Location = new System.Drawing.Point(296, 100);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(155, 203);
            this.txtCodigo.TabIndex = 6;
            this.txtCodigo.Text = "";
            // 
            // fmRepeticion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 400);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.listTabla);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "fmRepeticion";
            this.Text = "fmRepeticion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTablaNum)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudContinue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbDoWhile;
        private System.Windows.Forms.RadioButton rbWhile;
        private System.Windows.Forms.RadioButton rbFor;
        private System.Windows.Forms.NumericUpDown nudTablaNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.NumericUpDown nudBreak;
        private System.Windows.Forms.NumericUpDown nudContinue;
        private System.Windows.Forms.CheckBox ckbBreak;
        private System.Windows.Forms.CheckBox ckbContinue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listTabla;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.RichTextBox txtCodigo;
    }
}