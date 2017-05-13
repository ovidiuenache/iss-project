using App.Context;
using App.Entity;

namespace App.Repository.Impl
{
    /// <summary>
    /// 
    /// Review Repository
    /// Author : Catalin Radoiu
    /// 
    /// </summary>
    public class ReviewRepository : AbstractRepository<Review>, IReviewRepository
    {
        public ReviewRepository(AppContext context) : base(context)
        {

        }
    }
}
