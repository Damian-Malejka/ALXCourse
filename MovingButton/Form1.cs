namespace MovingButton
{
    public partial class Form1 : Form
    {
        public Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            
            var somethingElse = rnd.NextDouble();

        }

        private void MovingButton_Click(object sender, EventArgs e)
        {
            var xPostion = rnd.NextDouble();
            xPostion = Int32.Parse(3.5);
            var yPostion = rnd.NextInt64();

           

            ButtonToMove.Top = xPostion;
            ButtonToMove.Left = rnd.NextInt64(1, 5); ;
          
        }
    }
}