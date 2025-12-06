// Pages/BookForm.cshtml.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KsiázkiNWD.Models;

namespace KsiázkiNWD.Pages
{
    public class BookFormModel : PageModel
    {
        [BindProperty]
        public Book Book { get; set; } = new();

        public string? Message { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            // ParsujRokZStringa();

            Message = $"Dodałeś książkę: {Book.Author} – \"{Book.Title}\" ({Book.Year}), gatunek: {Book.Genre}";
        }

        private void ParsujRokZStringa()
        {
            if (Request.Form["Year"].ToString() is string yearStr && int.TryParse(yearStr, out int year))
            {
                Book.Year = year;
            }
            else
            {
                Book.Year = 0;
            }
        }
    }
}