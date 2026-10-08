namespace ProjetoJogo_enzoEdavi
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lbl_titulo = new Label();
            btn_jogar = new Button();
            SuspendLayout();
            // 
            // lbl_titulo
            // 
            lbl_titulo.AutoSize = true;
            lbl_titulo.BackColor = Color.Transparent;
            lbl_titulo.Font = new Font("Showcard Gothic", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_titulo.ForeColor = Color.Orange;
            lbl_titulo.Location = new Point(490, 422);
            lbl_titulo.Name = "lbl_titulo";
            lbl_titulo.Size = new Size(912, 177);
            lbl_titulo.TabIndex = 0;
            lbl_titulo.Text = "The Goblin";
            // 
            // btn_jogar
            // 
            btn_jogar.BackColor = Color.PaleGoldenrod;
            btn_jogar.FlatStyle = FlatStyle.Flat;
            btn_jogar.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_jogar.ForeColor = Color.Orange;
            btn_jogar.Location = new Point(681, 619);
            btn_jogar.Name = "btn_jogar";
            btn_jogar.Size = new Size(565, 150);
            btn_jogar.TabIndex = 1;
            btn_jogar.Text = "Jogar";
            btn_jogar.UseVisualStyleBackColor = false;
            btn_jogar.Click += btn_jogar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1898, 1024);
            Controls.Add(btn_jogar);
            Controls.Add(lbl_titulo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Jogo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_titulo;
        private Button btn_jogar;
    }
}
