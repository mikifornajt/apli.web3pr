using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CW5OCENA.Models;

namespace CW5OCENA.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Book Book { get; set; } = new();

        public string? Message { get; set; }

        public void OnGet() { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
                return Page();

            Message = $"Książka dodana: {Book.Author} – \"{Book.Title}\" ({Book.Year}), gatunek: {Book.Genre}";
            return Page();
        }
    }
}