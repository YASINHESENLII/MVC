using WebApplication4.Models;

namespace WebApplication4.ViewModels
{
    public class HomeVM
    {
        public List<Slide> slides { get; set; }
        public List<Product> products { get; set; }

        public List<Client> clients { get; set; }
    }
}
