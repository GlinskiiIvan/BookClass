using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookClass
{
    public partial class Form1 : Form
    {
        List<Book> books = new List<Book>();
        public class Book
        {
            private string author, title, language, binding, type;
            private int yearPublication, numberPages;

            public Book() { }
            public Book(string author, string title, string language, string binding, int yearPublication, int numberPages)
            {
                this.author = author;
                this.title = title;
                this.language = language;
                this.binding = binding;
                this.yearPublication = yearPublication;
                this.numberPages = numberPages;                
            }

            public string Author
            {
                get { return author; }
                set { author = value; }
            }

            public string Title
            {
                get { return title; }
                set { title = value; }
            }

            public string Language
            {
                get { return language; }
                set { language = value; }
            }

            public string Binding
            {
                get { return binding; }
                set { binding = value; }
            }

            public int YearPublication
            {
                get { return yearPublication; }
                set { yearPublication = value; }
            }

            public int NumberPages
            {
                get { return numberPages; }
                set 
                { 
                    numberPages = value;
                    if (numberPages < 200) { type = "книжонка"; }
                    if (numberPages > 1000) { type = "книжища"; }
                    if (numberPages >= 200 && numberPages <= 1000) { type = "книга"; }
                }
            }
            public string Type { get { return type; } }
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button_AddBook_Click(object sender, EventArgs e)
        {
            Book book = new Book();
            book.Author = textBox_Author.Text;
            book.Title = textBox_Title.Text;
            book.Language = textBox_Language.Text;
            book.YearPublication = Convert.ToInt32(textBox_YearPublication.Text);
            book.Binding = textBox_Binding.Text;
            book.NumberPages = Convert.ToInt32(textBox_NumberPages.Text);
            books.Add(book);
        }

        private void button_More_Click(object sender, EventArgs e)
        {
            foreach(var book in books)
            {
                if(book.Title == textBox_TitleMore.Text)
                {
                    textBox_More.Text = book.Type + Environment.NewLine + Environment.NewLine;
                    textBox_More.Text += book.Title + Environment.NewLine;
                    textBox_More.Text += book.Author + Environment.NewLine;
                    textBox_More.Text += book.Language + Environment.NewLine;
                    textBox_More.Text += book.YearPublication + Environment.NewLine;
                    textBox_More.Text += book.Binding + Environment.NewLine;
                    textBox_More.Text += book.NumberPages + Environment.NewLine;
                }
            }
        }
    }
}
