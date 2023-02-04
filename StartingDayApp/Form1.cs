using StartingDayApp.Models;
using StartingDayApp.Services;

namespace StartingDayApp
{
    public partial class Form1 : Form
    {
        private InvoiceRepository _InvoiceRepository;
        private Invoice _Invoice;
        public Form1()
        {
            InitializeComponent();
            var connectionString = "Data Source=DAMIAN-KOMPUTER\\SQLEXPRESS01;Initial Catalog=invoiceDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; //pobieramy z property bazy w sql explorer w view
            _InvoiceRepository = new InvoiceRepository(connectionString);
            _Invoice = new Invoice();
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                _Invoice.SeriesNumber = Int32.Parse(SeriesNumberAddBox.Text);
                _Invoice.ClientCompanyName = ClientCompanyNameAddBox.Text;
                _Invoice.ClientNIP = ClientNIPAddBox.Text;
                _Invoice.UserFirstName = UserFirstNameAddBox.Text;
                _Invoice.UserLastName = UserLastNameAddBox.Text;
                _Invoice.Amount = Int32.Parse(AmountAddBox.Text);


                if (_Invoice.ClientCompanyName != "" && _Invoice.ClientNIP != "" && _Invoice.UserFirstName != "" && _Invoice.UserLastName != "")
                {

                    if (_InvoiceRepository.InsertInvoiceToDb(_Invoice))
                    {
                        LogBox.Text = "Invoice was added";
                    }
                    else
                    {
                        LogBox.Text = "Fail while Invoice been adding";
                    }
                }
                else
                {
                    LogBox.Text = "Complete all information in form";
                }
            }
            catch
            {
                LogBox.Text = "Fail";
            }
            
        }

        private void ShowAllInvoicesButton_Click(object sender, EventArgs e)
        {
            List<Invoice> invoiceList = new List<Invoice>();
            invoiceList = _InvoiceRepository.GetAllInvoices();
            ShowInvoiceList(invoiceList);
        }

        private void ShowInvoiceList(List<Invoice> list)
        {
            string newLine = Environment.NewLine;
            string logBoxText = "Invoices List:" + newLine;
            foreach (Invoice item in list)
            {
                logBoxText += "ID: " + item.Id + " Series Number: " + item.SeriesNumber + " Client company name: " + item.ClientCompanyName + " Client nip: " + item.ClientNIP + " Client First Name: " + item.UserFirstName + " Client Last Name: " + item.UserLastName + " Amount: " + item.Amount + newLine;
            }
            LogBox.Text = logBoxText;
        }
    }
}