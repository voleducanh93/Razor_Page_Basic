using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie.Pages.Admin
{
    public class DashboardModel : PageModel
    {
        public int TotalUsers { get; set; }
        public int TotalMovies { get; set; }
        public decimal TotalRevenue { get; set; }

        public void OnGet()
        {
            // For demonstration purposes, hardcoded values. 
            // Replace with actual data retrieval logic.
            TotalUsers = 150; // Example data
            TotalMovies = 120; // Example data
            TotalRevenue = 2500.75M; // Example data
        }
    }
}
