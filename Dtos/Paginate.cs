using System;

namespace TechTestWebApi.Dtos
{
    public class PaginateParams
    {
        public string? keyword { get; set; } // search keyword
        public int page { get; set; } = 1;
        public int pageSize { get; set; } = 25;
    }

    public class Paginate<T>
    {
        public List<T> Data { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }

        public Paginate(IEnumerable<T> source, int count, PaginateParams query)
        {
            Data = source.ToList();
            Page = query.page <= 0 ? 1 : query.page;
            PageSize = query.pageSize;
            TotalCount = count;
            TotalPages = (int)Math.Ceiling(count / (double)query.pageSize);
        }
    }
}

