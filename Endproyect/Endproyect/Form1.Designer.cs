namespace Endproyect
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
            this.NOMBRE = new System.Windows.Forms.Label();
            this.APELLIDO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NOMBRE
            // 
            this.NOMBRE.AutoSize = true;
            this.NOMBRE.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NOMBRE.Location = new System.Drawing.Point(51, 19);
            this.NOMBRE.Name = "NOMBRE";
            this.NOMBRE.Size = new System.Drawing.Size(92, 19);
            this.NOMBRE.TabIndex = 0;
            this.NOMBRE.Text = "NOMBRE ";
            this.NOMBRE.Click += new System.EventHandler(this.NOMBRE_Click);
            // 
            // APELLIDO
            // 
            this.APELLIDO.AutoSize = true;
            this.APELLIDO.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.APELLIDO.Location = new System.Drawing.Point(301, 19);
            this.APELLIDO.Name = "APELLIDO";
            this.APELLIDO.Size = new System.Drawing.Size(94, 19);
            this.APELLIDO.TabIndex = 1;
            this.APELLIDO.Text = "APELLIDO";
            this.APELLIDO.Click += new System.EventHandler(this.APELLIDO_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(525, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "N° DE CONNTACTO";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(900, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "CORREO";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Felix Titling", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "ESPECIALIDAD ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 65);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(197, 20);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(503, 65);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(221, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(810, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(261, 20);
            this.textBox4.TabIndex = 8;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(212, 125);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(183, 20);
            this.textBox5.TabIndex = 9;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(25, 174);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(652, 381);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(41, 579);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 61);
            this.button1.TabIndex = 11;
            this.button1.Text = "GUARDAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(232, 579);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 61);
            this.button2.TabIndex = 12;
            this.button2.Text = "MOSTRAR DATOS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Endproyect.Properties.Resources.maxresdefault;
            this.ClientSize = new System.Drawing.Size(1083, 669);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.APELLIDO);
            this.Controls.Add(this.NOMBRE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NOMBRE;
        private System.Windows.Forms.Label APELLIDO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

