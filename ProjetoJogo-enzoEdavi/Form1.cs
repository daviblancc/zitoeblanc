namespace ProjetoJogo_enzoEdavi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_jogar_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            this.Hide();
        }
    }
}
