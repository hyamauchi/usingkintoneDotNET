using System.Collections.Generic;

namespace usingkintoneDotNET
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BookModel> books = BookModel.FindAll<BookModel>();

            foreach (var item in books)
            {
                System.Diagnostics.Debug.WriteLine(item.age);
            }

        }
    }
}
