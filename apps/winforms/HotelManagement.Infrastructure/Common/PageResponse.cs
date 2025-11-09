using System.Collections.Generic;

namespace HotelManagement.Infrastructure.Common
{
    public class PageResponse<T> where T : class
    {
        public IEnumerable<T> Content { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalElements { get; set; }
    }
}
