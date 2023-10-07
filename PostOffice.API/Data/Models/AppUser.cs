using Microsoft.AspNetCore.Identity;

namespace PostOffice.API.Data.Models
{
    public class AppUser : IdentityUser<Guid>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Create_date { get; set; }

        public ICollection<MoneyOrder> MoneyOrders { get; set; }

        public ICollection<ParcelOrder> ParcelOrders { get; set; }

        public ICollection<TrackHistory> History { get; set; }
    }
}
