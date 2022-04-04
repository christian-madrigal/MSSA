using System.Collections.Generic;
namespace Assignment_12._2.Models
{
    public class Data : IData
    {
        public List<Book> Books { get; set; }
        
        public Book GetBook(int? id)
        {
            if (id == null)
            {
                return null;
            }
            else
            {
                return Books.Find(x => x.Id == id);
            }
        }
        public List<Book> InitializeData()
        {
            Books = new List<Book>()
            {
                new Book()
                {
                    Id = 101,
                    Title ="Diary of a Wimpy Kid",
                    Author="Jeff Kinney",
                    Year =2007,
                    ImageName ="DiaryofAWimpyKid.jpg"
                },
                new Book()
                {
                    Id = 102,
                    Title = "Rodrick Rules",
                    Author = "Jeff Kinney",
                    Year = 2008,
                    ImageName = "RodrickRules.jpg"
                },
                new Book()
                {
                    Id = 103,
                    Title = "The Last Straw",
                    Author = "Jeff Kinney",
                    Year = 2009,
                    ImageName = "LastStraw.jpg"
                },
                new Book()
                {
                    Id = 104,
                    Title = "Dog Days",
                    Author = "Jeff Kinney",
                    Year = 2012,
                    ImageName = "DogDays.jpg"
                },
                new Book()
                {
                    Id = 105,
                    Title = "The Ugly Truth",
                    Author = "Jeff Kinney",
                    Year = 2010,
                    ImageName = "UglyTruth.jpg"
                }
            };
            return Books;
        }
    }
}
