using Microsoft.EntityFrameworkCore;
using WalletPlusInc.web.Data.Entities;
using WalletPlusInc.web.Data.Repositories;
using WalletPlusInc.web.Data.Repository.Interface;

namespace WalletPlusInc.web.Data.Repository
{
    public class CustomerRepository : Repository<Customer, Guid>
    {
        public CustomerRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
    }
}
