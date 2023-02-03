using LibraryDataBaseApp.Models;
using LibraryDataBaseApp.Services;
using System.Data.Common;
using System.Transactions;
using Transaction = LibraryDataBaseApp.Models.Transaction;

namespace LibraryDataBaseApp
{
    public partial class Form1 : Form
    {
        private BookRepository _BookRepository;
        private ClientRepository _ClientRepository;
        private TransactionRepository _TransactionRepository;
        private Book _Book;
        private Client _Client;
        private Transaction _Transaction;

        public Form1()
        {
            InitializeComponent();
            var connectionString = "Data Source=DAMIAN-KOMPUTER\\SQLEXPRESS01;Initial Catalog=LIBRARY;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"; //pobieramy z property bazy w sql explorer w view
            _BookRepository = new BookRepository(connectionString);
            _ClientRepository = new ClientRepository(connectionString);
            _TransactionRepository = new TransactionRepository(connectionString);
            _Book = new Book();
            _Client = new Client();
            _Transaction = new Transaction();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _Book.Title = TitleAddBox.Text;
            _Book.FirstNameAuthor = AuthorFirstNameAddBox.Text;
            _Book.LastNameAuthor = AuthorLastNameAddBox.Text;

            if (_Book.Title != "" && _Book.FirstNameAuthor != "" && _Book.LastNameAuthor != "")
            {

                if (_BookRepository.InsertBookToDb(_Book))
                {
                    LogBox.Text = "Book was added";
                }
                else
                {
                    LogBox.Text = "Fail while book been adding";
                }
            }
            else
            {
                LogBox.Text = "Complete all information in form";
            }

        }

        private void ShowAllBooksButton_Click(object sender, EventArgs e)
        {
            List<Book> booksList = new List<Book>();
            booksList = _BookRepository.GetAllBooks();
            ShowBookList(booksList);
        }

        private void ShowBookList(List<Book> list)
        {
            string newLine = Environment.NewLine;
            string logBoxText = "Books List:"+newLine;
            foreach (Book item in list)
            {
                logBoxText += "ID: " + item.IdBook + " Title: " + item.Title + " First Name: " + item.FirstNameAuthor +" Last Name: "+ item.LastNameAuthor + newLine;
            }
            LogBox.Text = logBoxText;
        }

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            _Client.FirstName = ClientFirstNameAddBox.Text;
            _Client.LastName = ClientLastNameAddBox.Text;
            if(_Client.FirstName!="" && _Client.LastName!="")
            {
                if (_ClientRepository.InsertClientToDb(_Client))
                {
                    LogBox.Text = "Client was added";
                }
                else
                {
                    LogBox.Text = "Fail while client been adding";
                }
            }
            else
            {
                LogBox.Text = "Complete all information in form";
            }

            
        }

        private void ShowAllClientsButton_Click(object sender, EventArgs e)
        {
            List<Client> clientsList = new List<Client>();
            clientsList = _ClientRepository.GetAllClients();
            ShowClientList(clientsList);
        }
        private void ShowClientList(List<Client> list)
        {
            string newLine = Environment.NewLine;
            string logBoxText = "Clients List:" + newLine;
            foreach (Client item in list)
            {
                logBoxText += "ID: " + item.IdClient  + " First Name: " + item.FirstName + " Last Name: " + item.LastName + newLine;
            }
            LogBox.Text = logBoxText;
        }

        private void AddTransactionButton_Click(object sender, EventArgs e)
        {
            try
            {
                _Client.IdClient = Int32.Parse(ClientIdTransactionBox.Text);
                _Book.IdBook = Int32.Parse(BookIdTransactionBox.Text);

                if (ClientIdTransactionBox.Text != "" && BookIdTransactionBox.Text != "")
                {
                    if (_BookRepository.CheckBooks(_Book))
                    {
                        if (_ClientRepository.CheckClients(_Client))
                        {
                            if (_TransactionRepository.InsertTransactionToDb(_Transaction, _Book, _Client))
                            {
                                LogBox.Text = "Transaction was added";
                            }
                            else
                            {
                                LogBox.Text = "This book is already booked";
                            }

                        }
                        else
                        {
                            LogBox.Text = "Client was not found";
                        }
                    }
                    else
                    {
                        LogBox.Text = "Book was not found";
                    }
                }
                else
                {
                    LogBox.Text = "Complete all information in form";
                }
            }
            catch
            {
                LogBox.Text = "You should write a number in  TextBox";
            }
        }

        private void ShowAllTransactionsButton_Click(object sender, EventArgs e)
        {
            List<Transaction> transactionsList = new List<Transaction>();
            transactionsList = _TransactionRepository.GetAllTransactionsId();
            ShowTransactionList(transactionsList);
        }

        private void ShowTransactionList(List<Transaction> list)
        {
            string newLine = Environment.NewLine;
            string logBoxText = "Transactions List:" + newLine;
            foreach (Transaction item in list)
            {
                logBoxText += "Id Transaction: " + item.IdTransaction + " Id Book: " + item.IdBook + " Id Client: " + item.IdClient + newLine;
            }
            LogBox.Text = logBoxText;
        }

        private void RemoveTransactionButton_Click(object sender, EventArgs e)
        {
            try
            {
                _Transaction.IdTransaction = Int32.Parse(IdTransactionRemoveBox.Text);
                if (_TransactionRepository.RemoveTransactionsFromDb(_Transaction))
                {
                    LogBox.Text = "Transaction was removed";
                }
                else
                {
                    LogBox.Text = "Fail while client been removing";
                }
            }
            catch
            {
                LogBox.Text = "You should write a number in  TextBox";
            }
        }
    }
}