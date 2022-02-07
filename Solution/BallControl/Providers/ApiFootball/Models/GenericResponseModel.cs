namespace Providers.ApiFootball.Models
{
    public class GenericResponseModel<T>
    {
        public PagingModel Paging { get; set; }
        public int Results { get; set; }
        public T Response { get; set; }
    }
}
