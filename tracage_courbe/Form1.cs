   public partial class Form1 : Form
    {
        int nAmplitude = 100;
        int nDeplacement = 200;
        int repere_X = 200;
        int Pas = 5;
        Pen redPen = new Pen(Color.Blue, 5);
        Pen WhitePen = new Pen(Color.White, 1);
        public Form1()
        {
            InitializeComponent();
        }

        

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {


            repere(e);
            Brush aBrush = (Brush)Brushes.Red;

            e.Graphics.DrawRectangle(redPen, 0, 0, pictureBox1.Width-10, pictureBox1.Height-10);
            double y = 0;
            for (int x = 0; x < pictureBox1.Width; x++)
            {
                  e.Graphics.FillRectangle(aBrush, x*2,(float) Math.Sin (y)*nAmplitude+nDeplacement, 2, 2);

            


                y += 0.05;
            }
        }
        void repere (PaintEventArgs e)
        {
            e.Graphics.DrawLine(WhitePen, 0, repere_X, pictureBox1.Width, repere_X);
            e.Graphics.DrawLine(WhitePen, pictureBox1.Width/2, 0, pictureBox1.Width / 2, pictureBox1.Height);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            nAmplitude += Pas;
            pictureBox1.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nAmplitude -= Pas;
            pictureBox1.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nDeplacement -= Pas;
            pictureBox1.Invalidate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nDeplacement += Pas;
            pictureBox1.Invalidate();
        }
    }
