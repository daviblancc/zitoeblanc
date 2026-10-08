using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoJogo_enzoEdavi
{
    public partial class Game : Form
    {
        private Player jogador;


        public Game()
        {
            InitializeComponent();
            IniciarJogo();
        }

        private void IniciarJogo()
        {
            // Instanciar um objeto Player
            jogador = new Player();
            // Definir uma posição para o jogador
            jogador.Location = new Point(50, 340);
            // Adicionar o player no formulário
            Controls.Add(jogador);

            //Ativa a verificação de teclas pressionadas
            KeyPreview = true;
            //Quando a tecla for pressionada, executa o método Game_KeyDown
            KeyDown += Game_KeyDown;
        }

        private void Game_KeyDown(object sender, KeyEventArgs e)
        {
            // Executa o método mover e passa a tecla pressionada
            jogador.Mover(e.KeyCode, ClientSize.Width, ClientSize.Height);
        }
    }
}
