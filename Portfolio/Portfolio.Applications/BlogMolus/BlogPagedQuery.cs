using MediatR;
using Portfolio.Domain.Model.DataContexts;
using Portfolio.Domain.Model.Entity;
using Portfolio.Domain.Model.ViewModels;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Portfolio.Applications.BlogMolus
{
    public class BlogPagedQuery : IRequest<PagedViewModel<BlogPost>>
    {
        //public int pageSize { get; set; } = 3;

        int pageIndex;
        int pageSize;

        public int PageIndex {

            get
            {
                if (pageIndex >0)
                {
                    return pageIndex;
                }
                return 1;
            }
            set
            {
                if (value>0)
                {
                    pageIndex = value;
                }
                else
                {
                    pageIndex = 1;
                }
            }
        }


        public int PageSize
        {

            get
            {
                if (pageSize > 0)
                {
                    return pageSize;
                }
                return 15;
            }
            set
            {
                if (value > 0)
                {
                    pageSize = value;
                }
                else
                {
                    pageIndex = 15;
                }
            }
        }


        public class BlogPagedQueryHandler : IRequestHandler<BlogPagedQuery, PagedViewModel<BlogPost>>
        {
            readonly PortfolioDbContext db;
            public BlogPagedQueryHandler(PortfolioDbContext db)
            {
                this.db = db; //Model
            }
            public async Task<PagedViewModel<BlogPost>> Handle(BlogPagedQuery model, CancellationToken cancellationToken)
            {
                var query = db.BlogPosts.Where(b => b.CreateByUserId == null && b.DeleteByUserId == null).AsQueryable(); // silinmemisleri getirir

                //int queryCount = await query.CountAsync(cancellationToken); // silinmemislerin sayni takir

                //var pagedData = await query.Skip((model.Pageindex - 1) * model.PageCount) // skip necensi seyfede,
                //    .Take(model.PageCount) // nece denesini gosdersin.
                //    .ToListAsync(cancellationToken);

                return new PagedViewModel<BlogPost>(query, model.pageIndex=1, model.pageSize=100);
            }
        }
    }
}
