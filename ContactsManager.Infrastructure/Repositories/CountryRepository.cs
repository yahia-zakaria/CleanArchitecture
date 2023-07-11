using Entities;

namespace Infrastructure
{
	public class CountryRepository : RepositoryBase<Country>
    {
        private readonly ApplicationDbContext context;
        public CountryRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public void x()
        {
            throw new NotImplementedException();
        }
    }
}
