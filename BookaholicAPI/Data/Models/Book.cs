using System.ComponentModel.DataAnnotations;

namespace BookaholicAPI.Data.Models
{
    public class Book
    {
        public string? Id { get; set; }

        public string? Name { get; set; }

        public byte Rating { get; set; }

        public string? Description { get; set; }

        public short Pages { get; set; }

        public Language Language { get; set; }

        public string? LanguageId { get; set; }

        public ICollection<Genre>? Genres { get; set; }

        public Author Author { get; set; }
        
        public string? AuthorId { get; set; }

        public ICollection<Comment>? Comments { get; set; }
    }
}
