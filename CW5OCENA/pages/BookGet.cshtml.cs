// Pages/Index.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW5OCENA.Pages
{
    public class Book
    {
        public string Author { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public int Year { get; set; }
        public string Genre { get; set; } = string.Empty;
    }

    public class IndexModel : PageModel
    {
        [BindProperty]
        public Book Book { get; set; } = new();

        public string? Message { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
                return;

            Message = $"Dodano: {Book.Author} – \"{Book.Title}\" ({Book.Year}), gatunek: {Book.Genre}";
        }
    }
}