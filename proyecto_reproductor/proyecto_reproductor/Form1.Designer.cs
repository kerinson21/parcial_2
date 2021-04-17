
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
            ((System.ComponentModel.ISupportInitialize)(this.repro_umg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btx_agregar)).BeginInit();
            this.SuspendLayout();
            // 
            // repro_umg
            // 
            this.repro_umg.Enabled = true;
            this.repro_umg.Location = new System.Drawing.Point(165, 119);
            this.repro_umg.Name = "repro_umg";
            this.repro_umg.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("repro_umg.OcxState")));
            this.repro_umg.Size = new System.Drawing.Size(445, 46);
            this.repro_umg.TabIndex = 0;
            // 
            // list_canciones
            // 
            this.list_canciones.FormattingEnabled = true;
            this.list_canciones.Location = new System.Drawing.Point(165, 251);
            this.list_canciones.Name = "list_canciones";
            this.list_canciones.Size = new System.Drawing.Size(406, 160);
            this.list_canciones.TabIndex = 1;
            this.list_canciones.SelectedIndexChanged += new System.EventHandler(this.list_canciones_SelectedIndexChanged);
            // 
            // btn_playlist
            // 
            this.btn_playlist.Location = new System.Drawing.Point(165, 204);
            this.btn_playlist.Name = "btn_playlist";
            this.btn_playlist.Size = new System.Drawing.Size(117, 30);
            this.btn_playlist.TabIndex = 2;
            this.btn_playlist.Text = "Mis PlayList";
            this.btn_playlist.UseVisualStyleBackColor = true;
            this.btn_playlist.Click += new System.EventHandler(this.btn_playlist_Click);
            // 
            // btx_agregar
            // 
            this.btx_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btx_agregar.Image")));
            this.btx_agregar.Location = new System.Drawing.Point(577, 298);
            this.btx_agregar.Name = "btx_agregar";
            this.btx_agregar.Size = new System.Drawing.Size(49, 51);
            this.btx_agregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btx_agregar.TabIndex = 3;
            this.btx_agregar.TabStop = false;
            this.btx_agregar.Click += new System.EventHandler(this.btx_agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(632, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Agregar a Playlist";
            // 
            // lb_texto
            // 
            this.lb_texto.AutoSize = true;
            this.lb_texto.Location = new System.Drawing.Point(288, 213);
            this.lb_texto.Name = "lb_texto";
            this.lb_texto.Size = new System.Drawing.Size(157, 13);
            this.lb_texto.TabIndex = 5;
            this.lb_texto.Text = "PlayList que estas escuchando:";
            // 
            // lb_nombre_playlist
            // 
            this.lb_nombre_playlist.AutoSize = true;
            this.lb_nombre_playlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nombre_playlist.Location = new System.Drawing.Point(445, 210);
            this.lb_nombre_playlist.Name = "lb_nombre_playlist";
            this.lb_nombre_playlist.Size = new System.Drawing.Size(167, 18);
            this.lb_nombre_playlist.TabIndex = 6;
            this.lb_nombre_playlist.Text = "Todas las Canciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

