using ETicaretAPI.Domain.Entities.Common;

namespace ETicaretAPI.Domain
{
    public  class Customer : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Order> Orders { get; set; }

    }
}
