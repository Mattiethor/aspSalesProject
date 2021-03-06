using System.ComponentModel.DataAnnotations;

namespace ntv_database.Models
{
    public class Customer
    {
        public Customer()
        {
            Sales = new List<Sale>();
        }
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        //move to class, change to int, add address, zip code.
        public string Address { get; set; }

        public List<Sale> Sales { get; set; }
    }
}
