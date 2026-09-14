namespace _3NLIDTS_PROYECTO4
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.txt_Estatura = new System.Windows.Forms.TextBox();
            this.txt_Edad = new System.Windows.Forms.TextBox();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.rb_Mas = new System.Windows.Forms.RadioButton();
            this.rb_Fem = new System.Windows.Forms.RadioButton();
            this.rb_otro = new System.Windows.Forms.RadioButton();
            this.gb_genero = new System.Windows.Forms.GroupBox();
            this.gb_genero.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(451, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(442, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(446, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(447, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estatura:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 13.8F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(480, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Edad:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_Nombre.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.ForeColor = System.Drawing.Color.Gray;
            this.txt_Nombre.Location = new System.Drawing.Point(574, 49);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(256, 34);
            this.txt_Nombre.TabIndex = 5;
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Font = new System.Drawing.Font("Arial", 13.8F);
            this.txt_Apellidos.ForeColor = System.Drawing.Color.Gray;
            this.txt_Apellidos.Location = new System.Drawing.Point(574, 115);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(256, 34);
            this.txt_Apellidos.TabIndex = 6;
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Font = new System.Drawing.Font("Arial", 13.8F);
            this.txt_Telefono.ForeColor = System.Drawing.Color.Gray;
            this.txt_Telefono.Location = new System.Drawing.Point(574, 181);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(256, 34);
            this.txt_Telefono.TabIndex = 7;
            this.txt_Telefono.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txt_Estatura
            // 
            this.txt_Estatura.Font = new System.Drawing.Font("Arial", 13.8F);
            this.txt_Estatura.ForeColor = System.Drawing.Color.Gray;
            this.txt_Estatura.Location = new System.Drawing.Point(574, 247);
            this.txt_Estatura.Name = "txt_Estatura";
            this.txt_Estatura.Size = new System.Drawing.Size(256, 34);
            this.txt_Estatura.TabIndex = 8;
            this.txt_Estatura.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txt_Edad
            // 
            this.txt_Edad.Font = new System.Drawing.Font("Arial", 13.8F);
            this.txt_Edad.ForeColor = System.Drawing.Color.Gray;
            this.txt_Edad.Location = new System.Drawing.Point(574, 313);
            this.txt_Edad.Name = "txt_Edad";
            this.txt_Edad.Size = new System.Drawing.Size(256, 34);
            this.txt_Edad.TabIndex = 9;
            this.txt_Edad.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.Btn_Guardar.Font = new System.Drawing.Font("Arial", 13.8F);
            this.Btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.Btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Guardar.Location = new System.Drawing.Point(428, 562);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(204, 90);
            this.Btn_Guardar.TabIndex = 11;
            this.Btn_Guardar.Text = "💾Guardar";
            this.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.SystemColors.GrayText;
            this.Btn_Cancelar.Font = new System.Drawing.Font("Arial", 13.8F);
            this.Btn_Cancelar.ForeColor = System.Drawing.Color.White;
            this.Btn_Cancelar.Location = new System.Drawing.Point(680, 562);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(204, 90);
            this.Btn_Cancelar.TabIndex = 12;
            this.Btn_Cancelar.Text = "🤚🏼Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // rb_Mas
            // 
            this.rb_Mas.AutoSize = true;
            this.rb_Mas.Location = new System.Drawing.Point(6, 67);
            this.rb_Mas.Name = "rb_Mas";
            this.rb_Mas.Size = new System.Drawing.Size(135, 30);
            this.rb_Mas.TabIndex = 0;
            this.rb_Mas.TabStop = true;
            this.rb_Mas.Text = "Masculino";
            this.rb_Mas.UseVisualStyleBackColor = true;
            // 
            // rb_Fem
            // 
            this.rb_Fem.AutoSize = true;
            this.rb_Fem.Location = new System.Drawing.Point(174, 67);
            this.rb_Fem.Name = "rb_Fem";
            this.rb_Fem.Size = new System.Drawing.Size(133, 30);
            this.rb_Fem.TabIndex = 1;
            this.rb_Fem.TabStop = true;
            this.rb_Fem.Text = "Femenino";
            this.rb_Fem.UseVisualStyleBackColor = true;
            // 
            // rb_otro
            // 
            this.rb_otro.AutoSize = true;
            this.rb_otro.Location = new System.Drawing.Point(337, 67);
            this.rb_otro.Name = "rb_otro";
            this.rb_otro.Size = new System.Drawing.Size(78, 30);
            this.rb_otro.TabIndex = 2;
            this.rb_otro.TabStop = true;
            this.rb_otro.Text = "Otro";
            this.rb_otro.UseVisualStyleBackColor = true;
            // 
            // gb_genero
            // 
            this.gb_genero.BackColor = System.Drawing.Color.LightGray;
            this.gb_genero.Controls.Add(this.rb_otro);
            this.gb_genero.Controls.Add(this.rb_Fem);
            this.gb_genero.Controls.Add(this.rb_Mas);
            this.gb_genero.Cursor = System.Windows.Forms.Cursors.Default;
            this.gb_genero.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gb_genero.Font = new System.Drawing.Font("Arial", 13.8F);
            this.gb_genero.ForeColor = System.Drawing.Color.Black;
            this.gb_genero.Location = new System.Drawing.Point(422, 379);
            this.gb_genero.Name = "gb_genero";
            this.gb_genero.Size = new System.Drawing.Size(489, 177);
            this.gb_genero.TabIndex = 10;
            this.gb_genero.TabStop = false;
            this.gb_genero.Text = "Género:";
            this.gb_genero.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1364, 741);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Guardar);
            this.Controls.Add(this.gb_genero);
            this.Controls.Add(this.txt_Edad);
            this.Controls.Add(this.txt_Estatura);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.txt_Apellidos);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_genero.ResumeLayout(false);
            this.gb_genero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Estatura;
        private System.Windows.Forms.TextBox txt_Edad;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.RadioButton rb_Mas;
        private System.Windows.Forms.RadioButton rb_Fem;
        private System.Windows.Forms.RadioButton rb_otro;
        private System.Windows.Forms.GroupBox gb_genero;
    }
}

