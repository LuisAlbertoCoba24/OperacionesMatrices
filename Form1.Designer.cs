namespace Matrices
{
    partial class MatrizForm
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
            this.filasLabel = new System.Windows.Forms.Label();
            this.Filastxt = new System.Windows.Forms.TextBox();
            this.ColumnasLbael = new System.Windows.Forms.Label();
            this.Columnastxt = new System.Windows.Forms.TextBox();
            this.DimensionBtn = new System.Windows.Forms.Button();
            this.LimpiarBtn = new System.Windows.Forms.Button();
            this.PrimeraMatrizBtn = new System.Windows.Forms.Button();
            this.SegundaMatrizBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SumaBtn = new System.Windows.Forms.Button();
            this.DiagonalBtn = new System.Windows.Forms.Button();
            this.MultiplicacionBtn = new System.Windows.Forms.Button();
            this.DivisionBtn = new System.Windows.Forms.Button();
            this.txtMatrizDos = new System.Windows.Forms.RichTextBox();
            this.txtMatrizResultado = new System.Windows.Forms.RichTextBox();
            this.txtMatrisUno = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // filasLabel
            // 
            this.filasLabel.AutoSize = true;
            this.filasLabel.Location = new System.Drawing.Point(37, 33);
            this.filasLabel.Name = "filasLabel";
            this.filasLabel.Size = new System.Drawing.Size(41, 17);
            this.filasLabel.TabIndex = 0;
            this.filasLabel.Text = "Filas:";
            this.filasLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Filastxt
            // 
            this.Filastxt.Location = new System.Drawing.Point(84, 30);
            this.Filastxt.Name = "Filastxt";
            this.Filastxt.Size = new System.Drawing.Size(100, 22);
            this.Filastxt.TabIndex = 1;
            // 
            // ColumnasLbael
            // 
            this.ColumnasLbael.AutoSize = true;
            this.ColumnasLbael.Location = new System.Drawing.Point(213, 33);
            this.ColumnasLbael.Name = "ColumnasLbael";
            this.ColumnasLbael.Size = new System.Drawing.Size(74, 17);
            this.ColumnasLbael.TabIndex = 2;
            this.ColumnasLbael.Text = "Columnas:";
            this.ColumnasLbael.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Columnastxt
            // 
            this.Columnastxt.Location = new System.Drawing.Point(293, 30);
            this.Columnastxt.Name = "Columnastxt";
            this.Columnastxt.Size = new System.Drawing.Size(100, 22);
            this.Columnastxt.TabIndex = 3;
            // 
            // DimensionBtn
            // 
            this.DimensionBtn.Location = new System.Drawing.Point(422, 30);
            this.DimensionBtn.Name = "DimensionBtn";
            this.DimensionBtn.Size = new System.Drawing.Size(97, 23);
            this.DimensionBtn.TabIndex = 4;
            this.DimensionBtn.Text = "Dimensión";
            this.DimensionBtn.UseVisualStyleBackColor = true;
            this.DimensionBtn.Click += new System.EventHandler(this.DimensionBtn_Click);
            // 
            // LimpiarBtn
            // 
            this.LimpiarBtn.Location = new System.Drawing.Point(537, 30);
            this.LimpiarBtn.Name = "LimpiarBtn";
            this.LimpiarBtn.Size = new System.Drawing.Size(75, 23);
            this.LimpiarBtn.TabIndex = 5;
            this.LimpiarBtn.Text = "Limpiar";
            this.LimpiarBtn.UseVisualStyleBackColor = true;
            this.LimpiarBtn.Click += new System.EventHandler(this.LimpiarBtn_Click);
            // 
            // PrimeraMatrizBtn
            // 
            this.PrimeraMatrizBtn.Location = new System.Drawing.Point(40, 139);
            this.PrimeraMatrizBtn.Name = "PrimeraMatrizBtn";
            this.PrimeraMatrizBtn.Size = new System.Drawing.Size(278, 53);
            this.PrimeraMatrizBtn.TabIndex = 7;
            this.PrimeraMatrizBtn.Text = "Ingrese valores de la primera matriz";
            this.PrimeraMatrizBtn.UseVisualStyleBackColor = true;
            this.PrimeraMatrizBtn.Click += new System.EventHandler(this.PrimeraMatrizBtn_Click);
            // 
            // SegundaMatrizBtn
            // 
            this.SegundaMatrizBtn.Location = new System.Drawing.Point(513, 139);
            this.SegundaMatrizBtn.Name = "SegundaMatrizBtn";
            this.SegundaMatrizBtn.Size = new System.Drawing.Size(248, 53);
            this.SegundaMatrizBtn.TabIndex = 9;
            this.SegundaMatrizBtn.Text = "Ingrese valores de la segunda matriz";
            this.SegundaMatrizBtn.UseVisualStyleBackColor = true;
            this.SegundaMatrizBtn.Click += new System.EventHandler(this.SegundaMatrizBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(780, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "=";
            // 
            // SumaBtn
            // 
            this.SumaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumaBtn.Location = new System.Drawing.Point(358, 290);
            this.SumaBtn.Name = "SumaBtn";
            this.SumaBtn.Size = new System.Drawing.Size(91, 40);
            this.SumaBtn.TabIndex = 12;
            this.SumaBtn.Text = "+";
            this.SumaBtn.UseVisualStyleBackColor = true;
            this.SumaBtn.Click += new System.EventHandler(this.SumaBtn_Click);
            // 
            // DiagonalBtn
            // 
            this.DiagonalBtn.Location = new System.Drawing.Point(40, 467);
            this.DiagonalBtn.Name = "DiagonalBtn";
            this.DiagonalBtn.Size = new System.Drawing.Size(91, 40);
            this.DiagonalBtn.TabIndex = 13;
            this.DiagonalBtn.Text = "Diagonal";
            this.DiagonalBtn.UseVisualStyleBackColor = true;
            this.DiagonalBtn.Click += new System.EventHandler(this.DiagonalBtn_Click);
            // 
            // MultiplicacionBtn
            // 
            this.MultiplicacionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicacionBtn.Location = new System.Drawing.Point(358, 345);
            this.MultiplicacionBtn.Name = "MultiplicacionBtn";
            this.MultiplicacionBtn.Size = new System.Drawing.Size(91, 40);
            this.MultiplicacionBtn.TabIndex = 14;
            this.MultiplicacionBtn.Text = "X";
            this.MultiplicacionBtn.UseVisualStyleBackColor = true;
            this.MultiplicacionBtn.Click += new System.EventHandler(this.MultiplicacionBtn_Click);
            // 
            // DivisionBtn
            // 
            this.DivisionBtn.Location = new System.Drawing.Point(137, 467);
            this.DivisionBtn.Name = "DivisionBtn";
            this.DivisionBtn.Size = new System.Drawing.Size(120, 40);
            this.DivisionBtn.TabIndex = 15;
            this.DivisionBtn.Text = "Transpuesta";
            this.DivisionBtn.UseVisualStyleBackColor = true;
            this.DivisionBtn.Click += new System.EventHandler(this.DivisionBtn_Click);
            // 
            // txtMatrizDos
            // 
            this.txtMatrizDos.Location = new System.Drawing.Point(513, 230);
            this.txtMatrizDos.Name = "txtMatrizDos";
            this.txtMatrizDos.Size = new System.Drawing.Size(247, 198);
            this.txtMatrizDos.TabIndex = 16;
            this.txtMatrizDos.Text = "";
            // 
            // txtMatrizResultado
            // 
            this.txtMatrizResultado.Location = new System.Drawing.Point(825, 230);
            this.txtMatrizResultado.Name = "txtMatrizResultado";
            this.txtMatrizResultado.Size = new System.Drawing.Size(293, 197);
            this.txtMatrizResultado.TabIndex = 17;
            this.txtMatrizResultado.Text = "";
            // 
            // txtMatrisUno
            // 
            this.txtMatrisUno.Location = new System.Drawing.Point(40, 221);
            this.txtMatrisUno.Name = "txtMatrisUno";
            this.txtMatrisUno.Size = new System.Drawing.Size(278, 198);
            this.txtMatrisUno.TabIndex = 18;
            this.txtMatrisUno.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 467);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 40);
            this.button2.TabIndex = 20;
            this.button2.Text = "Matriz triangular";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MatrizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 538);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtMatrisUno);
            this.Controls.Add(this.txtMatrizResultado);
            this.Controls.Add(this.txtMatrizDos);
            this.Controls.Add(this.DivisionBtn);
            this.Controls.Add(this.MultiplicacionBtn);
            this.Controls.Add(this.DiagonalBtn);
            this.Controls.Add(this.SumaBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SegundaMatrizBtn);
            this.Controls.Add(this.PrimeraMatrizBtn);
            this.Controls.Add(this.LimpiarBtn);
            this.Controls.Add(this.DimensionBtn);
            this.Controls.Add(this.Columnastxt);
            this.Controls.Add(this.ColumnasLbael);
            this.Controls.Add(this.Filastxt);
            this.Controls.Add(this.filasLabel);
            this.Name = "MatrizForm";
            this.Text = "Matriz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label filasLabel;
        private System.Windows.Forms.TextBox Filastxt;
        private System.Windows.Forms.Label ColumnasLbael;
        private System.Windows.Forms.TextBox Columnastxt;
        private System.Windows.Forms.Button DimensionBtn;
        private System.Windows.Forms.Button LimpiarBtn;
        private System.Windows.Forms.Button PrimeraMatrizBtn;
        private System.Windows.Forms.Button SegundaMatrizBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SumaBtn;
        private System.Windows.Forms.Button DiagonalBtn;
        private System.Windows.Forms.Button MultiplicacionBtn;
        private System.Windows.Forms.Button DivisionBtn;
        private System.Windows.Forms.RichTextBox txtMatrizDos;
        private System.Windows.Forms.RichTextBox txtMatrizResultado;
        private System.Windows.Forms.RichTextBox txtMatrisUno;
        private System.Windows.Forms.Button button2;
    }
}

