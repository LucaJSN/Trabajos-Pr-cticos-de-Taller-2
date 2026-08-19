namespace Practico3
{
    partial class PequeñoFormulario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PequeñoFormulario));
            LDni = new Label();
            LNombre = new Label();
            LApellido = new Label();
            LNya = new Label();
            LModificar = new Label();
            TDni = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            BGuardar = new Button();
            BEliminar = new Button();
            panel1 = new Panel();
            LTarjetas = new Label();
            checkBox1 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox3 = new CheckBox();
            TTelefono = new TextBox();
            LTelefono = new Label();
            pictureBox1 = new PictureBox();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            LTitulo = new Label();
            BSalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(28, 56);
            LDni.Name = "LDni";
            LDni.Size = new Size(35, 20);
            LDni.TabIndex = 0;
            LDni.Text = "DNI";
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(29, 118);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(64, 20);
            LNombre.TabIndex = 1;
            LNombre.Text = "Nombre";
            LNombre.Click += label2_Click;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(29, 85);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(66, 20);
            LApellido.TabIndex = 2;
            LApellido.Text = "Apellido";
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(3, 12);
            LNya.Name = "LNya";
            LNya.Size = new Size(136, 20);
            LNya.TabIndex = 3;
            LNya.Text = "Nombre y Apellido";
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(145, 12);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(73, 20);
            LModificar.TabIndex = 4;
            LModificar.Text = "Modificar";
            // 
            // TDni
            // 
            TDni.Location = new Point(145, 49);
            TDni.Name = "TDni";
            TDni.Size = new Size(125, 27);
            TDni.TabIndex = 5;
            TDni.Tag = "";
            TDni.TextChanged += TDni_TextChanged;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(145, 82);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(125, 27);
            TApellido.TabIndex = 6;
            TApellido.TextChanged += TApellido_TextChanged;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(145, 115);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(125, 27);
            TNombre.TabIndex = 7;
            TNombre.TextChanged += TNombre_TextChanged;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // BGuardar
            // 
            BGuardar.Image = (Image)resources.GetObject("BGuardar.Image");
            BGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BGuardar.Location = new Point(167, 405);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(126, 67);
            BGuardar.TabIndex = 8;
            BGuardar.Text = "Guardar";
            BGuardar.TextAlign = ContentAlignment.MiddleRight;
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // BEliminar
            // 
            BEliminar.Image = (Image)resources.GetObject("BEliminar.Image");
            BEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BEliminar.Location = new Point(23, 405);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(129, 67);
            BEliminar.TabIndex = 9;
            BEliminar.Text = "Eliminar";
            BEliminar.TextAlign = ContentAlignment.MiddleRight;
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GrayText;
            panel1.Controls.Add(LTarjetas);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(LNya);
            panel1.Controls.Add(LModificar);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(LDni);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(TDni);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(12, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 319);
            panel1.TabIndex = 10;
            panel1.Paint += panel1_Paint;
            // 
            // LTarjetas
            // 
            LTarjetas.AutoSize = true;
            LTarjetas.Location = new Point(11, 207);
            LTarjetas.Name = "LTarjetas";
            LTarjetas.Size = new Size(128, 20);
            LTarjetas.TabIndex = 16;
            LTarjetas.Text = "Tarjeta de credito:";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(145, 267);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(107, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "MasterCard";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(145, 237);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(62, 24);
            checkBox2.TabIndex = 14;
            checkBox2.Text = "VISA";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(145, 207);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(83, 24);
            checkBox3.TabIndex = 15;
            checkBox3.Text = "Naranja";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(145, 148);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(125, 27);
            TTelefono.TabIndex = 9;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.Location = new Point(29, 155);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(67, 20);
            LTelefono.TabIndex = 8;
            LTelefono.Text = "Telefono";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Varon;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(374, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 204);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Checked = true;
            RBVaron.Location = new Point(394, 288);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(68, 24);
            RBVaron.TabIndex = 11;
            RBVaron.TabStop = true;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += RBVaron_CheckedChanged;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(495, 288);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(68, 24);
            RBMujer.TabIndex = 12;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += RBMujer_CheckedChanged;
            // 
            // LTitulo
            // 
            LTitulo.AutoSize = true;
            LTitulo.BorderStyle = BorderStyle.FixedSingle;
            LTitulo.ForeColor = SystemColors.HotTrack;
            LTitulo.Location = new Point(237, 27);
            LTitulo.Name = "LTitulo";
            LTitulo.Size = new Size(119, 22);
            LTitulo.TabIndex = 13;
            LTitulo.Text = "NUEVO CLIENTE";
            LTitulo.Click += LTitulo_Click;
            // 
            // BSalir
            // 
            BSalir.Image = (Image)resources.GetObject("BSalir.Image");
            BSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BSalir.Location = new Point(493, 405);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(126, 67);
            BSalir.TabIndex = 14;
            BSalir.Text = "Salir";
            BSalir.TextAlign = ContentAlignment.MiddleRight;
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // PequeñoFormulario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(631, 496);
            Controls.Add(BSalir);
            Controls.Add(LTitulo);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(BEliminar);
            Controls.Add(BGuardar);
            Name = "PequeñoFormulario";
            Text = "Pequeño Formulario";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LDni;
        private Label LNombre;
        private Label LApellido;
        private Label LNya;
        private Label LModificar;
        private TextBox TDni;
        private TextBox TApellido;
        private TextBox TNombre;
        private Button BGuardar;
        private Button BEliminar;
        private Panel panel1;
        private PictureBox pictureBox1;
        private RadioButton RBVaron;
        private RadioButton RBMujer;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private Label LTelefono;
        private Label LTarjetas;
        private TextBox TTelefono;
        private Label LTitulo;
        private Button BSalir;
    }
}
