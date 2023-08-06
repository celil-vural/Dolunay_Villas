namespace Entity.RequestParameters
{
    public class PageRequestParameters
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public PageRequestParameters() : this(1, 10) { }
        public PageRequestParameters(int pageNumber = 1, int pageSize = 10)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
