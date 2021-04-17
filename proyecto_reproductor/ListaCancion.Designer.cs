
namespace proyecto_reproductor
{
    partial class ListaCancion
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
            this.lst_can_play = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lst_can_play
            // 
            this.lst_can_play.FormattingEnabled = true;
            this.lst_can_play.Location = new System.Drawing.Point(118, 50);
            this.lst_can_play.Name = "lst_can_play";
            this.lst_can_play.Size = new System.Drawing.Size(251, 433);
            this.lst_can_play.TabIndex = 0;
            // 
            // ListaCancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 566);
            this.Controls.Add(this.lst_can_play);
            this.Name = "ListaCancion";
            this.Text = "ListaCancion";
            this.Load += new System.EventHandler(this.ListaCancion_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_can_play;
    }
}