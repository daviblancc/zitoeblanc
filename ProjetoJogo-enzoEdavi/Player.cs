using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ProjetoJogo_enzoEdavi
{
    public class Player : PictureBox
    {
        public int Velocidade { get; set; } = 10;

        public Player()
        {
            Size = new System.Drawing.Size(200, 200);
            SizeMode = PictureBoxSizeMode.StretchImage;
            string caminhoimagem = Path.Combine(
                Application.StartupPath,
                "assets",
                "player.png"
            );
            Image = Image.FromFile(caminhoimagem);
        }

        public void Mover(Keys tecla, int larguraTela, int alturaTela)
        {
            if (tecla == Keys.W || tecla == Keys.Up) // mover para cima
            {
                //Top = Top - Velocidade;
                Top -= Velocidade;
                //verifica se saiu pela parte de cima da tela
                if (Top + Height < 0)
                {
                    Top = alturaTela; // aparece na parte de baixo da tela
                }
            }
            else if (tecla == Keys.A || tecla == Keys.Left) // mover para esquerda
            {
                Left -= Velocidade; 
                //verifica se saiu pela parte da esquerda da tela
                if (Left + Width < 0)
                {
                    Left = larguraTela;
                }
            }
            else if (tecla == Keys.D || tecla == Keys.Right) // mover para direita
            {
                Left += Velocidade;

                if (Left + Width > 2120)
                {
                    Left = larguraTela - 2120;
                }
            }
            else if (tecla == Keys.S || tecla == Keys.Down) // mover para baixo
            {
                Top += Velocidade;

                if (Top + Height > 1080)
                {
                    Top = alturaTela - 1280; // aparece na parte de baixo da tela
                }
            }
        }
    }
}
