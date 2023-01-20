namespace AlxCourseFormHomework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "0")
            {
                var wynik = (double.Parse(textBox1.Text) / double.Parse(textBox2.Text));

                if (wynik % 2 == 0)
                {
                    wynik.ToString();
                    LogBox.Text = wynik.ToString() + " jest parzysta";
                }
                else
                {
                    wynik.ToString();
                    LogBox.Text = wynik.ToString() + " jest nieparzysta";
                }
            }
            else
            {
                LogBox.Text = "Pamiêtaj cholero nie dziel przez zero!";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(textBox2.Text!="0")
            {
                var wynik = (double.Parse(textBox1.Text) / double.Parse(textBox2.Text));

                if (wynik % 2 == 0)
                {
                    wynik.ToString();
                    LogBox.Text = wynik.ToString() + " jest parzysta";
                }
                else
                {
                    wynik.ToString();
                    LogBox.Text = wynik.ToString() + " jest nieparzysta";
                }
            }
            else
            {
                LogBox.Text = "Pamiêtaj cholero nie dziel przez zero!";
            }
        }

        private void LogBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}