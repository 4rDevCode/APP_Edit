namespace AppEdit
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.gb01 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.nudAño = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gb01.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(479, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Probar conexión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gb01
            // 
            this.gb01.Controls.Add(this.textBox1);
            this.gb01.Controls.Add(this.button2);
            this.gb01.Controls.Add(this.nudAño);
            this.gb01.Controls.Add(this.label2);
            this.gb01.Controls.Add(this.txtEmpresa);
            this.gb01.Controls.Add(this.label1);
            this.gb01.Enabled = false;
            this.gb01.Location = new System.Drawing.Point(12, 53);
            this.gb01.Name = "gb01";
            this.gb01.Size = new System.Drawing.Size(479, 72);
            this.gb01.TabIndex = 1;
            this.gb01.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(325, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "RESET ZVERS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // nudAño
            // 
            this.nudAño.Location = new System.Drawing.Point(234, 29);
            this.nudAño.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudAño.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudAño.Name = "nudAño";
            this.nudAño.Size = new System.Drawing.Size(85, 20);
            this.nudAño.TabIndex = 1;
            this.nudAño.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAño.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Año:";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(140, 28);
            this.txtEmpresa.MaxLength = 2;
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(51, 20);
            this.txtEmpresa.TabIndex = 0;
            this.txtEmpresa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEmpresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmpresa_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código empresa:";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(104, 28);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(37, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "00";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 137);
            this.Controls.Add(this.gb01);
            this.Controls.Add(this.button1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppEdit";
            this.gb01.ResumeLayout(false);
            this.gb01.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAño)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gb01;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown nudAño;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

