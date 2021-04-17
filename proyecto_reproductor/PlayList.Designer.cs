
namespace proyecto_reproductor
{
    partial class PlayList
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
            this.list_playList = new System.Windows.Forms.ListBox();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_recargar = new System.Windows.Forms.Button();
            this.btn_agregarP = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbn_reproducir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // list_playList
            // 
            this.list_playList.FormattingEnabled = true;
            this.list_playList.Location = new System.Drawing.Point(12, 42);
            this.list_playList.Name = "list_playList";
            this.list_playList.Size = new System.Drawing.Size(237, 290);
            this.list_playList.TabIndex = 0;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(279, 62);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(148, 42);
            this.btn_nuevo.TabIndex = 1;
            this.btn_nuevo.Text = "Nueva PlayList";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_recargar
            // 
            this.btn_recargar.Location = new System.Drawing.Point(279, 110);
            this.btn_recargar.Name = "btn_recargar";
            this.btn_recargar.Size = new System.Drawing.Size(148, 31);
            this.btn_recargar.TabIndex = 2;
            this.btn_recargar.Text = "Recargar Lista";
            this.btn_recargar.UseVisualStyleBackColor = true;
            this.btn_recargar.Click += new System.EventHandler(this.btn_recargar_Click);
            // 
            // btn_agregarP
            // 
            this.btn_agregarP.Location = new System.Drawing.Point(279, 147);
            this.btn_agregarP.Name = "btn_agregarP";
            this.btn_agregarP.Size = new System.Drawing.Size(148, 24);
            this.btn_agregarP.TabIndex = 3;
            this.btn_agregarP.Text = "Agregar a PlayList";
            this.btn_agregarP.UseVisualStyleBackColor = true;
            this.btn_agregarP.Click += new System.EventHandler(this.btn_agregarP_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ver Canciones de la Lista";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbn_reproducir
            // 
            this.tbn_reproducir.Location = new System.Drawing.Point(279, 223);
            this.tbn_reproducir.Name = "tbn_reproducir";
            this.tbn_reproducir.Size = new System.Drawing.Size(148, 40);
            this.tbn_reproducir.TabIndex = 5;
            this.tbn_reproducir.Text = "Reproducir PlayList";
            this.tbn_reproducir.UseVisualStyleBackColor = true;
            this.tbn_reproducir.Click += new System.EventHandler(this.tbn_reproducir_Click);
            // 
            // PlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 434);
            this.Controls.Add(this.tbn_reproducir);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_agregarP);
            this.Controls.Add(this.btn_recargar);
            this.Controls.Add(this.btn_nuevo);
            this.Controls.Add(this.list_playList);
            this.Name = "PlayList";
            this.Text = "PlayList";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox list_playList;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_recargar;
        private System.Windows.Forms.Button btn_agregarP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tbn_reproducir;
    }
}