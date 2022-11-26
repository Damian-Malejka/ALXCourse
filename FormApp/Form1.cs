namespace HardcodedFormApp
///W TYM PLIKU ROBIMY LOGIKE//
{
    public partial class Form1 : Form //partial z³ozenie klas z form1.designer
    {
        public Form1()//konstruktor formularza
        {
            InitializeComponent();//wywo³aj nam komponent formularza
            HardcodedButton=new Button();//inicjalizacja przycisku z form1.designer
            HardcodedButton.Parent =this; ;// przypnij formularz do rodzica tego formularza
            HardcodedButton.Top = 50;//odsuniecie od gory okna
            HardcodedButton.Left = 50;//odsuniecie od lewej krawedzi okna
            HardcodedButton.Text = "Hardcoded button...";
            HardcodedButton.Width = 200; //szerokosc
            HardcodedButton.Height = 50;

            HardcodedButton.Click += new System.EventHandler(SayHello); //Dodajemy metody systemowego obs³ugiwania zdarzeñ dla klikniecia
            HardcodedButton.Click += new System.EventHandler(ExtendButton);
        }

        private void SayHello(object sender, EventArgs args) //object sender, EventArgs args musi byc bo eventhandler ma takie argumenty
        {
            MessageBox.Show("Hello!"); 
        }

        private void ExtendButton(object sender, EventArgs args)
        {
            HardcodedButton.Width += 10;
        }
    }
}