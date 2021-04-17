
namespace proyecto_reproductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.repro_umg = new AxWMPLib.AxWindowsMediaPlayer();
            this.list_canciones = new System.Windows.Forms.ListBox();
            this.btn_playlist = new System.Windows.Forms.Button();
            this.btx_agregar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_texto = new System.Windows.Forms.Label();
            this.lb_nombre_playlist = new System.Windows.Forms.Label();
            this.btn_previous = new System.Windows.Forms.PictureBox();
            this.btn_next = new System.Windows.Forms.PictureBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelAlbum = new System.Windows.Forms.Label();
            this.labelAnio = new System.Windows.Forms.Label();
            this.labelDuracion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.repro_umg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btx_agregar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).BeginInit();
            this.SuspendLayout();
            // 
            // repro_umg
            // 
            this.repro_umg.Enabled = true;
            this.repro_umg.Location = new System.Drawing.Point(104, 133);
            this.repro_umg.Name = "repro_umg";
            this.repro_umg.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("repro_umg.OcxState")));
            this.repro_umg.Size = new System.Drawing.Size(445, 40);
            this.repro_umg.TabIndex = 0;
            this.repro_umg.Enter += new System.EventHandler(this.repro_umg_Enter);
            // 
            // list_canciones
            // 
            this.list_canciones.FormattingEnabled = true;
            this.list_canciones.Location = new System.Drawing.Point(104, 266);
            this.list_canciones.Name = "list_canciones";
            this.list_canciones.Size = new System.Drawing.Size(406, 147);
            this.list_canciones.TabIndex = 1;
            this.list_canciones.SelectedIndexChanged += new System.EventHandler(this.list_canciones_SelectedIndexChanged);
            // 
            // btn_playlist
            // 
            this.btn_playlist.Location = new System.Drawing.Point(104, 219);
            this.btn_playlist.Name = "btn_playlist";
            this.btn_playlist.Size = new System.Drawing.Size(117, 23);
            this.btn_playlist.TabIndex = 2;
            this.btn_playlist.Text = "Mis PlayList";
            this.btn_playlist.UseVisualStyleBackColor = true;
            this.btn_playlist.Click += new System.EventHandler(this.btn_playlist_Click);
            // 
            // btx_agregar
            // 
            this.btx_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btx_agregar.Image")));
            this.btx_agregar.Location = new System.Drawing.Point(516, 313);
            this.btx_agregar.Name = "btx_agregar";
            this.btx_agregar.Size = new System.Drawing.Size(49, 44);
            this.btx_agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btx_agregar.TabIndex = 3;
            this.btx_agregar.TabStop = false;
            this.btx_agregar.Click += new System.EventHandler(this.btx_agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agregar a Playlist";
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Location = new System.Drawing.Point(227, 228);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(157, 13);
            this.lb_texto.TabIndex = 5;
            this.lb_texto.Text = "PlayList que estas escuchando:";
            // 
            // lb_nombre_playlist
            // 
            this.lb_nombre_playlist.AutoSize = true;
            this.lb_nombre_playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre_playlist.Location = new System.Drawing.Point(384, 225);
            this.lb_nombre_playlist.Name = "lb_nombre_playlist";
            this.lb_nombre_playlist.Size = new System.Drawing.Size(167, 18);
            this.lb_nombre_playlist.TabIndex = 6;
            this.lb_nombre_playlist.Text = "Todas las Canciones";
            // 
            // btn_previous
            // 
            this.btn_previous.Image = ((System.Drawing.Image)(resources.GetObject("btn_previous.Image")));
            this.btn_previous.Location = new System.Drawing.Point(154, 149);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(38, 20);
            this.btn_previous.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_previous.TabIndex = 7;
            this.btn_previous.TabStop = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.Image = ((System.Drawing.Image)(resources.GetObject("btn_next.Image")));
            this.btn_next.Location = new System.Drawing.Point(189, 149);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(22, 20);
            this.btn_next.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_next.TabIndex = 8;
            this.btn_next.TabStop = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(101, 96);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 18);
            this.label.TabIndex = 10;
            this.label.Text = "Album:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(267, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Año:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Duración:";
            // 
            // labelAlbum
            // 
            this.labelAlbum.AutoSize = true;
            this.labelAlbum.Location = new System.Drawing.Point(153, 100);
            this.labelAlbum.Name = "labelAlbum";
            this.labelAlbum.Size = new System.Drawing.Size(35, 13);
            this.labelAlbum.TabIndex = 11;
            this.labelAlbum.Text = "label4";
            // 
            // labelAnio
            // 
            this.labelAnio.AutoSize = true;
            this.labelAnio.Location = new System.Drawing.Point(303, 100);
            this.labelAnio.Name = "labelAnio";
            this.labelAnio.Size = new System.Drawing.Size(35, 13);
            this.labelAnio.TabIndex = 12;
            this.labelAnio.Text = "label5";
            // 
            // labelDuracion
            // 
            this.labelDuracion.AutoSize = true;
            this.labelDuracion.Location = new System.Drawing.Point(487, 99);
            this.labelDuracion.Name = "labelDuracion";
            this.labelDuracion.Size = new System.Drawing.Size(35, 13);
            this.labelDuracion.TabIndex = 13;
            this.labelDuracion.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 435);
            this.Controls.Add(this.labelDuracion);
            this.Controls.Add(this.labelAnio);
            this.Controls.Add(this.labelAlbum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.lb_nombre_playlist);
            this.Controls.Add(this.lb_texto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btx_agregar);
            this.Controls.Add(this.btn_playlist);
            this.Controls.Add(this.list_canciones);
            this.Controls.Add(this.repro_umg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repro_umg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btx_agregar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_previous)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_next)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_playlist;
        private System.Windows.Forms.PictureBox btx_agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_texto;
        public System.Windows.Forms.ListBox list_canciones;
        public AxWMPLib.AxWindowsMediaPlayer repro_umg;
        public System.Windows.Forms.Label lb_nombre_playlist;
        private System.Windows.Forms.PictureBox btn_previous;
        private System.Windows.Forms.PictureBox btn_next;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelAlbum;
        private System.Windows.Forms.Label labelAnio;
        private System.Windows.Forms.Label labelDuracion;
    }
}

