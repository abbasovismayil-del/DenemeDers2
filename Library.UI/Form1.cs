using Library.Business.Services;
using Library.DataAcces.Abstractions;
using Library.DataAcces.Context;
using Library.Entity.Models;

namespace Library.UI
{
    public partial class Form1 : Form
    {
        private readonly BookService _bookService;
        private readonly AuthorService _authorService;
        private readonly MembersService _membersService;
        private readonly IUnitOfWork _unitOfWork;


        public Form1()
        {
            InitializeComponent();

            _unitOfWork = new UnitOfWork(new ApplicationDBContext());
            _bookService = new BookService(_unitOfWork);
            _authorService = new AuthorService(_unitOfWork);
            _membersService = new MembersService(_unitOfWork);

            GetAllData();

        }

        private void GetAllData()
        {
            lstAuthors.DataSource = null;
            lstAuthors.DisplayMember = "AuthorName";
            lstAuthors.ValueMember = "ID";
            lstAuthors.DataSource = _authorService.GetAll();

            lstBooks.DataSource = null;
            lstBooks.DisplayMember = "BookName";
            lstBooks.ValueMember = "ID";
            lstBooks.DataSource = _bookService.GetAll();

            lstMembers.DataSource = null;
            lstMembers.DisplayMember = "NameSurname";
            lstMembers.ValueMember = "ID";
            lstMembers.DataSource = _membersService.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Author a = new Author();
            a.AuthorName = "Dostoyevski";
            a.Nationality = "Rus";
            _authorService.Add(a);
            _unitOfWork.complete();

            Books S = new Books();
            S.BookName = "Suc ve Ceza";
            S.Publisher = "Is bankası yayınları";
            S.Author = a;
            _bookService.Add(S);
            _unitOfWork.complete();

            Member m = new Member();
            m.NameSurname = "Ugur Sahin";
            m.PhoneNumber = "05516295292";
            m.Address = "Ankara";
            _membersService.Add(m);
            _unitOfWork.complete();

            GetAllData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstAuthors.SelectedIndex != -1 && lstBooks.SelectedIndex != -1 && lstMembers.SelectedIndex != -1)
                {
                    var authorID = (Guid)lstAuthors.SelectedValue;

                    _authorService.Delete(authorID);
                    _unitOfWork.complete();

                    var bookID = (Guid)lstBooks.SelectedValue;

                    _bookService.Delete(bookID);
                    _unitOfWork.complete();

                    var memberID = (Guid)lstMembers.SelectedValue;

                    _membersService.Delete(memberID);
                    _unitOfWork.complete();

                    GetAllData();
                    MessageBox.Show("Silme işlemi başarılı.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
