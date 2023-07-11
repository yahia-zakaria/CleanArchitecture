using Entities;

namespace Infrastructure
{
	public class PersonRepository : RepositoryBase<Person>
    {
        private readonly ApplicationDbContext context;
        public PersonRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
    }
}
