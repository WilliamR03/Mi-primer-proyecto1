namespace Floristeria
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            txtcliente = new TextBox();
            txtproducto = new TextBox();
            txtcantidad = new TextBox();
            txtfecha = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnagregar = new Button();
            btnguardar = new Button();
            dataGridViewDatos = new DataGridView();
            ColumnCliente = new DataGridViewTextBoxColumn();
            ColumnProducto = new DataGridViewTextBoxColumn();
            ColumnCantidad = new DataGridViewTextBoxColumn();
            ColumnFecha = new DataGridViewTextBoxColumn();
            btneliminar = new Button();
            btnactualizar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            SuspendLayout();
            // 
            // txtcliente
            // 
            txtcliente.Location = new Point(108, 87);
            txtcliente.Name = "txtcliente";
            txtcliente.Size = new Size(183, 23);
            txtcliente.TabIndex = 0;
            // 
            // txtproducto
            // 
            txtproducto.Location = new Point(108, 136);
            txtproducto.Name = "txtproducto";
            txtproducto.Size = new Size(183, 23);
            txtproducto.TabIndex = 1;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(108, 186);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(183, 23);
            txtcantidad.TabIndex = 2;
            // 
            // txtfecha
            // 
            txtfecha.Location = new Point(108, 238);
            txtfecha.Name = "txtfecha";
            txtfecha.Size = new Size(183, 23);
            txtfecha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(64, 21);
            label1.TabIndex = 4;
            label1.Text = "Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(10, 134);
            label2.Name = "label2";
            label2.Size = new Size(80, 21);
            label2.TabIndex = 5;
            label2.Text = "Producto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(11, 184);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 6;
            label3.Text = "Cantidad";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 236);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 7;
            label4.Text = "Fecha";
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.Lime;
            btnagregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnagregar.Location = new Point(17, 288);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(134, 23);
            btnagregar.TabIndex = 8;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // btnguardar
            // 
            btnguardar.BackColor = Color.Lime;
            btnguardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnguardar.Location = new Point(157, 288);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(134, 23);
            btnguardar.TabIndex = 9;
            btnguardar.Text = "Guardar";
            btnguardar.UseVisualStyleBackColor = false;
            btnguardar.Click += btnguardar_Click;
            // 
            // dataGridViewDatos
            // 
            dataGridViewDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDatos.Columns.AddRange(new DataGridViewColumn[] { ColumnCliente, ColumnProducto, ColumnCantidad, ColumnFecha });
            dataGridViewDatos.Location = new Point(315, 87);
            dataGridViewDatos.Name = "dataGridViewDatos";
            dataGridViewDatos.Size = new Size(444, 263);
            dataGridViewDatos.TabIndex = 10;
            dataGridViewDatos.CellClick += dataGridViewDatos_CellClick;
            // 
            // ColumnCliente
            // 
            ColumnCliente.HeaderText = "Cliente";
            ColumnCliente.Name = "ColumnCliente";
            // 
            // ColumnProducto
            // 
            ColumnProducto.HeaderText = "Producto";
            ColumnProducto.Name = "ColumnProducto";
            // 
            // ColumnCantidad
            // 
            ColumnCantidad.HeaderText = "Cantidad";
            ColumnCantidad.Name = "ColumnCantidad";
            // 
            // ColumnFecha
            // 
            ColumnFecha.HeaderText = "Fecha";
            ColumnFecha.Name = "ColumnFecha";
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.Red;
            btneliminar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btneliminar.Location = new Point(17, 327);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(134, 23);
            btneliminar.TabIndex = 11;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.BackColor = Color.Lime;
            btnactualizar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnactualizar.Location = new Point(157, 327);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(134, 23);
            btnactualizar.TabIndex = 12;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = false;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.af606cbf7f5250a76c9f05ed123b2bf4_planta_de_flores_planas_delicadas_simples2;
            pictureBox1.Location = new Point(-1, 387);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 66);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.d1e19da670d88af2de2b576533d3fd63_icono_de_flores_de_planta_acuarela_delicada1;
            pictureBox2.Location = new Point(757, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 66);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.af606cbf7f5250a76c9f05ed123b2bf4_planta_de_flores_planas_delicadas_simples2;
            pictureBox3.Location = new Point(-1, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 66);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.d1e19da670d88af2de2b576533d3fd63_icono_de_flores_de_planta_acuarela_delicada1;
            pictureBox4.Location = new Point(757, 387);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(100, 66);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(394, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(61, 51);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(288, 387);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(100, 66);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 13;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(461, 387);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(100, 66);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 13;
            pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(288, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(100, 66);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 13;
            pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(461, 0);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(100, 66);
            pictureBox9.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox9.TabIndex = 13;
            pictureBox9.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = (Image)resources.GetObject("pictureBox10.Image");
            pictureBox10.Location = new Point(394, 402);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(61, 51);
            pictureBox10.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox10.TabIndex = 13;
            pictureBox10.TabStop = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(857, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox1);
            Controls.Add(btnactualizar);
            Controls.Add(btneliminar);
            Controls.Add(dataGridViewDatos);
            Controls.Add(btnguardar);
            Controls.Add(btnagregar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtfecha);
            Controls.Add(txtcantidad);
            Controls.Add(txtproducto);
            Controls.Add(txtcliente);
            Name = "Form4";
            Text = "Agregar Pedidos";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtcliente;
        private TextBox txtproducto;
        private TextBox txtcantidad;
        private TextBox txtfecha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnagregar;
        private Button btnguardar;
        private DataGridView dataGridViewDatos;
        private DataGridViewTextBoxColumn ColumnCliente;
        private DataGridViewTextBoxColumn ColumnProducto;
        private DataGridViewTextBoxColumn ColumnCantidad;
        private DataGridViewTextBoxColumn ColumnFecha;
        private Button btneliminar;
        private Button btnactualizar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
    }
}