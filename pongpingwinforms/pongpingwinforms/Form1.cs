namespace pongpingwinforms
{
    public partial class Form1 : Form
    {
        int playerY = 150;
        int aiy = 150;
        int ballX = 200;
        int ballY = 150;
        int ballSpeedX = 4;
        int ballSpeedY = 4;
        int playerScore = 0;
        int aiScore = 0;
        bool moveUp, moveDown;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) moveUp = true;
            if (e.KeyCode == Keys.Down) moveDown = true;
        }
        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) moveUp = false;
            if (e.KeyCode == Keys.Down) moveDown = false;
        }
        //private void Form1_Load(object sender, EventArgs e)
        //{
        //timer.Start();
        //}
    }
}
