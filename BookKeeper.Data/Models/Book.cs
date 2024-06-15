using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookKeeper.Data.Models
{
    public class Book
    {
        public Book()
        {

        }

        public Book(string author, string country, string language, int numberOfPages, string title, int year, string? informationUrl = null, string? imageName = null)
        {
            Author = author;
            Country = country;
            Language = language;
            NumberOfPages = numberOfPages;
            Title = title;
            Year = year;
            InformationUrl = informationUrl;
            ImageName = imageName;
        }

        public int BookId { get; set; }

        public string Author { get; set; } = "";

        public string Country { get; set; } = "";

        public string Language { get; set; } = "";

        public int NumberOfPages { get; set; }

        public string Title { get; set; } = "";

        public int Year { get; set; }

        public string? InformationUrl { get; set; } = null;

        public string? ImageName { get; set; } = null;
        public bool LoanedOut { get; set; } = false;


    }
}
