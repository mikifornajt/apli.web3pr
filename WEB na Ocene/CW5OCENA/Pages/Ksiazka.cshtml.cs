using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW5OCENA.Pages
{
    [IgnoreAntiforgeryToken]
    public class KsiazkaModel : PageModel
    {
        public string Msg1 { get; set; } = "";
        public string Msg2 { get; set; } = "";

        public void OnGet()
        {
            string autor = Request.Query["autor"];
            string tytul = Request.Query["tytul"];
            string rokTxt = Request.Query["rok"];
            string gatunek = Request.Query["gatunek"];

            if (!string.IsNullOrEmpty(autor))
            {
                int rok = 0;
                int.TryParse(rokTxt, out rok);
                
                Msg1 = $"{autor} - {tytul} ({rok}), {gatunek}";
            }
        }

        public void OnPost()
        {
            string autor = Request.Form["autor"];
            string tytul = Request.Form["tytul"];
            string rokTxt = Request.Form["rok"];
            string gatunek = Request.Form["gatunek"];

            int rok = 0;
            int.TryParse(rokTxt, out rok);
            
            Msg2 = $"{autor} - {tytul} ({rok}), {gatunek}";
        }
    }
}