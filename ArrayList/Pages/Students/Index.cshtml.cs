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
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContaxt _db;
        public IEnumerable<Student> Students { get; set; }
        public IndexModel(ApplicationDbContaxt db)
        {
            _db = db;
        }
        public void OnGet()
        {
            Students = _db.Student;
        }
    }
}
