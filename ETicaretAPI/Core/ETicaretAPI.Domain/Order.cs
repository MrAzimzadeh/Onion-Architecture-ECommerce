using System.Security.AccessControl;
using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }
        public string Address { get; set; }

        public ICollection<Prodact> Prodacts { get; set; } // bir orderin birden cox prodacti ola biler deyirik 
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

    }
}
