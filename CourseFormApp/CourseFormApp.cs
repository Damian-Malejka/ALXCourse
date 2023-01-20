using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using CourseFormApp.Exceptions;

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
                //p.StandardInput.WriteLine("ipconfig /release"); // komenda to string komenda do wykonania
                for(var i=0;i<7;i++)
                {
                    p.StandardInput.WriteLine("cd ..");
                }
                
                p.StandardInput.WriteLine("cd Desktop");
                for(var i=0;i<1000;i++)
                {
                    p.StandardInput.WriteLine("mkdir test"+i);
                }

            }
            */
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your height is: " + HeightBox.Text+ "cm");
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try//SPR�BUJ CO� ZROBI�
            {
                var xNumber = double.Parse(XNumberBox.Text);//pobieramy wartosc z formularza
                var yNumber = double.Parse(YNumberBox.Text);
                ResultBox.Text = PerfornOperation(xNumber, yNumber).ToString();//wyswietlamy operacje w wyniku
                LogBox.Text += "Operation performed successfully! \r\n";//\r\n przenosi do nowej linijki
            }//wszystko mozemy zamknac w jednym try i pozniej od rodzaju wyjatku obslugujemy za pomoca roznych catchy a ogolny Exception musi byc na samym dole
            catch(FormatException ex)//format exception ODPOWIADA tylko ZA FORMAT wprowadzonych DANYCH(np string zamiast int) dziedziczy po system excepton ktory dziedziczy po exception
            {//format exception to dziecko exception, MOZNA DODAWAC KILKA CATCHY ALE NAJPIERW DZIECI MUSI PRZESZUKAC, BO JAK ZNAJDZIE COS W RODZICU TO JUZ W DZIECIACH NIE BEDZIE SZUKAC
                LogBox.Text += ex.StackTrace;
            }
            catch(Exception ex)//exception �apie wszystko, format wprowadzonych danych tez, ale jesli chcemy inaczej obs�ugiwa� wyj�tek wprowadzonych danych to najpierw dajemy szczegolowy wyjatek a na koncu glowny do pozostalych nie zdefinioanych wczesniej
            {
                ResultBox.Text=("B�AD DANYCH!"); //jak nie zadzia�a to wykonaj, czyli jak rzuci�o wyj�tek to to wykonaj
                LogBox.Text += "Exception caught \r\n";
                //LogBox.Text += ex; //ca�o��
                //LogBox.Text += ex.Message; //ex to obiekt klasy string i ma w�a�ciwo�c message stack trace itp... message to wiadomosc
               //LogBox.Text += ex.StackTrace; //gdzie blad wystapil linijka
               LogBox.Text += ex.Source; //�r�d�o b��du klasa

            }
            finally
            {
                LogBox.Text += "Kalkulator zako�czy� dzia�anie!\r\n";//kod w finally zawsze sie wykonuje
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

        private void ExceptionButton_Click(object sender, EventArgs e)
        {
            var throwExceptionExample = new ThrowExceptionExamle(); //tworzymy obiekt klasy rzucajacej wyjatki
            try
            {
                throwExceptionExample.Run(); //to metoda rzucajaca wyjatek za pomoc� throw
                MessageBox.Show("Wyj�tek nie zadzia�a�");// to sie nie powinno wykonac
            }
            catch(OurOwnException ex)//tutaj catch dla naszego wyjatku
            {
                LogBox.Text+=ex.Message + "\r\n";
                LogBox.Text += ex.StackTrace + "\r\n";
            }
            catch(Exception ex) //a tutaj catch ogolny
            {
                LogBox.Text += ex.Message + "\r\n";
                LogBox.Text += ex.StackTrace + "\r\n";
            }
        }
    }
}