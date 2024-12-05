using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Telecom_T13.Data;
using Telecom_T13.Models;

namespace Telecom_T13.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public LoginModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Customer_Profile> CustomerProfiles { get; set; }

        public async Task OnGetAsync()
        {
            try
            {
                CustomerProfiles = await _context.Customer_Profiles.ToListAsync();
            }
            catch (Exception ex)
            {
                // Log the exception or display a message
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }


}