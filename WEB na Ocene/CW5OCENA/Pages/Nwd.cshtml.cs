using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW5OCENA.Pages
{
    [IgnoreAntiforgeryToken]
    public class NwdModel : PageModel
    {
        public int A { get; set; }
        public int B { get; set; }
        public int Wynik { get; set; }

        public void OnPost()
        {
            string aTxt = Request.Form["a"];
            string bTxt = Request.Form["b"];
            string metoda = Request.Form["metoda"];

            int a = 0;
            int b = 0;
            int.TryParse(aTxt, out a);
            int.TryParse(bTxt, out b);
            
            A = a;
            B = b;

            if (metoda == "rek")
            {
                Wynik = NwdRekurencja(a, b);
            }
            else
            {
                Wynik = NwdIteracja(a, b);
            }
        }

        int NwdRekurencja(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            return NwdRekurencja(b, a % b);
        }

        int NwdIteracja(int a, int b)
        {
            while (a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
    }
}