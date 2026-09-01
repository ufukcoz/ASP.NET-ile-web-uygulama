using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TodoApp.Models;
using TodoApp.Services;

namespace TodoApp.Pages.Todoss
{
    public class IndexModel : PageModel
    {
        private readonly ITodoStore _store;

        [BindProperty(SupportsGet = true)]
        public String? Q { get; set; }

        [BindProperty(SupportsGet = true)]
        public TodoPriority? Priority { get; set; }

        [BindProperty(SupportsGet = true)]
        public String? Status { get; set; } // "done", "pending" or null

        [BindProperty(SupportsGet = true)]
        public String? Sort { get; set; } // due_asc or due_desc

        public IEnumerable<TodoApp.Models.Todo> Items { get; private set; } = [];

        public IndexModel(ITodoStore store)
        {
            _store = store;
        }

        public void OnGet()
        {
            bool? isDone = Status?.ToLowerInvariant() switch
            {
                "done" => true,
                "pending" => false,
                _ => null
            };

            bool? dueAsc = Sort?.ToLowerInvariant() switch
            {
                "due_desc" => false,
                _ => true
            };

            Items = _store.Search(Q, Priority, isDone, dueAsc);
        }
    }
}