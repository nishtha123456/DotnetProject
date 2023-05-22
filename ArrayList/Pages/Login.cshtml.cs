using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ArrayList.Pages
{
    public class LoginModel : PageModel
    {
        public string Message { get; set; }
        public string Name { get; set; }

        // the click event handler 
        // MUST be prefixed with OnGet if the 
        // request is of HTTP GET type 
        public void OnGetOnClick()
        {

            Message = "Hello";

        }
        public void OnPostSave(string name)
        {
            Name = name;
        }
    }
}
