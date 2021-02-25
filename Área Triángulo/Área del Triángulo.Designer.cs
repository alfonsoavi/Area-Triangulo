
namespace Área_Triángulo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_base = new System.Windows.Forms.TextBox();
            this.t_altura = new System.Windows.Forms.TextBox();
            this.t_area = new System.Windows.Forms.TextBox();
            this.b_resultado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.VerInfor = new System.Windows.Forms.Button();
            this.TablaArea = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.Button();
            this.t_num = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaArea)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "BASE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ALTURA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ÁREA";
            // 
            // t_base
            // 
            this.t_base.Location = new System.Drawing.Point(188, 76);
            this.t_base.Name = "t_base";
            this.t_base.Size = new System.Drawing.Size(100, 20);
            this.t_base.TabIndex = 3;
            // 
            // t_altura
            // 
            this.t_altura.Location = new System.Drawing.Point(188, 113);
            this.t_altura.Name = "t_altura";
            this.t_altura.Size = new System.Drawing.Size(100, 20);
            this.t_altura.TabIndex = 4;
            // 
            // t_area
            // 
            this.t_area.Enabled = false;
            this.t_area.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_area.Location = new System.Drawing.Point(188, 192);
            this.t_area.Name = "t_area";
            this.t_area.Size = new System.Drawing.Size(100, 20);
            this.t_area.TabIndex = 5;
            // 
            // b_resultado
            // 
            this.b_resultado.Location = new System.Drawing.Point(101, 150);
            this.b_resultado.Name = "b_resultado";
            this.b_resultado.Size = new System.Drawing.Size(115, 23);
            this.b_resultado.TabIndex = 6;
            this.b_resultado.Text = "CALCULAR ÁREA";
            this.b_resultado.UseVisualStyleBackColor = true;
            this.b_resultado.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Área_Triángulo.Properties.Resources.Triangulo_2;
            this.pictureBox1.Location = new System.Drawing.Point(333, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 224);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(52, 229);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 8;
            this.Guardar.Text = "GUARDAR";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // VerInfor
            // 
            this.VerInfor.Location = new System.Drawing.Point(166, 272);
            this.VerInfor.Name = "VerInfor";
            this.VerInfor.Size = new System.Drawing.Size(105, 23);
            this.VerInfor.TabIndex = 9;
            this.VerInfor.Text = "MOSTRAR INFOR";
            this.VerInfor.UseVisualStyleBackColor = true;
            this.VerInfor.Click += new System.EventHandler(this.VerInfor_Click);
            // 
            // TablaArea
            // 
            this.TablaArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaArea.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.TablaArea.Location = new System.Drawing.Point(128, 301);
            this.TablaArea.Name = "TablaArea";
            this.TablaArea.Size = new System.Drawing.Size(446, 180);
            this.TablaArea.TabIndex = 10;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "N°";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Base";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Altura";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Area";
            this.Column3.Name = "Column3";
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(219, 487);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 11;
            this.Eliminar.Text = "ELIMINAR";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // t_num
            // 
            this.t_num.Enabled = false;
            this.t_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.t_num.Location = new System.Drawing.Point(65, 32);
            this.t_num.Name = "t_num";
            this.t_num.Size = new System.Drawing.Size(100, 20);
            this.t_num.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "N°";
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(27, 334);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 14;
            this.editar.Text = "EDITAR";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.editar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(188, 229);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(98, 23);
            this.Actualizar.TabIndex = 15;
            this.Actualizar.Text = "ACTUALIZAR";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(607, 525);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.t_num);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.TablaArea);
            this.Controls.Add(this.VerInfor);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_resultado);
            this.Controls.Add(this.t_area);
            this.Controls.Add(this.t_altura);
            this.Controls.Add(this.t_base);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Name = "Form1";
            this.Text = "Área del Triángulo ";
            this.TransparencyKey = System.Drawing.Color.Red;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox t_base;
        private System.Windows.Forms.TextBox t_altura;
        private System.Windows.Forms.TextBox t_area;
        private System.Windows.Forms.Button b_resultado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button VerInfor;
        private System.Windows.Forms.DataGridView TablaArea;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox t_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button Actualizar;
    }
}

