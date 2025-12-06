using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CW5OCENA.Pages
{
    public class NwdModel : PageModel
    {
        [BindProperty]
        public int A { get; set; }

        [BindProperty]
        public int B { get; set; }

        [BindProperty]
        public string Method { get; set; } = "rek";

        public int Result { get; set; }

        public void OnPost()
        {
            if (!ModelState.IsValid) return;

            A = Math.Abs(A);
            B = Math.Abs(B);
            if (A == 0) A = 1;
            if (B == 0) B = 1;

            Result = Method == "rek" ? NwdRek(A, B) : NwdIter(A, B);
        }

        int NwdIter(int a, int b)
        {
            while (a != b)
                if (a > b) a -= b;
                else b -= a;
            return a;
        }

        int NwdRek(int a, int b) => b == 0 ? a : NwdRek(b, a % b);
    }
}