using System;
using System.Collections.Generic;
using System.Text;
using Task_2.Book_classes;

namespace Task_2
{
    class Book
    {
        Author author = new Author();
        Content content = new Content();
        Title title = new Title();

        public string AuthorPr
        {
            set
            {
                author.author = value;
            }
        }

        public string ContentPr
        {
            set
            {
                content.content = value;
            }
        }
        public string TitlePr
        {
            set
            {
                title.title = value;
            }
        }

        public void Show()
        {
            title.Show();
            author.Show();
            content.Show();         
        }
    }
}
