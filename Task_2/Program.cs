using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book
            {
                AuthorPr = "asd",
                ContentPr = "ADSFFOKFKGIKsdabisndohinbmpOSNMaodnt",
                TitlePr = " afs"
            };

            book1.Show();

            Console.ReadKey();
        }
    }
}
