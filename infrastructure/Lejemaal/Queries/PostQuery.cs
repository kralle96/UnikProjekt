using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using application.Dto;
using application.Queries.DtoInterface;
using Microsoft.EntityFrameworkCore;

namespace infrastructure.Lejemaal.Queries
{
    public class PostQuery : IPostQuery
    {
        private readonly LejemaalContext _LejemaalContext;

        public PostQuery(LejemaalContext _lejemaalContext)
        {
            _LejemaalContext = _lejemaalContext;
        }

        // Retunere alle post
        async Task<IEnumerable<PostDto>> IPostQuery.GetAll()
        {
            return await _LejemaalContext.Post.AsNoTracking().Select(a => new PostDto { PostNr = a.PostNr }).ToListAsync();
        }

        // Retunere post fra id
        async Task<PostDto> IPostQuery.Get(int postNr)
        {
            return await _LejemaalContext.Post.AsNoTracking().Select(a => new PostDto { PostNr = a.PostNr })
                .FirstOrDefaultAsync(a => a.PostNr == postNr);
        }
    }
}
