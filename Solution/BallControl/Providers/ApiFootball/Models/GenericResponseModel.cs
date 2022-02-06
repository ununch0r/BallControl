using System.Collections.Generic;

namespace Providers.ApiFootball.Models
{
    public class GenericResponseModel<T>
    {
        public PagingModel Paging { get; set; }
        public int Results { get; set; }
        public IList<IList<T>> Response { get; set; }
    }
}
