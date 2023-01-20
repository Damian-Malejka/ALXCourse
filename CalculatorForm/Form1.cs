using CommonFunctionalities.Services.Interfaces;
using CommonFunctionalities.Services;
using System.Text;


namespace CalculatorForm
{
    public partial class CalculatorForm : Form
    {
        public StringBuilder ExpressionBuilder { get; set; }
        //STRING JEST NIEMUTOWALNY CZYLI JAK SIE STWORZY Z JAKAS WARTOSCIA TO NIE MOZNA MODYFIKOWAC;
        //var text = "Ala ma kota";
        //text+=" i psa"//tutaj zostanie zmienna text usunieta i utworzona od nowa z tekstem Ala ma kota i psa

        /*STRING BUILDER POZWALA NA TWORZENIE MUTOWALNYCH STRINGOW*/
        public IExpressionService CalculatorService;
        private IExpressionService ExpressionService { get; set; }
        public CalculatorForm()
        {
            InitializeComponent();
            ExpressionBuilder = new StringBuilder();//inicjalizacja expression buildera
            ExpressionService = new ExpressionService();
        }
        private void Buttons_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            ExpressionBuilder.Append(button.Text);
            if (ResultBox.Text == "0")//jak jest zero na poczatku tekstu to je kasuje
            {
                ResultBox.Text = "";
                ResultBox.Text += button.Text;
            }
            else
            {
                ResultBox.Text += button.Text;
            }
        }

        private void CalculatorForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 0)
            {
                MessageBox.Show("zero");
            }
            /*if(e.KeyCode == Keys.Enter)
            // Initialize the flag to false.
            nonNumberEntered = false;

            // Determine whether the keystroke is a number from the top of the keyboard.
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                // Determine whether the keystroke is a number from the keypad.
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    // Determine whether the keystroke is a backspace.
                    if (e.KeyCode != Keys.Back)
                    {
                        // A non-numerical keystroke was pressed.
                        // Set the flag to true and evaluate in KeyPress event.
                        nonNumberEntered = true;
                    }
                }
            }
            //If shift key was pressed, it's not a number.
            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }*/
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            //STRING BUILDER DEMO
            /* ExpressionBuilder.Append("Hello ");//tutaj od zera tworzymy tekst
             ResultBox.Text = ExpressionBuilder.ToString();//i wyœwietlamy e kalkulatorze
             ExpressionBuilder.Append("user ");
             ResultBox.Text = ExpressionBuilder.ToString();
             ExpressionBuilder.Append("this ");
             ResultBox.Text = ExpressionBuilder.ToString();
             ExpressionBuilder.Append("is ");
             ResultBox.Text = ExpressionBuilder.ToString();
             ExpressionBuilder.Append("a ");
             ResultBox.Text = ExpressionBuilder.ToString();
             ExpressionBuilder.Append("string builder.");
             ResultBox.Text = ExpressionBuilder.ToString();

             var text = ExpressionBuilder.ToString();
             ExpressionBuilder.Clear(); //wyczyœæ expression buildera
            */
            ExpressionBuilder.Append("(-)");
            ResultBox.Text = ExpressionBuilder.ToString();
        }
        private void RunButton_Click(object sender, EventArgs e)
        {
            var expression = ResultBox.Text;
            expression += "=";
            var result = ExpressionService.ProcessExpression(expression);
            ResultBox.Text = result;

            ExpressionBuilder.Clear();

        }
        private void CeButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Clear();
            ResultBox.Text = ExpressionBuilder.ToString();
        }

        private void CButton_Click(object sender, EventArgs e)
        {
            ExpressionBuilder.Clear();
            ResultBox.Text = ExpressionBuilder.ToString();
        }







        //To NIZEJ BYLO W PIERWSZEJ WERSJI UZYWAMY JEDNAK WSPOLNY EVENT HANDLER PRAWIE DLA WSZYSTKICH PRZYCISKOW
        /* private void ModButton_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("%");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         private void Button1x_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("1/");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         private void PowButton_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("^");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         private void SqrtButton_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("sqrt");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         private void DivButton_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("/");
             ResultBox.Text = ExpressionBuilder.ToString();
         }
         private void MultiplyButton_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("*");
             ResultBox.Text = ExpressionBuilder.ToString();

         }

         private void SubstractButton_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("-");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         private void AddButton_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("+");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         private void Button0_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("0");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         private void Button1_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("1");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         private void Button2_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("2");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         private void Button3_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("3");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         private void Button4_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("4");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         private void Button5_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("5");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         private void Button6_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("6");
             ResultBox.Text = ExpressionBuilder.ToString();
         }
         private void Button7_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("7");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         private void Button8_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("8");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         private void Button9_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append("9");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         private void DotButton_Click(object sender, EventArgs e)
         {
             ExpressionBuilder.Append(".");
             ResultBox.Text = ExpressionBuilder.ToString();
         }

         */
    }
}