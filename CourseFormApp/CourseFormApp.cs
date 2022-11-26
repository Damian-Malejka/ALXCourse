using System.Diagnostics;
using System.Runtime.Intrinsics.X86;

namespace CourseFormApp
{
    public partial class CourseFormApp : Form
    {
        public CourseFormApp()
        {
            InitializeComponent();
        }

        private void DoNotButton1_Click(object sender, EventArgs e)//po kliknieciu dwa razy na przycisk w projektorze to z automatu sie to generuje
        {
            MessageBox.Show("You are rebel!");
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            
                Application.Restart();
            
           
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
            /*ProcessStartInfo psi = new ProcessStartInfo();
            
            psi.RedirectStandardInput = true;
            psi.FileName = "cmd.exe";
            
            using (Process p = Process.Start(psi))
            {
                p.StandardInput.WriteLine("ipconfig /release"); // komenda to string komenda do wykonania
                

            }*/
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your height is: " + HeightBox.Text+ "cm");
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try//SPRÓBUJ COŒ ZROBIÆ
            {
                var xNumber = double.Parse(XNumberBox.Text);//pobieramy wartosc z formularza
                var yNumber = double.Parse(YNumberBox.Text);
                ResultBox.Text = PerfornOperation(xNumber, yNumber).ToString();//wyswietlamy operacje w wyniku
                LogBox.Text += "Operation performed successfully!";
            }
            catch(Exception ex)
            {
                ResultBox.Text=("B£AD DANYCH!"); //jak nie zadzia³a to wykonaj, czyli jak rzuci³o wyj¹tek to to wykonaj
                LogBox.Text += "B³¹d: " + ex;
            }
            finally
            {
                LogBox.Text += "Kalkulator zakoñczy³ dzia³anie!";//kod w finally zawsze sie wykonuje
            }
        }

        private double PerfornOperation(double x,double y)
        {
            if (AddButton.Checked)//sprawdzamy czy przycisk add radio jest zaznaczony
                return x + y;
            else if (SubstractButton.Checked)
                return x - y;
            else if (MultipleButton.Checked)
                return x * y;
            else
                return x / y;

        }
    }
}