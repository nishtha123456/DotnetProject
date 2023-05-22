using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArrayList.Data;
using ArrayList.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace ArrayList.Pages.Students
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContaxt _db;
      
        public Student Student { get; set; }
        public CreateModel(ApplicationDbContaxt db)
        {
            _db = db;
          
        }

                    public void OnGet()
        {
        }
        public async  Task<IActionResult> OnPost(Student student)
            {
            await _db.Student.AddAsync(student);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}
