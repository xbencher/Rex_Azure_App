using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rex_Azure_App.Data;

namespace Rex_Azure_App.Pages_Persons1
{
    public class IndexModel : PageModel
    {
        private readonly Rex_Azure_App.Data.ApplicationDBContext _context;

        public IndexModel(Rex_Azure_App.Data.ApplicationDBContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Person.ToListAsync();
        }
    }
}
