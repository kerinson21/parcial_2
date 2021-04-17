
namespace proyecto_reproductor
{
    partial class DataPlaylist
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
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.btn_guardarP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(128, 73);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(179, 20);
            this.txtNombreP.TabIndex = 0;
            // 
            // btn_guardarP
            // 
            this.btn_guardarP.Location = new System.Drawing.Point(313, 66);
            this.btn_guardarP.Name = "btn_guardarP";
            this.btn_guardarP.Size = new System.Drawing.Size(130, 37);
            this.btn_guardarP.TabIndex = 1;
            this.btn_guardarP.Text = "Guardar";
            this.btn_guardarP.UseVisualStyleBackColor = true;
            this.btn_guardarP.Click += new System.EventHandler(this.btn_guardarP_Click);
            // 
            // DataPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 195);
            this.Controls.Add(this.btn_guardarP);
            this.Controls.Add(this.txtNombreP);
            this.Name = "DataPlaylist";
            this.Text = "DataPlaylist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Button btn_guardarP;
    }
}