namespace Entity.RequestParameters
{
    public class RealEsateRequestParameters
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public RealEsateRequestParameters() : this(1, 10) { }
        public RealEsateRequestParameters(int pageNumber = 1, int pageSize = 10)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}
